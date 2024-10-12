using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class entProveedor
    {
        public int idProv { get; set; }
        public Int64 rucProv { get; set; }
        public int idRubro { get; set; }
        public int ubiProv { get; set; }
        public string nameProv { get; set; }
        public Int64 telfProv { get; set; }
        public DateTime fechaProv { get; set; }
        public Boolean estProv { get; set; }
    }
}
