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
                        int notaEntradaID = Convert.ToInt32(dr["NotaEntradaID"]);

                        // Verificar si la nota de entrada ya existe en la lista
                        var nota = lista.FirstOrDefault(n => n.NotaEntradaID == notaEntradaID);

                        if (nota == null)
                        {
                            // Crear una nueva nota de entrada si aún no existe
                            nota = new entNotaEntrada
                            {
                                NotaEntradaID = notaEntradaID,
                                Fecha = Convert.ToDateTime(dr["Fecha"]),
                                Estado = Convert.ToBoolean(dr["Estado"]),
                                UsuarioID = Convert.ToInt32(dr["UsuarioID"])
                            };

                            lista.Add(nota);
                        }

                        // Crear el detalle de la nota de entrada
                        entDetalleNotaEntrada detalle = new entDetalleNotaEntrada
                        {
                            ProductoID = Convert.ToInt32(dr["ProductoID"]),
                            Cantidad = Convert.ToInt32(dr["Cantidad"]),
                            Descripcion = Convert.ToString(dr["Descripcion"])
                        };

                        // Agregar el detalle a la lista de detalles de la nota de entrada
                        nota.Detalles.Add(detalle);
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
        public bool InsertarNotaEntrada(entNotaEntrada notaEntrada, List<entDetalleNotaEntrada> detallesNotaEntrada)
        {
            SqlCommand cmd = null;
            int filasAfectadas = 0;
            try
            {
                SqlConnection cn = datConexion.Instancia.Conectar(); // Singleton para obtener la conexión
                cmd = new SqlCommand("spInsertarNotaEntrada", cn);
                cmd.CommandType = CommandType.StoredProcedure;

                // Parámetros para la nota de entrada
                cmd.Parameters.AddWithValue("@Fecha", notaEntrada.Fecha);
                cmd.Parameters.AddWithValue("@Estado", notaEntrada.Estado);
                cmd.Parameters.AddWithValue("@UsuarioID", notaEntrada.UsuarioID);

                // Parámetro para los detalles de la nota de entrada (DataTable)
                DataTable dtDetallesNotaEntrada = new DataTable();
                dtDetallesNotaEntrada.Columns.Add("ProductoID", typeof(int));
                dtDetallesNotaEntrada.Columns.Add("Cantidad", typeof(int));
                dtDetallesNotaEntrada.Columns.Add("Descripcion", typeof(string));

                foreach (var detalle in detallesNotaEntrada)
                {
                    dtDetallesNotaEntrada.Rows.Add(detalle.ProductoID, detalle.Cantidad, detalle.Descripcion);
                }

                SqlParameter tvpParam = cmd.Parameters.AddWithValue("@DetallesNotaEntrada", dtDetallesNotaEntrada);
                tvpParam.SqlDbType = SqlDbType.Structured;
                tvpParam.TypeName = "dbo.NotaEntradaDetalleType";

                // Ejecutar el procedimiento almacenado
                cn.Open();
                filasAfectadas = cmd.ExecuteNonQuery();
                return filasAfectadas > 0;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (cmd != null)
                {
                    cmd.Connection.Close();
                }
            }
        }
        ///////////////////////Modificar nota entrada
        public bool ModificarNotaEntrada(entNotaEntrada notaEntrada, List<entDetalleNotaEntrada> detallesNotaEntrada)
        {
            SqlCommand cmd = null;
            int filasAfectadas = 0;

            try
            {
                SqlConnection cn = datConexion.Instancia.Conectar();
                cmd = new SqlCommand("spModificarNotaEntrada", cn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@NotaEntradaID", notaEntrada.NotaEntradaID);
                cmd.Parameters.AddWithValue("@Fecha", notaEntrada.Fecha);
                cmd.Parameters.AddWithValue("@Estado", notaEntrada.Estado);
                cmd.Parameters.AddWithValue("@UsuarioID", notaEntrada.UsuarioID);

                // Parámetro para los detalles de la nota de entrada (DataTable)
                DataTable dtDetallesNotaEntrada = new DataTable();
                dtDetallesNotaEntrada.Columns.Add("ProductoID", typeof(int));
                dtDetallesNotaEntrada.Columns.Add("Cantidad", typeof(int));
                dtDetallesNotaEntrada.Columns.Add("Descripcion", typeof(string));

                foreach (var detalle in detallesNotaEntrada)
                {
                    dtDetallesNotaEntrada.Rows.Add(detalle.ProductoID, detalle.Cantidad, detalle.Descripcion);
                }

                SqlParameter tvpParam = cmd.Parameters.AddWithValue("@DetallesNotaEntrada", dtDetallesNotaEntrada);
                tvpParam.SqlDbType = SqlDbType.Structured;
                tvpParam.TypeName = "dbo.NotaEntradaDetalleType";

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

        //OBTENER DETALLES DE NOTA DE ENTRADA(BUSCAR NOTA DE ENTRADA)
        public entNotaEntrada ObtenerDetallesNotaEntrada(int notaEntradaID)
        {
            SqlCommand cmd = null;
            entNotaEntrada notaEntrada = null;

            try
            {
                using (SqlConnection cn = datConexion.Instancia.Conectar())
                {
                    cmd = new SqlCommand("spObtenerDetallesNotaEntrada", cn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@NotaEntradaID", notaEntradaID);

                    cn.Open();
                    SqlDataReader dr = cmd.ExecuteReader();

                    if (dr.Read())
                    {
                        notaEntrada = new entNotaEntrada
                        {
                            NotaEntradaID = Convert.ToInt32(dr["NotaEntradaID"]),
                            Fecha = Convert.ToDateTime(dr["Fecha"]),
                            Estado = Convert.ToBoolean(dr["Estado"]),
                            UsuarioID = Convert.ToInt32(dr["UsuarioID"]),
                            Detalles = new List<entDetalleNotaEntrada>() // Inicializa la lista de detalles
                        };

                        // Llenar los detalles de la nota de entrada
                        do
                        {
                            var detalle = new entDetalleNotaEntrada
                            {
                                ProductoID = Convert.ToInt32(dr["ProductoID"]),
                                Cantidad = Convert.ToInt32(dr["Cantidad"]),
                                Descripcion = Convert.ToString(dr["Descripcion"])
                            };
                            notaEntrada.Detalles.Add(detalle);
                        } while (dr.Read());
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return notaEntrada;
        }


        #endregion


    }
}
