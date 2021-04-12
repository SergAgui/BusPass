using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BusPass.Models;

namespace BusPass.Controllers
{
    public class FareController : Controller
    {
        private readonly IRepository repository;
        public FareController(IRepository repo) => repository = repo;

        // GET: FareController
        public ActionResult Index()
        {
            return View(repository.AllFares());
        }

        // GET: FareController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: FareController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
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

        // GET: FareController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: FareController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
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

        // GET: FareController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: FareController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
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
