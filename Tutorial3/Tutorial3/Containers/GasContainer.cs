using Tutorial3.Interfaces;

namespace Tutorial3.Containers;

public class GasContainer: Container, IHazardNotifier
{
    public double Pessure { get; set; }
    public GasContainer(double cargo, double height, double mass, double weight,
        double depth, double serialNumber, double maxPayload, double pressure)
        : base(cargo, height, mass, weight, depth, serialNumber, maxPayload)
    {
        Pessure = pressure;
    }
    
    public override void Empty()
    {
        Mass *= 0.05;
    }

    public void Notification(string numberOfContainer)
    {
        throw new NotImplementedException();
    }
}