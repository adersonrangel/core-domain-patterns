using Inkra.Parqueadero.Domain.Enumeration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inkra.Parqueadero.Domain
{
    public class Car : Vehicle
    {
        public Car():this("Propietario del carro" , "---")
        {

        }

        public Car(string owner, string licencePlate) :base(owner,licencePlate)
        {           
            type = VehicleTypeEnum.Car;            
        }

        /// <summary>
        /// Vehicle Type
        /// </summary>
        public override VehicleTypeEnum Type => type;

    }
}
