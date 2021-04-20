using BusPass.Models;
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
        private readonly IRepository repository;
        public ServiceAlertController(IRepository repo) => repository = repo;

        // GET: ServiceAlertController
        public ActionResult Index()
        {
            return View(repository.AllAlerts());
        }

        // GET: ServiceAlertController/Create
        public ActionResult Add()
        {
            return View();
        }

        // POST: ServiceAlertController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Add([Bind("Id,Message,AlertType")]ServiceAlertModel serviceAlert)
        {
            if(ModelState.IsValid)
            {
                repository.NewAlert(serviceAlert);
                return RedirectToAction(nameof(Index));
            }
            return View(serviceAlert);
        }

        // POST: ServiceAlertController/Delete/5
        public ActionResult Delete(int id)
        {
            repository.RemoveAlert(id);
            return RedirectToAction(nameof(Index));
        }
    }
}
