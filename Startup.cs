using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpOverrides;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Infrastructure;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Net.Http.Headers;
using System;
using System.Net;

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
            services.Configure<CookiePolicyOptions>(options =>
              {
                  // This lambda determines whether user consent for non-essential cookies is needed for a given request.
                  options.CheckConsentNeeded = context => true;
                  options.MinimumSameSitePolicy = Microsoft.AspNetCore.Http.SameSiteMode.None;
              });

            services.AddSingleton(typeof(IHttpContextAccessor), typeof(HttpContextAccessor));
            var opt = new WebEssentials.AspNetCore.Pwa.PwaOptions
            {
                OfflineRoute = "/",
                RegisterServiceWorker = true,
                RegisterWebmanifest = true
            };

            services.AddProgressiveWebApp(opt, "manifest.json");
            services.AddHttpContextAccessor();
            services.AddSingleton<IActionContextAccessor, ActionContextAccessor>();
            services.Configure<ForwardedHeadersOptions>(options =>
           {
               options.ForwardedHeaders =
                   ForwardedHeaders.All;
           });
            services.AddResponseCaching();
            services.AddMvc();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public static void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            System.Console.WriteLine("Launching with environment: " + env.EnvironmentName);
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
            }

            app.UseRouting();

            app.UseEndpoints(endpoints => {
                endpoints.MapControllers();

                endpoints.MapRazorPages();

                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");

            });

            app.UseForwardedHeaders(new ForwardedHeadersOptions
            {
                ForwardedHeaders = ForwardedHeaders.All,
                RequireHeaderSymmetry = false,
                ForwardLimit = null,
                KnownProxies = { IPAddress.Parse("127.0.0.1") },
            });

            var policyCollection = new HeaderPolicyCollection()
                .AddXssProtectionEnabled()
                .AddFrameOptionsDeny()
                .AddXssProtectionBlock()
                .AddContentTypeOptionsNoSniff()
                .AddReferrerPolicyStrictOriginWhenCrossOrigin()
                .RemoveServerHeader()
                .AddContentSecurityPolicy(builder =>
               {
                   builder.AddFrameAncestors().None();
               });

            app.UseSecurityHeaders(policyCollection);

            app.UseResponseCaching();

            app.Use(async (context, next) =>
           {
               context.Response.GetTypedHeaders().CacheControl =
               new Microsoft.Net.Http.Headers.CacheControlHeaderValue()
               {
                   Public = true,
                   MaxAge = TimeSpan.FromSeconds(10)
               };
               context.Response.Headers[Microsoft.Net.Http.Headers.HeaderNames.Vary] =
                   new string[] { "Accept-Encoding" };

               await next();
           });

            app.UseStaticFiles(new StaticFileOptions
            {
                OnPrepareResponse = ctx =>
                {
                    const int durationInSeconds = 60 * 60 * 24;
                    ctx.Context.Response.Headers[HeaderNames.CacheControl] =
                        "public,max-age=" + durationInSeconds;
                }
            });
            app.UseCookiePolicy();

            
        }
    }
}