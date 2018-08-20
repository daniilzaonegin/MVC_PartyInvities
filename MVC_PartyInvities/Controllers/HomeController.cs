using MVC_PartyInvities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_PartyInvities.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ViewResult Index() {
            int hour = DateTime.Now.Hour;
            ViewBag.Greeting = hour < 12 ? "Good morning" : "Good Afternoon";
            return View();
        }

        [HttpGet]
        public ViewResult RsvpForm() {
            return View();
        }

        [HttpPost]
        public ViewResult RsvpForm(GuestResponse guestResponse) {
            if (ModelState.IsValid)
            {
                //что сделать: отправить guestResponse по электронной почте организатору вечеринки
                return View("Thanks", guestResponse);
            }
            else
            {
                //обнаружена ошибка проверки достоверности.
                return View();
            }
        }

    }
}