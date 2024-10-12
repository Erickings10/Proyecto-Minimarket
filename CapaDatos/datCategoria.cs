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
    public class datCategoria
    {
        #region sigleton
        private static readonly datCategoria _instancia = new datCategoria();
        public static datCategoria Instancia
        {
            get
            {
                return datCategoria._instancia;
            }
        }
        #endregion singleton

        #region metodos
        public List<entCategoria> ListarCategoria()
        {
            List<entCategoria> lista = new List<entCategoria>();
            SqlCommand cmd = null;
            SqlDataReader dr = null;
            try
            {
                SqlConnection cn = datConexion.Instancia.Conectar();
                cmd = new SqlCommand("spListarCategoria", cn); // Asume que tienes un SP llamado spListarCategorias
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    entCategoria cat = new entCategoria();
                    cat.CategoriaID = Convert.ToInt32(dr["CategoriaID"]);
                    cat.Descripcion = dr["Descripcion"].ToString();
                    cat.Estado = Convert.ToBoolean(dr["Estado"]);
                    lista.Add(cat);
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                if (dr != null) dr.Close();
                if (cmd != null) cmd.Connection.Close();
            }
            return lista;
        }

        // Método para agregar una nueva categoría
        public bool InsertarCategoria(entCategoria categoria)
        {
            SqlCommand cmd = null;
            bool inserto = false;
            try
            {
                SqlConnection cn = datConexion.Instancia.Conectar();
                cmd = new SqlCommand("spInsertarCategoria", cn); // Asume que tienes un SP llamado spInsertarCategoria
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Descripcion", categoria.Descripcion);
                cmd.Parameters.AddWithValue("@Estado", categoria.Estado);
                cn.Open();
                int filas = cmd.ExecuteNonQuery();
                if (filas > 0)
                    inserto = true;
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                if (cmd != null) cmd.Connection.Close();
            }
            return inserto;
        }

        // Método para actualizar una categoría
        public bool ModificarCategoria(entCategoria categoria)
        {
            SqlCommand cmd = null;
            bool actualizo = false;
            try
            {
                SqlConnection cn = datConexion.Instancia.Conectar();
                cmd = new SqlCommand("spModificarCategoria", cn); // Asume que tienes un SP llamado spActualizarCategoria
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@CategoriaID", categoria.CategoriaID);
                cmd.Parameters.AddWithValue("@Descripcion", categoria.Descripcion);
                cmd.Parameters.AddWithValue("@Estado", categoria.Estado);
                cn.Open();
                int filas = cmd.ExecuteNonQuery();
                if (filas > 0)
                    actualizo = true;
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                if (cmd != null) cmd.Connection.Close();
            }
            return actualizo;
        }

        public void DeshabilitarCategoria(entCategoria cat)
        {
            SqlCommand cmd = null;
            try
            {
                SqlConnection cn = datConexion.Instancia.Conectar();
                cmd = new SqlCommand("spDeshabilitarCategoria", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@CategoriaID", cat.CategoriaID);
                cn.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                cmd?.Connection.Close();
            }
        }

        #endregion metodos
    }
}
