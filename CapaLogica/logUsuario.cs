using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogica
{
    public class logUsuario
    {
        #region sigleton
        //Patron Singleton
        // Variable estática para la instancia
        private static readonly logUsuario _instancia = new logUsuario();
        //privado para evitar la instanciación directa
        public static logUsuario Instancia
        {
            get
            {
                return logUsuario._instancia;
            }
        }

        #endregion singleton

        #region metodos

        public List<entUsuario> ListarUsuarios()
        {
            return datUsuario.Instancia.ListarUsuarios();
        }
        public bool ActualizarInicioSesion(int idUsuario, bool estado)
        {
            return datUsuario.Instancia.ActualizarInicioSesion(idUsuario, estado);
        }
        #endregion
    }
}
