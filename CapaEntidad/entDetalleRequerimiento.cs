using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class entDetalleRequerimiento
    {
        public int DetallerequerimientoID { get; set; }
        public int RequerimientoID { get; set; }
        public int ProductoID { get; set; }
        public int Cantidad { get; set; }
        public string Prioridad { get; set; }
    }
}
