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
    public class datDetalleOrdenCompra
    {
        #region singleton
        private static readonly datDetalleOrdenCompra _instancia = new datDetalleOrdenCompra();
        public static datDetalleOrdenCompra Instancia
        {
            get
            {
                return datDetalleOrdenCompra._instancia;
            }
        }
        #endregion singleton

        #region metodos     
        public Boolean InsertarDetOrdenCompra(entDetalleOrdenCompra detOrden)
        {
            SqlCommand cmd = null;
            Boolean insertado = false;
            try
            {
                SqlConnection cn = datConexion.Instancia.Conectar();
                cmd = new SqlCommand("spInsertarDetalleOrdenCompra", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@OrdendecompraID", detOrden.OrdendecompraID);
                cmd.Parameters.AddWithValue("@RequerimientoID", detOrden.RequerimientoID);
                cmd.Parameters.AddWithValue("@Cantidad", detOrden.Cantidad);
                cmd.Parameters.AddWithValue("@Precio", detOrden.Precio);
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
