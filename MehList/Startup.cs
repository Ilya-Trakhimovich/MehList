using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using DAL.Abstract;
using DAL.Abstract.IRepositories;
using DAL.Abstract.IUnitOfWork;
using DAL.Concrete;
using DAL.Concrete.Repositories;
using DAL.Concrete.UnitOfWork;
using DAL.EF.EFContext;
using DAL.EF.Entities;
using MehList.Mapper;
using MehList.ViewModels;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace MehList
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
            services.AddScoped<IMechanismRepository, MechanismRepository>();
            services.AddScoped<IBuildingObjectRepository, BuildingObjectRepository>();
            services.AddScoped<IUnitOfWork, UnitOfWork>();            
            services.AddDbContext<AppDbContext>(options =>
            {
                options.UseSqlServer(Configuration["ConnectionStrings:AppDbConnection"]);
            });
            services.AddAutoMapper(typeof(Startup));
            services.AddControllersWithViews();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseRouting();
            app.UseAuthorization();
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                 pattern: "{controller=Mechanism}/{action=Index}");
            });
        }
    }
}
