using Microsoft.AspNetCore.Mvc;
using WebApplication3.Controllers.Models;
using WebApplication3.Services.FoodTruckService;
using WebApplication3.Services.FoodTruckService.Models;

namespace WebApplication3.Controllers;

[ApiController]
[Route("[controller]")]
public class FoodTruckController : ControllerBase
{
    private readonly IFoodTruckService _foodTruckService;

    public FoodTruckController(IFoodTruckService foodTruckService)
    {
        _foodTruckService = foodTruckService;
    }

    [HttpGet]
    public IEnumerable<FoodTruck> Get(FoodTruckRequestModel foodTruckRequestModel)
    {
        return _foodTruckService.GetFoodTruckOptions(foodTruckRequestModel);
    }
}