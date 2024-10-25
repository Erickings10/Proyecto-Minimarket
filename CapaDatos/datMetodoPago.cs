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
        //Patron Singleton
        // Variable estática para la instancia
        private static readonly datMetodoPago _instancia = new datMetodoPago();
        //privado para evitar la instanciación directa
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

        public entMetodoPago BuscarMetodoPago(int MetodoPagoID)
        {
            SqlCommand cmd = null;
            entMetodoPago cliente = null;

            try
            {
                using (SqlConnection cn = datConexion.Instancia.Conectar())
                {
                    cmd = new SqlCommand("spBuscarMetodoPago", cn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@MetodoPagoID", MetodoPagoID);

                    cn.Open();

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        if (dr.Read())
                        {
                            cliente = new entMetodoPago
                            {
                                MetododepagoID = Convert.ToInt32(dr["MetododepagoID"]),
                                Descripcion = Convert.ToString(dr["Descripcion"]),
                                Estado = Convert.ToBoolean(dr["Estado"])
                            };
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return cliente;
        }
        #endregion
    }
}
