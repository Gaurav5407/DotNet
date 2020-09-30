using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using TestController.Models;

namespace TestController.Controllers
{
    public class MedicineController : Controller
    {
        [HttpGet]
        public JsonResult Get(int? id)
        {
            Medicine medicine = Medicine.lst.Where(d => d.Id == id).FirstOrDefault();
            if (medicine != null)
            {
                return Json(medicine, JsonRequestBehavior.AllowGet);
            }
            return Json(Medicine.lst, JsonRequestBehavior.AllowGet);
        }
        [HttpPost]
        public ActionResult Post(Medicine modal=null)
        {
            if (!ModelState.IsValid)
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest, "Record not recieved");

            Medicine medicine = Medicine.lst.Where(d => d.Id == modal.Id).FirstOrDefault();
            if (medicine != null)
            {
                return Content("Record already exists");
            }
            else
            {
                Medicine.lst.Add(modal);
            }
            return null;
        }
        [HttpPost]
        public ActionResult Put(Medicine modal)
        {
            if (modal == null)
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest, "Record not recieved");

            Medicine medicine = Medicine.lst.Where(d => d.Id == modal.Id).FirstOrDefault();
            if (medicine != null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest, "Not found result");
            }
            else
            {
                medicine = modal;
                return Json(medicine, JsonRequestBehavior.AllowGet);
            }
        }
        [HttpPost]
        public ActionResult Delete(int? id)
        {
            Medicine medicine = Medicine.lst.Where(d => d.Id == id).FirstOrDefault();
            if (medicine != null)
            {
                Medicine.lst.Remove(medicine);
                return Json(medicine, JsonRequestBehavior.AllowGet);
            }
            else
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest, "Record not Found");
            }

        }
    }
}