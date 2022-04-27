using BusPass.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BusPass.Controllers
{
    [Authorize]
    public class BuyingController : Controller
    {
        private readonly IRepository repository;
        private UserManager<IdentityUser> userManager;
        public BuyingController(IRepository repo, UserManager<IdentityUser> manager)
        {
            repository = repo;
            userManager = manager;
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
        public async Task<ActionResult> Order([Bind("Id,UserId,FareId,PurchaseDate")] OrderModel order)
        {
            if (ModelState.IsValid)
            {
                try
                {

                    order.UserId = userManager.GetUserId(User);
                    order.User = await userManager.GetUserAsync(User);
                    order.Fare = repository.FindFareId(order.FareId);
                    repository.NewOrder(order);
                    return RedirectToAction("Receipt", new { id = order.Id });
                }
                catch
                {
                    throw new Repository.IncorrectOrderException("Invalid Order");
                }
            }
            return View(order);
        }

        //GET: Buying/Receipt/5
        public ActionResult Receipt(int id)
        {
            var fareDict = new Dictionary<int, string>();
            foreach (var item in repository.AllFares())
            {
                fareDict.Add(item.Id, item.Fare);
            }
            ViewData["AllFares"] = fareDict;
            return View(repository.FindOrderId(id));
        }

        //GET: Buying/PastOrders/5
        public ActionResult PastOrders()
        {
            if (User.IsInRole("Manager") || User.IsInRole("Administrator"))
            {
                return View(repository.OrderList());
            }
            else
            {
                return View(repository.OrderList().Where(uid => uid.UserId == userManager.GetUserId(User)));
            }
        }

        // POST: Buying/Refund/5
        public ActionResult Refund(int id)
        {
            repository.RemoveOrder(id);
            return RedirectToAction(nameof(Refund));
        }
    }
}