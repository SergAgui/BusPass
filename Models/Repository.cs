using BusPass.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BusPass.Models
{
    public class Repository
    {
        private readonly ApplicationDbContext _context;
        public Repository(ApplicationDbContext context) => _context = context;

        public CustomerModel GetCustomerId(int id)
        {
            var customer = _context.Customers.Where(cust => cust.Id == id).FirstOrDefault();
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
            var customer = GetCustomerId(custId);
            _context.Customers.Remove(customer);
            _context.SaveChanges();
        }
    }
}
