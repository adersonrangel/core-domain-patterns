using Inkra.Parqueadero.Domain.Enumeration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inkra.Parqueadero.Domain
{
    public abstract class Vehicle : IVehicle
    {
        protected VehicleTypeEnum type;

        public Vehicle(string owner , string licencePlate)
        {
            this.Owner = owner;
            this.LicencePlate = licencePlate;
        }

        public string LicencePlate { get; set; }
        public string Owner { get; set; }

        public abstract VehicleTypeEnum Type { get; }
    }
}
