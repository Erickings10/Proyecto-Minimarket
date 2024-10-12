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
    public class datUdMedida
    {
        #region sigleton
        private static readonly datUdMedida _instancia = new datUdMedida();
        public static datUdMedida Instancia
        {
            get
            {
                return datUdMedida._instancia;
            }
        }
        #endregion singleton

        #region metodos
        public List<entUdMedida> ListarMedidaProducto()
        {
            SqlCommand cmd = null;
            List<entUdMedida> lista = new List<entUdMedida>();
            try
            {
                SqlConnection cn = datConexion.Instancia.Conectar();
                cmd = new SqlCommand("spListarMedidaProducto", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    entUdMedida med = new entUdMedida
                    {
                        UnidadmedidaID = Convert.ToInt32(dr["UnidadmedidaID"]),
                        Descripcion = Convert.ToString(dr["Descripcion"]),
                        Estado = Convert.ToBoolean(dr["Estado"])
                    };
                    lista.Add(med);
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                cmd?.Connection.Close();
            }
            return lista;
        }

        public void InsertarMedidaProducto(entUdMedida med)
        {
            SqlCommand cmd = null;
            try
            {
                SqlConnection cn = datConexion.Instancia.Conectar();
                cmd = new SqlCommand("spInsertarMedidaProducto", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Descripcion", med.Descripcion);
                cmd.Parameters.AddWithValue("@Estado", med.Estado);
                cn.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                cmd?.Connection.Close();
            }
        }

        public void EditarMedidaProducto(entUdMedida med)
        {
            SqlCommand cmd = null;
            try
            {
                SqlConnection cn = datConexion.Instancia.Conectar();
                cmd = new SqlCommand("spEditarMedidaProducto", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@UnidadmedidaID", med.UnidadmedidaID);
                cmd.Parameters.AddWithValue("@Descripcion", med.Descripcion);
                cmd.Parameters.AddWithValue("@Estado", med.Estado);
                cn.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                cmd?.Connection.Close();
            }
        }

        public void DeshabilitarMedidaProducto(entUdMedida med)
        {
            SqlCommand cmd = null;
            try
            {
                SqlConnection cn = datConexion.Instancia.Conectar();
                cmd = new SqlCommand("spDeshabilitarMedidaProducto", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@UnidadmedidaID", med.UnidadmedidaID);
                cn.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                cmd?.Connection.Close();
            }
        }
        #endregion metodos
    }
}
