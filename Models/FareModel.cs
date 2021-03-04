using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BusPass.Models
{
    [Table("Fares")]
    public class FareModel
    {
        public int Id {get; set;}
        public string Fare {get; set;}
        public PriceModel Price;
    }
}
