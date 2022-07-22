using System.Text;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.IdentityModel.Tokens;
using Newtonsoft.Json.Converters;

using Microsoft.EntityFrameworkCore;
using calculadora_api.Models;

using System;
using calculadora_api.Repositories;

namespace calculadora_api
{
    public class Startup
    {
        public IConfiguration Configuration { get; }

        public Startup(IConfiguration configuration) => Configuration = configuration;

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddCors();
            services.AddControllers();
            services.AddCors(o => o.AddPolicy("MyPolicy", builder =>
            {
                builder.AllowAnyOrigin()
               .AllowAnyMethod()
               .AllowAnyHeader();
            }));

            // var key = Encoding.ASCII.GetBytes(Settings.Secret);
            // services.AddAuthentication(x =>
            // {
            //     x.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
            //     x.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
            // })
            // .AddJwtBearer(x =>
            // {
            //     x.RequireHttpsMetadata = false;
            //     x.SaveToken = true;
            //     x.TokenValidationParameters = new TokenValidationParameters
            //     {
            //         ValidateIssuerSigningKey = true,
            //         IssuerSigningKey = new SymmetricSecurityKey(key),
            //         ValidateIssuer = false,
            //         ValidateAudience = false
            //     };
            // });

            services.AddControllersWithViews()
                .AddNewtonsoftJson(options =>
                {
                    options.SerializerSettings.Converters.Add(new StringEnumConverter());
                });
            // "Server=WIN-DBIQMVKJ4NK\\SQLEXPRESS;Database=master;Uid=WIN-DBIQMVKJ4NK\\Administrator;"
            // services.AddDbContext<UserContext>(opt => opt.UseSqlServer("Server=localhost;Database=master;Trusted_Connection=True;"));
            services.AddDbContext<UserContext>(opt => opt.UseSqlServer("Server=calculadora-juridica.database.windows.net; Database=safra; User ID=safra; Password=Xp2PunKvyZgeuXgp; Trusted_Connection=False;"));
            services.AddScoped<UserRepository>();
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            app.UseRouting();
            app.UseCors("MyPolicy");

//            app.UseCors(x => x
//                .AllowAnyOrigin()
//                .AllowAnyMethod()
//                .AllowAnyHeader());

//            app.UseAuthentication();
//            app.UseAuthorization();


            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
