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
    public class datProductos
    {
        #region sigleton
        //Patron Singleton
        // Variable estática para la instancia
        private static readonly datProductos _instancia = new datProductos();
        //privado para evitar la instanciación directa
        public static datProductos Instancia
        {
            get
            {
                return datProductos._instancia;
            }
        }
        #endregion singleton

        #region metodos


        ////////////////////listado de Productos
        
        public List<entProductos> ListarProductos()
        {
            SqlCommand cmd = null;
            List<entProductos> lista = new List<entProductos>();
            try
            {
                SqlConnection cn = datConexion.Instancia.Conectar(); //singleton
                cmd = new SqlCommand("spListarProductos", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    entProductos Prod = new entProductos();

                    Prod.ProductoID = dr["ProductoID"] != DBNull.Value ? Convert.ToInt32(dr["ProductoID"]) : 0;
                    Prod.CategoriaproductoID = dr["CategoriaID"] != DBNull.Value ? Convert.ToInt32(dr["CategoriaID"]) : 0;
                    Prod.unidadMedidaID = dr["UnidadmedidaID"] != DBNull.Value ? Convert.ToInt32(dr["UnidadmedidaID"]) : 0;
                    Prod.descripcion = dr["Descripcion"] != DBNull.Value ? Convert.ToString(dr["Descripcion"]) : string.Empty;
                    Prod.precioVenta = dr["PrecioVenta"] != DBNull.Value ? Convert.ToDecimal(dr["PrecioVenta"]) : 0;
                    Prod.cantidad = dr["Cantidad"] != DBNull.Value ? Convert.ToInt32(dr["Cantidad"]) : 0;
                    Prod.fecha = dr["Fecha"] != DBNull.Value ? Convert.ToDateTime(dr["Fecha"]) : DateTime.MinValue;
                    Prod.estado = dr["Estado"] != DBNull.Value ? Convert.ToBoolean(dr["Estado"]) : false;

                    lista.Add(Prod);
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
        ////////////////////INSERTAR PRODUCTO
        public Boolean InsertarProductos(entProductos producto)
        {
            SqlCommand cmd = null;
            bool insercionExitosa = false;
            try
            {
                SqlConnection cn = datConexion.Instancia.Conectar();
                cmd = new SqlCommand("spInsertarProducto", cn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@CategoriaID", producto.CategoriaproductoID);
                cmd.Parameters.AddWithValue("@Descripcion", producto.descripcion);
                cmd.Parameters.AddWithValue("@UnidadmedidaID", producto.unidadMedidaID);
                cmd.Parameters.AddWithValue("@PrecioVenta", producto.precioVenta);
                cmd.Parameters.AddWithValue("@Cantidad", producto.cantidad);
                cmd.Parameters.AddWithValue("@Fecha", producto.fecha);
                cmd.Parameters.AddWithValue("@Estado", producto.estado);

                cn.Open();
                int filasAfectadas = cmd.ExecuteNonQuery();

                insercionExitosa = filasAfectadas > 0;
            }
            catch (Exception e)
            {
                throw e;
            }
            finally { 
                cmd.Connection.Close(); 
            }

            return insercionExitosa;
        }
        ////////////////////BUSCAR PRODUCTO
        public entProductos BuscarProductoPorID(int productoID)
        {
            SqlCommand cmd = null;
            entProductos Prod = null;

            try
            {
                using (SqlConnection cn = datConexion.Instancia.Conectar())
                {
                    cmd = new SqlCommand("spBuscarProductoPorID", cn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@ProductoID", productoID);

                    cn.Open();

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        if (dr.Read())
                        {
                            Prod = new entProductos
                            {
                                ProductoID = Convert.ToInt32(dr["ProductoID"]),
                                CategoriaproductoID = Convert.ToInt32(dr["CategoriaID"]),
                                unidadMedidaID = Convert.ToInt32(dr["UnidadmedidaID"]),
                                descripcion = Convert.ToString(dr["Descripcion"]),
                                precioVenta = Convert.ToDecimal(dr["PrecioVenta"]),
                                cantidad = Convert.ToInt32(dr["Cantidad"]),
                                fecha = Convert.ToDateTime(dr["Fecha"]),
                                estado = Convert.ToBoolean(dr["Estado"])
                            };
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return Prod;
        }
        public entProductos BuscarProductosPorDescripcion(string descripcion)
        {
            entProductos producto = new entProductos();
            SqlCommand cmd = null;
            try
            {
                SqlConnection cn = datConexion.Instancia.Conectar(); // conexión a la base de datos
                cmd = new SqlCommand("spBuscarProductoPorDescripcion", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Descripcion", descripcion);

                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    
                    producto.ProductoID = Convert.ToInt32(dr["ProductoID"]);
                    producto.CategoriaproductoID = Convert.ToInt32(dr["CategoriaID"]);
                    producto.descripcion = Convert.ToString(dr["Descripcion"]);
                    producto.unidadMedidaID = Convert.ToInt32(dr["UnidadmedidaID"]);
                    producto.precioVenta = Convert.ToDecimal(dr["PrecioVenta"]);
                    producto.cantidad = Convert.ToInt32(dr["Cantidad"]);
                    producto.estado = Convert.ToBoolean(dr["Estado"]);

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

            return producto; 
        }


        ////////////////////MODIFICAR PRODUCTO
        public bool EditarProducto(entProductos producto)
        {
            SqlCommand cmd = null;
            bool edicionExitosa = false;

            try
            {
                using (SqlConnection cn = datConexion.Instancia.Conectar())
                {
                    cmd = new SqlCommand("spEditarProducto", cn);
                    cmd.CommandType = CommandType.StoredProcedure;

                    // Asignar parámetros
                    cmd.Parameters.AddWithValue("@ProductoID", producto.ProductoID);
                    cmd.Parameters.AddWithValue("@CategoriaID", producto.CategoriaproductoID);
                    cmd.Parameters.AddWithValue("@Descripcion", producto.descripcion);
                    cmd.Parameters.AddWithValue("@UnidadmedidaID", producto.unidadMedidaID);
                    cmd.Parameters.AddWithValue("@PrecioVenta", producto.precioVenta);
                    cmd.Parameters.AddWithValue("@Cantidad", producto.cantidad);
                    cmd.Parameters.AddWithValue("@Fecha", producto.fecha);
                    cmd.Parameters.AddWithValue("@Estado", producto.estado);

                    cn.Open();
                    int filasAfectadas = cmd.ExecuteNonQuery();

                    edicionExitosa = filasAfectadas > 0;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return edicionExitosa;
        }
        ////////////////////DESHABILITAR PRODUCTO
        public bool DeshabilitarProducto(int productoID)
        {
            SqlCommand cmd = null;
            bool deshabilitacionExitosa = false;

            try
            {
                using (SqlConnection cn = datConexion.Instancia.Conectar())
                {
                    cmd = new SqlCommand("spDeshabilitarProducto", cn);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@ProductoID", productoID);

                    cn.Open();
                    int filasAfectadas = cmd.ExecuteNonQuery();

                    deshabilitacionExitosa = filasAfectadas > 0;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return deshabilitacionExitosa;
        }
        #endregion metodos
    }
}
