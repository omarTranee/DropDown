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
            ViewBag.StateName = db.States.Where(c=>c.country_id==64).ToList();
            ViewBag.CategoryName = db.Categories.ToList();
            return View();
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
        public ActionResult GetClinic(int stateId=-1, int cityId =-1, int categoryid=-1)
        {

            //return $" - City  : {cityId} co- State : {stateId}  -Categoery : {categoryid}";
            return View("AllClinic",db.Clinics.Where(c => c.Category.Id == categoryid && c.City.id == cityId).ToList());

        }
    }
}