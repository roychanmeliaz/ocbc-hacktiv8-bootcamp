using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;

// using TodoApp.Data;
using Microsoft.EntityFrameworkCore;
using Pomelo.EntityFrameworkCore.MySql.Infrastructure;
using TodoApp.Models;

using System.Text;
using Microsoft.IdentityModel.Tokens;
// using TodoAppWithJWT.Configuration;
using TodoApp.Configuration;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Authentication.JwtBearer;


namespace TodoApp
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
            // services.AddDbContext<ApiDbContext>(options=>
            //     options.UseSqlite(
            //         Configuration.GetConnectionString("DefaultConnection")
            //     ));

            services.AddDbContextPool<ItemDataContext>(
                options => options.UseMySql(
                    Configuration.GetConnectionString("DBConn"),
                    new MySqlServerVersion(new Version(7, 4, 24))
                ));

            // start jwt
            services.Configure<JwtConfig>(Configuration.GetSection("JwtConfig"));

            var key = Encoding.ASCII.GetBytes(Configuration["JwtConfig:Secret"]);
            var tokenValidationParams = new TokenValidationParameters {
                ValidateIssuerSigningKey = true,
                IssuerSigningKey = new SymmetricSecurityKey(key),
                ValidateIssuer = false,
                ValidateAudience = false,
                ValidateLifetime = true,
                RequireExpirationTime = false,
                ClockSkew = TimeSpan.Zero
            };

            services.AddSingleton(tokenValidationParams);

            services.AddAuthentication(options => {
                options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                options.DefaultScheme = JwtBearerDefaults.AuthenticationScheme;
                options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
            })
            .AddJwtBearer (jwt => {
                jwt.SaveToken = true;
                jwt.TokenValidationParameters = tokenValidationParams;
            });

            services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = true)
                        .AddEntityFrameworkStores<ItemDataContext>();
            // end jwt

            services.AddControllers();
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "TodoApp", Version = "v1" });
            });
            // services.AddSwaggerGen(c =>
            // {
            //     c.SwaggerDoc("v1", new OpenApiInfo { Title = "You api title", Version = "v1" });
            //     c.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme
            //     {
            //         Description = @"JWT Authorization header using the Bearer scheme. \r\n\r\n 
            //                     Enter 'Bearer' [space] and then your token in the text input below.
            //                     \r\n\r\nExample: 'Bearer 12345abcdef'",
            //         Name = "Authorization",
            //         In = ParameterLocation.Header,
            //         Type = SecuritySchemeType.ApiKey,
            //         Scheme = "Bearer"
            //     });

            //     c.AddSecurityRequirement(new OpenApiSecurityRequirement()
            //     {
            //         {
            //         new OpenApiSecurityScheme
            //         {
            //             Reference = new OpenApiReference
            //             {
            //                 Type = ReferenceType.SecurityScheme,
            //                 Id = "Bearer"
            //             },
            //             Scheme = "oauth2",
            //             Name = "Bearer",
            //             In = ParameterLocation.Header,

            //             },
            //             new List<string>()
            //         }
            //     });
            // });  
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "TodoApp v1"));
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
