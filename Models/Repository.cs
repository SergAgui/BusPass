using BusPass.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Identity;

namespace BusPass.Models
{
    public class Repository : IRepository
    {
        private readonly ApplicationDbContext _context;
        public Repository(ApplicationDbContext context) => _context = context;

        //Fare Methods
        //Find Fare by Id
        public FareModel FindFareId(int id)
        {
            var fare = _context.FareTable.Where(fare => fare.Id == id).FirstOrDefault();
            return fare;
        }
        //Add new fare to db
        public void NewFare(FareModel fare)
        {
            bool fareExists = _context.FareTable.Any(f => f.Fare == fare.Fare);
            if (!fareExists)
            {
                _context.FareTable.Add(fare);
                _context.SaveChanges();
            }
            else
            {
                throw new IncorrectFareException("Fare already exist");
            }
        }
        //Update Fare details
        public void UpdateFare(FareModel fare)
        {
            _context.FareTable.Update(fare);
            _context.SaveChanges();
        }
        //Remove Fare from db
        public void RemoveFare(int id)
        {
            var fare = FindFareId(id);
            _context.FareTable.Remove(fare);
            _context.SaveChanges();
        }
        //List of all Fares
        public List<FareModel> AllFares()
        {
            return _context.FareTable.ToList();
        }

        //Service Alert Methods
        //Find Alert by Id
        public ServiceAlertModel FindAlertId(int id)
        {
            var serviceAlert = _context.ServiceAlertsTable.Where(sa => sa.Id == id).FirstOrDefault();
            return serviceAlert;
        }
        //Add new Alert to db
        public void NewAlert(ServiceAlertModel serviceAlert)
        {
            _context.ServiceAlertsTable.Add(serviceAlert);
            _context.SaveChanges();
        }
        //Remove Alert from db
        public void RemoveAlert(int id)
        {
            var serviceAlert = FindAlertId(id);
            _context.ServiceAlertsTable.Remove(serviceAlert);
            _context.SaveChanges();
        }
        //List of all Alerts
        public List<ServiceAlertModel> AllAlerts()
        {
            return _context.ServiceAlertsTable.ToList();
        }

        //User Methods
        //List of all users
        public List<IdentityUser> AllUsers()
        {
            return _context.Users.ToList();
        }

        //Order Methods
        //Find Order by Id
        public OrderModel FindOrderId(int id)
        {
            var order = _context.OrderTable.Where(o => o.Id == id).FirstOrDefault();
            return order;
        }
        //New Order to db
        public void NewOrder(OrderModel order)
        {
            bool orderExists = _context.OrderTable.Any(odr => odr.FareId == order.FareId && odr.UserId == order.UserId && odr.PurchaseDate == order.PurchaseDate);
            bool userExists = _context.Users.Any(usr => usr.Id == order.UserId);
            bool fareExists = _context.FareTable.Any(fr => fr.Id == order.FareId);
            if(orderExists)
            {
                throw new IncorrectOrderException("Order already exists!");
            }
            if(!userExists)
            {
                throw new IncorrectUserException("Invalid User");
            }
            if(!fareExists)
            {
                throw new IncorrectFareException("Invalid Fare");
            }
                _context.OrderTable.Add(order);
                _context.SaveChanges();
        }
        //Remove order
        public void RemoveOrder(int id)
        {
            var order = FindOrderId(id);
            _context.OrderTable.Remove(order);
            _context.SaveChanges();
        }
        //List of orders
        public List<OrderModel> OrderList()
        {
            return _context.OrderTable.ToList();
        }

        //Exceptions
        public class IncorrectFareException : Exception
        {
            public IncorrectFareException(string message) : base(message)
            {
            }
        }
        public class IncorrectUserException : Exception
        {
            public IncorrectUserException(string message) : base(message)
            {
            }
        }
        public class IncorrectOrderException : Exception
        {
            public IncorrectOrderException(string message) : base(message)
            {
            }
        }
    }
}
