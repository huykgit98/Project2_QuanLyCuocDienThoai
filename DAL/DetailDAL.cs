using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebMVC.Models;

namespace DAL
{
    public class DetailDAL
    {
        QuanLyCuocDienThoai_dbEntities1 db = new QuanLyCuocDienThoai_dbEntities1();
        DETAIL detail = new DETAIL();
        public void setDetail(int id)
        {
            this.detail.id = id;
        }
        public void setDetail(int id, string id_sim, DateTime start, DateTime stop)
        {
            this.detail.id = id;
            this.detail.id_sim = id_sim;
            this.detail.time_start = start;
            this.detail.time_stop = stop;
        }
        public void setDetail(string id_sim, DateTime start, DateTime stop)
        {
            this.detail.id_sim = id_sim;
            this.detail.time_start = start;
            this.detail.time_stop = stop;
        }
        public void setDetail(string id_sim, DateTime start, DateTime stop, int minutea7, int minutea23, int fare)
        {
            this.detail.id_sim = id_sim;
            this.detail.time_start = start;
            this.detail.time_stop = stop;
            this.detail.minute_7hto23h = minutea7;
            this.detail.minute_23hto7h = minutea23;
            this.detail.fare = fare;
        }
        public IEnumerable<DETAIL> GetAll(string masim, DateTime kisd, DateTime hansd)
        {
           // hansd = kisd.;
            // List<DETAIL> detail = db.DETAILs.Where(p => p.id_sim.).ToList();

            //List<DETAIL> detail = db.DETAILs.ToList();
            List<DETAIL> detail = db.DETAILs.Where(p => p.id_sim.Contains(masim) && p.time_start >= kisd && p.time_stop <= hansd).ToList(); 
            return detail;
        }
        public IEnumerable<DETAIL> GetAll()
        {
            List<DETAIL> detail = db.DETAILs.ToList();
            return detail;
        }
        public void Create()
        {
            var numeric_value = 1;

            while (db.DETAILs.Any(c => c.id == numeric_value))
            {
                numeric_value++;
            }
            detail.id = numeric_value;


            db.DETAILs.Add(detail);
            db.SaveChanges();

            db.Entry(detail).State = EntityState.Detached;
        }
        public void Delete()
        {
            var delete_detail = db.DETAILs.First(p => p.id == detail.id);

            db.DETAILs.Remove(delete_detail);
            db.SaveChanges();

            db.Entry(detail).State = EntityState.Detached;
        }

        public void Update()
        {
            var edited_detail = db.DETAILs.First(p => p.id == detail.id);

            edited_detail.id_sim = detail.id_sim;
            edited_detail.time_start = detail.time_start;
            edited_detail.time_stop = detail.time_stop;
            edited_detail.minute_7hto23h = detail.minute_7hto23h;
            edited_detail.minute_23hto7h = detail.minute_23hto7h;
            edited_detail.fare = detail.fare;

            db.SaveChanges();

            db.Entry(detail).State = EntityState.Detached;
        }

        public IEnumerable<DETAIL> SearchByName(string name)
        {
            if (db.DETAILs.Any(c => c.SIM.CUSTOMER.name_cus.Contains(name)))
            {
                List<DETAIL> result = db.DETAILs.Where(c => c.SIM.CUSTOMER.name_cus.Contains(name)).ToList();
                return result;
            }
            return null;
        }

        public int GetFare(string sim_id, DateTime date_export, DateTime date_cut)
        {
            var results = from detail in db.DETAILs
                          where date_export <= detail.time_start && date_cut >= detail.time_stop && detail.id_sim == sim_id
                          group detail by detail.id_sim into g
                          select new
                          {
                              SimID = g.Key,
                              TotalFare = g.Sum(x => x.fare)
                          };
           
            return Convert.ToInt32(results.Select(a => a.TotalFare).SingleOrDefault());
        }
        public int GetTotalUseMins(string sim_id, DateTime date_export, DateTime date_cut)
        {
            var results = from detail in db.DETAILs
                          where date_export <= detail.time_start && date_cut >= detail.time_stop && detail.id_sim == sim_id
                          group detail by detail.id_sim into g
                          select new
                          {
                              SimID = g.Key,
                              TotalMin = g.Sum(x => x.minute_7hto23h) + g.Sum(x => x.minute_23hto7h)
                          };
            return Convert.ToInt32(results.Select(a => a.TotalMin).SingleOrDefault());
        }
    }
}