using BanMayTinh.DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BanMayTinh.Controllers
{
    public class HomeController : Controller
    {
        DBContext context = new DBContext();
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult CheckOut()
        {
            return View();
        }

        public ActionResult LogIn()
        {
            return View();
        }

        public ActionResult Register()
        {
            return View();
        }
    }
}