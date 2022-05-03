using Inkra.Parqueadero.Domain.Enumeration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inkra.Parqueadero.Domain.Creator
{
    public abstract class VehicleFactory 
    {
        public static IVehicle Create(string owner, string licence, VehicleTypeEnum type)
        {
            switch (type)
            {
                case VehicleTypeEnum.Car:
                    return new Car(owner, licence);                   
                case VehicleTypeEnum.MotorCycle:
                    return new MotorCycle(owner, licence);                   
                case VehicleTypeEnum.Truck:
                    return new Truck(owner,licence);
                default:
                    throw new NotImplementedException("Este tipo de vehiculo no es soportado");
                    
            }
        }
        
    }
}
