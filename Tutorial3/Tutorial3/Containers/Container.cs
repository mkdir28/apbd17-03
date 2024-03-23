using Tutorial3.Interfaces;

namespace Tutorial3.Containers;

public abstract class Container : IContainer
{
    public double Cargo { get; set; }
    public double Height { get; set; }
    public double Mass { get; set; }
    public double Weight { get; set; }
    public double Depth { get; set; }
    public double SerialNumber { get; set; }

    
    //ctor - constractor
    protected Container(double cargo, double height, double mass, double weight,
        double depth, double serialNumber)
    {
        Cargo = cargo;
        Height = height;
        Mass = mass;
        Weight = weight;
        Depth = depth;
        SerialNumber = serialNumber;
    }

    public void UnLoad()
    {
        throw new NotImplementedException();
    }

    public virtual void Load(double cargoWeight)
    {
        throw new NotImplementedException();
    }
}