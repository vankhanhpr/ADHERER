
using System.Text;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.IdentityModel.Tokens;
using WebApi.data;
using WebApi.serrvice.admin.interfaces;
using WebApi.serrvice.admin.responsitory;
using WebApi.serrvice.authentication;
using WebApi.serrvice.authentication.responsitoty;
using WebApi.serrvice.unit.interfaces;
using WebApi.serrvice.unit.responsitory;
using WebApi.serrvice.user.interfaces;
using WebApi.serrvice.user.responsitory;

namespace WebApi
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
            services.AddDbContext<MyDBContext>(options =>
            options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));

            services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
            .AddJwtBearer(options =>
            {
                options.TokenValidationParameters = new TokenValidationParameters
                {
                    ValidateIssuer = true, // có validate Server tạo JWT không ?
                    ValidateAudience = true,
                    ValidateLifetime = true, //có validate expire time hay không ?
                    ValidateIssuerSigningKey = true,
                    ValidIssuer = Configuration["Jwt:Issuer"],
                    ValidAudience = Configuration["Jwt:Issuer"],
                    IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(Configuration["Jwt:Key"]))
                };
            });

            //services.AddSingleton<IFileProvider>(
            //   new PhysicalFileProvider(
            //       Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/images/user")));//image
            //services.AddSingleton<IFileProvider>(
            //   new PhysicalFileProvider(
            //       Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/images/admin")));//image


            services.AddScoped<IUserResponsitory, UserResponsitory>();
            services.AddScoped<IAuthentication, AuthenticationResponsitory>();
            services.AddScoped<IAdUserResponsitory, AdUserResponsitory>();
            services.AddTransient<IProvinceResponsitory, ProvinceResponsitory>();
            services.AddTransient<IDistrictResponsitory, DistrictResponsitory>();
            services.AddTransient<IWardResponsitory, WardResponsitory>();
            services.AddTransient<IDangBoResponsitory, DangBoResponsitory>();

            services.AddCors();
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);
        }

        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseHsts();
            }

            app.UseCors(builder => builder
                                    .AllowAnyOrigin()
                                    .AllowAnyMethod()
                                    .AllowAnyHeader()
                                    .AllowCredentials());
            app.UseAuthentication();
            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseMvc();
        }
    }
}
