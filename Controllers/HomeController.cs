﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using BusPass.Models;

namespace BusPass.Controllers
{
    public class HomeController : Controller
    {
        private readonly IRepository repository;
        public HomeController(IRepository repo) => repository = repo;

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            return View();
        }

        public IActionResult Contact ()
        {
            return View();
        }

        public IActionResult Alerts()
        {
            return View(repository.AllAlerts());
        }

        public IActionResult Fares()
        {
            return View(repository.AllFares());
        }

        public IActionResult Purchase()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
