using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogica
{
    public class logCategoria
    {
        #region singleton
        // Implementación del patrón Singleton
        private static readonly logCategoria _instancia = new logCategoria();
        public static logCategoria Instancia
        {
            get
            {
                return logCategoria._instancia;
            }
        }
        #endregion singleton

        #region metodos
        public List<entCategoria> ListarCategoria()
        {
            return datCategoria.Instancia.ListarCategoria();
        }

        public void InsertarCategoria(entCategoria cat)
        {
            datCategoria.Instancia.InsertarCategoria(cat);
        }

        public void ModificarCategoria(entCategoria cat)
        {
            datCategoria.Instancia.ModificarCategoria(cat);
        }

        public void DeshabilitarCategoria(entCategoria cat)
        {
            datCategoria.Instancia.DeshabilitarCategoria(cat);
        }
        #endregion metodos

    }
}
