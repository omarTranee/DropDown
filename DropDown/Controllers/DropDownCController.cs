using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DropDown.Models;

namespace DropDown.Controllers
{
    public class DropDownCController : Controller
    {
        // GET: DropDownC
        public ActionResult Index()
        {
            DropDownDbContext db = new DropDownDbContext();

            // المتغيرات اللي بعتها مع اللستا بتاعت الكانتريز دي الايدي بتاع الكانتري واسمها عشان لما اعوز استخدمهم ف الفيو وابعتهم يرجعولي وهما اليي بستخدمهم ف الفلتر اللي حصل ف 
            // الدالة اللي بترجعلي المدن 
            // وهو برده اللي بيرجع من الدالة بتاعت 
            // $("#IdForListReferesToCountry").val()
            // val() الفاليو اللي هاترجع هي قيمة الاي دي 
            ViewBag.CountryName = new SelectList(db.Countries,"id","name");
            return View();
        }

        public JsonResult GetStatesByID(int ID)
        {
            DropDownDbContext db = new DropDownDbContext();

            return Json(db.States.Where(s => s.country_id == ID), JsonRequestBehavior.AllowGet);
        }

        public JsonResult GetCityByID(int ID)
        {
            DropDownDbContext db = new DropDownDbContext();
            return Json(db.Cities.Where(c => c.state_id == ID), JsonRequestBehavior.AllowGet);
        }

        public ActionResult AllUser()
        {
            DropDownDbContext db = new DropDownDbContext();
            return View(db.UserProfiles.ToList());
        }
    }
}