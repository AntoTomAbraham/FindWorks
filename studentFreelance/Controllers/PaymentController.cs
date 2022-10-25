using Microsoft.AspNetCore.Mvc;
using studentFreelance.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Razor;
using Razorpay.Api;
using System.Xml.Linq;

namespace studentFreelance.Controllers
{
    public class PaymentController : Controller
    {
        private const string _key = "rzp_test_C7ayx7PaJJkARf";
        private const string _secret = "4BdgF5N5FitWBRBA6QwZrVwi";

        public IActionResult pay()
        {
            return View();
        }
        public IActionResult paynow()
        {
            return View();
        }

    }
}
