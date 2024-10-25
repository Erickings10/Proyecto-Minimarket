using CapaEntidad;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class datBoleta
    {
        #region sigleton
        //Patron Singleton
        // Variable estática para la instancia
        private static readonly datBoleta _instancia = new datBoleta();
        //privado para evitar la instanciación directa
        public static datBoleta Instancia
        {
            get
            {
                return datBoleta._instancia;
            }
        }
        #endregion singleton

        #region metodos
        public async Task<string> GenerarBoletaAsync(entBoleta boleta)
        {
            HttpClient client = new HttpClient();
            client.DefaultRequestHeaders.Add("Authorization", "Bearer eyJ0eXAiOiJKV1QiLCJhbGciOiJSUzI1NiJ9.eyJ1c2VybmFtZSI6Ikp1YW5PZmZ4MTkiLCJjb21wYW55IjoiOTQ4MjIxODgzMTEiLCJpYXQiOjE3Mjk2NTA4MDQsImV4cCI6ODAzNjg1MDgwNH0.W4jBn2dzoww3DZdtcmjcvaiS_0Gy-7EorE3zFudjWVnHO-8JkZvW-iEs0JegN-LkiEeZoW2awIE0YvlMpk7sWckWM12DxRed7QoLkmcf46Q8jezf9U_SXbMAaYZWJJMwEyLFmz226_NUT42KgSC7GyixKzZ_Wooi8PfCNIMz2G6KRiDDDD0kM7HEpcoikYP7lrcyY-ljggt5qySVfHbCYkOYcbWXWMcn7hCfWEV56bYOxvVu-6QIgvIJYgv-SJcLO3uYaLfbxO2gpm80EQVup0Q_-ZEoxo4f3pY8Suw-w49X7Wb5njVkpPiKeSd7W4WHkJahrQRf4FGVU_4JWVlN25SffK9w3oioSxAC3JDm7eI-uncmhVYPAPNXveK_FFtuMnHDD3pmyaYeP00Wiocgqh1aLaPROJidV-UY7VKjQyozSLvd_PsNiau6K1DIshydInWdUZG3oXwyLpfZ-LbGL5pLztdzyzJhemP-DE5_STahbIrm5lUJTUbNOJvfLUO7BVdnCcMpf38NfHjw6ZFzt_bEM0xYBvzDMj3JL9fTSqBvIUi-enhn_rn7_YLXeCIhQSraEYq_cLo5AjQQT0RxjlnULFMRVtX3yIoenNi1uuVWXZxQkqk0XRw6iqYXbS6Qv_7frlvMb4r2-rXIxRCGydN0dsJ5H-4f0dToprp_y1w");

            // Serializa la factura a JSON
            string jsonFactura = JsonConvert.SerializeObject(boleta);

            // Configura el contenido de la solicitud
            StringContent content = new StringContent(jsonFactura, Encoding.UTF8, "application/json");

            string url = "https://facturacion.apisperu.com/api/v1/invoice/send";
            try
            {
                HttpResponseMessage response = await client.PostAsync(url, content);
                response.EnsureSuccessStatusCode();

                string responseContent = await response.Content.ReadAsStringAsync();
                return responseContent; // Aquí recibes la respuesta de la API, que puedes procesar
            }
            catch (Exception ex)
            {
                // Manejo de errores
                return $"Error: {ex.Message}";
            }
        }

        public async Task<string> GenerarBoletaPDFAsync(entBoleta factura, string rutaArchivo)
        {
            HttpClient client = new HttpClient();
            client.DefaultRequestHeaders.Add("Authorization", "Bearer eyJ0eXAiOiJKV1QiLCJhbGciOiJSUzI1NiJ9.eyJ1c2VybmFtZSI6Ikp1YW5PZmZ4MTkiLCJjb21wYW55IjoiOTQ4MjIxODgzMTEiLCJpYXQiOjE3Mjk2NTA4MDQsImV4cCI6ODAzNjg1MDgwNH0.W4jBn2dzoww3DZdtcmjcvaiS_0Gy-7EorE3zFudjWVnHO-8JkZvW-iEs0JegN-LkiEeZoW2awIE0YvlMpk7sWckWM12DxRed7QoLkmcf46Q8jezf9U_SXbMAaYZWJJMwEyLFmz226_NUT42KgSC7GyixKzZ_Wooi8PfCNIMz2G6KRiDDDD0kM7HEpcoikYP7lrcyY-ljggt5qySVfHbCYkOYcbWXWMcn7hCfWEV56bYOxvVu-6QIgvIJYgv-SJcLO3uYaLfbxO2gpm80EQVup0Q_-ZEoxo4f3pY8Suw-w49X7Wb5njVkpPiKeSd7W4WHkJahrQRf4FGVU_4JWVlN25SffK9w3oioSxAC3JDm7eI-uncmhVYPAPNXveK_FFtuMnHDD3pmyaYeP00Wiocgqh1aLaPROJidV-UY7VKjQyozSLvd_PsNiau6K1DIshydInWdUZG3oXwyLpfZ-LbGL5pLztdzyzJhemP-DE5_STahbIrm5lUJTUbNOJvfLUO7BVdnCcMpf38NfHjw6ZFzt_bEM0xYBvzDMj3JL9fTSqBvIUi-enhn_rn7_YLXeCIhQSraEYq_cLo5AjQQT0RxjlnULFMRVtX3yIoenNi1uuVWXZxQkqk0XRw6iqYXbS6Qv_7frlvMb4r2-rXIxRCGydN0dsJ5H-4f0dToprp_y1w"); // Coloca aquí tu token

            // Serializa la factura a JSON
            string jsonFactura = JsonConvert.SerializeObject(factura);

            // Configura el contenido de la solicitud
            StringContent content = new StringContent(jsonFactura, Encoding.UTF8, "application/json");

            string url = "https://facturacion.apisperu.com/api/v1/invoice/pdf";
            try
            {
                // Realiza la solicitud
                HttpResponseMessage response = await client.PostAsync(url, content);
                response.EnsureSuccessStatusCode();

                // Lee el contenido de la respuesta como un array de bytes (PDF)
                byte[] pdfBytes = await response.Content.ReadAsByteArrayAsync();

                // Guarda el archivo en la ruta especificada
                File.WriteAllBytes(rutaArchivo, pdfBytes);

                //using (FileStream fs = new FileStream("ruta/del/archivo.pdf", FileMode.Create, FileAccess.Write, FileShare.None, 4096, true))
                //{
                //    await fs.WriteAsync(pdfBytes, 0, pdfBytes.Length);
                //}

                return $"PDF guardado exitosamente en: {rutaArchivo}";
            }
            catch (Exception ex)
            {
                // Manejo de errores
                return $"Error: {ex.Message}";
            }
        }

        #endregion
    }
}
