using Gionet.blazor.Data;
using Gionet.blazor.Data.Services;
using Gionet.blazor.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Gionet.blazor
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddRazorPages();
            services.AddServerSideBlazor();
            services.AddSingleton<WeatherForecastService>();
            var connectionString = "server=31.170.161.85;user=u598002034_TkvUc;password=Puertas3489*;database=u598002034_fnZfT";
            var serverVersion = new MySqlServerVersion(new Version(8, 0, 25));
            ServerVersion.AutoDetect(connectionString);

            // Replace 'YourDbContext' with the name of your own DbContext derived class.
            services.AddDbContext<u598002034_fnZfTContext>(dbContextOptions => dbContextOptions.UseMySql(connectionString, serverVersion).EnableSensitiveDataLogging().EnableDetailedErrors(),    // <-- with debugging (remove for production).
            ServiceLifetime.Transient);
            services.AddTransient<u598002034_fnZfTContext>();
            services.AddTransient<Clientesclass>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Error");
            }

            app.UseStaticFiles();

            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapBlazorHub();
                endpoints.MapFallbackToPage("/_Host");
            });
        }
    }
}
