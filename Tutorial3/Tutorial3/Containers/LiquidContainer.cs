using Tutorial3.Exception;
using Tutorial3.Interfaces;

namespace Tutorial3.Containers;

public class LiquidContainer : Container, IHazardNotifier
{
    public LiquidContainer(double cargo, double height, double mass, double weight,
        double depth, double serialNumber, double maxPayload) : base(cargo, height, mass,
        weight, depth, serialNumber, maxPayload)
    {
        
    }
    

    public override void Load(double cargoWeight)
    {
        base.Load(Weight);
    }

    public void Notification(string numberOfContainer)
    {
        throw new NotImplementedException();
    }
}