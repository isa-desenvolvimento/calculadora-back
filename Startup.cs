using System.Text;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.IdentityModel.Tokens;
using Newtonsoft.Json.Converters;

using MySql.Data.EntityFrameworkCore.DataAnnotations;
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
            //services.AddDbContext<UserContext>(opt => opt.UseSqlServer("Server=calculadora-juridica.database.windows.net; Database=safra; User ID=safra; Password=Xp2PunKvyZgeuXgp; Trusted_Connection=False;"));
            services.AddDbContext<UserContext>(opt => opt.UseMySQL("Server=us-cdbr-east-06.cleardb.net;UserID=bf9af8184f7487;Password=b48470cb; Database=heroku_cd4d9aced910652;" ));

            //services.AddDbContext<UserContext>(opt => opt.UseNpgsql("Server=ec2-54-152-28-9.compute-1.amazonaws.com; Port=5432;  Database=daj1l101t4uo1m; User Id=qdeaemyryydppu; Password=9a0959ea82c51ac23efccfe1a06ff02d625f98f06259bb51336dbdc09f2949f2;"));
            //services.AddDbContext<UserContext>(opt => opt.UseSqlServer("postgres://qdeaemyryydppu:9a0959ea82c51ac23efccfe1a06ff02d625f98f06259bb51336dbdc09f2949f2@ec2-54-152-28-9.compute-1.amazonaws.com:5432/daj1l101t4uo1m"));
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
