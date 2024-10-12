using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogica
{
    public class logUdMedida
    {
        #region sigleton
        private static readonly logUdMedida _instancia = new logUdMedida();
        public static logUdMedida Instancia
        {
            get
            {
                return logUdMedida._instancia;
            }
        }
        #endregion singleton

        #region metodos
        public List<entUdMedida> ListarMedidaProducto()
        {
            return datUdMedida.Instancia.ListarMedidaProducto();
        }

        public void InsertarMedidaProducto(entUdMedida med)
        {
            datUdMedida.Instancia.InsertarMedidaProducto(med);
        }

        public void EditarMedidaProducto(entUdMedida med)
        {
            datUdMedida.Instancia.EditarMedidaProducto(med);
        }

        public void DeshabilitarMedidaProducto(entUdMedida med)
        {
            datUdMedida.Instancia.DeshabilitarMedidaProducto(med);
        }
        #endregion metodos
    }
}
