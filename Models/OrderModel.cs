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
        public IdentityUser User {get; set;}
        [Required]
        public int FareId{get; set;}
        public FareModel Fare {get; set;}
        [Required]
        [DataType(DataType.Date)]
        public DateTime PurchaseDate {get; set;}
    }
}
