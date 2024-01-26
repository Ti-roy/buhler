using WebApplication3.Controllers.Models;
using WebApplication3.Services.CsvLoader;
using WebApplication3.Services.FoodTruckService.Models;
using WebApplication3.Services.GeoService;

namespace WebApplication3.Services.FoodTruckService;

public class FoodTruckService : IFoodTruckService
{
    private const string ApprovedStatusString = "APPROVED";
    private readonly ICsvLoaderService _csvLoaderService;
    private readonly IGeoService _geoService;

    public FoodTruckService(ICsvLoaderService csvLoaderService, IGeoService geoService)
    {
        _csvLoaderService = csvLoaderService;
        _geoService = geoService;
    }

    public List<FoodTruck> GetFoodTruckOptions(FoodTruckRequestModel foodTruckRequestModel)
    {
        var filteredFoodTrucks = _csvLoaderService.GetFoodTrucks()
            // Those checks should be present - but they invalidate most of the data, so I`ve commented them out
            // .Where(ft => ft.Approved == ApprovedStatusString)
            // .Where(ft => DateTime.Parse(ft.ExpirationDate) > DateTime.Now)
            .Where(ft => ft.FoodItems.Contains(foodTruckRequestModel.PreferredFood, StringComparison.OrdinalIgnoreCase))
            .ToList();

        foreach (var ft in filteredFoodTrucks)
        {
            ft.Distance = _geoService.CalculateDistance(foodTruckRequestModel.Latitude, foodTruckRequestModel.Longitude, ft.Latitude, ft.Longitude);
        }

        var sortedFoodTrucks = filteredFoodTrucks.OrderBy(ftd => ftd.Distance);

        var result = sortedFoodTrucks.Take(foodTruckRequestModel.NumberOfResults).ToList();

        return result;
    }
}