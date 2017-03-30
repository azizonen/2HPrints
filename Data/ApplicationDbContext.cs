using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using XChange.Models;

namespace XChange.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public DbSet<Category> Categories { get; set; }
        public DbSet<Subcategory> Subcategories { get; set; }
        public DbSet<Auction> Auctions { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<Category>().HasKey(m => m.Id);
            builder.Entity<Subcategory>().HasKey(m => m.Id);
            builder.Entity<Auction>().HasKey(m => m.Id);

            // shadow properties
            builder.Entity<Auction>().Property<DateTime>("CreatedAt");
            builder.Entity<Auction>().Property<DateTime>("EndsAt");

            base.OnModelCreating(builder);
        }
    }
}
