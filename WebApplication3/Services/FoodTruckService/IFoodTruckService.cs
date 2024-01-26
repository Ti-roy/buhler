using WebApplication3.Controllers.Models;
using WebApplication3.Services.FoodTruckService.Models;

namespace WebApplication3.Services.FoodTruckService;

public interface IFoodTruckService
{
    List<FoodTruck> GetFoodTruckOptions(FoodTruckRequestModel foodTruckRequestModel);
}