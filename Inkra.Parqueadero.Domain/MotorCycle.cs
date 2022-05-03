using Inkra.Parqueadero.Domain.Enumeration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inkra.Parqueadero.Domain
{
    public class MotorCycle : Vehicle
    {
        public MotorCycle(string owner, string licencePlate) : base(owner, licencePlate)
        {           
            type = VehicleTypeEnum.MotorCycle;
        }

        public override VehicleTypeEnum Type => type;
    }
}
