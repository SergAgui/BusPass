using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BusPass.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace BusPass.Controllers
{
    [Authorize]
    public class BuyingController : Controller
    {
        private readonly IRepository repository;
        public BuyingController(IRepository repo)
        {
            repository = repo;
        }

        // GET: Buying
        public ActionResult Order()
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
        public ActionResult Checkout([Bind("Id,User,Fare,PurchaseDate")]OrderModel order)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    //TODO: See if it's this part that is directing to Checkout and not Receipt
                    repository.NewOrder(order);
                    return View("Receipt");
                }
                catch
                {
                    throw new Repository.IncorrectOrderException("Invalid Order");
                }
            }
            return View(order);
        }

        //GET: Buying/Receipt/5
        public ActionResult Receipt()
        {
            return View(repository.OrderList().Last());
        }

        //GET: Buying/Receipt/5
        public ActionResult Receipt(int id)
        {
            return View(repository.FindOrderId(id));
        }

        //GET: Buying/PastOrders
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