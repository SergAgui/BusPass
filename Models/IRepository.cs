using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BusPass.Models
{
    public interface IRepository
    {
        PriceModel FindPriceId(int id);
        void NewPrice(PriceModel price);
        FareModel FindFareId(int id);
        void NewFare(FareModel fare);
        CustomerModel FindCustomerId(int id);
        void NewCustomer(CustomerModel customer);
        void RemoveCustomer(int id);
        void UpdateCustomer(int id);
    }
}
