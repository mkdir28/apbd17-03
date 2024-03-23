using Tutorial3.Exception;
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
    public double MaxPayload { get; set; }


    
    //ctor - constractor
    protected Container(double cargo, double height, double mass, double weight,
        double depth, double serialNumber, double maxPayload)
    {
        Cargo = cargo;
        Height = height;
        Mass = mass;
        Weight = weight;
        Depth = depth;
        SerialNumber = serialNumber;
        MaxPayload = maxPayload;
    }

    public void UnLoad()
    {
        throw new NotImplementedException();
    }

    public void Empty()
    {
        Mass = 0;
    }
    
    public virtual void Load(double cargoWeight)
    {
        //throw new NotImplementedException();
        if (Mass > MaxPayload)
        {
            throw new OverfillException();
        }

        Mass = cargoWeight;
    }
}