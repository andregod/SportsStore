﻿using Microsoft.EntityFrameworkCore;
using SportsStore.Models;

namespace SportsStore.Data
{
    public class SportsStoreDbContext : DbContext
    {
        public SportsStoreDbContext(DbContextOptions<SportsStoreDbContext> options) : base(options) { }

        public DbSet<Product> Products {get;set; }
    }
}
