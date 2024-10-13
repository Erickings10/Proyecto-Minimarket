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
    public partial class FormOrdenCompra : Form
    {
        public FormOrdenCompra()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;

            txtCantidad.Enabled = false;
            txtTotal.Enabled = false;

            chkEstado.Checked = true;
            chkEstado.Enabled = false;
        }
        private void AbrirProveedor()
        {
            using (FormReporteProveedor FRP = new FormReporteProveedor())
            {
                if (FRP.ShowDialog() == DialogResult.OK)
                {
                    txtProveedorID.Text = FRP.idProv;
                }
            }
        }

        private void btnProveedor_Click(object sender, EventArgs e)
        {
            AbrirProveedor();

        }

        private void btnAgregarOrden_Click(object sender, EventArgs e)
        {
            if (dgvSeleccion.Rows.Count < 1)
            {
                MessageBox.Show("No se ha seleccionado ningún requerimiento.", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            // Crear objeto para la Orden de Compra
            entOrdenCompra orden = new entOrdenCompra();
            orden.ProveedorID = Convert.ToInt32(txtProveedorID.Text);
            orden.Fecha = DateTime.Now;
            decimal montoTotal = 0;

            // Calcular el total sumando los precios de cada requerimiento
            foreach (DataGridViewRow fila in dgvSeleccion.Rows)
            {
                decimal precioRequerimiento = Decimal.Parse(fila.Cells[2].Value?.ToString());
                montoTotal += precioRequerimiento;
            }
            orden.Total = montoTotal;
            orden.Estado = chkEstado.Checked; // Asignar estado 

            // Llamada para insertar la Orden de Compra en la capa lógica
            if (logOrdenCompra.Instancia.InsertarOrdenCompra(ref orden))
            {
                // Iterar sobre las filas para insertar detalles de la Orden de Compra
                foreach (DataGridViewRow fila in dgvSeleccion.Rows)
                {
                    entDetalleOrdenCompra detalle = new entDetalleOrdenCompra();
                    detalle.OrdendecompraID = orden.OrdenCompraID;
                    detalle.RequerimientoID = int.Parse(fila.Cells[1].Value?.ToString());
                    detalle.Cantidad = int.Parse(txtCantidad.Text);
                    detalle.Precio = decimal.Parse(fila.Cells[2].Value?.ToString());

                    // Insertar el detalle en la capa lógica
                    logDetalleOrdenCompra.Instancia.InsertarDetOrdenCompra(detalle);
                }

                // Confirmación de la inserción
                MessageBox.Show("Orden de Compra creada exitosamente. ID de Orden: " + orden.OrdenCompraID, "CONFIRMACIÓN", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Error al crear la Orden de Compra.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            // Limpiar el formulario
            dgvSeleccion.Rows.Clear();
            txtProveedorID.Text = "";
            txtTotal.Text = "";
        }

        private int idTemporal = 1;
        private int cantidadActual = 0;
        private void btnAgregarRequerimiento_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtRequerimientoID.Text) ||
                string.IsNullOrEmpty(txtPrecioRequerimiento.Text) ||
                string.IsNullOrEmpty(txtProveedorID.Text))
            {
                MessageBox.Show("Por favor, complete todos los campos del requerimiento.", "ALERTA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Agregar el requerimiento al DataGridView
            dgvSeleccion.Rows.Add(idTemporal, txtRequerimientoID.Text, txtPrecioRequerimiento.Text, txtProveedorID.Text);

            // Incrementar los contadores de ID temporal y cantidad
            idTemporal++;
            cantidadActual++;

            // Limpiar los campos de texto
            txtRequerimientoID.Text = "";
            txtPrecioRequerimiento.Text = "";
            txtCantidad.Text = cantidadActual.ToString(); // Mostrar la cantidad incrementada

            // Calcular y mostrar el total
            CalcularTotal();
        }

        private void CalcularTotal()
        {
            decimal total = 0;
            foreach (DataGridViewRow row in dgvSeleccion.Rows)
            {
                if (row.Cells[2].Value != null)
                {
                    decimal precioRequerimiento = Convert.ToDecimal(row.Cells[2].Value);
                    total += precioRequerimiento;
                }
            }
            txtTotal.Text = total.ToString("C2");
        }

        private void btnEliminarRequerimiento_Click(object sender, EventArgs e)
        {
            if (dgvSeleccion.SelectedRows.Count > 0)
            {
                dgvSeleccion.Rows.RemoveAt(dgvSeleccion.SelectedRows[0].Index);
            }
            CalcularTotal();
        }

        private void btn_regresar_Click(object sender, EventArgs e)
        {
            ModuloAbastecimiento abas = new ModuloAbastecimiento();
            abas.Show();
            this.Close();
        }
    }
}
