using FlamingSoftHR.Server;
using FlamingSoftHR.Server.Data;
using FlamingSoftHR.Server.Models;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.ResponseCompression;
using Microsoft.EntityFrameworkCore;

namespace FlamingSoftHR
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            //Add services to the container.
            //var connectionString = builder.Configuration.GetConnectionString("DefaultConnection") ?? throw new InvalidOperationException("Connection string 'DefaultConnection' not found.");
            //builder.Services.AddDbContext<ApplicationDbContext>(options =>
            //  options.UseSqlServer(connectionString));
            //Database in memory
            //builder.Services.AddDbContext<FlamingSoftHRContext>(p => p.UseInMemoryDatabase("FlamingSoftHRDB"));
            builder.Services.AddSqlServer<FlamingSoftHRContext>(builder.Configuration.GetConnectionString("cnFlamingSoft"));

            builder.Services.AddDatabaseDeveloperPageExceptionFilter();

            builder.Services.AddDefaultIdentity<ApplicationUser>(options => options.SignIn.RequireConfirmedAccount = true)
                .AddEntityFrameworkStores<ApplicationDbContext>();

            builder.Services.AddIdentityServer()
                .AddApiAuthorization<ApplicationUser, ApplicationDbContext>();

            builder.Services.AddAuthentication()
                .AddIdentityServerJwt();

            builder.Services.AddControllersWithViews();
            builder.Services.AddRazorPages();

            var app = builder.Build();

           // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseMigrationsEndPoint();
                app.UseWebAssemblyDebugging();
            }
            else
            {
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();

            app.UseBlazorFrameworkFiles();
            app.UseStaticFiles();

            app.UseRouting();

           // app.UseIdentityServer();
            app.UseAuthentication();
            app.UseAuthorization();


            app.MapRazorPages();
            app.MapControllers();
            app.MapFallbackToFile("index.html");

            app.MapGet("/Connection", async ([FromServices] FlamingSoftHRContext dbContext) =>
                {
                    dbContext.Database.EnsureCreated();
                    return Results.Ok("Database in Memory " + dbContext.Database.IsInMemory());
                });
            app.MapGet("/Departments", async ([FromServices] FlamingSoftHRContext dbContext) =>
                {
                    return Results.Ok(dbContext.Departments);
                }); 
            app.MapGet("/Employees", async ([FromServices] FlamingSoftHRContext dbContext) =>
                {
                    return Results.Ok(dbContext.Employees);
                });
            app.MapGet("/EmployeeTypes", async ([FromServices] FlamingSoftHRContext dbContext) =>
            {
                return Results.Ok(dbContext.EmployeeTypes);
            });
            app.MapGet("/LoggedTimes", async ([FromServices] FlamingSoftHRContext dbContext) =>
            {
                return Results.Ok(dbContext.LoggedTime);
            });
            app.MapGet("/LoggedTimeTypes", async ([FromServices] FlamingSoftHRContext dbContext) =>
            {
                return Results.Ok(dbContext.LoggedTimeTypes);
            });

            app.MapGet("/AspNetUsers", async ([FromServices] FlamingSoftHRContext dbContext) =>
            {
                return Results.Ok(dbContext.AspNetUsers);
            });
            app.MapGet("/AspNetRole", async ([FromServices] FlamingSoftHRContext dbContext) =>
            {
                return Results.Ok(dbContext.AspNetRoles);
            });
            app.MapGet("/AspNetRoleClaim", async ([FromServices] FlamingSoftHRContext dbContext) =>
            {
                return Results.Ok(dbContext.AspNetRoleClaims);
            });
            app.MapGet("/AspNetUserRole", async ([FromServices] FlamingSoftHRContext dbContext) =>
            {
                return Results.Ok(dbContext.AspNetUserRoles);
            });
            app.MapGet("/AspNetUserLogins", async ([FromServices] FlamingSoftHRContext dbContext) =>
            {
                return Results.Ok(dbContext.AspNetUserLogins);
            }); 
            app.MapGet("/AspNetUserClaims", async ([FromServices] FlamingSoftHRContext dbContext) =>
            {
                return Results.Ok(dbContext.AspNetUserClaims);
            });
            app.MapGet("/AspNetUserTokens", async ([FromServices] FlamingSoftHRContext dbContext) =>
            {
                return Results.Ok(dbContext.AspNetUserTokens);
            });
            app.MapGet("/PG", async ([FromServices] FlamingSoftHRContext dbContext) =>
            {
                return Results.Ok(dbContext.PersistedGrants);
            });   
            app.MapGet("/DC", async ([FromServices] FlamingSoftHRContext dbContext) =>
            {
                return Results.Ok(dbContext.DeviceCodes);
            });
            app.MapGet("/K", async ([FromServices] FlamingSoftHRContext dbContext) =>
            {
                return Results.Ok(dbContext.Keys);
            });
             app.MapGet("/EF", async ([FromServices] FlamingSoftHRContext dbContext) =>
            {
                return Results.Ok(dbContext.__EFMigrationsHistory);
            });


            app.Run();
        }
    }
}