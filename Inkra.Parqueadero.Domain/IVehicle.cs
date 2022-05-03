using Inkra.Parqueadero.Domain.Enumeration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inkra.Parqueadero.Domain
{
    public interface IVehicle
    {
        public string Owner { get; set; }
        public string LicencePlate { get; set; }       
        public VehicleTypeEnum Type { get; }

    }
}
