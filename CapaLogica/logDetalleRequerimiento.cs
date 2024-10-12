using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogica
{
    public class logDetalleRequerimiento
    {
        #region sigleton

        private static readonly logDetalleRequerimiento _instancia = new logDetalleRequerimiento();
        public static logDetalleRequerimiento Instancia
        {
            get
            {
                return logDetalleRequerimiento._instancia;
            }
        }
        #endregion singleton

        #region metodos

        public List<entDetalleRequerimiento> ListarDetalleRequerimiento() 
        {
            return datDetalleRequerimiento.Instancia.ListarDetalleRequerimiento();
        }

        public bool InsertarDetalleRequerimiento(entDetalleRequerimiento detReq)
        {
            return datDetalleRequerimiento.Instancia.InsertarDetalleRequerimiento(detReq);
        }
        #endregion metodos
    }
}
