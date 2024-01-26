using System.Reflection;
using Microsoft.VisualBasic.FileIO;
using WebApplication3.Services.FoodTruckService.Models;

namespace WebApplication3.Services.CsvLoader;

public class CsvLoaderService : ICsvLoaderService
{
    private List<FoodTruck> _foodTrucks = new List<FoodTruck>();

    public CsvLoaderService(IWebHostEnvironment env)
    {
        var path = Path.Combine(env.ContentRootPath, "Services","CsvLoader","Mobile_Food_Facility_Permit.csv");
        using (TextFieldParser parser = new TextFieldParser(path))
        {
            parser.TextFieldType = FieldType.Delimited;
            parser.SetDelimiters(",");
            
            // Skip the first row (column headers)
            if (!parser.EndOfData)
            {
                parser.ReadFields();
            }
            
            while (!parser.EndOfData) 
            {
                string[] fields = parser.ReadFields();

                var foodTruck = StringsToFoodTruck(fields);

                _foodTrucks.Add(foodTruck);
            }
        }
    }

    private static FoodTruck StringsToFoodTruck(string[] fields)
    {
        var foodTruck = new FoodTruck
        {
            LocationId = int.Parse(fields[0]),
            Applicant = fields[1],
            FacilityType = fields[2],
            Cnn = fields[3],
            LocationDescription = fields[4],
            Address = fields[5],
            BlockLot = fields[6],
            Block = fields[7],
            Lot = fields[8],
            Permit = fields[9],
            Status = fields[10],
            FoodItems = fields[11],
            X = fields[12],
            Y = fields[13],
            Latitude = decimal.Parse(fields[14]),
            Longitude = decimal.Parse(fields[15]),
            Schedule = fields[16],
            DaysHours = fields[17],
            NOISent = fields[18],
            Approved = fields[19],
            Received = fields[20],
            PriorPermit = fields[21],
            ExpirationDate = fields[22],
            LocationData = fields[23]
        };
        return foodTruck;
    }

    // Simulating repository behaviour
    public IEnumerable<FoodTruck> GetFoodTrucks()
    {
        return _foodTrucks;
    }
}