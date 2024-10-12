using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class entUsuario
    {
        public int id { get; set; }
        public string usuario { get; set; }
        public string contraseña { get; set; }
        public int tipoUsuario { get; set; }
        public bool estado { get; set; }
        public bool sesionActiva { get; set; }
    }
}
