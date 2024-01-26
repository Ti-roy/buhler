namespace WebApplication3.Services.FoodTruckService.Models;
public class FoodTruck
{
    public int LocationId { get; set; }
    public string Applicant { get; set; }
    public string FacilityType { get; set; }
    public string Cnn { get; set; }
    public string LocationDescription { get; set; }
    public string Address { get; set; }
    public string BlockLot { get; set; }
    public string Block { get; set; }
    public string Lot { get; set; }
    public string Permit { get; set; }
    public string Status { get; set; }
    public string FoodItems { get; set; }
    public string X { get; set; }
    public string Y { get; set; }
    public decimal Latitude { get; set; }
    public decimal Longitude { get; set; }
    public string Schedule { get; set; }
    public string DaysHours { get; set; }
    public string NOISent { get; set; }
    public string Approved { get; set; }
    public string Received { get; set; }
    public string PriorPermit { get; set; }
    public string ExpirationDate { get; set; }
    public string LocationData { get; set; }
    // Custom property not present in csv
    // Used for calculations
    public double Distance { get; set; }
}