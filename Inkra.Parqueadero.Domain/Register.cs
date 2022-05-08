using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inkra.Parqueadero.Domain
{
    public class Register
    {
        public DateTime CheckIn { get; set; }
        public DateTime CheckOut { get; set; }
        public IVehicle Client { get; set; }

        public double In()
        {
            return (CheckIn - CheckOut).TotalSeconds;
        }
    }
}
