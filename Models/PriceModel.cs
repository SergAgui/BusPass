using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BusPass.Models
{
    [Table("Prices")]
    [Keyless]
    public class PriceModel
    {
        public int SingleRidePrice {get; set;}
        public int SingleReducedPrice {get; set;}
        public int SingleDisabilityPrice {get; set;}
        public int SingleDayPrice {get; set;}
        public int ReducedDayPrice {get; set;}
        public int DisabilityDayPrice {get; set;}
        public int TenDayPrice {get; set;}
        public int MonthPassPrice {get; set;}
    }
}
