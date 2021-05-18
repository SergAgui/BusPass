using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BusPass.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
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
        public ActionResult Order(IdentityUser user)
        {
            List<FareModel> NewFare = new List<FareModel>();
            foreach (var item in repository.AllFares())
            {
                NewFare.Add(item);
            }
            ViewData["NewFare"] = NewFare;
            return View();
        }

        // POST: Bying/Checkout
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Checkout(OrderModel order)
        {
            try
            {
                repository.NewOrder(order);
                return View();
            }
            catch (Exception ex)
            {
                ViewBag.message = "Invalid Order";
                return View();
            }
        }

        //GET: View previous orders
        public ActionResult PastOrders()
        {
            return View(repository.OrderList());
        }

        // GET: Buying/Refund/5
        public ActionResult Refund()
        {
            return View(repository.OrderList());
        }

        // POST: Buying/Refund/5
        public ActionResult Refund(int id)
        {
            repository.RemoveOrder(id);
            return RedirectToAction(nameof(Refund));
        }
    }
}