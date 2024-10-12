using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogica
{
    public class logRubroProv
    {
        #region sigleton

        private static readonly logRubroProv _instancia = new logRubroProv();
        public static logRubroProv Instancia
        {
            get
            {
                return logRubroProv._instancia;
            }
        }
        #endregion singleton

        #region metodos

        public List<entRubroProv> ListarRubro()
        {
            return datRubroProv.Instancia.ListarRubro();
        }
        public void InsertaRubro(entRubroProv Rub)
        {
            datRubroProv.Instancia.InsertaRubro(Rub);
        }
        public void EditaRubro(entRubroProv Rub)
        {
            datRubroProv.Instancia.EditaRubro(Rub);
        }
        public void DeshabilitaRubro(entRubroProv Rub)
        {
            datRubroProv.Instancia.DeshabilitarRubro(Rub);
        }

        public DataTable ListaDeRubros()
        {
            return datRubroProv.Instancia.ListaDeRubros();
        }
        #endregion metodos
    }
}
