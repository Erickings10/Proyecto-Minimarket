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
    public class datMetodoPago
    {
        #region sigleton
        private static readonly datMetodoPago _instancia = new datMetodoPago();
        public static datMetodoPago Instancia
        {
            get
            {
                return datMetodoPago._instancia;
            }
        }
        #endregion singleton

        #region metodos
        public List<entMetodoPago> ListarMetodoPago()
        {
            SqlCommand cmd = null;
            List<entMetodoPago> lista = new List<entMetodoPago>();
            try
            {
                SqlConnection cn = datConexion.Instancia.Conectar();
                cmd = new SqlCommand("spListarMetodosPago", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    entMetodoPago mp = new entMetodoPago();
                    mp.MetododepagoID = Convert.ToInt32(dr["MetododepagoID"]);
                    mp.Descripcion = Convert.ToString(dr["Descripcion"]);
                    mp.Estado = Convert.ToBoolean(dr["Estado"]);
                    lista.Add(mp);
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
        #endregion
    }
}
