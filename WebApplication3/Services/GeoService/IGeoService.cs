namespace WebApplication3.Services.GeoService;

public interface IGeoService
{
    double CalculateDistance(decimal lat1, decimal lon1, decimal lat2, decimal lon2);
}