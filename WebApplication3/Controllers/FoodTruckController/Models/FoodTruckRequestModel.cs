using System.ComponentModel.DataAnnotations;

namespace WebApplication3.Controllers.Models;

public class FoodTruckRequestModel
{
    // Values should have more validation
    // This way even though lat is required - it could be omitted from model
    // And it would be filled with 0
    // Skipped to keep simple
    [Required] 
    public decimal Latitude { get; set; }
    [Required]
    public decimal Longitude { get; set; }
    [Required]
    [Range(1, Int32.MaxValue)]
    public int NumberOfResults { get; set; }
    [Required]
    public string PreferredFood { get; set; }
}