using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebMVC.Models;

namespace DAL
{
    public class CustomerDAL
    {
        QuanLyCuocDienThoai_dbEntities1 db = new QuanLyCuocDienThoai_dbEntities1();
        CUSTOMER customer = new CUSTOMER();

        public void setCustomer(string name, int identity, string job, string position, string address, string email)
        {
            this.customer.name_cus = name;
            this.customer.identify = identity;
            this.customer.job = job;
            this.customer.position = position;
            this.customer.address = address;
            this.customer.email = email;

        }
        public void setCustomer(string id, string name, int identity, string job, string position, string address, string email)
        {
            this.customer.id = id;
            this.customer.name_cus = name;
            this.customer.identify = identity;
            this.customer.job = job;
            this.customer.position = position;
            this.customer.address = address;
            this.customer.email = email;

        }
        public void setCustomer(string id)
        {
            this.customer.id = id;
        }
        public IEnumerable<CUSTOMER> GetAll()
        {
            List<CUSTOMER> customer = db.CUSTOMERs.ToList();
            return customer;
        }
        public void Create()
        {
            var numeric_value = 1;
            var id_str = "KH0";

            while (db.CUSTOMERs.Any(c => c.id == id_str + numeric_value.ToString()))
            {
                numeric_value++;
                if (numeric_value > 9)
                    id_str = "KH";
            }
            customer.id = id_str + numeric_value.ToString();


            db.CUSTOMERs.Add(customer);
            db.SaveChanges();
        }

        public void Delete()
        {
            var delete_customer = db.CUSTOMERs.First(p => p.id == customer.id);
            IList<CONTRACT> delete_contracts = db.CONTRACTs.Where(p => p.SIM.id == customer.id).ToList();
            IList<SIM> delete_sims = db.SIMs.Where(p => p.id == customer.id).ToList();
            IList<BILL> delete_bills = db.BILLs.Where(p => p.SIM.id == customer.id).ToList();
            IList<DETAIL> delete_details = db.DETAILs.Where(p => p.SIM.id == customer.id).ToList();

            db.DETAILs.RemoveRange(delete_details);
            db.BILLs.RemoveRange(delete_bills);
            db.CONTRACTs.RemoveRange(delete_contracts);
            db.SIMs.RemoveRange(delete_sims);
            db.CUSTOMERs.Remove(delete_customer);
            db.SaveChanges();
            db.Entry(customer).State = EntityState.Detached;
        }


        public void Update()
        {
            var edited_customer = db.CUSTOMERs.Where(p => p.id == customer.id).Select(p => p).FirstOrDefault();
            edited_customer.name_cus = customer.name_cus;
            edited_customer.identify = customer.identify;
            edited_customer.job = customer.job;
            edited_customer.position = customer.position;
            edited_customer.address = customer.address;
            edited_customer.email = customer.email;

            db.SaveChangesAsync();

            db.Entry(customer).State = EntityState.Detached;
        }
        public bool checkExistCustomer()
        {
            return db.CUSTOMERs.Any(c => c.id != customer.id && (c.identify == customer.identify || c.name_cus == customer.name_cus && c.address == customer.address && c.identify == customer.identify));
        }
        public IEnumerable<CUSTOMER> SearchByName(string name)
        {
            if (db.CUSTOMERs.Any(c => c.name_cus.Contains(name)))
            {
                List<CUSTOMER> result = db.CUSTOMERs.Where(c => c.name_cus.Contains(name)).ToList();
                return result;
            }
            return null;
        }

        public List<CUSTOMER> SearchById_Customer(string id_customer)
        {
            if (db.CUSTOMERs.Any(c => c.id.Contains(id_customer)))
            {
                List<CUSTOMER> result = db.CUSTOMERs.Where(c => c.id.Contains(id_customer)).ToList();
                return result;
            }
            return null;
        }

        public string getName_in_Customer(string id_customer)
        {
            return (from h in db.CUSTOMERs where h.id.Equals(id_customer) select h.name_cus).FirstOrDefault();
        }
        public string getEmail_in_Customer(string id_customer)
        {
            return (from h in db.CUSTOMERs where h.id.Equals(id_customer) select h.email).FirstOrDefault();
        }
        public void AdvSearch()
        {

        }
    }
}
