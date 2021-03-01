using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BusPass.Models
{
    [Table("Customers")]
    public class CustomerModel
    {
        public int Id {get; set;}
        public string FirstName {get; set;}
        public string LastName {get; set;}
    }
}
