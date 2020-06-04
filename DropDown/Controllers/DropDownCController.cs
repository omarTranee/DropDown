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
        DropDownDbContext db = new DropDownDbContext();
        // GET: DropDownC
        public ActionResult Index()
        {
            ViewBag.CountryName = db.Countries.ToList();
            ViewBag.CategoryName = db.Categories.ToList();
            return View();
        }

        public JsonResult GetStatesByID(int ID)
        {

            return Json(db.States.Where(s => s.country_id == ID), JsonRequestBehavior.AllowGet);
        }

        public JsonResult GetCityByID(int ID)
        {
            return Json(db.Cities.Where(c => c.state_id == ID), JsonRequestBehavior.AllowGet);
        }

        #region MyRegion
        /* public ActionResult AllUser()
     {
         return View(db.UserProfiles.ToList());
     }*/

        /*  public ActionResult AllClinic()
          { 

              return View(db.Clinics.ToList());
          }*/

        #endregion
        [HttpPost]
        public JsonResult GetClinic(int stateId , int cityId ,int counteryId = -1, int catid = -1)
        {

        

            var city = db.Clinics.Where(c => c.Category.Id ==catid && c.State.state_id ==stateId).ToList();
            //var ClinicByCat = city.Where(c => c.Category.Id == CategoryId).ToList();

            ////return View("AllClinic",ClinicByCat);
            /// countris states 
            /// 

            //return $"Countrey  : {counteryId} - City  : {cityId} co- State : {stateId}  -Categoery : {catid}";
            return Json(db.Clinics.Where(c => c.Category.Id == catid && c.State.state_id == stateId).ToList());
        }
    }
}