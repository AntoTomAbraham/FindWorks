using Microsoft.AspNetCore.Mvc;
using studentFreelance.Models;
using System;
using Microsoft.AspNetCore.SignalR;

namespace studentFreelance.Controllers
{
    public class ChatController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult ShowConnectedUsers()
        {
            return View();
        }

    }
}
