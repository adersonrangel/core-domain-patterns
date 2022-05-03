using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inkra.Parqueadero.Domain
{
    public class Ticket
    {
        public Vehicle Vehicle { get; set; }

        public Ticket(Car car)
        {
            this.Vehicle = car;
        }
    }
}
