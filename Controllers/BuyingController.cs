﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BusPass.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BusPass.Controllers
{
    public class BuyingController : Controller
    {
        private readonly IRepository repository;
        public BuyingController(IRepository repo)
        {
            repository = repo;
        }

        // GET: Buying
        public ActionResult Order()
        {
            return View();
        }

        // POST: Bying/Checkout
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Checkout()
        {
            return View();
        }

        //GET: View previous orders
        public ActionResult PastOrders()
        {
            return View(repository.OrderList());
        }

        // GET: Buying/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // GET: Buying/Delete/5
        public ActionResult Refund(int id)
        {
            return View();
        }

        // POST: Buying/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Refund(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}