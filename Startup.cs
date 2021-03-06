﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using aspnet.Models.Services.Application;
using aspnet.Models.Services.Infrastructure;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;

namespace aspnet
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();            
            services.AddTransient<ICourseService,ADOCourseService>();                       
            services.AddTransient<IDataBaseAccessor,SQLiteDataBaseAccessor>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env,IApplicationLifetime lifetime)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();

                //Logica per reload con browsersync 
                lifetime.ApplicationStarted.Register(()=>{ 
                    string filePath= Path.Combine(env.ContentRootPath,"bin/reload.txt");                    
                    File.WriteAllText(filePath,DateTime.Now.ToString());
                });
            }

           app.UseStaticFiles();

           app.UseMvc(routeBuilder => {
               routeBuilder.MapRoute("default","{controller=Home}/{action=Index}/{id?}");
           });
        }
    }
}
