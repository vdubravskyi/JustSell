using AutoMapper;
using JustSell.Bussiness.Common;
using JustSell.Data;
using JustSell.DatabaseLogger;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace JustSell
{
    public class Startup
    {
        public IConfiguration Configuration { get; }

        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<MainDBContext>(options =>
            {
                options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection"));
            });

            services.AddSingleton(new MapperConfiguration(options =>
            {
                options.AddProfile<MapperProfile>();
            }).CreateMapper());

            services.AddMvc();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env, ILoggerFactory loggerFactory)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            var context = app.ApplicationServices.CreateScope().ServiceProvider.GetService<MainDBContext>();

            loggerFactory.AddProvider(new DatabaseLoggerProvider(context));

            app.UseHttpsRedirection();

            app.UseAuthorization();

            app.UseHttpsRedirection();
        }
    }
}
