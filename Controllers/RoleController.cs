using BusPass.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
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
        public async Task<IActionResult> Edit(string id)
        {
            IdentityRole role = await roleManager.FindByIdAsync(id);
            List<IdentityUser> members = new List<IdentityUser>();
            List<IdentityUser> nonMembers = new List<IdentityUser>();
            foreach (var user in userManager.Users)
            {
                var list = await userManager.IsInRoleAsync(user, role.Name) ? members : nonMembers;
                list.Add(user);
            }
            return View(new RoleLists
            {
                Role = role,
                Members = members,
                NonMembers = nonMembers
            });
        }

        // POST: RoleController/Edit/5
        public async Task<IActionResult> Edit(RoleInfo info)
        {
            IdentityResult result;
            if (ModelState.IsValid)
            {
                foreach (string userId in info.AddId ?? new string[] { })
                {
                    var user = await userManager.FindByIdAsync(info.RoleId);
                    if (user != null)
                    {
                        result = await userManager.AddToRoleAsync(user, info.RoleName);
                        if (!result.Succeeded)
                        {
                            Error(result);
                        }
                    }
                }
                foreach (string userId in info.RemoveId ?? new string[] { })
                {
                    var user = await userManager.FindByIdAsync(userId);
                    if (user != null)
                    {
                        result = await userManager.RemoveFromRoleAsync(user, info.RoleName);
                        if (!result.Succeeded)
                            Error(result);
                    }
                }
                return View(nameof(Index));
            }
            return View(info);
        }

        private void Error(IdentityResult result)
        {
            foreach (IdentityError error in result.Errors)
            {
                ModelState.AddModelError("", error.Description);
            }
        }
    }
}
