using ViewComponentSample.Model.Context;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddRazorPages();
builder.Services.AddControllersWithViews();

builder.Services.AddDbContext<VCDbContext>();
var app = builder.Build();

//app.MapGet("/", () => "Hello World!");

app.MapRazorPages();
app.MapDefaultControllerRoute();

app.Run();
