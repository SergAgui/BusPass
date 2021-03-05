﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BusPass.Models
{
    [Table("Orders")]
    public class OrderModel
    {
        public int Id {get; set;}
        public int CustomerId {get; set;}
        public CustomerModel Customer {get; set;}
        public FareModel Fare {get; set;}
    }
}
