using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BusPass.Models
{
    [Table("Orders")]
    public class OrderModel
    {
        public int Id {get; set;}
        public string UserId {get; set;}
        [Required]
        public IdentityUser User {get; set;}
        public int FareId{get; set;}
        [Required]
        public FareModel Fare {get; set;}
        [DataType(DataType.Date)]
        public DateTime PurchaseDate {get; set;}
    }
}
