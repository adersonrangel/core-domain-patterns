using Inkra.Parqueadero.Domain.Enumeration;

namespace Inkra.Parqueadero.Domain
{
    public class Truck : Vehicle
    {
        public Truck(string owner, string licencePlate) : base(owner, licencePlate)
        {           
            type = VehicleTypeEnum.Truck;
        }

        public override VehicleTypeEnum Type => type;
    }
}
