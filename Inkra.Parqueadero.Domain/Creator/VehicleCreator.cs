using Inkra.Parqueadero.Domain.Enumeration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inkra.Parqueadero.Domain.Creator
{
    public abstract class VehicleCreator : IVehicleCreator
    {

        public abstract IVehicle Create(string owner, string licence, VehicleTypeEnum type);
    }
}
