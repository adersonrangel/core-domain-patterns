using Inkra.Parqueadero.Domain;
using Inkra.Parqueadero.Domain.Creator;
using Xunit;

namespace Inkra.Domain.Test
{
    public class DomainTest
    {
        [Fact]
        public void Create_Sucess_Car()
        {
           IVehicle vehicle = VehicleFactory.Create("Aderson Rangel", "THI77D", Parqueadero.Domain.Enumeration.VehicleTypeEnum.Car);
           

            Assert.NotNull(vehicle);
        }

        [Theory]
        [InlineData("","")]
        [InlineData("Aderson Rangel", "")]
        [InlineData("", "THI77D")]
        [InlineData("Aderson Rangel", "THI77D")]
        public void Create_Invalid_Car(string owner, string licence)
        {
            IVehicle vehicle = VehicleFactory.Create(owner, licence, Parqueadero.Domain.Enumeration.VehicleTypeEnum.Car);


            Assert.NotNull(vehicle);
        }
    }
}