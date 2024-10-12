using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class entNotaEntrada
    {
        public int NotaEntradaID { get; set; }
        public int ProductoID { get; set; }
        public int Cantidad { get; set; }
        public int TiendaID { get; set; }
        public string Descripcion { get; set; }
        public DateTime Fecha { get; set; }
        public bool Estado { get; set; }
        public int UsuarioID { get; set; }
    }
}
