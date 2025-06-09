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
            return View();
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

    }
}