namespace Tutorial3.Containers;

public class RefrigeratedContainer
{
    public string ProductType { get; set; }
    public double TemperatureNow { get; set; }
    public double TemperatureRequiered { get; set; }

    public RefrigeratedContainer(string productType, double temperatureNow,
        double temperatureRequiered)
    {
        ProductType = productType;
        TemperatureNow = TemperatureRequiered;
        TemperatureRequiered = temperatureRequiered;
    }
    
}