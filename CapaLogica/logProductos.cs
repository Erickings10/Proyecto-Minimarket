using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogica
{
    public class logProductos
    {
        #region sigleton
        // Variable estática para la instancia
        private static readonly logProductos _instancia = new logProductos();
        //privado para evitar la instanciación directa
        public static logProductos Instancia
        {
            get
            {
                return logProductos._instancia;
            }
        }
        #endregion singleton
        #region metodos
        public List<entProductos> ListarProductos()
        {
            return datProductos.Instancia.ListarProductos();
        }
        public bool InsertarProducto(entProductos producto)
        {
            return datProductos.Instancia.InsertarProductos(producto);
        }
        public bool EditarProducto(entProductos producto)
        {
            return datProductos.Instancia.EditarProducto(producto);
        }
        public entProductos BuscarProductoPorID(int productoID)
        {
            return datProductos.Instancia.BuscarProductoPorID(productoID);
        }

        public entProductos BuscarProductoPorNombre(string descripcion)
        {
            return datProductos.Instancia.BuscarProductosPorDescripcion(descripcion);
        }
        #endregion
    }
}
