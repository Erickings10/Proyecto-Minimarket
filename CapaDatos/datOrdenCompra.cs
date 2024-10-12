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
    public class datOrdenCompra
    {
        #region singleton
        private static readonly datOrdenCompra _instancia = new datOrdenCompra();
        public static datOrdenCompra Instancia
        {
            get
            {
                return datOrdenCompra._instancia;
            }
        }
        #endregion singleton
        #region metodos  
        public Boolean InsertarOrdenCompra(ref entOrdenCompra orden)
        {
            SqlCommand cmd = null;
            Boolean insertado = false;
            try
            {
                SqlConnection cn = datConexion.Instancia.Conectar();
                cmd = new SqlCommand("spInsertarOrdenCompra", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Fecha", orden.Fecha);
                cmd.Parameters.AddWithValue("@ProveedorID", orden.ProveedorID);
                cmd.Parameters.AddWithValue("@Total", orden.Total);
                cmd.Parameters.AddWithValue("@Estado", orden.Estado);
                SqlParameter idOrdCom = new SqlParameter("@OrdenCompraID", SqlDbType.Int);
                idOrdCom.Direction = ParameterDirection.Output;
                cmd.Parameters.Add(idOrdCom);
                cn.Open();
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    insertado = true;
                    i = 0;
                    int.TryParse(cmd.Parameters["@OrdenCompraID"].Value.ToString(), out i);
                    orden.OrdenCompraID = i;
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
            return insertado;
        }
        #endregion metodos  
    }
}
