using Microsoft.AspNetCore.Diagnostics;
using Microsoft.OpenApi.Models;
using MISA.AMIS.BL;
using MISA.AMIS.Common.Entities;
using MISA.AMIS.Common.Enums;
using MISA.AMIS.Common.Interface;
using MISA.AMIS.DL;

namespace MISA.AMIS.KeToan.API
{
    public class Startupcs
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
                services.AddCors();
                //Cấu hình Dl
                services.AddScoped(typeof(IDbContext<>), typeof(DbContext<>));
                services.AddScoped(typeof(IBaseService<>), typeof(BaseService<>));
                services.AddScoped<IDepartmentService, DepartmentService>();
                services.AddScoped<IEmployeeService, EmployeeService>();
                services.AddScoped<IJobPositionService, JobPositionService>();
                services.AddSwaggerGen(c =>
                {
                    c.SwaggerDoc("v1", new OpenApiInfo { Title = "MISA.AMIS.Api", Version = "v1" });
                });

            }

            // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
            public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
            {
                if (env.IsDevelopment())
                {
                    app.UseDeveloperExceptionPage();
                    app.UseSwagger();
                    app.UseCors(o => o.AllowAnyOrigin().AllowAnyHeader().AllowAnyMethod());
                    app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "MISA.AMIS.Api v1"));
                }

                app.UseExceptionHandler(a => a.Run(async context =>
                {
                    var exceptionHandlerPathFeature = context.Features.Get<IExceptionHandlerPathFeature>();
                    var exception = exceptionHandlerPathFeature.Error;

                    var serviceResult = new ServiceResult();
                    serviceResult.devMsg = exception.Message;
                    serviceResult.userMsg = MISA.AMIS.Common.Properties.Resources.UserMsg_Exception;
                    serviceResult.MISACode = (int)MISACode.ServerError;
                    await context.Response.WriteAsJsonAsync(serviceResult);
                }));
                app.UseRouting();

                app.UseAuthorization();

                app.UseEndpoints(endpoints =>
                {
                    endpoints.MapControllers();
                });
            }
        }
    }
}
