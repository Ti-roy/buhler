namespace WebApplication3.Services.GeoService;

public class GeoService : IGeoService
{
    private const double EarthRadiusKm = 6371;
    public double CalculateDistance(decimal lat1, decimal lon1, decimal lat2, decimal lon2)
    {
        double dLat = Math.PI * (double)(lat2 - lat1) / 180.0;
        double dLon = Math.PI * (double)(lon2 - lon1) / 180.0;

        double a = Math.Sin(dLat / 2) * Math.Sin(dLat / 2) +
                   Math.Cos(Math.PI * (double)lat1 / 180.0) * Math.Cos(Math.PI * (double)lat2 / 180.0) *
                   Math.Sin(dLon / 2) * Math.Sin(dLon / 2);
        double c = 2 * Math.Atan2(Math.Sqrt(a), Math.Sqrt(1 - a));
        double distance = EarthRadiusKm * c;

        return distance;
    }
}