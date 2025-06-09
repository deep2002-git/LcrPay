using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace lcr_pay.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View("Index");
        }

        public ActionResult Privacy_Policy()
        {
            return View();
        } 
        public ActionResult Term_condition()
        {
            return View();
        } 
        public ActionResult Return_Policy()
        {
            return View();
        }
        public ActionResult Contact_Us()
        {
            return View();
        }

        public ActionResult BBPS_Services()
        {
            return View();
        }

        public ActionResult Mobile_Recharge()
        {
            return View();
        }

    }
}