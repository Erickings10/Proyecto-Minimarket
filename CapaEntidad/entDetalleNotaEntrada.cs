using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class entDetalleNotaEntrada
    {
        public int ProductoID { get; set; }         // ID del producto
        public int Cantidad { get; set; }           // Cantidad del producto en la nota de entrada
        public string Descripcion { get; set; }     // Descripción del producto o detalle adicional

    }
}
