using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class datCliente
    {
        #region sigleton
        //Patron Singleton
        // Variable estática para la instancia
        private static readonly datCliente _instancia = new datCliente();
        //privado para evitar la instanciación directa
        public static datCliente Instancia
        {
            get
            {
                return datCliente._instancia;
            }
        }
        #endregion singleton

        #region metodos

        public List<entCliente> ListarClientes()
        {
            SqlCommand cmd = null;
            List<entCliente> lista = new List<entCliente>();
            try
            {
                SqlConnection cn = datConexion.Instancia.Conectar(); 
                cmd = new SqlCommand("spListarClientes", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    entCliente cliente = new entCliente();
                    cliente.ClienteID = Convert.ToInt32(dr["ClienteID"]);
                    cliente.DNI = Convert.ToString(dr["DNI"]);
                    cliente.Nombre = Convert.ToString(dr["Nombre"]);
                    cliente.Apellido = Convert.ToString(dr["Apellido"]);
                    cliente.Telefono = Convert.ToString(dr["Telefono"]);
                    cliente.Estado = Convert.ToBoolean(dr["Estado"]);
                    lista.Add(cliente);
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                cmd.Connection.Close();
            }
            return lista;
        }

        public bool InsertarCliente(entCliente cliente)
        {
            SqlCommand cmd = null;
            bool insercionExitosa = false;
            try
            {
                SqlConnection cn = datConexion.Instancia.Conectar(); //singleton para la conexión
                cmd = new SqlCommand("spInsertarCliente", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();

                // Parámetros para el procedimiento almacenado
                cmd.Parameters.AddWithValue("@DNI", cliente.DNI);
                cmd.Parameters.AddWithValue("@Nombre", cliente.Nombre);
                cmd.Parameters.AddWithValue("@Apellido", cliente.Apellido);
                cmd.Parameters.AddWithValue("@Telefono", cliente.Telefono);
                cmd.Parameters.AddWithValue("@Estado", cliente.Estado);

                // Ejecución del comando
                int filasAfectadas = cmd.ExecuteNonQuery();
                if (filasAfectadas > 0)
                {
                    insercionExitosa = true;
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                cmd.Connection.Close();
            }
            return insercionExitosa;
        }

        #endregion
    }
}
