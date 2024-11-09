using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace SoftwareMinimarket
{
    public class FileHelper
    {
        public string ObtenerRutaDocumentos()
        {
            // Obtiene la ruta de la carpeta "Documentos" del usuario actual
            return Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
        }

        public string GenerarRutaArchivoPDF(string nombreArchivo)
        {
            string rutaDocumentos = ObtenerRutaDocumentos();
            // Combina la ruta de Documentos con el nombre del archivo PDF
            return Path.Combine(rutaDocumentos, nombreArchivo + ".pdf");
        }
    }
}
