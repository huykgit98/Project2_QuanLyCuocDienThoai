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
    public class HomeController : Controller
    {
        private QuanLyCuocDienThoai_dbEntities1 db = new QuanLyCuocDienThoai_dbEntities1();

        public ActionResult Index()
        {
            return View();
        }
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        // GET: BILLs/Details/5
        public ActionResult BillDetails(string id)
        {
            var bILLs = db.BILLs.Include(b => b.SIM);
            return View(bILLs.ToList());
            //if (id == null)
            //{
            //	return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            //}
            //BILL bILL = db.BILLs.Find(id);
            //if (bILL == null)
            //{
            //	return HttpNotFound();
            //}
            //return View(bILL);
        }

        //public ActionResult SearchBill (string StartDate, string EndDate)
        //{
        //	var result = db.BILLs.Where(a => a.ID_SIM == id)
        //		.Where(a => a.DATE_EXPORT >= DateTime.ParseExact(StartDate, "MM/dd/yyyy", CultureInfo.InvariantCulture))
        //		.Where(a => a.DATE_CUT <= DateTime.ParseExact(EndDate, "MM/dd/yyyy", CultureInfo.InvariantCulture));
        //	return PartialView("AdvanceSearch", result);
        //}
    }
}