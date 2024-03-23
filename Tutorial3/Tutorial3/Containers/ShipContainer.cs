namespace Tutorial3.Containers;

public class ShipContainer: RefrigeratedContainer
{
    public List<RefrigeratedContainer> ContainerTransport { get; set; }
    public double MaxSpeed { get; set;}
    public int MaxSpeedNumber { get; set;}
    public double MaxSpeedWeight { get; set;}
    
    public ShipContainer(double maxSpeed, int maxContainerNumber, double maxSpeedWeight, PossibleProduct productType, double temperatureNow,
        double temperatureRequiered, double height, double mass, double weight,
        double depth, string serialNumber, double maxPayload): base(productType, temperatureNow, temperatureRequiered,
        height,mass, weight, depth, serialNumber, maxPayload){
        ContainerTransport = new List<RefrigeratedContainer>();
        MaxSpeed = maxSpeed;
        MaxSpeedNumber = maxContainerNumber;
        MaxSpeedWeight = maxSpeedWeight;
    }
    
    //Load a container onto a ship
    public void LoadCargoToShip(List<RefrigeratedContainer> container) {
        foreach (var cargoload in container) {
            if (ContainerTransport.Count >= MaxSpeedNumber)
                throw new System.Exception("Error - cannot load more containers.");
            ContainerTransport.Add(cargoload);
        }
    }
    //Load a list of containers onto a ship
    public void LoadContainerIntoShip(List<RefrigeratedContainer> containers) {
        if (containers.Count + ContainerTransport.Count> MaxSpeedNumber)
            throw new InvalidOperationException("Error - the maximum is reached");
        ContainerTransport.AddRange(containers);
    }
    
    //Unload a container
    public void UnloadContainer(RefrigeratedContainer container) {
        ContainerTransport.Remove(container);
    }
    
    //Replace a container on the ship with a given number with another container
    public void ReplaceContainerWithGivenNumber(RefrigeratedContainer container1, 
        RefrigeratedContainer container2){
        int replace = ContainerTransport.IndexOf(container1);
        if (replace != -1)
            ContainerTransport[replace] = container2;
        else
            throw new System.Exception("No container with this nuber.");
    }
    
    // The possibility of transferring a container between two ships
    public static void TransferBetweenTwoShips(ShipContainer shop1, 
        ShipContainer ship2, RefrigeratedContainer container) {
        shop1.UnloadContainer(container);
        ship2.LoadCargoToShip(new List<RefrigeratedContainer> {
            container
        });
    }
    
    //Remove a container from the ship
    public void RemoveContainerFromShip(RefrigeratedContainer container){
        UnloadContainer(container);
    }
    
    //Print information about a given container
    public void PrintInfoContainer() {
        Console.WriteLine("Information about container ->" +  
                          "\n"+ "Product Type: " + ProductType + "\n" +
                          "Required Temperature: " + TemperatureRequiered + "\n" +
                          "Current Temperature: " + TemperatureNow);
    }
    
    // Print information about a given ship and its cargo
    public void PrintInfoShip()
    {
        Console.WriteLine("Information about a ship: Max Speed -> " + "\n" + 
                          MaxSpeed + "\n" + "Max Container Number: "+ 
                          MaxSpeedNumber + "\n" + "Max Weight - " + MaxSpeedWeight);
        Console.WriteLine("Information about the Containers:");
        PrintInfoContainer();
    }
}