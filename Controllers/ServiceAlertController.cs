using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BusPass.Controllers
{
    public class ServiceAlertController : Controller
    {
        // GET: ServiceAlertController
        public ActionResult Index()
        {
            return View();
        }

        // GET: ServiceAlertController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: ServiceAlertController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ServiceAlertController/Create
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

        // GET: ServiceAlertController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: ServiceAlertController/Edit/5
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

        // GET: ServiceAlertController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ServiceAlertController/Delete/5
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
