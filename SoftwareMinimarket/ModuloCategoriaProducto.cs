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
    public partial class ModuloCategoriaProducto : Form
    {
        entCategoria desCategoria = new entCategoria();
        public ModuloCategoriaProducto()
        {
            InitializeComponent();
            dgvCategoriaProducto.ReadOnly = true;
            ListarCategoria();
            CambiarEncabezados();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {

                if (string.IsNullOrWhiteSpace(txtDescripcion.Text))
                {
                    MessageBox.Show("Por favor, ingresa una descripción para la categoría.");
                    return;
                }


                entCategoria categoria = new entCategoria
                {
                    Descripcion = txtDescripcion.Text.Trim(),
                    Estado = chbxEstado.Checked
                };


                logCategoria.Instancia.InsertarCategoria(categoria);
                MessageBox.Show("Categoría de producto agregada exitosamente.");


                ListarCategoria();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar la categoría: " + ex.Message);
            }

            btnModificar.Enabled = true;
            btnDeshabilitar.Enabled = true;
            Limpiar();
            DialogResult = DialogResult.OK;  // Esto cierra el formulario y devuelve el resultado a FormPrincipal
            Close();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                entCategoria categoria = new entCategoria();
                categoria.CategoriaID = desCategoria.CategoriaID;
                categoria.Descripcion = txtDescripcion.Text.Trim();
                categoria.Estado = chbxEstado.Checked;
                logCategoria.Instancia.ModificarCategoria(categoria);
                MessageBox.Show("Categoría modificada exitosamente.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al modificar: " + ex.Message);
            }
            Limpiar();
            ListarCategoria();
        }

        private void btnDeshabilitar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvCategoriaProducto.SelectedRows.Count > 0)
                {
                    int categoriaId = Convert.ToInt32(dgvCategoriaProducto.SelectedRows[0].Cells["CategoriaID"].Value);
                    entCategoria categoria = new entCategoria
                    {
                        CategoriaID = categoriaId
                    };


                    logCategoria.Instancia.DeshabilitarCategoria(categoria);
                    MessageBox.Show("Categoría de producto deshabilitada exitosamente.");


                    ListarCategoria();
                }
                else
                {
                    MessageBox.Show("Por favor, selecciona una categoría para deshabilitar.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }


        public void CambiarEncabezados()
        {
            dgvCategoriaProducto.Columns["CategoriaID"].HeaderText = "ID Categoria";
            dgvCategoriaProducto.Columns["Descripcion"].HeaderText = "Descripción";
            dgvCategoriaProducto.Columns["Estado"].HeaderText = "Estado";
        }

        private void Limpiar()
        { 
            txtDescripcion.Clear();
            dgvCategoriaProducto.ClearSelection();
        }

        public void ListarCategoria()
        {
            try
            {
                var lista = logCategoria.Instancia.ListarCategoria();
                dgvCategoriaProducto.DataSource = lista;
                dgvCategoriaProducto.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al listar categorías: " + ex.Message);
            }
        }

        private void dgvCategoriaProducto_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow fila = dgvCategoriaProducto.Rows[e.RowIndex];
            desCategoria.CategoriaID = Convert.ToInt32(fila.Cells["CategoriaID"].Value.ToString());
            desCategoria.Descripcion = fila.Cells["Descripcion"].Value.ToString();
            txtDescripcion.Text = fila.Cells["Descripcion"].Value.ToString();
            chbxEstado.Checked = Convert.ToBoolean(fila.Cells["Estado"].Value);
            desCategoria.Estado = Convert.ToBoolean(fila.Cells["Estado"].Value);
        }

        private void btn_Nuevo_Click(object sender, EventArgs e)
        {
            gboxDatos.Enabled = true;
            Limpiar();
            btnModificar.Enabled = false;
            btnDeshabilitar.Enabled = false;
        }
    }
}
