﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BusPass.Models;
using Microsoft.AspNetCore.Authorization;

namespace BusPass.Controllers
{
    [Authorize(Roles = "Administrator")]
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
        public ActionResult Add()
        {
            return View();
        }

        // POST: FareController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Add([Bind("Id,Fare,Price,PassType")] FareModel newFare)
        {
            if (ModelState.IsValid)
            {
                repository.NewFare(newFare);
                return RedirectToAction(nameof(Index));
            }
            return View(newFare);
        }

        // GET: FareController/Edit/5
        public ActionResult Edit(int id)
        {
            return View(repository.FindFareId(id));
        }

        // POST: FareController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind("Id,Fare,Price,PassType")] FareModel editFare, int id)
        {
            if (id != editFare.Id)
            {
                return NotFound();
            }
            if (ModelState.IsValid)
            {
                try
                {
                    repository.UpdateFare(editFare);
                    return RedirectToAction(nameof(Index));
                }
                catch
                {
                    throw new Repository.IncorrectFareException("Invalid Fare");
                }
            }
            return View(editFare);
        }

        // POST: FareController/Delete/5
        public ActionResult Delete(int id)
        {
            repository.RemoveFare(id);
            return RedirectToAction(nameof(Index));
        }
    }
}
