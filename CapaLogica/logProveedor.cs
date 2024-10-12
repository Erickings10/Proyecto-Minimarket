using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogica
{
    public class logProveedor
    {
        #region sigleton
        // Variable estática para la instancia
        private static readonly logProveedor _instancia = new logProveedor();
        //privado para evitar la instanciación directa
        public static logProveedor Instancia
        {
            get
            {
                return logProveedor._instancia;
            }
        }
        #endregion singleton

        #region metodos

        public List<entProveedor> ListarProveedor()
        {
            return datProveedor.Instancia.ListarProveedor();

        }
        public void InsertaProveedor(entProveedor Pro)
        {
            datProveedor.Instancia.InsertarProveedor(Pro);
        }

        public void EditaProveedor(entProveedor Pro)
        {
            datProveedor.Instancia.EditaProveedor(Pro);
        }

        public void DeshabilitaProveedor(entProveedor Pro)
        {
            datProveedor.Instancia.DeshabilitaProveedor(Pro);
        }

        #endregion metodos
    }
}
