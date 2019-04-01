using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using WebMVC.Models;

namespace GUI_WebMVC.Controllers
{
    public class DETAILController : Controller
    {
        private QuanLyCuocDienThoai_dbEntities1 db = new QuanLyCuocDienThoai_dbEntities1();

        // GET: DETAILs
        public ActionResult Index(string id, string simID, string StartDate, string EndDate)
        {

            var cus = db.CUSTOMERs.Where(s => s.email == id + "@gmail.com").FirstOrDefault();
            var sim = db.SIMs.Where(s => s.id_cus == cus.id);
            ViewBag.simID = new SelectList(sim, "ID_SIM", "PHONENUMBER");
            ViewBag.StartDate = StartDate;
            ViewBag.EndDate = EndDate;
            var dETAIL = db.DETAILs.Where(s => sim.Any(s2 => s2.id == s.id_sim));
            if (!String.IsNullOrEmpty(simID) && !String.IsNullOrEmpty(StartDate) && !String.IsNullOrEmpty(EndDate))
            {
                sim = sim.Where(s => s.id.Contains(simID));
                try
                {
                    DateTime sdate = Convert.ToDateTime(StartDate);
                    DateTime edate = Convert.ToDateTime(EndDate);
                    dETAIL = db.DETAILs.Where(s => sim.Any(s2 => s2.id == s.id_sim) && s.time_start >= sdate && s.time_stop <= edate);
                }
                catch (Exception ex) //Truong hop loi dinh dang MM dd yyyy
                {
                    dETAIL = db.DETAILs.Where(s => sim.Any(s2 => s2.id == s.id_sim));
                }
            }
            else if (!String.IsNullOrEmpty(simID)) //Truong hop chi loc theo sdt
            {
                sim = sim.Where(s => s.id.Contains(simID));
                dETAIL = db.DETAILs.Where(s => sim.Any(s2 => s2.id == s.id_sim));
            }
            return View(dETAIL.ToList());

        }

      
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
