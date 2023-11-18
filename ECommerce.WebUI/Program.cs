using ECommerce.DAL.Data;
using ECommerce.DAL.DBModel;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddDbContext<AppDbIdentityContext>(
    opts =>
    {
        opts.UseSqlServer(builder.Configuration.GetConnectionString("SqlSrvConnectionString"));
        opts.UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking);
    }
);

builder.Services.AddIdentity<AppUser, AppRole>().AddEntityFrameworkStores<AppDbIdentityContext>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
