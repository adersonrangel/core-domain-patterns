using Inkra.Parqueadero.Domain;
using Inkra.Parqueadero.Domain.Generico;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Inkra.Domain.Test
{
    public class DocuwareApiTest
    {

        [Fact]
        public void Consultar_Docuware_Sucess() 
        { 
            DocuwareApi<ModelListado> docuwareApi = new DocuwareApi<ModelListado>();
            var respuesta = docuwareApi.CONSULTAR_DOCUWARE<ModelListado>(string.Empty, string.Empty, string.Empty);

            Assert.NotNull(respuesta);
        }

        [Fact]
        public void Consulta_Docuware_No_Generic() 
        {
            DocuwareApi<ModelListado> docuwareApi = new DocuwareApi<ModelListado>();
            var respuesta = docuwareApi.CONSULTAR_DOCUWARE("MyArchivador", "TipoBusqueda", "ValorBusqueda");

            Assert.NotNull(respuesta);
        }
    }
}
