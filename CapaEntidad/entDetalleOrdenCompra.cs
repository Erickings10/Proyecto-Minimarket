using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class entDetalleOrdenCompra
    {
        public int DetalleordendecompraID { get; set; }
        public int RequerimientoID { get; set; }
        public int Cantidad { get; set; }
        public int OrdendecompraID { get; set; }
        public decimal Precio { get; set; }

    }
}
