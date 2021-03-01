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
        public string SingleRide {get; set;}
        public string SingleReduced {get; set;}
        public string SingleDisability {get; set;}
        public string SingleDay {get; set;}
        public string ReducedDay {get; set;}
        public string DisabilityDay {get; set;}
        public string TenDayBooklet {get; set;}
        public string MonthPass {get; set;}
    }
}
