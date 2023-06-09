using Intex2A.Data;
using Intex2A.Models;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.ML.OnnxRuntime;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Intex2A
{
    public class Startup
    {
        public IConfiguration Configuration { get; set; }
      
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
       
        }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<IntexDbContext>(options =>
            {
                options.UseNpgsql(Configuration.GetConnectionString("DefaultConnection"));
            });
            services.AddScoped<IintexRepository, EFintexRepository>();
            services.AddDbContext<ApplicationDbContext>(options =>
                options.UseSqlServer(
                    Configuration.GetConnectionString("SecurityConnection")));
            services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = false)
                .AddRoles<IdentityRole>()
                .AddEntityFrameworkStores<ApplicationDbContext>();
            services.AddScoped<IintexRepository, EFintexRepository>();
            services.AddControllersWithViews();
            services.AddRazorPages();
            services.Configure<CookiePolicyOptions>(options =>
            {
                // This lambda determines whether user consent for non-essential 
                // cookies is needed for a given request.
                options.CheckConsentNeeded = context => true;
                // requires using Microsoft.AspNetCore.Http;
                options.MinimumSameSitePolicy = SameSiteMode.None;
                options.ConsentCookie.SecurePolicy = CookieSecurePolicy.Always;

            });
            services.Configure<IdentityOptions>(options =>
            {
                // Default Password settings.
                options.Password.RequireDigit = true;
                options.Password.RequireLowercase = true;
                options.Password.RequireNonAlphanumeric = true;
                options.Password.RequireUppercase = true;
                options.Password.RequiredLength = 13;
                options.Password.RequiredUniqueChars = 1;
            });

            services.AddHsts(options =>
            {
                options.Preload = true;
                options.IncludeSubDomains = true;
                options.MaxAge = TimeSpan.FromDays(60);
            });

            services.AddSingleton<InferenceSession>(provider => {
                var env = provider.GetService<IWebHostEnvironment>();
                var modelPath = Path.Combine(env.ContentRootPath, "wwwroot", "my_model.onnx");
                return new InferenceSession(modelPath);
            });
        }

            // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public async void Configure(IApplicationBuilder app, IWebHostEnvironment env)
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
                app.UseHsts();
                app.UseStaticFiles();
                app.UseCookiePolicy();
                app.UseRouting();

                app.UseAuthentication();
                app.UseAuthorization();
                app.Use(async (context, next) => {
                    context.Response.Headers.Add("Content-Security-Policy", "default-src 'self'; script-src 'self'  https://ajax.aspnetcdn.com/ajax/jquery.validate/1.17.0/jquery.validate.min.js https://ajax.aspnetcdn.com; style-src 'self' https://stackpath.bootstrapcdn.com 'unsafe-inline' https://fonts.googleapis.com; font-src 'self' https://stackpath.bootstrapcdn.com https://fonts.gstatic.com; img-src 'self' https://via.placeholder.com; frame-src 'self'; connect-src 'self' wss://localhost:44391;");
                    await next();
                });

                app.UseEndpoints(endpoints =>
                {
                    endpoints.MapControllerRoute(
                        name: "wrappingpage",
                        pattern: "{wrapping}/Page{pageNum}",
                        defaults: new { Controller = "Home", action = "Summary" });

                    endpoints.MapControllerRoute(
                        name: "editburial",
                        pattern: "Home/Edit/{burialId}",
                        defaults: new { Controller = "Home", action = "Edit" });

                    endpoints.MapControllerRoute(
                        name: "deleteburial",
                        pattern: "Home/Delete/{burialId}",
                        defaults: new { Controller = "Home", action = "Delete" });

                    endpoints.MapControllerRoute(
                        name: "confirmdelete",
                        pattern: "Home/ConfirmDelete/{burialId}",
                        defaults: new { Controller = "Home", action = "ConfirmDelete" });

                    endpoints.MapControllerRoute(
                        name: "createburial",
                        pattern: "Home/CreateBurial",
                        defaults: new { Controller = "Home", action = "CreateBurial" });

                    endpoints.MapControllerRoute(
                        name: "Paging",
                        pattern: "Page{pageNum}",
                        defaults: new { Controller = "Home", action = "Index" }
                        );
                    endpoints.MapControllerRoute(
                    name: "score",
                    pattern: "Model/Score",
                    defaults: new { Controller = "Inference", action = "Score" });

                    endpoints.MapControllerRoute(
                        name: "default",
                        pattern: "{controller=Home}/{action=Index}/{id?}");
                    endpoints.MapRazorPages();

                });

                //using (var scope = app.ApplicationServices.CreateScope())
                //{
                //    var roleManager = scope.ServiceProvider.GetRequiredService<RoleManager<IdentityRole>>();
                //    var roles = new[] { "Admin", "Manager", "Memeber" };
                //    foreach (var role in roles)
                //    {
                //        if (!await roleManager.RoleExistsAsync(role))
                //            await roleManager.CreateAsync(new IdentityRole(role));
                //    }
                //}

                //using (var scope = app.ApplicationServices.CreateScope())
                //{
                //    var userManager =
                //        scope.ServiceProvider.GetRequiredService<UserManager< IdentityUser >> ();

                //    string email = "admin@admin.com";
                //    string password = "Test1234";

                //    if(await userManager.FindByEmailAsync(email) == null)
                //    {
                //        var user = new IdentityUser();
                //        user.UserName = email;
                //        user.Email = email;

                //        await userManager.CreateAsync(user, password);
                //        await userManager.AddToRoleAsync(user, "Admin");
                //    }

                //}
            }
        }
    }
