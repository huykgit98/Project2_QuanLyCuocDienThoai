using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebMVC.Models;

namespace GUI_WebMVC.Controllers
{
    public class HomeController : Controller
    {
        private QuanLyCuocDienThoai_dbEntities1 db = new QuanLyCuocDienThoai_dbEntities1();

        [HttpGet]
        public ActionResult Index()
        {
            return View(db.BILLs.ToList());
        }
        [HttpPost]
        public ActionResult Bill(string sdt)
        {

            var dt = db.BILLs.ToList().Where(p => p.SIM.phone.Contains(sdt));
            return View(dt);
        }
        [HttpGet]
        public ActionResult Detail(string simID, string kiSD)
        {
            DateTime kiSDDate = Convert.ToDateTime(kiSD);
            DateTime hanSDDate = kiSDDate.AddMonths(1);
            var dt = db.DETAILs.ToList().Where(p => p.id_sim.Contains(simID) && p.time_start >= kiSDDate && p.time_stop <= hanSDDate);
           return View(dt);

           
        }/*
        [HttpGet]
        public ActionResult Detail(string simID, string kiSD)
        {
            var sim = db.SIMs.Where(s => s.id == simID);
            var dETAIL = db.DETAILs.Where(s => sim.Any(s2 => s2.id == s.id_sim));
            sim = sim.Where(s => s.id.Contains(simID));
            DateTime kiSDDate = Convert.ToDateTime(kiSD);
            DateTime hanSDDate = kiSDDate.AddMonths(1);
          //  dETAIL = db.DETAILs.Where(s => sim.Any(s2 => s2.id == s.id_sim) && s. >= sdate && s.TIME_STOP <= edate);
            return View();

        }*/
    }
}