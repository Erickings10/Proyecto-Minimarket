using CapaEntidad;
using CapaLogica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SoftwareMinimarket
{
    public partial class FormAgregarCliente : Form
    {
        public FormAgregarCliente()
        {
            InitializeComponent();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            entCliente cliente = new entCliente
            {
                DNI = txtDNI.Text,
                nombres = txtNombre.Text,
                ApellidosCompletos = txtApellido.Text,
                Telefono = txtTelefono.Text,
                Estado = true
            };

            bool resultado = logCliente.Instancia.InsertarCliente(cliente);

            if (resultado)
            {
                DialogResult = DialogResult.OK;
                Close();
            }
            else
                MessageBox.Show("Error al insertar cliente");

        }
        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;  
            Close();
        }

        private async void txtDNI_TextChanged(object sender, EventArgs e)
        {
            // Verificamos que el texto tenga 8 dígitos
            if (txtDNI.Text.Length == 8)
            {
                // Llamamos al método que obtiene el cliente de la API
                var cliente = await logCliente.Instancia.GetClienteAPI(txtDNI.Text);

                if (cliente != null)
                {
                    // Llenamos los campos si la consulta fue exitosa
                    txtNombre.Text = cliente.nombres;
                    txtApellido.Text = cliente.apellidoPaterno + " " + cliente.apellidoMaterno;
                }
                else
                {
                    MessageBox.Show("No se encontró un cliente con ese DNI.");
                    txtNombre.Clear();
                    txtApellido.Clear();
                }
            }
        }

        private void txtDNI_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verificamos si la tecla no es un número ni la tecla de retroceso (backspace)
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                // Cancelamos el evento, impidiendo que el carácter no numérico se ingrese
                e.Handled = true;
            }
        }
    }
}
