using ECommerce.DAL.Configuration;
using ECommerce.DAL.DBModel;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.DAL.Data
{
    public class AppDbIdentityContext : IdentityDbContext<AppUser, AppRole,string>
    {
        public AppDbIdentityContext(DbContextOptions<AppDbIdentityContext> options) : base(options)
        {

        }
   

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfigurationsFromAssembly(typeof(ProductConfiguration).Assembly);
            base.OnModelCreating(builder);
        }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductCategory> ProductCategories { get; set; }
        public DbSet<ProductImage> ProductImages { get; set; }

    }
}
