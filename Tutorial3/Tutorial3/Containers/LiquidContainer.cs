using Tutorial3.Interfaces;

namespace Tutorial3.Containers;

public class LiquidContainer : Container, IHazardNotifier
{
    public LiquidContainer(double cargo) : base(cargo)
    {
        
    }

    public override void Load(double cargoWeight)
    {
        base.Load(cargoWeight);
    }

    public void Notification(string numberOfContainer)
    {
        throw new NotImplementedException();
    }
}