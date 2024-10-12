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
    public class datRequerimiento
    {
        #region sigleton
        private static readonly datRequerimiento _instancia = new datRequerimiento();
        public static datRequerimiento Instancia
        {
            get
            {
                return datRequerimiento._instancia;
            }
        }
        #endregion singleton

        #region metodos

        public bool InsertarRequerimiento(ref entRequerimiento req)
        {
            SqlCommand cmd = null;
            bool insertado = false;
            try
            {
                SqlConnection cn = datConexion.Instancia.Conectar();
                cmd = new SqlCommand("spInsertarRequerimiento", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@UsuarioID", req.UsuarioID);
                cmd.Parameters.AddWithValue("@Fecha", req.Fecha);
                cmd.Parameters.AddWithValue("@Estado", req.Estado);

                SqlParameter idReq = new SqlParameter("@RequerimientoID", SqlDbType.Int);
                idReq.Direction = ParameterDirection.Output;
                cmd.Parameters.Add(idReq);
                cn.Open();

                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    insertado = true;
                    req.RequerimientoID = Convert.ToInt32(idReq.Value);
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
