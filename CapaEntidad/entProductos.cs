using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class entProductos
    {
        public int ProductoID { get; set; }

        public int CategoriaproductoID { get; set; }

        public int unidadMedidaID { get; set; }

        public string descripcion { get; set; }

        public decimal precioVenta { get; set; }
        public int cantidad { get; set; }

        public DateTime fecha { get; set; }

        public Boolean estado { get; set; }
    }
}
