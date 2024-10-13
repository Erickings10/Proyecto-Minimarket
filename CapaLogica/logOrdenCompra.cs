using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogica
{
    public class logOrdenCompra
    {
        #region Singleton
        private static readonly logOrdenCompra _instancia = new logOrdenCompra();
        public static logOrdenCompra Instancia
        {
            get
            {
                return _instancia;
            }
        }
        #endregion Singleton
        #region Singleton       
        public bool InsertarOrdenCompra(ref entOrdenCompra orden)
        {
            return datOrdenCompra.Instancia.InsertarOrdenCompra(ref orden);
        }

        #endregion Singleton
    }
}
