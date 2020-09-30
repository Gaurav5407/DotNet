using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TestController.Controllers
{
    public class ResourceController : Controller
    {
        // GET: Resource
        public FileResult Get()
        {
            string path = Server.MapPath(string.Format("~/App_Data/test.pdf"));
            return File(path, "application/pdf");
        }
    }
}