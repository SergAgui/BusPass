﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BusPass.Models
{
    [Table("Admin")]
    public class AdminModel
    {
        public int Id {get; set;}
        public string FistName {get; set;}
        public string LastName {get; set;}
    }
}
