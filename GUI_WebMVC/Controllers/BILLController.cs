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
    public class BILLController : Controller
    {
        private QuanLyCuocDienThoai_dbEntities1 db = new QuanLyCuocDienThoai_dbEntities1();

        // GET: BILL
        public ActionResult Index(string id, string simID)
        {
            var cus = db.CUSTOMERs.Where(s => s.email == id + "@gmail.com").FirstOrDefault();
            var sim = db.SIMs.Where(s => s.id_cus == cus.id);
            ViewBag.simID = new SelectList(sim, "ID_SIM", "PHONENUMBER");
            var bILL = db.BILLs.Where(s => sim.Any(s2 => s2.id == s.id_sim));
            if (!String.IsNullOrEmpty(simID)) //Truong hop chi loc theo sdt
            {
                sim = sim.Where(s => s.id.Contains(simID));
                bILL = db.BILLs.Where(s => sim.Any(s2 => s2.id == s.id_sim));
            }
            bILL = db.BILLs.Where(s => sim.Any(s2 => s2.id == s.id_sim));
            /*var dETAIL = db.DETAILs.Where(s => sim.Any(s2 => s2.ID_SIM == s.ID_SIM));
            var billdetails = from s in dETAIL
                              group s by s.ID_SIM into detailgroup
                              select new
                              {
                                  ID_SIM = detailgroup.Key,

                                  MINUTEUSED = dETAIL.Sum(x => x.MINUTE_AFTER7) + dETAIL.Sum(x => x.MINUTE_AFTER23),
                              };*/

            return View(bILL.ToList());
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