using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BusPass.Controllers
{
    public class FareController : Controller
    {
        // GET: FareController
        public ActionResult Index()
        {
            return View();
        }

        // GET: FareController/Details/5
        public ActionResult Details(int id)
        {
            return View();
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
