using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BusPass.Models
{
    [Table("Prices")]
    public class PriceModel
    {
        public int Id {get; set;}
        public int Price {get; set;}
    }
}
