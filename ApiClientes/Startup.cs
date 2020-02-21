using ApiCliente.Application.Interfaces;
using ApiCliente.Application.Services;
using ApiCliente.Domain.Core.Interfaces.Repositories;
using ApiCliente.Domain.Core.Interfaces.Services;
using ApiCliente.Domain.Services.Services;
using ApiCliente.Infrastructure.Repository.Repositories;
using ApiCliente.Infrastruture.CrossCutting.Adapter.Interfaces;
using ApiCliente.Infrastruture.CrossCutting.Adapter.Map;
using ApiCliente.Infrastruture.Data;
using AutoMapper;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;
using System;

namespace ApiClientes
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }


        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<SqlContext>(
              x => x.UseSqlServer(Configuration.GetConnectionString("DefaultConnection"))
          );

            services.AddMemoryCache();
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_3_0);

            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo
                {
                    Version = "v1",
                    Title = "API Clientes",
                    Description = "API contemplando crud de cliente e endereço",
                    Contact = new OpenApiContact
                    {
                        Name = "Diogo Ribeiro da Silva",
                        Email = "diogoribeirosilva@gmail.com",
                        Url = new Uri("https://www.linkedin.com/in/diogo-ribeiro-da-silva-b43a863b/"),
                    },
                });
            });

            services.AddScoped<IClienteRepository, ClienteRepository>();
            services.AddScoped<IClienteApplicationService, ClienteApplicationService>();
            services.AddScoped<IClienteService, ClienteService>();
            services.AddScoped<IClienteMapper, ClienteMapper>();
            services.AddScoped<IEnderecoRepository, EnderecoRepository>();
            services.AddScoped<IEnderecoApplicationService, EnderecoApplicationService>();
            services.AddScoped<IEnderecoService, EnderecoService>();
            services.AddScoped<IEnderecoMapper, EnderecoMapper>();

            services.AddAutoMapper();
        }
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            app.UseStaticFiles();

            app.UseSwagger();

            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "Api Clientes");
                c.RoutePrefix = string.Empty;
            });

           
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/error");
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
