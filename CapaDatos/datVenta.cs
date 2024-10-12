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
    public class datVenta
    {
        #region sigleton
        //Patron Singleton
        // Variable estática para la instancia
        private static readonly datVenta _instancia = new datVenta();
        //privado para evitar la instanciación directa
        public static datVenta Instancia
        {
            get
            {
                return datVenta._instancia;
            }
        }
        #endregion singleton
        public bool InsertarVenta(entVenta venta, List<entDetalleVenta> detallesVenta)
        {
            SqlCommand cmd = null;
            bool resultado = false;
            try
            {
                SqlConnection cn = datConexion.Instancia.Conectar(); // Singleton para obtener la conexión
                cmd = new SqlCommand("spInsertarVenta", cn);
                cmd.CommandType = CommandType.StoredProcedure;

                // Parámetros para la venta
                cmd.Parameters.AddWithValue("@UsuarioID", venta.UsuarioID);
                cmd.Parameters.AddWithValue("@ClienteID", venta.ClienteID);
                cmd.Parameters.AddWithValue("@MetodoPagoID", venta.MetodoPagoID);
                cmd.Parameters.AddWithValue("@Fecha", venta.Fecha);
                cmd.Parameters.AddWithValue("@Total", venta.Total);

                // Parámetro para los detalles de la venta (DataTable)
                DataTable dtDetallesVenta = new DataTable();
                dtDetallesVenta.Columns.Add("ProductoID", typeof(int));
                dtDetallesVenta.Columns.Add("Cantidad", typeof(int));
                dtDetallesVenta.Columns.Add("PrecioUnitario", typeof(decimal));

                foreach (var detalle in detallesVenta)
                {
                    dtDetallesVenta.Rows.Add(detalle.ProductoID, detalle.Cantidad, detalle.PrecioUnitario);
                }

                SqlParameter tvpParam = cmd.Parameters.AddWithValue("@DetallesVenta", dtDetallesVenta);
                tvpParam.SqlDbType = SqlDbType.Structured;
                tvpParam.TypeName = "dbo.DetalleVentaType";

                // Ejecutar el procedimiento almacenado
                cn.Open();
                cmd.ExecuteNonQuery();
                resultado = true;
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
            return resultado;
        }

    }
}
