using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inkra.Parqueadero.Domain.Generico
{
    public class ModelListado
    {

        public ModelListado()
        {
            ListaDocumentos = new List<ListaDocumentos>();
        }

        public string Archivador { get; set; }
        public string TipoBusqueda { get; set; }
        public string ValorBusqueda { get; set; }
        public string Json { get; set; }
        public List<ListaDocumentos> ListaDocumentos { get; set; }
    }

    public class ListaDocumentos
    {
        public bool SELECCION { get; set; } = true;
        public string ID { get; set; }
        public string LIQUIDACION { get; set; }
        public string FECHADOCUMENTO { get; set; }
        public string TIPODOCUMENTO { get; set; }
        public string CAMARA { get; set; }
        public string NITOCEDULA { get; set; }
        public string NOMBRE { get; set; }
        public string URL { get; set; }
        public string URLVisual { get; set; }

        public string INSCRIPCION { get; set; }
        public string CODIGODOCUMENTO { get; set; }
        public string LIBRO { get; set; }
        public string LIBROARCHIVO { get; set; }
        public string ESTADO { get; set; }
    }
}
