using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class datConexion
    {
        private static readonly datConexion _instancia = new datConexion();
        public static datConexion Instancia
        {
            get { return datConexion._instancia; }
        }

        public SqlConnection Conectar()
        {
            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = "Data Source =DESKTOP-HNE371D; Initial Catalog = BaseMinimarket;" + 
                "Integrated Security=true";
            return cn;
        }
    }
}

