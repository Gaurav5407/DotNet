using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using TestController.Models;

namespace TestController
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            List<Medicine> medicineList = new List<Medicine>();
            Medicine medicine1 = new Medicine();
            medicine1.Id = 1;
            medicine1.Name = "gaurav";
            medicine1.Price = 100;
            medicine1.ExpiryDate = new DateTime(2015, 12, 31);
            Medicine medicine2 = new Medicine();
            medicine2.Id = 2;
            medicine2.Name = "rock";
            medicine2.Price = 200;
            medicine2.ExpiryDate = new DateTime(2020, 5, 28);
            medicineList.Add(medicine1);
            medicineList.Add(medicine2);
            Medicine.lst = medicineList;
            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);
        }
    }
}
