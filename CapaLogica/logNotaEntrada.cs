using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogica
{
    public class logNotaEntrada
    {
        #region sigleton
        // Variable estática para la instancia
        private static readonly logNotaEntrada _instancia = new logNotaEntrada();
        //privado para evitar la instanciación directa
        public static logNotaEntrada Instancia
        {
            get
            {
                return logNotaEntrada._instancia;
            }
        }
        #endregion singleton
        #region metodos
        public List<entNotaEntrada> ListarNotaEntrada()
        {
            return datNotaEntrada.Instancia.ListarNotasEntrada();
        }
        public bool InsertarNotaEntrada(entNotaEntrada notaEntrada)
        {
            return datNotaEntrada.Instancia.InsertarNotaEntrada(notaEntrada);
        }
        public bool ModificarNotaEntrada(entNotaEntrada notaEntrada)
        {
            return datNotaEntrada.Instancia.ModificarNotaEntrada(notaEntrada);
        }

        public bool DeshabilitarNotaEntrada(entNotaEntrada notaEntrada)
        {
            return datNotaEntrada.Instancia.DeshabilitarNotaEntrada(notaEntrada);
        }
        #endregion
    }
}
