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
    public class datNotaEntrada
    {
        #region sigleton
        //Patron Singleton
        // Variable estática para la instancia
        private static readonly datNotaEntrada _instancia = new datNotaEntrada();
        //privado para evitar la instanciación directa
        public static datNotaEntrada Instancia
        {
            get
            {
                return datNotaEntrada._instancia;
            }
        }
        #endregion singleton

        #region metodos
        ////////////////////////Listar nota entrada
        public List<entNotaEntrada> ListarNotasEntrada()
        {
            SqlCommand cmd = null;
            List<entNotaEntrada> lista = new List<entNotaEntrada>();

            try
            {
                using (SqlConnection cn = datConexion.Instancia.Conectar())
                {
                    cmd = new SqlCommand("spListarNotasEntrada", cn);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cn.Open();
                    SqlDataReader dr = cmd.ExecuteReader();

                    while (dr.Read())
                    {
                        entNotaEntrada nota = new entNotaEntrada();
                        nota.NotaEntradaID = Convert.ToInt32(dr["NotaentradaID"]);
                        nota.ProductoID = Convert.ToInt32(dr["ProductoID"]);
                        nota.Cantidad = Convert.ToInt32(dr["Cantidad"]);
                        nota.TiendaID = Convert.ToInt32(dr["TiendaID"]);
                        nota.Descripcion = Convert.ToString(dr["Descripcion"]);
                        nota.Fecha = Convert.ToDateTime(dr["Fecha"]);
                        nota.Estado = Convert.ToBoolean(dr["Estado"]);
                        nota.UsuarioID = Convert.ToInt32(dr["UsuarioID"]);
                        lista.Add(nota);
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return lista;
        }
        ////////////////////////Insertar nota entrada
        public bool InsertarNotaEntrada(entNotaEntrada notaEntrada)
        {
            SqlCommand cmd = null;
            int filasAfectadas = 0;

            try
            {
                SqlConnection cn = datConexion.Instancia.Conectar(); 
                cmd = new SqlCommand("spInsertarNotaEntrada", cn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@ProductoID", notaEntrada.ProductoID);
                cmd.Parameters.AddWithValue("@Cantidad", notaEntrada.Cantidad);
                cmd.Parameters.AddWithValue("@TiendaID", notaEntrada.TiendaID);
                cmd.Parameters.AddWithValue("@Descripcion", notaEntrada.Descripcion);
                cmd.Parameters.AddWithValue("@Fecha", notaEntrada.Fecha);
                cmd.Parameters.AddWithValue("@Estado", notaEntrada.Estado);
                cmd.Parameters.AddWithValue("@UsuarioID", notaEntrada.UsuarioID);

                cn.Open();
                filasAfectadas = cmd.ExecuteNonQuery(); 

                return filasAfectadas > 0; 
            }
            catch (Exception e)
            {
                throw e; 
            }
            finally
            {
                cmd.Connection.Close();
            }
        }
        ///////////////////////Modificar nota entrada
        public bool ModificarNotaEntrada(entNotaEntrada notaEntrada)
        {
            SqlCommand cmd = null;
            int filasAfectadas = 0;

            try
            {
                SqlConnection cn = datConexion.Instancia.Conectar();
                cmd = new SqlCommand("spModificarNotaEntrada", cn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@NotaEntradaID", notaEntrada.NotaEntradaID);
                cmd.Parameters.AddWithValue("@ProductoID", notaEntrada.ProductoID);
                cmd.Parameters.AddWithValue("@CantidadNueva", notaEntrada.Cantidad);
                cmd.Parameters.AddWithValue("@TiendaID", notaEntrada.TiendaID);
                cmd.Parameters.AddWithValue("@Descripcion", notaEntrada.Descripcion);
                cmd.Parameters.AddWithValue("@Fecha", notaEntrada.Fecha);
                cmd.Parameters.AddWithValue("@Estado", notaEntrada.Estado);
                cmd.Parameters.AddWithValue("@UsuarioID", notaEntrada.UsuarioID);

                cn.Open();
                filasAfectadas = cmd.ExecuteNonQuery();

                return filasAfectadas > 0;
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                cmd.Connection.Close();
            }
        }

        ///////////////////////Deshabilitar nota entrada
        public bool DeshabilitarNotaEntrada(entNotaEntrada notaEntrada)
        {
            SqlCommand cmd = null;
            int filasAfectadas = 0;

            try
            {
                SqlConnection cn = datConexion.Instancia.Conectar();
                cmd = new SqlCommand("spDeshabilitarNotaEntrada", cn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@NotaEntradaID", notaEntrada.NotaEntradaID);
                cmd.Parameters.AddWithValue("@ProductoID", notaEntrada.ProductoID);
                cmd.Parameters.AddWithValue("@Cantidad", notaEntrada.Cantidad);

                cn.Open();
                filasAfectadas = cmd.ExecuteNonQuery();

                return filasAfectadas > 0;
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                cmd.Connection.Close();
            }
        }
        #endregion


    }
}
