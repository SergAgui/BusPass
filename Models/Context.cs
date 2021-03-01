using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BusPass.Models
{
    public class Context : DbContext
    {
        public DbSet<FareModel> Fares {get; set;}
        public DbSet<CustomerModel> Customers {get; set;}
        public DbSet<AdminModel> Admins {get; set;}
        public Context(DbContextOptions<Context> options) : base(options)
        {

        }
    }
}
