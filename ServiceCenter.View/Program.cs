var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

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

app.MapAreaControllerRoute(
    name: "default",
    areaName: "Guest",
    pattern: "guest/{controller=Guest}/{action=Index}/{id?}");

app.MapAreaControllerRoute(
    name: "default",
    areaName: "Operator",
    pattern: "operator/{controller=Tariff}/{action=Index}/{id?}");

app.MapAreaControllerRoute(
    name: "default",
    areaName: "Operator",
    pattern: "operator/{controller=Orders}/{action=Orders}/{id?}");


app.MapAreaControllerRoute(
    name: "default",
    areaName: "Operator",
    pattern: "operator/{controller=Abonent}/{action=Abonent}/{id?}");

app.MapAreaControllerRoute(
    name: "default",
    areaName: "Admin",
    pattern: "admin/{controller=Tariff}/{action=Tariff}/{id?}");

app.MapAreaControllerRoute(
    name: "default",
    areaName: "Admin",
    pattern: "admin/{controller=Types_tariff}/{action=Types_tariff}/{id?}");

app.MapAreaControllerRoute(
    name: "default",
    areaName: "Admin",
    pattern: "admin/{controller=Services}/{action=Services}/{id?}");

app.MapAreaControllerRoute(
    name: "default",
    areaName: "Admin",
    pattern: "admin/{controller=Materials}/{action=Materials}/{id?}");

app.MapAreaControllerRoute(
    name: "default",
    areaName: "Admin",
    pattern: "admin/{controller=Employee}/{action=Employee}/{id?}");

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
