﻿using Microsoft.EntityFrameworkCore;
using ShopsRUs.Data.Configurations;
using ShopsRUs.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopsRUs.Data
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext(DbContextOptions<ApplicationContext> options) :base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new SeedUserData());
            
            modelBuilder.ApplyConfiguration(new SeedDiscountData());
            modelBuilder.ApplyConfiguration(new SeedInvoiceData());
            modelBuilder.ApplyConfiguration(new SeedInvoiceDetailsData());
        }
        
        public DbSet<DiscountType> DiscountType { get; set; }
        public DbSet<Invoice> Invoices { get; set; }
        public DbSet<InvoiceDetails> InvoiceDetails { get; set; }
        public DbSet<Users> Users { get; set; }
    }
}
