using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BusPass.Models
{
    public class RoleInfo
    {
        [Required]
        public string RoleName {get; set;}
        public string RoleId {get; set;}
        public string[] AddId {get; set;}
        public string[] RemoveId {get; set;}
    }
}
