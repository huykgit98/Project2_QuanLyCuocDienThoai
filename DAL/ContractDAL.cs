using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebMVC.Models;

namespace DAL
{
    public class ContractDAL
    {
        QuanLyCuocDienThoai_dbEntities1 db = new QuanLyCuocDienThoai_dbEntities1();
        CONTRACT contract = new CONTRACT();
        public void setCONTRACT(String sim_id, DateTime date, int? fee, bool status)
        {
            this.contract.id_sim = sim_id;
            this.contract.fee = fee;
            this.contract.date_register = date;
            this.contract.status = status;
        }
        public void setCONTRACT(string id)
        {
            this.contract.id = id;
        }

        public void setCONTRACT_bySimID(string sim_id)
        {
            this.contract.id = sim_id;
        }

        public void setCONTRACT(string id, string sim_id, DateTime date, int? fee, bool status)
        {
            this.contract.id = id;
            this.contract.id_sim = sim_id;
            this.contract.fee = fee;
            this.contract.date_register = date;
            this.contract.status = status;
        }
        public IEnumerable<CONTRACT> GetAll()
        {
            List<CONTRACT> contract = db.CONTRACTs.ToList();
            return contract;
        }
        public void Create()
        {
            var numeric_value = 1;
            var id_str = "C0";

            while (db.CONTRACTs.Any(c => c.id == id_str + numeric_value.ToString()))
            {
                numeric_value++;
                if (numeric_value > 9)
                    id_str = "C";
            }
            contract.id = id_str + numeric_value.ToString();
            db.CONTRACTs.Add(contract);
            db.SaveChanges();
            db.Entry(contract).State = EntityState.Detached;
        }

        public void Delete()
        {
            var delete_contract = db.CONTRACTs.First(p => p.id == contract.id);
            var sim_id = delete_contract.id_sim;
            var customer_id = delete_contract.SIM.id_cus;
            var contract_count = db.CONTRACTs.Count(p => p.SIM.id_cus == customer_id);
            if (contract_count < 2)
            {
                IList<SIM> delete_sims = db.SIMs.Where(p => p.id_cus == customer_id).ToList();
                IList<CUSTOMER> delete_customers = db.CUSTOMERs.Where(p => p.id == customer_id).ToList();
                IList<BILL> delete_bills = db.BILLs.Where(p => p.id_sim == sim_id).ToList();
                IList<DETAIL> delete_details = db.DETAILs.Where(p => p.id_sim == sim_id).ToList();
                db.DETAILs.RemoveRange(delete_details);
                db.BILLs.RemoveRange(delete_bills);
                db.SIMs.RemoveRange(delete_sims);
                db.CUSTOMERs.RemoveRange(delete_customers);
            }

            db.CONTRACTs.Remove(delete_contract);
            db.SaveChanges();
            db.Entry(contract).State = EntityState.Detached;
        }

        public void Update()
        {
            var edited_contract = db.CONTRACTs.First(p => p.id == contract.id);
            edited_contract.id_sim = contract.id_sim;
            edited_contract.fee = contract.fee;
            edited_contract.date_register = contract.date_register;
            edited_contract.status = contract.status;
            db.SaveChanges();
            db.Entry(contract).State = EntityState.Detached;
        }
        public List<CONTRACT> SearchBy_CustomerName(string name)
        {
            if (db.CONTRACTs.Any(c => c.SIM.CUSTOMER.name_cus.Contains(name)))
            {
                List<CONTRACT> result = db.CONTRACTs.Where(c => c.SIM.CUSTOMER.name_cus.Contains(name)).ToList();
                return result;
            }
            return null;
        }
        public void cancelContract_bySimID()
        {
            var cancel_contract = db.CONTRACTs.First(p => p.id_sim == contract.id);

            cancel_contract.status = false;
            db.SaveChanges();

            db.Entry(cancel_contract).State = EntityState.Detached;
        }

    }
}
