using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class entVenta
    {
        public int VentaID { get; set; }
        public int UsuarioID { get; set; }
        public int ClienteID { get; set; }
        public int MetodoPagoID { get; set; }
        public DateTime Fecha { get; set; }
        public decimal Total { get; set; }
    }
}
