using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebMVC.Models;

namespace DAL
{
    public class SimDAL
    {
        QuanLyCuocDienThoai_dbEntities1 db = new QuanLyCuocDienThoai_dbEntities1();
        SIM sim = new SIM();
        public void setSim(string id)
        {
            this.sim.id = id;
        }
        public void setSim(string id, string cus_id, int phonenumber, bool status)
        {
            this.sim.id = id;
            this.sim.phone = phonenumber;
            this.sim.id_cus = cus_id;
            this.sim.status = status;
        }
        public void setSim(string id, int phonenumber, bool status)
        {
            this.sim.id = id;
            this.sim.phone = phonenumber;
            this.sim.status = status;
        }

        public void setSim(string id_sim, string id_customer, bool status)
        {
            this.sim.id = id_sim;
            this.sim.id_cus = id_customer;
            this.sim.status = status;
        }
        public IEnumerable<SIM> GetAll()
        {
            List<SIM> sim = db.SIMs.ToList();
            return sim;
        }
        public string[] GetAll_Array()
        {
            string[] sim = db.SIMs.Select(C => C.id).ToArray();
            return sim;
        }
        public void Create()
        {
            var numeric_value = 1;
            var id_str = "S0";

            while (db.SIMs.Any(c => c.id == id_str + numeric_value.ToString()))
            {
                numeric_value++;
                if (numeric_value > 9)
                    id_str = "S";
            }
            sim.id = id_str + numeric_value.ToString();


            db.SIMs.Add(sim);
            db.SaveChanges();

            db.Entry(sim).State = EntityState.Detached;
        }

        public void Delete()
        {
            // db.SIMs.Select(p => p.id == sim.id);
            var delete_sim = db.SIMs.First(p => p.id == sim.id);
            var customer_id = delete_sim.id_cus;
            var sim_count = db.SIMs.Count(p => p.id_cus == customer_id);
            if (sim_count < 2)
            {
                IList<CONTRACT> delete_contracts = db.CONTRACTs.Where(p => p.id == sim.id).ToList();
                IList<CUSTOMER> delete_customers = db.CUSTOMERs.Where(p => p.id == customer_id).ToList();
                IList<BILL> delete_bills = db.BILLs.Where(p => p.id == sim.id).ToList();
                IList<DETAIL> delete_details = db.DETAILs.Where(p => p.id_sim == sim.id).ToList();
                db.DETAILs.RemoveRange(delete_details);
                db.BILLs.RemoveRange(delete_bills);
                db.CONTRACTs.RemoveRange(delete_contracts);
                db.CUSTOMERs.RemoveRange(delete_customers);
            }

            db.SIMs.Remove(delete_sim);
            db.SaveChanges();

            db.Entry(sim).State = EntityState.Detached;
        }

        public void Update()
        {
            var edited_sim = db.SIMs.First(p => p.id == sim.id);

            edited_sim.id_cus = sim.id_cus;
            edited_sim.phone = sim.phone;
            edited_sim.status = sim.status;

            db.SaveChanges();

            db.Entry(sim).State = EntityState.Detached;
        }

        public void Update_id_cus()
        {
            var edited_sim = db.SIMs.First(p => p.id == sim.id);
            edited_sim.status = this.sim.status;
            edited_sim.id_cus = this.sim.id_cus;

            db.SaveChanges();
            db.Entry(sim).State = EntityState.Detached;
        }

        public List<SIM> SearchByid(string id)
        {
            if (db.SIMs.Any(c => c.id.Contains(id)))
            {
                List<SIM> result = db.SIMs.Where(c => c.id.Contains(id)).ToList();
                return result;
            }
            return null;
        }
        public List<SIM> SearchBy_CustomerName(string name)
        {
            if (db.SIMs.Any(c => c.CUSTOMER.name_cus.Contains(name)))
            {
                List<SIM> result = db.SIMs.Where(c => c.CUSTOMER.name_cus.Contains(name)).ToList();
                return result;
            }
            return null;
        }
        public string getIDcustomer_in_Sim()
        {
            return (from h in db.SIMs where h.id.Equals(sim.id) select h.id_cus).FirstOrDefault();
        }

        public bool checkPhoneNumber()
        {
            return db.SIMs.Any(c => c.id != sim.id && c.phone == sim.phone);
        }
        public bool checkifLocked()
        {
            var check = (from h in db.SIMs
                         where h.id.Equals(sim.id)
                         select h.status).SingleOrDefault();
            return (bool)check;
        }
        public void lockSim()
        {
            var lock_sim = db.SIMs.First(p => p.id == sim.id);

            lock_sim.status = false;

            db.SaveChanges();

            db.Entry(sim).State = EntityState.Detached;

        }
    }
}
