using Autofac;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Orders_Payments_Server.DataBase.Contexts;
using Orders_Payments_Server.DataBase.Funds.Repositories.Interfaces;
using Orders_Payments_Server.DataBase.Funds.Repositories;
using Orders_Payments_Server.DataBase.Orders.Repositories.Interfaces;
using Orders_Payments_Server.DataBase.Orders.Repositories;
using Orders_Payments_Server.DataBase.Payments.Repositories;
using Orders_Payments_Server.DataBase.Payments.Repositories.Interfaces;
using Orders_Payments_Server.Domain.Funds.Services.Interfaces;
using Orders_Payments_Server.Domain.Funds.Services;
using Orders_Payments_Server.Domain.Orders.Services.Interfaces;
using Orders_Payments_Server.Domain.Orders.Services;
using Orders_Payments_Server.Domain.Payments.Services.Interfaces;
using Orders_Payments_Server.Domain.Payments.Services;

namespace Orders_Payments_Server.API
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; private set; }
        public ILifetimeScope AutofacContainer { get; private set; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {

            services.AddControllers();
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "Orders_Payments_Server", Version = "v1" });
            });
            services.AddOptions();
        }

        public void ConfigureContainer(ContainerBuilder builder)
        {
            builder.RegisterType<MSSQLServerDBContext>().As<OrdersPaymentsDBContext>().WithParameter("connectionString", Configuration["ConnectionStrings:OrdersPaymentsDB"]).InstancePerLifetimeScope();
            builder.RegisterType<FundsRepository>().As<IFundsRepository>();
            builder.RegisterType<OrdersRepository>().As<IOrdersRepository>();
            builder.RegisterType<PaymentsRepository>().As<IPaymentsRepository>();
            builder.RegisterType<FundsService>().As<IFundsService>();
            builder.RegisterType<OrdersService>().As<IOrdersService>();
            builder.RegisterType<PaymentsService>().As<IPaymentsService>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "Orders_Payments_Server v1"));
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
