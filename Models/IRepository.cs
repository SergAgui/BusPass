using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BusPass.Models
{
    public interface IRepository
    {
        CustomerModel FindCustomerId(int id);
        void NewCustomer(CustomerModel customer);
        void RemoveCustomer(int id);
    }
}
