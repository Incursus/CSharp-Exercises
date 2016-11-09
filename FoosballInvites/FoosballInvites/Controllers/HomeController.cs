using System;
using System.Web.Mvc;
using PartyInvites.Models;

namespace FoosballInvites.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ViewResult Index()
        {
            int hour = DateTime.Now.Hour;
            ViewBag.Greeting = hour < 12 ? "Labas rytas" : "Laba diena";
            return View();
        }

        [HttpGet]
        public ViewResult RsvpForm()
        {
            return View();
        }
       

        [HttpPost]
        public ViewResult RsvpForm(GuestResponse guestResponse)
        {
            if (ModelState.IsValid)
                return View("Ačiū", guestResponse);

            else
            {
                return View();
            }
        }
    }
}