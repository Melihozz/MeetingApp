var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();
    
var app = builder.Build();

//değiş
app.MapDefaultControllerRoute();
app.Run();
