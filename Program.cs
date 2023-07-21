using marsev.Context;
using marsev.Models;
using marsev.RepositoryPattern.Base;
using marsev.RepositoryPattern.Concrete;
using marsev.RepositoryPattern.interfaces;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<MMDbContext>(options => options.UseSqlServer(""));
//builder.Services.AddDbContext<MMDbContext>(options => options.UseSqlServer(""));

//builder.Services.AddDbContext<MMDbContext>(options => options.UseSqlServer(builder.Configuration["ConnectionStrings:Mssql"]));


builder.Services.AddScoped<IRepository<Kitap>,Repository<Kitap>>();
builder.Services.AddScoped<IRepository<AppUser>, Repository<AppUser>>();
builder.Services.AddScoped<IEtkinlikRepository, EtkinlikRepository>();
builder.Services.AddScoped<IRepository<FormModel>, Repository<FormModel>>();
builder.Services.AddScoped<IRepository<KitapTalepModel>, Repository<KitapTalepModel>>();
builder.Services.AddScoped<IRepository<Kayit>, Repository<Kayit>>();

builder.Services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme).AddCookie(
    options => { 
        options.LoginPath = "/Auth/Login";
        options.AccessDeniedPath = "/Auth/AccessDenied";
        options.Cookie.Name = "UserDetail";
    }) ;
builder.Services.AddAuthorization(options =>
{
    options.AddPolicy("AdminPolicy", policy => policy.RequireClaim("role","admin"));
    // options.AddPolicy("UserPolicy", policy => policy.RequireClaim("role", "admin", "user"));
});


var app = builder.Build();

using (var scope = app.Services.CreateScope())
{
    var db = scope.ServiceProvider.GetRequiredService<MMDbContext>();
    db.Database.Migrate();
}


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
app.UseAuthentication();
app.UseAuthorization();
app.UseEndpoints(endpoints =>

{
    endpoints.MapControllerRoute(
          name: "areas",
          pattern: "{area:exists}/{controller=Home}/{action=Index}/{id?}"
        );

    endpoints.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}"
    );

   
        
  
});





app.Run();
