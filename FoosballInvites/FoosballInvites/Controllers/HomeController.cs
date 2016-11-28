using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FoosballInvites.Models;

namespace FoosballInvites.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ViewResult Index()
        {
            int hour = DateTime.Now.Hour;
            ViewBag.Greeting = hour < 12 ? "Good morning" : "Good day";
            return View();
        }

        [HttpGet]
        public ViewResult RsvpForm()
        {
            return View();
        }

        [HttpPost]
        public ViewResult RsvpForm(CollegueResponse collegueResponse)
        {
            if (ModelState.IsValid)
            {
                // TODO: Email response to the party organizer
                return View("Thanks", collegueResponse);
            }
            else
            {
                // there is a validation error
                return View();
            }
        }
    }
}