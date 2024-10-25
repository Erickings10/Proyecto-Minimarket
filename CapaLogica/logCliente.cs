using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogica
{
    public class logCliente
    {
        #region sigleton
        //Patron Singleton
        // Variable estática para la instancia
        private static readonly logCliente _instancia = new logCliente();
        //privado para evitar la instanciación directa
        public static logCliente Instancia
        {
            get
            {
                return logCliente._instancia;
            }
        }

        #endregion singleton

        #region metodos

        public List<entCliente> ListarClientes()
        {
            return datCliente.Instancia.ListarClientes();
        }

        public bool InsertarCliente(entCliente cliente)
        {
            return datCliente.Instancia.InsertarCliente(cliente);
        }
        public async Task<entCliente> GetClienteAPI(string DNI)
        {
            return await datCliente.Instancia.GetClienteAPI(DNI);
        }

        public entCliente BuscarClientePorID(int ClienteID)
        {
            return datCliente.Instancia.BuscarClientePorID(ClienteID);
        }
        #endregion
    }
}
