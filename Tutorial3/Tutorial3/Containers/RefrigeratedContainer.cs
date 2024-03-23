namespace Tutorial3.Containers;

public class RefrigeratedContainer
{
    public PossibleProduct ProductType { get; set; }
    public double TemperatureNow { get; set; }
    public double TemperatureRequiered { get; set; }

    public RefrigeratedContainer(PossibleProduct productType, double temperatureNow,
        double temperatureRequiered)
    {
        ProductType = productType;
        TemperatureNow = temperatureNow;
        TemperatureRequiered = temperatureRequiered;
    }
    
    private double GetTemperature(PossibleProduct products) {
        switch (products) {
            case PossibleProduct.Bananas:
                return 13.3;
            case PossibleProduct.Chocolate:
                return 18;
            case PossibleProduct.Fish:
                return 2;
            case PossibleProduct.Meat:
                return -15;
            case PossibleProduct.Ice_cream:
                return -18;
            case PossibleProduct.Frozem_pizza:
                return -30;
            case PossibleProduct.Cheese:
                return 7.2;
            case PossibleProduct.Sausages:
                return 5;
            case PossibleProduct.Butter:
                return 20.5;
            case PossibleProduct.Eggs:
                return 19;
            default:
                throw new System.Exception("Unknown product.");
        }
    }
    
    public void SetTemperature(double temperature) {
        if (temperature < TemperatureRequiered)
            throw new System.Exception("Error - the temperature of the container cannot be lower than the temperature required by a given type of product.");
        TemperatureNow = temperature;
    }
    
}