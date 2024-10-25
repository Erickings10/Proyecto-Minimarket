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
    public partial class ModuloMedidaProducto : Form
    {
        private entCategoria desCategoria = new entCategoria();
        public ModuloMedidaProducto()
        {
            InitializeComponent();
            dgvMedidaProducto.ReadOnly = true;
            ListarMedida();
            CambiarEncabezados();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                // Validación de descripción
                if (string.IsNullOrWhiteSpace(txtDescripcion.Text))
                {
                    MessageBox.Show("La descripción no puede estar vacía.");
                    return;
                }

                entUdMedida medida = new entUdMedida
                {
                    Descripcion = txtDescripcion.Text,
                    Estado = chbxEstado.Checked
                };

                logUdMedida.Instancia.InsertarMedidaProducto(medida);
                MessageBox.Show("Medida de producto agregada exitosamente.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

            Limpiar();
            ListarMedida();

            DialogResult = DialogResult.OK;  // Esto cierra el formulario y devuelve el resultado a FormPrincipal
            Close();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                entUdMedida medida = new entUdMedida
                {
                    UnidadmedidaID = desCategoria.CategoriaID,
                    Descripcion = txtDescripcion.Text.Trim(),
                    Estado = chbxEstado.Checked
                };
                logUdMedida.Instancia.EditarMedidaProducto(medida);
                MessageBox.Show("Medida de producto modificada exitosamente.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            Limpiar();
            ListarMedida();
        }

        private void btnDeshabilitar_Click(object sender, EventArgs e)
        {
            try
            {
                entUdMedida medida = new entUdMedida
                {
                    UnidadmedidaID = desCategoria.CategoriaID,
                    Estado = false // Deshabilitar
                };
                logUdMedida.Instancia.DeshabilitarMedidaProducto(medida);
                MessageBox.Show("Medida de producto deshabilitada exitosamente.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            Limpiar();
            ListarMedida();
        }

        private void dgvMedidaProducto_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            DataGridViewRow filaActual = dgvMedidaProducto.Rows[e.RowIndex];
            desCategoria.CategoriaID = Convert.ToInt32(filaActual.Cells["UnidadmedidaID"].Value.ToString());
            txtDescripcion.Text = filaActual.Cells["Descripcion"].Value.ToString();
            desCategoria.Descripcion = filaActual.Cells["Descripcion"].Value.ToString();
            chbxEstado.Checked = Convert.ToBoolean(filaActual.Cells["Estado"].Value);
            desCategoria.Estado = Convert.ToBoolean(filaActual.Cells["Estado"].Value);
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Nuevo_Click(object sender, EventArgs e)
        {
            gboxDatos.Enabled = true;
            dgvMedidaProducto.Enabled = true;
            gboxDatos.Enabled = true;
            btnModificar.Enabled = false;
            btnDeshabilitar.Enabled = false;
            Limpiar();
        }

        public void CambiarEncabezados()
        {
            dgvMedidaProducto.Columns["UnidadmedidaID"].HeaderText = "ID Medida";
            dgvMedidaProducto.Columns["Descripcion"].HeaderText = "Descripción";
            dgvMedidaProducto.Columns["Estado"].HeaderText = "Estado";
        }

        private void Limpiar()
        {
            txtDescripcion.Text = "";
            chbxEstado.Checked = false;
        }

        public void ListarMedida()
        {
            try
            {
                var lista = logUdMedida.Instancia.ListarMedidaProducto();
                dgvMedidaProducto.DataSource = lista;
                dgvMedidaProducto.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al listar unidades de medida: " + ex.Message);
            }
        }

    }
}
