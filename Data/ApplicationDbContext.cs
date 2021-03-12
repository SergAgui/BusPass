using System;
using System.Collections.Generic;
using System.Text;
using BusPass.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace BusPass.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<CustomerModel> Customers {get; set;}
        public DbSet<FareModel> Fares {get; set;}
        public DbSet<OrderModel> Orders {get; set;}
        public DbSet<PriceModel> Prices {get; set;}
        public DbSet<ServiceAlertModel> ServiceAlerts {get; set;}
    }
}