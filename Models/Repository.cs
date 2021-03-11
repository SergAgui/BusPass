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
            _context.Add(price);
            _context.SaveChanges();
        }

        //Add new fare to db
        public void NewFare(FareModel fare)
        {
            _context.Add(fare);
            _context.SaveChanges();
        }

        //Fare Methods
        //Find Fare by Id
        public FareModel FindFareId(int id)
        {
            var fare = _context.Fares.Where(fare => fare.Id == id).FirstOrDefault();
            return fare;
        }

        //Customer Methods
        //Find Customer by Id 
        public CustomerModel FindCustomerId(int id)
        {
            var customer = _context.Customers.Where(cust => cust.Id == id).FirstOrDefault();
            return customer;
        }

        //Add new customers to db
        public void NewCustomer(CustomerModel customer)
        {
            _context.Customers.Add(customer);
            _context.SaveChanges();
        }

        //Remove customer acct from db
        public void RemoveCustomer(int custId)
        {
            var customer = FindCustomerId(custId);
            _context.Customers.Remove(customer);
            _context.SaveChanges();
        }

        //Update Customer details
        public void UpdateCustomer(int id)
        {
            var customer = FindCustomerId(id);
            _context.Customers.Update(customer);
            _context.SaveChanges();
        }
    }
}
