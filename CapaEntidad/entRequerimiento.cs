using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class entRequerimiento
    {
        public int RequerimientoID { get; set; }
        public int UsuarioID { get; set; }
        public DateTime Fecha { get; set; }
        public bool Estado { get; set; }
    }
}
