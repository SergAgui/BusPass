using BusPass.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BusPass.Models
{
    public class Repository : IRepository
    {
        private readonly ApplicationDbContext _context;
        public Repository(ApplicationDbContext context) => _context = context;

        //Price Methods
        //Find Price by Id
        public PriceModel FindPriceId(int id)
        {
            var price = _context.Prices.Where(price => price.Id == id).FirstOrDefault();
            return price;
        }
        //Add new price to db
        public void NewPrice(PriceModel price)
        {
            _context.Prices.Add(price);
            _context.SaveChanges();
        }
        //Update price
        public void UpdatePrice(int id)
        {
            var price = FindPriceId(id);
            _context.Prices.Update(price);
            _context.SaveChanges();
        }
        //Remove Price from db
        public void RemovePrice(int id)
        {
            var price = FindPriceId(id);
            _context.Prices.Remove(price);
            _context.SaveChanges();
        }

        //Fare Methods
        //Find Fare by Id
        public FareModel FindFareId(int id)
        {
            var fare = _context.Fares.Where(fare => fare.Id == id).FirstOrDefault();
            return fare;
        }
        //Add new fare to db
        public void NewFare(FareModel fare)
        {
            _context.Fares.Add(fare);
            _context.SaveChanges();
        }
        //Update Fare details
        public void UpdateFare(int id)
        {
            var fare = FindFareId(id);
            _context.Fares.Update(fare);
            _context.SaveChanges();
        }
        //Remove Fare from db
        public void RemoveFare(int id)
        {
            var fare = FindFareId(id);
            _context.Fares.Remove(fare);
            _context.SaveChanges();
        }
        //List of all Fares
        public List<FareModel> AllFares()
        {
            return _context.Fares.ToList();
        }

        //Service Alert Methods
        //Find Alert by Id
        public ServiceAlertModel FindAlertId(int id)
        {
            var serviceAlert = _context.ServiceAlerts.Where(sa => sa.Id == id).FirstOrDefault();
            return serviceAlert;
        }
        //Add new Alert to db
        public void NewAlert(ServiceAlertModel serviceAlert)
        {
            _context.ServiceAlerts.Add(serviceAlert);
            _context.SaveChanges();
        }
        //Remove Alert from db
        public void RemoveAlert(int id)
        {
            var serviceAlert = FindAlertId(id);
            _context.ServiceAlerts.Remove(serviceAlert);
            _context.SaveChanges();
        }
        //List of all Alerts
        public List<ServiceAlertModel> AllAlerts()
        {
            return _context.ServiceAlerts.ToList();
        }

        //User Methods
        //Find User by Id 
        public UserModel FindUserId(int id)
        {
            var user = _context.Users.Where(cust => cust.Id == id).FirstOrDefault();
            return user;
        }
        //New user to db
        public void NewUser(UserModel user)
        {
            _context.Users.Add(user);
            _context.SaveChanges();
        }
        //Remove user acct from db
        public void RemoveUser(int custId)
        {
            var user = FindUserId(custId);
            _context.Users.Remove(user);
            _context.SaveChanges();
        }
        //Update User details
        public void UpdateUser(int id)
        {
            var user = FindUserId(id);
            _context.Users.Update(user);
            _context.SaveChanges();
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
    }
}
