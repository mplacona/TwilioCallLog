using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;
using Twilio;

namespace TwilioCallLogMVC.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index(string phoneNumber)
        {
            // Instantiate a new Twilio Rest Client
            var client = new TwilioRestClient("your-twilio-account-sid", "your-twilio-auth-token");
            
            // Select all calls from my account based on a phoneNumber
            var calls = client.ListCalls(new CallListRequest(){To = phoneNumber}).Calls;

            return View(calls);
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View("~/Views/Shared/Error.cshtml");
        }
    }
}
