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
        public int UserId {get; set;}
        [Required]
        public UserModel User {get; set;}
        [Required]
        public FareModel Fare {get; set;}
        [DataType(DataType.Date)]
        public DateTime PurchaseDate {get; set;}
    }
}
