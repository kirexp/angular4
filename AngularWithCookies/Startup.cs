using System;
using ESA.DAL.Almaty.Entities.Account;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.SpaServices.Webpack;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using WebApplication1.Auth;

namespace AngularWithCookies
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
            services.AddMvc();
            //services.AddAuthentication("Identity.Application");
            services.AddAuthentication(options => {
                options.DefaultChallengeScheme = "Identity.Application";
                options.DefaultSignInScheme = "Identity.Application";
                options.DefaultAuthenticateScheme = "Identity.Application";

            }).AddCookie("Identity.Application", options =>
            {
                options.LoginPath = "/Home/Index";
                options.LogoutPath = "/Home/Index";
                options.ExpireTimeSpan = TimeSpan.FromHours(1);
                options.SlidingExpiration = true;
            });
            services.AddIdentityCore<User>(options => { })
                .AddUserManager<ApplicationUserManager<User>>().AddUserStore<ApplicationUserStore>()//.AddSignInManager<ApplicationSignInManger<User>>()
                .AddDefaultTokenProviders();
            services.ConfigureApplicationCookie(options => {
                options.Cookie = new CookieBuilder {
                    Expiration = TimeSpan.FromHours(1),
                    SecurePolicy = CookieSecurePolicy.Always,
                    HttpOnly = true,
                };

            });
            // Add application services.
            services.AddTransient<SignInManager<User>, SignInManager<User>>();
            services.AddTransient<UserManager<User>, ApplicationUserManager<User>>();
            services.AddTransient<IHttpContextAccessor, HttpContextAccessor>();

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseWebpackDevMiddleware(new WebpackDevMiddlewareOptions
                {
                    HotModuleReplacement = true
                });
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
            }

            app.UseAuthentication();
            
            app.UseStaticFiles();

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");

                routes.MapSpaFallbackRoute(
                    name: "spa-fallback",
                    defaults: new { controller = "Home", action = "Index" });
            });
        }
    }
}
