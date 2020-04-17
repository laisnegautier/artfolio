using artfolio.Data;
using artfolio.Hubs;
using artfolio.Models;
using artfolio.Services;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace artfolio
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<ApplicationDbContext>(options =>
                options
                    .UseLazyLoadingProxies()
                    .UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));

            services.AddDefaultIdentity<Artist>(options => options.SignIn.RequireConfirmedAccount = true)
                .AddEntityFrameworkStores<ApplicationDbContext>();

            services.AddTransient<IEmailSender, EmailSender>();
            services.Configure<AuthMessageSenderOptions>(Configuration);

            services.AddControllersWithViews();
            services.AddRazorPages()
                // Rewriting Identity URLs for /Identity/Account/... to /Account/...
                .AddRazorPagesOptions(o => o.Conventions.AddAreaFolderRouteModelConvention("Identity", "/Account/", model => { foreach (var selector in model.Selectors) { var attributeRouteModel = selector.AttributeRouteModel; attributeRouteModel.Order = -1; attributeRouteModel.Template = attributeRouteModel.Template.Remove(0, "Identity".Length); } }));

            services.Configure<CookiePolicyOptions>(options =>
                {
                    // This lambda determines whether user consent for non-essential cookies is needed for a given request.
                    options.CheckConsentNeeded = context => true;
                    options.MinimumSameSitePolicy = SameSiteMode.None;
                });

            // Messaging and broadcast notification
            services.AddSignalR();

            // CSRF applied to all my controllers
            services.AddMvc(options => { options.Filters.Add(new AutoValidateAntiforgeryTokenAttribute()); });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseDatabaseErrorPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthentication();
            app.UseAuthorization();

            app.UseCookiePolicy();

            app.UseEndpoints(endpoints =>
            {
                // Specific endpoints
                endpoints.MapControllerRoute(
                    name: "artist",
                    pattern: "{userName}",
                    defaults: new { controller = "Artist", action = "Index" });

                endpoints.MapControllerRoute(
                    name: "artwork",
                    pattern: "{userName}/{title}",
                    defaults: new { controller = "Artwork", action = "Index" });
                // constraints: new { title = @"^.*-.*$" });

                endpoints.MapControllerRoute(
                    name: "messages",
                    pattern: "Messages/{userName}",
                    defaults: new { controller = "Messages", action = "Index" });

                // Default endpoints
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");

                endpoints.MapRazorPages();
                endpoints.MapHub<MessagesHub>("/MessagesHub");
            });
        }
    }
}