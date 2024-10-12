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
    public class datProveedor
    {
        #region sigleton
        
        private static readonly datProveedor _instancia = new datProveedor();
        
        public static datProveedor Instancia
        {
            get
            {
                return datProveedor._instancia;
            }
        }
        #endregion singleton

        #region metodos

        public List<entProveedor> ListarProveedor()
        {
            SqlCommand cmd = null;
            List<entProveedor> lista = new List<entProveedor>();
            try
            {
                SqlConnection cn = datConexion.Instancia.Conectar(); 
                cmd = new SqlCommand("spListarProveedor", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    entProveedor Pro = new entProveedor();
                    Pro.idProv = Convert.ToInt32(dr["ProveedorID"]);
                    Pro.rucProv = Convert.ToInt64(dr["Ruc"]);
                    Pro.idRubro = Convert.ToInt32(dr["TipoproveedorID"]);
                    Pro.ubiProv = Convert.ToInt32(dr["Ubigeo"]);
                    Pro.nameProv = Convert.ToString(dr["Nombre"]);
                    Pro.telfProv = Convert.ToInt64(dr["Telefono"]);
                    Pro.fechaProv = Convert.ToDateTime(dr["Fecha"]);
                    Pro.estProv = Convert.ToBoolean(dr["Estado"]);
                    lista.Add(Pro);
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

        public Boolean InsertarProveedor(entProveedor Pro)
        {
            SqlCommand cmd = null;
            Boolean inserta = false;
            try
            {
                SqlConnection cn = datConexion.Instancia.Conectar();
                cmd = new SqlCommand("spInsertarProveedor", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@rucProveedor", Pro.rucProv);
                cmd.Parameters.AddWithValue("@idRubro", Pro.idRubro);
                cmd.Parameters.AddWithValue("@ubiProv", Pro.ubiProv);
                cmd.Parameters.AddWithValue("@nameProv", Pro.nameProv);
                cmd.Parameters.AddWithValue("@telfProv", Pro.telfProv);
                cmd.Parameters.AddWithValue("@fechaProv", Pro.fechaProv);
                cmd.Parameters.AddWithValue("@estProv", Pro.estProv);
                cn.Open();
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    inserta = true;
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            finally { cmd.Connection.Close(); }
            return inserta;
        }

        public Boolean EditaProveedor(entProveedor Pro)
        {
            SqlCommand cmd = null;
            Boolean edita = false;
            try
            {
                SqlConnection cn = datConexion.Instancia.Conectar();
                cmd = new SqlCommand("spModificarProveedor", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idProv", Pro.idProv);
                cmd.Parameters.AddWithValue("@rucProveedor", Pro.rucProv);
                cmd.Parameters.AddWithValue("@idRubro", Pro.idRubro);
                cmd.Parameters.AddWithValue("@ubiProv", Pro.ubiProv);
                cmd.Parameters.AddWithValue("@nameProv", Pro.nameProv);
                cmd.Parameters.AddWithValue("@telfProv", Pro.telfProv);
                cmd.Parameters.AddWithValue("@fechaProv", Pro.fechaProv);
                cmd.Parameters.AddWithValue("@estProv", Pro.estProv);
                cn.Open();
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    edita = true;
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            finally { cmd.Connection.Close(); }
            return edita;
        }

        public Boolean DeshabilitaProveedor(entProveedor Pro)
        {
            SqlCommand cmd = null;
            Boolean deshabilita = false;
            try
            {
                SqlConnection con = datConexion.Instancia.Conectar();
                cmd = new SqlCommand("spDeshabilitarProveedor", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ProveedorID", Pro.idProv);
                //cmd.Parameters.AddWithValue("@estProv", Pro.estProv);
                con.Open();
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    deshabilita = true;
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
            return deshabilita;
        }

        #endregion metodos
    }
}
