using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class entOrdenCompra
    {
        public DateTime Fecha { get; set; }
        public int ProveedorID { get; set; }
        public decimal Total { get; set; }
        public bool Estado { get; set; }
        public int OrdenCompraID { get; set; }
    }
}
