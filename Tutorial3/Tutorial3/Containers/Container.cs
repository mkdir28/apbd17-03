using Tutorial3.Exception;
using Tutorial3.Interfaces;

namespace Tutorial3.Containers;

public abstract class Container : IContainer
{
    public double Height { get; set; }
    public double Mass { get; set; }
    public double Weight { get; set; }
    public double Depth { get; set; }
    public string SerialNumber { get; set; }
    public double MaxPayload { get; set; }


    
    //ctor - constractor
    protected Container(double height, double mass, double weight,
        double depth, string serialNumber, double maxPayload)
    {
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

    public virtual void Empty()
    {
        Mass = 0;
    }
    
    public virtual void Load(double cargoMass)
    {
        //throw new NotImplementedException();
        if (Mass > MaxPayload)
        {
            throw new OverfillException();
        }

        Mass = cargoMass;
    }
}