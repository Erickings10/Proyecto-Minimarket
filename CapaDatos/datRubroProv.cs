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
    public class datRubroProv
    {
        #region sigleton

        private static readonly datRubroProv _instancia = new datRubroProv();
        public static datRubroProv Instancia
        {
            get
            {
                return datRubroProv._instancia;
            }
        }

        #endregion sigleton

        #region metodos

        public List<entRubroProv> ListarRubro()
        {
            SqlCommand cmd = null;
            List<entRubroProv> lista = new List<entRubroProv>();
            try
            {
                SqlConnection con = datConexion.Instancia.Conectar();
                cmd = new SqlCommand("spListarRubro", con);
                cmd.CommandType = CommandType.StoredProcedure;
                con.Open();
                SqlDataReader rd = cmd.ExecuteReader();
                while (rd.Read())
                {
                    entRubroProv rub = new entRubroProv();
                    rub.idRubro = Convert.ToInt32(rd["TipoproveedorID"]);
                    rub.nameRubro = Convert.ToString(rd["Rubro"]);
                    rub.estRubro = Convert.ToBoolean(rd["Estado"]);
                    lista.Add(rub);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                cmd.Connection.Close();
            }
            return lista;
        }

        public Boolean InsertaRubro(entRubroProv Rub)
        {
            SqlCommand cmd = null;
            Boolean insertar = false;
            try
            {
                SqlConnection con = datConexion.Instancia.Conectar();
                cmd = new SqlCommand("spInsertarRubro", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Rubro", Rub.nameRubro);
                cmd.Parameters.AddWithValue("@Estado", Rub.estRubro);
                con.Open();
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    insertar = true;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                cmd.Connection.Close();
            }
            return insertar;
        }

        public Boolean EditaRubro(entRubroProv Rub)
        {
            SqlCommand cmd = null;
            Boolean editar = false;
            try
            {
                SqlConnection con = datConexion.Instancia.Conectar();
                cmd = new SqlCommand("spModificarRubro", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@TipoproveedorID", Rub.idRubro);
                cmd.Parameters.AddWithValue("@Rubro", Rub.nameRubro);
                cmd.Parameters.AddWithValue("@Estado", Rub.estRubro);
                con.Open();
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    editar = true;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                cmd.Connection.Close();
            }
            return editar;
        }

        public Boolean DeshabilitarRubro(entRubroProv Rub)
        {
            SqlCommand cmd = null;
            Boolean deshabilitar = false;
            try
            {
                SqlConnection con = datConexion.Instancia.Conectar();
                cmd = new SqlCommand("spDeshabilitarRubro", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@TipoproveedorID", Rub.idRubro);
                //cmd.Parameters.AddWithValue("@Estado", Rub.estRubro);
                con.Open();
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    deshabilitar = true;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                cmd.Connection.Close();
            }
            return deshabilitar;
        }

        public DataTable ListaDeRubros()
        {
            SqlCommand cmd = null;
            DataTable tabla = new DataTable();
            try
            {
                SqlConnection cn = datConexion.Instancia.Conectar();
                cmd = new SqlCommand("spListarRubro", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                SqlDataReader rd = cmd.ExecuteReader();
                tabla.Load(rd);
                rd.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally { cmd.Connection.Close(); }
            return tabla;
        }

        #endregion metodos
    }
}
