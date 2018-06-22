using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using NetEscapades.AspNetCore;
using Microsoft.AspNetCore.Http;
using WebEssentials.AspNetCore.Pwa;

namespace emperor_mvc
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public static void ConfigureServices(IServiceCollection services)
        {
            services.AddSingleton(typeof(IHttpContextAccessor), typeof(HttpContextAccessor));
            services.AddMvc();

            services.AddProgressiveWebApp();

            // WebEssentials.AspNetCore.ServiceWorker.AddProgressiveWebApp();
            
            // WebEssentials.AspNetCore.Pwa.AddProgressiveWebApp(services,"manifest.json",new PwaOptions { Strategy = ServiceWorkerStrategy.CacheFirst, RegisterServiceWorker = true, RegisterWebmanifest = true });

            // services.AddProgressiveWebApp( new PwaOptions { Strategy = ServiceWorkerStrategy.CacheFirst, RegisterServiceWorker = true, RegisterWebmanifest = true }, "manifest.json");
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public static void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
            }

            app.UseSecurityHeaders();

            app.UseStaticFiles();

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
