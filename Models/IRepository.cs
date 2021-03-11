﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BusPass.Models
{
    public interface IRepository
    {
        PriceModel FindPriceId(int id);
        void NewPrice(PriceModel price);
        void UpdatePrice(int id);
        void RemovePrice(int id);
        FareModel FindFareId(int id);
        void NewFare(FareModel fare);
        void UpdateFare(int id);
        void RemoveFare(int id);
        CustomerModel FindCustomerId(int id);
        void NewCustomer(CustomerModel customer);
        void RemoveCustomer(int id);
        void UpdateCustomer(int id);
    }
}
