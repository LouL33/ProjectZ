using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Microsoft.AspNet.Identity;
using System.IO;
using System.Net;
using ProjectZ.Models;
using ProjectZ.viewModels;
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

        [HttpPost]
        public ActionResult AButton(UsersLocation point)
        {
            //var RandomPlace = new Results();
            do
            {
                var googleKey = "https://maps.googleapis.com/maps/api/place/nearbysearch/json?key=AIzaSyAUmnlcZvvd_b31I8JVPkHyeW-fUkJVbqM&radius=5000&location={0},{1}&type=restaurant";
                var url = string.Format(googleKey, point.Latitude, point.Longitude);

                var request = WebRequest.Create(url);
                var rawResponse = String.Empty;
                var response = request.GetResponse();

                using (var reader = new StreamReader(response.GetResponseStream()))
                {
                    rawResponse = reader.ReadToEnd();
                };

                //var googleData = JsonConvert.DeserializeObject<RootObject>(rawResponese);

                Random random = new Random();
                int number = random.Next(0, 20);
               // randomPlace = googleData.results[number];


            }
            while (randomPlace.photos == null);
            if (User.Identity.GetUserId() != null)
            {
               // var randomToSave = new projectZModelscs { Name = randomPlace.name, /*Image = randomRest.photos.FirstOrDefault().photo_reference, */Address = randomPlace.vicinity, UserId = User.Identity.GetUserId(), Faveorited = false, GoogleId = randomPlace.id }
            }

            return View();
        }


    }
}
