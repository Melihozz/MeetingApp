var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();
    
var app = builder.Build();

// app.MapDefaultControllerRoute();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=home}/{action=Index}/{id?}"
);

app.Run();
