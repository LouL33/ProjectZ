using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Microsoft.AspNet.Identity;
using System.IO;
using System.Net;
using Newtonsoft.Json;

namespace ProjectZ.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Title = "Home Page";

            return View();
        }

        //[HttpPost]
        //public ActionResult SearchingSection(UserLocation point)
        //{
            
        //}
       

    }
}
