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
        public DbSet<FareModel> FareTable {get; set;}
        public DbSet<OrderModel> OrderTable {get; set;}
        public DbSet<ServiceAlertModel> ServiceAlertsTable {get; set;}
        public DbSet<BusPass.Models.QRCModel> QRCModel { get; set; }
    }
}