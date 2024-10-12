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
    public class datDetalleRequerimiento
    {
        #region sigleton
        private static readonly datDetalleRequerimiento _instancia = new datDetalleRequerimiento();
        public static datDetalleRequerimiento Instancia
        {
            get
            {
                return datDetalleRequerimiento._instancia;
            }
        }
        #endregion singleton

        #region metodos

        public List<entDetalleRequerimiento> ListarDetalleRequerimiento()
        {
            SqlCommand cmd = null;
            List<entDetalleRequerimiento> lista = new List<entDetalleRequerimiento>();
            try
            {
                SqlConnection cn = datConexion.Instancia.Conectar();  // Usando el patrón singleton
                cmd = new SqlCommand("spListarDetalleRequerimiento", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();

                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    entDetalleRequerimiento detalle = new entDetalleRequerimiento();
                    detalle.DetallerequerimientoID = Convert.ToInt32(dr["DetallerequerimientoID"]);
                    detalle.ProductoID = Convert.ToInt32(dr["ProductoID"]);
                    detalle.RequerimientoID = Convert.ToInt32(dr["RequerimientoID"]);
                    detalle.Cantidad = Convert.ToInt32(dr["Cantidad"]);
                    detalle.Prioridad = Convert.ToString(dr["Prioridad"]);

                    lista.Add(detalle);
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
        public bool InsertarDetalleRequerimiento(entDetalleRequerimiento detReq)
        {
            SqlCommand cmd = null;
            bool insertado = false;
            try
            {
                SqlConnection cn = datConexion.Instancia.Conectar();
                cmd = new SqlCommand("spInsertarDetalleRequerimiento", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@RequerimientoID", detReq.RequerimientoID);
                cmd.Parameters.AddWithValue("@ProductoID", detReq.ProductoID);
                cmd.Parameters.AddWithValue("@Cantidad", detReq.Cantidad);
                cmd.Parameters.AddWithValue("@Prioridad", detReq.Prioridad);
                cn.Open();

                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    insertado = true;
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
            return insertado;
        }


        #endregion metodos
    }
}
