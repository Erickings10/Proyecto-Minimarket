using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class entNotaEntrada
    {
        public int NotaEntradaID { get; set; }      // ID de la nota de entrada
        public DateTime Fecha { get; set; }         // Fecha de la nota de entrada
        public bool Estado { get; set; }            // Estado de la nota de entrada (activo/inactivo)
        public int UsuarioID { get; set; }          // ID del usuario que crea la nota de entrada
        public List<entDetalleNotaEntrada> Detalles { get; set; } = new List<entDetalleNotaEntrada>(); // Lista de detalles
    }

}
