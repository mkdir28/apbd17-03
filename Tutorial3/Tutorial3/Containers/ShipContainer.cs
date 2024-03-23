namespace Tutorial3.Containers;

public class ShipContainer
{
    public List<RefrigeratedContainer> ContainerTransport { get; set; }
    public double MaxSpeed { get; set;}
    public int MaxSpeedNumber { get; set;}
    public double MaxSpeedWeight { get; set;}
    
    public ShipContainer(double maxSpeed, int maxContainerNumber, double maxSpeedWeight) {
        ContainerTransport = new List<RefrigeratedContainer>();
        MaxSpeed = maxSpeed;
        MaxSpeedNumber = maxContainerNumber;
        MaxSpeedWeight = maxSpeedWeight;
    }
    
    //Load cargo into a given container
    public void LoadCargo(List<RefrigeratedContainer> container) {
        foreach (var cargoload in container) {
            if (ContainerTransport.Count >= MaxSpeedNumber)
            {
                throw new System.Exception("Error - cannot load more containers.");
            }

            ContainerTransport.Add(cargoload);
        }
    }
    //Print information about a given container
    public void PrintInfoContainer(RefrigeratedContainer container)
    {
        Console.WriteLine("Product Type - {container}.ProductType}};" +
                          "Required Temperature - {{container.TemperatureRequiered}};" +
                          "Current Temperature - {{container.TemperatureNow}}");
    }
    
    // Print information about a given ship and its cargo
    public void PrintInfoShip()
    {
        Console.WriteLine("Information about a ship: Max Speed - {MaxSpeed};" +
                          "Max Container Number - {MaxSpeedNumber}; " +
                          "Max Weight - {MaxSpeedWeight}");
        Console.WriteLine("Information about the Containers:");
        foreach (var container in ContainerTransport)
        {
            PrintInfoContainer(container);
        }
    }
}