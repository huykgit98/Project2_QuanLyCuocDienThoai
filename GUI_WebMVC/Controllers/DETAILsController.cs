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
    public class DETAILsController : Controller
    {
        private QuanLyCuocDienThoai_dbEntities1 db = new QuanLyCuocDienThoai_dbEntities1();
        // GET: Details
        [HttpGet]
        public ActionResult Index()
        {
            return View(db.DETAILs.ToList());
        }
        [HttpPost]
        public ActionResult Index(string sdt)
        {

            var dt = db.DETAILs.ToList().Where(p => p.SIM.phone.Contains(sdt));
            return View(dt);
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