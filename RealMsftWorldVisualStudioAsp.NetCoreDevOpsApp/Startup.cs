using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Routing;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using System.Data.Odbc;
using System.Data.SqlClient;
using RealMsftWorldVisualStudioAsp.NetCoreDevOpsApp.Data;
using RealMsftWorldVisualStudioAsp.Services;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Rewrite;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication.OpenIdConnect;

namespace RealMsftWorldVisualStudioAsp.NetCoreDevOpsApp
{
    public class Startup
    {
        private IConfiguration _configuration;

        public Startup(IConfiguration configuration)
        {
            _configuration = configuration;
        }



        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {

            services.AddAuthentication(options =>
            {
                options.DefaultScheme = CookieAuthenticationDefaults.AuthenticationScheme;
                options.DefaultChallengeScheme = OpenIdConnectDefaults.AuthenticationScheme;
            })
                 .AddOpenIdConnect(options =>
         {
             _configuration.Bind("AzureAd", options);
          })
                .AddCookie();

            /* services.AddIdentity<UsersLogin, IdentityRole>(cfg =>
             {
                 cfg.User.RequireUniqueEmail = true;
                 cfg.Password.RequireDigit = true;
                 cfg.Password.RequireUppercase = true;
                 cfg.Password.RequiredLength = 8;
             })
             .AddEntityFrameworkStores<ContactInformationDbContext>();*/

            services.AddDbContext<ContactInformationDbContext>(options => options.UseSqlServer(_configuration.GetConnectionString("RealMsftWorldAzure")));

            services.AddIdentity<UsersLogin, IdentityRole>().AddEntityFrameworkStores<ContactInformationDbContext>();

            services.AddScoped<IContactInformationData, SqlContactInformationData>();
            services.AddMvc();

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(
            IApplicationBuilder app,
            IHostingEnvironment env,
            IConfiguration configuration)

        {




            //app.UseDefaultFiles();
             //app.UseRewriter( new RewriteOptions           ()
            //      .AddRedirectToHttpsPermanent());

            app.UseStaticFiles();

            app.UseAuthentication();

            app.UseMvcWithDefaultRoute();

            app.UseMvc(ConfigureRoute);

            app.UseBrowserLink();














            /* app.Run(async (context) =>
             {
                 var greeting = configuration["Greeting"];
                 await context.Response.WriteAsync(greeting);
             });*/

            //Some high level programs
            /*  app.Use(next => {
                  return async context =>
                  {
                      logger.LogInformation("Request incoming");
                      if (context.Request.Path.StartsWithSegments("/mym"))
                      {
                          await context.Response.WriteAsync("Hit!!");
                          logger.LogInformation("Request handled");

                      }

                      else
                      {
                          await next(context);
                          logger.LogInformation("Request outgoing");

                      }

                  };
              });

              app.UseWelcomePage( new WelcomePageOptions
              {
                  Path="/wp"
              } 
                  );*/


            /*app.UseMvc(cfg =>
              {
                  cfg.MapRoute("Default",
                      "{Controller}/{action}/{id?}",
                      new { controller = "App", Action = "Index" });
              });*/
        }

        private void ConfigureRoute(IRouteBuilder routeBuilder)
        {
            //Home/Index/4
            routeBuilder.MapRoute("Default", "{controller=Home}/{action=Index}/{id?}");
        }
    }
}