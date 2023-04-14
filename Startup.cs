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
            //    services.AddAuthentication(
            //        options =>
            //        {
            //            options.DefaultScheme = CookieAuthenticationDefaults.AuthenticationScheme;
            //            options.DefaultChallengeScheme = "OAuthProvider";
            //        })
            //        .AddCookie()
            //.AddGoogle(options =>
            //{
            //    IConfigurationSection googleAuthNSection =
            //        Configuration.GetSection("Authentication:Google");

            //    options.ClientId = googleAuthNSection["ClientId"];
            //    options.ClientSecret = googleAuthNSection["ClientSecret"];
            //})
            //.AddOAuth("OAuthProvider", options =>
            //{
            //    options.ClientId = "254761430313-purnb7pnn4rals57530jsrbsbtggumct.apps.googleusercontent.com";
            //    // other options here
            //});
            //    services.AddHsts(options =>
            //    {
            //        options.Preload = true;
            //        options.IncludeSubDomains = true;
            //        options.MaxAge = TimeSpan.FromDays(60);
            //    });
            services.AddSingleton<InferenceSession>(
                new InferenceSession("Model/my_model.onnx")
              );
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public async void Configure (IApplicationBuilder app, IWebHostEnvironment env)
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

            app.UseHsts();
            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseCookiePolicy();
            app.UseRouting();

            app.UseAuthentication();
            app.UseAuthorization();
            app.Use(async (context, next) => {
                context.Response.Headers.Add("Content-Security-Policy", "default-src 'self'; script-src 'self'; style-src 'self' https://stackpath.bootstrapcdn.com 'unsafe-inline' https://fonts.googleapis.com; font-src 'self' https://stackpath.bootstrapcdn.com https://fonts.gstatic.com; img-src 'self' https://via.placeholder.com; frame-src 'self'; connect-src 'self' wss://localhost:44391;");
                await next();
            });

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "wrappingpage",
                    pattern: "{wrapping}/Page{pageNum}",
                    defaults: new { Controller = "Home", action = "Summary" });

                endpoints.MapControllerRoute(
                    name: "sexpage",
                    pattern: "{sex}/Page{pageNum}",
                    defaults: new { Controller = "Home", action = "Summary" });

                endpoints.MapControllerRoute(
                    name:"Paging",
                    pattern:"Page{pageNum}",
                    defaults: new { Controller="Home", action="Index"}
                    );
                endpoints.MapControllerRoute(
                name: "score",
                pattern: "Model/Score",
                defaults: new { Controller = "Inference", action = "Score" });

                endpoints.MapControllerRoute(
                    name: "wrapping",
                    pattern: "{wrapping}",
                    defaults: new { Controller = "Home", action = "Summary", pageNum=1 });

                endpoints.MapControllerRoute(
                    name: "sex",
                    pattern: "{sex}",
                    defaults: new { Controller = "Home", action = "Summary", pageNum = 1 });
                
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
