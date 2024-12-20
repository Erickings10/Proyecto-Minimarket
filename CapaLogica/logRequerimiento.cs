﻿using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogica
{
    public class logRequerimiento
    {
        #region sigleton

        private static readonly logRequerimiento _instancia = new logRequerimiento();
        public static logRequerimiento Instancia
        {
            get
            {
                return logRequerimiento._instancia;
            }
        }
        #endregion singleton

        #region metodos

        public bool InsertarRequerimiento(ref entRequerimiento req)
        {
            return datRequerimiento.Instancia.InsertarRequerimiento(ref req);
        }
        public List<entRequerimiento> ListarRequerimientos()
        {
            return datRequerimiento.Instancia.ListarRequerimientos();
        }
        public bool CambiarEstadoRequerimiento(int requerimientoID, bool nuevoEstado)
        {
            return datRequerimiento.Instancia.CambiarEstadoRequerimiento(requerimientoID, nuevoEstado);
        }

        #endregion metodos
    }
}
