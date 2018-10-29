using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FluentValidation;
using FluentValidation.AspNetCore;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Todo.Business.Abstract;
using Todo.Business.Concrete;
using Todo.Business.Validator.FluentValidator;
using Todo.Core.Aspects.ValidationAspect;
using Todo.DataAccess.Abstract;
using Todo.DataAccess.Concrete;
using Todo.DataAccess.Models;

namespace Todo.WebAPI
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
            services.AddMvc(opt =>
            {
                opt.Filters.Add(typeof(ValidationAspect));
            }).AddFluentValidation();

            services.AddScoped<IValidator<Company>, CompanyValidator>();
            services.AddScoped<ICompanyService, CompanyManager>();
            services.AddScoped<ICompanyDal, EfCompanyDal>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseMvc();
        }
    }
}
