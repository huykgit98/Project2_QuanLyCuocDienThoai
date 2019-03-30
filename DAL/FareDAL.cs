using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebMVC.Models;


namespace DAL
{
   public class FareDAL
    {
        QuanLyCuocDienThoai_dbEntities1 db = new QuanLyCuocDienThoai_dbEntities1();
        FARE fare = new FARE();
        public void setFare(string id, int fare1, TimeSpan start, TimeSpan stop)
        {
            this.fare.id = id;
            this.fare.fare1 = fare1;
            this.fare.time_start = start;
            this.fare.time_stop = stop;
        }
        public void setFare(string id, TimeSpan start, TimeSpan stop)
        {
            this.fare.id = id;
            this.fare.time_start = start;
            this.fare.time_stop = stop;
        }
        public IEnumerable<FARE> GetAll()
        {
            List<FARE> fare = db.FAREs.ToList();
            return fare;
        }
        public TimeSpan getbeginTime(string id)
        {
            return (TimeSpan)db.FAREs.Where(c => c.id == id).Select(c => c.time_start).SingleOrDefault();
        }
        public int getFare1(string id)
        {
            return (int)db.FAREs.Where(c => c.id == id).Select(c => c.fare1).SingleOrDefault();
        }
        public void Update()
        {
            var edited_fare = db.FAREs.First(p => p.id == fare.id);

            edited_fare.id = fare.id;
            edited_fare.time_start = fare.time_start;
            edited_fare.time_stop = fare.time_stop;

            db.SaveChanges();

            db.Entry(fare).State = EntityState.Detached;
        }
        public void Update_rest()
        {
            var edited_fare = db.FAREs.First(p => p.id == fare.id);

            edited_fare.time_start = fare.time_start;
            edited_fare.time_stop = fare.time_stop;

            db.SaveChanges();

            db.Entry(fare).State = EntityState.Detached;
        }

    }
}
