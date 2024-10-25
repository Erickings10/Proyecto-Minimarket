using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class entCliente
    {
        public int ClienteID { get; set; }
        public string DNI { get; set; }
        public string nombres { get; set; }
        public string apellidoPaterno { get; set; }
        public string apellidoMaterno { get; set; }
        public string Telefono {  get; set; }
        public bool Estado { get; set; }

        // Propiedad calculada para mostrar Nombre Completo en el ComboBox
        public string NombreCompleto
        {
            get
            {
                return nombres + " " + apellidoPaterno + " " + apellidoMaterno;
            }
        }

        public string ApellidosCompletos
        {
            get
            {
                return apellidoPaterno + " " + apellidoMaterno;
            }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    var apellidos = value.Split(' ');
                    if (apellidos.Length >= 2)
                    {
                        apellidoPaterno = apellidos[0];
                        apellidoMaterno = apellidos[1];
                    }
                }
            }
        }

        public string tipoDocumento { get; set; }
        public string numeroDocumento { get; set; }
        public string digitoVerificador { get; set; }
    }
}
