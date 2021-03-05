using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BusPass.Models
{
    [Table("ServiceAlerts")]
    public class ServiceAlertModel
    {
        public int Id { get; set; }
        public string Message { get; set; }
    }
}
