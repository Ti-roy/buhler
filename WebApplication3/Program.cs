using WebApplication3.Services.CsvLoader;
using WebApplication3.Services.CsvLoaderService;
using WebApplication3.Services.FoodTruckService;
using WebApplication3.Services.GeoService;

var builder = WebApplication.CreateBuilder(args);
// This done as singleton to avoid reloading csv each time
// In real life it would be different
builder.Services.AddSingleton<IGeoService,GeoService>();
builder.Services.AddSingleton<ICsvLoaderService,CsvLoaderService>();
builder.Services.AddScoped<IFoodTruckService,FoodTruckService>();

builder.Services.AddControllers();

var app = builder.Build();

app.MapControllers();

app.Run();