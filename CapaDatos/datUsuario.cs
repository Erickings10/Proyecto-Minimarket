using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidad;

namespace CapaDatos
{
    public class datUsuario
    {
        #region sigleton
        //Patron Singleton
        // Variable estática para la instancia
        private static readonly datUsuario _instancia = new datUsuario();
        //privado para evitar la instanciación directa
        public static datUsuario Instancia
        {
            get
            {
                return datUsuario._instancia;
            }
        }
        #endregion singleton

        #region metodos
        ////////////////////listado de Almacenes
        public List<entUsuario> ListarUsuarios()
        {
            SqlCommand cmd = null;
            List<entUsuario> lista = new List<entUsuario>();
            try
            {
                SqlConnection cn = datConexion.Instancia.Conectar(); //singleton
                cmd = new SqlCommand("spListarUsuarios", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    entUsuario user = new entUsuario();
                    user.id = Convert.ToInt32(dr["UsuarioID"]);
                    user.usuario = Convert.ToString(dr["NombreUsuario"]);
                    user.contraseña = Convert.ToString(dr["Contraseña"]);
                    user.tipoUsuario = Convert.ToInt32(dr["TipoUsuario"]);
                    user.estado = Convert.ToBoolean(dr["Estado"]);
                    user.sesionActiva = Convert.ToBoolean(dr["SesionActiva"]);
                    lista.Add(user);
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
        ////////// Actualizar inicio de sesion
        public bool ActualizarInicioSesion(int usuarioID, bool sesionActiva)
        {
            SqlCommand cmd = null;
            bool resultado = false;

            try
            {
                SqlConnection cn = datConexion.Instancia.Conectar();
                cmd = new SqlCommand("spActualizarInicioSesion", cn);
                cmd.CommandType = CommandType.StoredProcedure;


                cmd.Parameters.AddWithValue("@UsuarioID", usuarioID);
                cmd.Parameters.AddWithValue("@SesionActiva", sesionActiva);

                cn.Open();

                // Ejecutar la consulta
                int filasAfectadas = cmd.ExecuteNonQuery();
                if (filasAfectadas > 0)
                {
                    resultado = true; // La actualización fue exitosa
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (cmd.Connection != null && cmd.Connection.State == ConnectionState.Open)
                {
                    cmd.Connection.Close();
                }
            }

            return resultado;
        }

        #endregion
    }
}
