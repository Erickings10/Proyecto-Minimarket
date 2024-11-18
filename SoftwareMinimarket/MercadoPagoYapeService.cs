using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;

namespace SoftwareMinimarket
{
    public class MercadoPagoYapeService
    {
        private readonly string publicKey = "APP_USR-f1201ec3-8c54-4b62-ae70-0f3c69c4fa2d";
        private readonly string accessToken = "APP_USR-4843073411612847-111618-7b744918ce6f76f61b219706ababd445-1914697978";

        public async Task<string> GenerateYapeToken(string phoneNumber, string otp)
        {
            using (var httpClient = new HttpClient())
            {
                var requestBody = new
                {
                    phoneNumber = phoneNumber,
                    otp = otp,
                    requestId = Guid.NewGuid().ToString()
                };

                var jsonContent = new StringContent(JsonSerializer.Serialize(requestBody), Encoding.UTF8, "application/json");

                var url = $"https://api.mercadopago.com/platforms/pci/yape/v1/payment?public_key={publicKey}";
                var response = await httpClient.PostAsync(url, jsonContent);

                var responseContent = await response.Content.ReadAsStringAsync();

                if (response.IsSuccessStatusCode)
                {
                    using (var jsonDoc = JsonDocument.Parse(responseContent))
                    {
                        var root = jsonDoc.RootElement;

                        // Busca el campo 'id', ya que no se genera 'token'
                        if (root.TryGetProperty("id", out JsonElement idElement))
                        {
                            return idElement.GetString();
                        }
                        else
                        {
                            throw new Exception($"El identificador ('id') no se encuentra en la respuesta. Respuesta completa: {responseContent}");
                        }
                    }
                }
                else
                {
                    throw new Exception($"Error al generar token/ID: {response.ReasonPhrase}. Respuesta completa: {responseContent}");
                }
            }
        }
        public async Task<string> CreatePayment(string id, decimal amount, string email)
        {
            using (var httpClient = new HttpClient())
            {
                var requestBody = new
                {
                    token = id, // Usa el identificador 'id' como 'token'
                    transaction_amount = amount,
                    description = "Pago en Minimarket",
                    installments = 1,
                    payment_method_id = "yape",
                    payer = new { email = email }
                };

                var jsonContent = new StringContent(JsonSerializer.Serialize(requestBody), Encoding.UTF8, "application/json");

                var url = "https://api.mercadopago.com/v1/payments";
                httpClient.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", accessToken);

                // Generar una clave de idempotencia única (puede ser un GUID)
                string idempotencyKey = Guid.NewGuid().ToString();
                httpClient.DefaultRequestHeaders.Add("X-Idempotency-Key", idempotencyKey);

                var response = await httpClient.PostAsync(url, jsonContent);

                var responseContent = await response.Content.ReadAsStringAsync();

                if (response.IsSuccessStatusCode)
                {
                    using (var jsonDoc = JsonDocument.Parse(responseContent))
                    {
                        var root = jsonDoc.RootElement;
                        if (root.TryGetProperty("status", out JsonElement statusElement))
                        {
                            return statusElement.GetString() == "approved" ? "Pago aprobado" : "Pago rechazado";
                        }
                        else
                        {
                            throw new Exception($"El estado del pago no se encuentra en la respuesta: {responseContent}");
                        }
                    }
                }
                else
                {
                    throw new Exception($"Error al crear pago: {response.ReasonPhrase}. Respuesta completa: {responseContent}");
                }
            }
        }

    }
}
