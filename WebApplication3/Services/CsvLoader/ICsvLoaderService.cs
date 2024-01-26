using WebApplication3.Services.FoodTruckService.Models;

namespace WebApplication3.Services.CsvLoader;

public interface ICsvLoaderService
{
    IEnumerable<FoodTruck> GetFoodTrucks();
}