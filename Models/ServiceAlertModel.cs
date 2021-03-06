﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BusPass.Models
{
    [Table("ServiceAlerts")]
    public class ServiceAlertModel
    {
        public int Id { get; set; }
        [Required]
        public string Message { get; set; }
        public enum Type {Current, Event}
        public Type AlertType {get; set;}
    }
}
