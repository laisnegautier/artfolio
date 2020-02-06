using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using artfolio.Areas.Identity.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace artfolio.Data
{
    public class artfolioContext : IdentityDbContext<IdentityUser>
    {
        public artfolioContext(DbContextOptions<artfolioContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            // Customize the ASP.NET Identity model and override the defaults if needed.
            // For example, you can rename the ASP.NET Identity table names and more.
            // Add your customizations after calling base.OnModelCreating(builder);
        }

        public DbSet<artfolioUser> artfolioUser { get; set; }
    }
}
