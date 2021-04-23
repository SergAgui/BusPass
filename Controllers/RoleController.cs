using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BusPass.Controllers
{
    public class RoleController : Controller
    {
        RoleManager<IdentityRole> roleManager;
        public RoleController(RoleManager<IdentityRole> roleMan) => roleManager = roleMan;

        // GET: RoleController
        public ActionResult Index()
        {
            return View(roleManager.Roles);
        }

        // GET: RoleController/Create
        public ActionResult Create()
        {
            return View(new IdentityRole());
        }

        // POST: RoleController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(IdentityRole role)
        {
            await roleManager.CreateAsync(role);
            return RedirectToAction("Index");
            /*try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }*/
        }

        // GET: RoleController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: RoleController/Delete/5
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
