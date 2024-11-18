using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.Json;

namespace SoftwareMinimarket
{
    public partial class PantallaYape : Form
    {
        public string ClienteNombre { get; set; }
        public decimal MontoTotal { get; set; }
        public bool PagoExitoso { get; private set; } = false;


        public PantallaYape(string clienteNombre, decimal montoTotal)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;

            // Asignar valores recibidos a las propiedades
            ClienteNombre = clienteNombre;
            MontoTotal = montoTotal;

            // Asignar valores a los controles
            txtCliente.Text = ClienteNombre;
            txtTotal.Text = $"S/. {MontoTotal:F2}";
        }

        private async void btnConfirmarPago_Click(object sender, EventArgs e)
        {
            try
            {
                // Validar campos de entrada
                if (string.IsNullOrWhiteSpace(txtCorreo.Text) ||
                    string.IsNullOrWhiteSpace(txtNumYape.Text) ||
                    string.IsNullOrWhiteSpace(txtOTP.Text))
                {
                    MessageBox.Show("Por favor, completa todos los campos.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Capturar datos ingresados
                string correo = txtCorreo.Text;
                string telefono = txtNumYape.Text;
                string otp = txtOTP.Text;

                // Confirmar pago con Yape
                await ConfirmarPagoYape(telefono, otp, MontoTotal, correo);

                // Si el pago es exitoso, habilitar el botón Confirmar Venta
                PagoExitoso = true;
                MessageBox.Show("Pago confirmado. Ahora puedes registrar la venta.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al procesar el pago: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async Task ConfirmarPagoYape(string telefono, string otp, decimal monto, string correo)
        {
            try
            {
                var yapeService = new MercadoPagoYapeService();

                // Generar ID de Yape
                string id = await yapeService.GenerateYapeToken(telefono, otp);

                // Crear el pago usando el ID como 'token'
                string resultadoPago = await yapeService.CreatePayment(id, monto, correo);

                if (resultadoPago != "Pago aprobado")
                {
                    throw new Exception("El pago fue rechazado.");
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Error al procesar el pago: {ex.Message}");
            }
        }

        private void btnConfirmarVenta_Click(object sender, EventArgs e)
        {
            if (!PagoExitoso)
            {
                MessageBox.Show("Primero confirma el pago antes de registrar la venta.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Confirmar cierre del formulario y notificar éxito
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}

