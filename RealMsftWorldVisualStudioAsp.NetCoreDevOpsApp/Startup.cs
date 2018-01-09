﻿using System;
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
using RealMsftWorldVisualStudioAsp.NetCoreDevOpsApp.Data;
using RealMsftWorldVisualStudioAsp.NetCoreDevOpsApp.Services;
using System.Data.Odbc;
using System.Data.SqlClient;


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
         
            services.AddSingleton<IGreeter, Greeter>();
            services.AddScoped<IRestaurantData, SqlRestaurantData>();

            services.AddDbContext<RestaurantDbContext>(options => options.UseSqlServer(_configuration.GetConnectionString("RealMsftWorldLocal")));
           
            services.AddDbContext<RestaurantDbContext>(options => options.UseSqlServer(_configuration.GetConnectionString("RealMsftWorldAzure")));
          


            services.AddMvc();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(
            IApplicationBuilder app, 
            IHostingEnvironment env,
            IConfiguration  configuration,
            IGreeter greeter, ILogger<Startup> logger)
        {
            /// if (env.IsDevelopment())
             //{
                 app.UseDeveloperExceptionPage();
            //}

            
            //app.UseDefaultFiles();
            app.UseStaticFiles();
            //app.UseMvcWithDefaultRoute();
            app.UseMvc(ConfigureRoute);

            app.Run(async (context) =>
        
            {
               

                var greeting = greeter.GetMessageOfTheDay();
               // context.Response.ContentType = "text/plain";
                await context.Response.WriteAsync($"{greeting} : {env.EnvironmentName} Not Found");
            });












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
