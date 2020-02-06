using System;
using artfolio.Areas.Identity.Data;
using artfolio.Data;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

[assembly: HostingStartup(typeof(artfolio.Areas.Identity.IdentityHostingStartup))]
namespace artfolio.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
                services.AddDbContext<artfolioContext>(options =>
                    options.UseSqlServer(
                        context.Configuration.GetConnectionString("artfolioContextConnection")));

                services.AddDefaultIdentity<artfolioUser>(options => options.SignIn.RequireConfirmedAccount = true)
                    .AddEntityFrameworkStores<artfolioContext>();
            });
        }
    }
}