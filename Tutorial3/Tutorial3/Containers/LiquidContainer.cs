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
    

    public override void Load(double cargoMass)
    {
        if (Cargo > 0) {
            if (cargoMass > MaxPayload * 0.5)
            {
                Notification(SerialNumber.ToString());
                throw new System.Exception("Cannot load hazardous cargo more than 50% of its capacity.");
            }
        }
        else {
            if (cargoMass > MaxPayload * 0.9) {
                throw new System.Exception("Up to 90% of capacity - dangerous operation.");
            }
        }

        base.Load(cargoMass);
    }

    public void Notification(string numberOfContainer) {
        throw new NotImplementedException();
    }
}