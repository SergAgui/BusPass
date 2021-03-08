﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BusPass.Models
{
    [Table("Fares")]
    public class FareModel
    {
        public int Id {get; set;}
        [Required]
        public string Fare {get; set;}

        [Required]
        public PriceModel Price;

        [DataType(DataType.Date)]
        public DateTime PurchaseDate {get; set;}
    }
}
