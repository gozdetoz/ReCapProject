﻿using Business.Abstract;
using Business.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi
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
            services.AddControllers();
            #region Aciklama
            //Autofac yapısını kullanacagımız için .NetCore kendi bağımlılık çözme işlemlerini kaldırdır. Bu işlemi Web Apinin Program.cs içinde tanımlaması yapıldı
            //BUS
            //services.AddSingleton<ICarService, CarManager>();
            //services.AddSingleton<IColorService, ColorManager>();
            //services.AddSingleton<IUserService, UserManager>();
            //services.AddSingleton<IRentalService, RentalManager>();
            //services.AddSingleton<ICustomerService, CustomerManager>();
            //services.AddSingleton<IBrandService, BrandManager>();



            ////DAL
            //services.AddSingleton<ICarDal, EfCarDal>();
            //services.AddSingleton<IColorDal, EfColorDal>();
            //services.AddSingleton<IUserDal, EfUserDal>();
            //services.AddSingleton<IRentalDal, EfRentalDal>();
            //services.AddSingleton<ICustomerDal, EfCustomerDal>();
            //services.AddSingleton<IBrandDal, EfBrandDal>();
            #endregion


        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
