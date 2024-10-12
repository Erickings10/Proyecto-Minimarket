using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogica
{
    public class logDetalleOrdenCompra
    {
        #region singleton
        private static readonly logDetalleOrdenCompra _instancia = new logDetalleOrdenCompra();
        public static logDetalleOrdenCompra Instancia
        {
            get
            {
                return logDetalleOrdenCompra._instancia;
            }
        }
        #endregion singleton

        #region metodos
        public bool InsertarDetOrdenCompra(entDetalleOrdenCompra detOrden)
        {
            return datDetalleOrdenCompra.Instancia.InsertarDetOrdenCompra(detOrden);
        }
        #endregion metodos
    }
}
