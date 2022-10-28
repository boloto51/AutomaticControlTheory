var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();
var app = builder.Build();

// app.MapGet("/", () => "Hello World!");
app.MapControllerRoute(
    name: "Content",
    pattern: "{area:exists}/{controller=Tutorial}/{action=Index}/{id?}");

app.Run();