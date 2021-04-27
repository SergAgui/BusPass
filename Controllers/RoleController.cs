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
        private RoleManager<IdentityRole> roleManager;
        private UserManager<IdentityUser> userManager;
        public RoleController(RoleManager<IdentityRole> roleMan, UserManager<IdentityUser> userMan)
        {
            roleManager = roleMan;
            userManager = userMan;
        }

        // GET: RoleController
        public ActionResult Index()
        {
            return View(roleManager.Roles);
        }

        // GET: RoleController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: RoleController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(IdentityRole role)
        {
            if (ModelState.IsValid)
            {
                await roleManager.CreateAsync(role);
                return RedirectToAction("Index");
            }
            return View(role);
        }

        // POST: RoleController/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            var role = await roleManager.FindByIdAsync(id);
            if (role != null)
            {
                var result = await roleManager.DeleteAsync(role);
                if (result.Succeeded)
                {
                    return RedirectToAction("Index");
                }
                else
                {
                    Error(result);
                }
            }
            else
            {
                ModelState.AddModelError("", "No role found");
            }
            return View("Index", roleManager.Roles);
        }

        // GET: RoleController/Edit/5
        public IActionResult Edit(string id)
        {
            return View(roleManager.FindByIdAsync(id));
        }

        // POST: RoleController/Edit/5


        private void Error(IdentityResult result)
        {
            foreach(IdentityError error in result.Errors)
            {
                ModelState.AddModelError("", error.Description);
            }
        }
    }
}
