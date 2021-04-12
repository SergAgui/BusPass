using System;
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
        public BuyingController(IRepository order)
        {
            repository = order;
        }

        // GET: Buying
        public ActionResult Order()
        {
            return View();
        }

        // GET: Order info and confirm
        public ActionResult Checkout()
        {
            return View();
        }

        //GET: View previous orders
        public ActionResult PastOrders()
        {
            return View();
        }

        // GET: Buying/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Buying/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Buying/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Buying/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Buying/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Buying/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Buying/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}