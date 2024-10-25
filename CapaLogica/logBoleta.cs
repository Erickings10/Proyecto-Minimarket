using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogica
{
    public class logBoleta
    {
        #region sigleton
        //Patron Singleton
        // Variable estática para la instancia
        private static readonly logBoleta _instancia = new logBoleta();
        //privado para evitar la instanciación directa
        public static logBoleta Instancia
        {
            get
            {
                return logBoleta._instancia;
            }
        }

        #endregion singleton

        #region metodos
        public async Task<string> GenerarBoletaAsync(entBoleta boleta)
        {
            return await datBoleta.Instancia.GenerarBoletaAsync(boleta);
        }

        public async Task<string> GenerarBoletaPDFAsync(entBoleta factura, string rutaArchivo)
        {
            return await datBoleta.Instancia.GenerarBoletaPDFAsync(factura, rutaArchivo);
        }
        #endregion
    }
}
