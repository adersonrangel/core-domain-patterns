using Inkra.Parqueadero.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Inkra.Domain.Test
{
    public class RegisterTest
    {
        [Fact]
        public void Create_Register()
        {
            Register register = new();

            register.CheckIn = DateTime.Now;
            register.CheckOut = DateTime.Now;

            var respuesta = register.In();

            Assert.True(respuesta > 0);
        }
    }
}
