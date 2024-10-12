using CapaEntidad;
using CapaLogica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SoftwareMinimarket
{
    public partial class ModuloEntradaProductos : Form
    {
        private entProductos desProducto = new entProductos();
        private entNotaEntrada desnotaEntrada = new entNotaEntrada();
        public ModuloEntradaProductos()
        {
            InitializeComponent();
            ListarEntrada();
            gboDatos.Enabled = false;
            btnRegistrar.Enabled = false;
            btnModificar.Enabled = false;
            btnDeshabilitar.Enabled = false;
        }

        private void btn_nuevo_Click(object sender, EventArgs e)
        {
            gboDatos.Enabled = true;
            btnDeshabilitar.Enabled = false;
            btnModificar.Enabled = false;
            btnRegistrar.Enabled = true;
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            gboDatos.Enabled = false;
            btnDeshabilitar.Enabled = false;
            btnModificar.Enabled = false;
            btnRegistrar.Enabled = false;
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            try
            {
                // Validación de ProductoID
                if (desProducto == null || desProducto.ProductoID <= 0)
                {
                    MessageBox.Show("Producto no válido. Seleccione un producto.");
                    return;
                }

                // Validación de cantidad
                if (string.IsNullOrWhiteSpace(txtCantidad.Text) || !int.TryParse(txtCantidad.Text, out int cantidad) || cantidad <= 0)
                {
                    MessageBox.Show("Por favor, ingrese una cantidad válida.");
                    return;
                }

                // Validación de TiendaID
                if (string.IsNullOrWhiteSpace(txtTienda.Text) || !int.TryParse(txtTienda.Text, out int tiendaID) || tiendaID <= 0)
                {
                    MessageBox.Show("Por favor, ingrese un ID de tienda válido.");
                    return;
                }

                // Validación de UsuarioID
                if (string.IsNullOrWhiteSpace(txtUsuario.Text) || !int.TryParse(txtUsuario.Text, out int usuarioID) || usuarioID <= 0)
                {
                    MessageBox.Show("Por favor, ingrese un ID de usuario válido.");
                    return;
                }

                // Validación de descripción
                if (string.IsNullOrWhiteSpace(txtDescripcion.Text))
                {
                    MessageBox.Show("La descripción no puede estar vacía.");
                    return;
                }

                entNotaEntrada nuevaNotaEntrada = new entNotaEntrada
                {
                    ProductoID = desProducto.ProductoID,
                    Cantidad = Convert.ToInt32(txtCantidad.Text),
                    TiendaID = Convert.ToInt32(txtTienda.Text),
                    Descripcion = txtDescripcion.Text,
                    UsuarioID = Convert.ToInt32(txtUsuario.Text),
                    Fecha = DateTime.Now,
                    Estado = chbx_Estado.Checked
                };

                bool resultado = logNotaEntrada.Instancia.InsertarNotaEntrada(nuevaNotaEntrada);

                if (resultado)
                {
                    MessageBox.Show("Nota de Entrada insertada con éxito");
                }
                else
                {
                    MessageBox.Show("Error al insertar Nota de Entrada");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }

            LimpiarVariables();

            ListarEntrada();
        }
        private void LimpiarVariables()
        {
            txtTienda.Text = "";
            txtUsuario.Text = "";
            txtDescripcion.Text = "";
            txtProducto.Text = "";
            txtCantidad.Text = "";
            chbx_Estado.Checked = false;
        }

        public void ListarEntrada()
        {
            dgvEntradaProductos.DataSource = logNotaEntrada.Instancia.ListarNotaEntrada();
        }

        private void AbrirReporteProductos()
        {
            using (FormReporteProductos formReporteProducto = new FormReporteProductos())
            {
                if (formReporteProducto.ShowDialog() == DialogResult.OK)
                {
                    desProducto = formReporteProducto.producto;
                    txtProducto.Text = desProducto.ProductoID.ToString();
                    txtDescripcion.Text = desProducto.descripcion;
                    txtTienda.Text = "1";
                    txtUsuario.Text = Form1.usuarioValido.id.ToString();
                }

            }
        } 

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                entNotaEntrada notaEntrada = new entNotaEntrada
                {
                    NotaEntradaID = desnotaEntrada.NotaEntradaID, 
                    ProductoID = Convert.ToInt32(txtProducto.Text), 
                    Cantidad = Convert.ToInt32(txtCantidad.Text),
                    TiendaID = Convert.ToInt32(txtTienda.Text),
                    Descripcion = txtDescripcion.Text, 
                    Fecha = DateTime.Now, 
                    Estado = chbx_Estado.Checked, 
                    UsuarioID = Convert.ToInt32(txtUsuario.Text)
                };

                bool resultado = logNotaEntrada.Instancia.ModificarNotaEntrada(notaEntrada);

                if (resultado)
                {
                    MessageBox.Show("Nota de entrada actualizada con éxito");
                }
                else
                {
                    MessageBox.Show("Error al actualizar la nota de entrada");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

            btnDeshabilitar.Enabled = false;
            btnModificar.Enabled = false;
            gboDatos.Enabled = false;
            btnRegistrar.Enabled = false;

            LimpiarVariables(); 
            ListarEntrada();     
        }

        private void btnBuscarProducto_Click(object sender, EventArgs e)
        {
            AbrirReporteProductos();
        }

        private void dgvEntradaProductos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow filaActual = dgvEntradaProductos.Rows[e.RowIndex];

            desnotaEntrada.NotaEntradaID = Convert.ToInt32(filaActual.Cells[0].Value.ToString());
            desnotaEntrada.ProductoID = Convert.ToInt32(filaActual.Cells[1].Value.ToString());
            desnotaEntrada.Cantidad = Convert.ToInt32(filaActual.Cells[2].Value.ToString());
            desnotaEntrada.TiendaID = Convert.ToInt32(filaActual.Cells[3].Value.ToString());
            desnotaEntrada.Descripcion = filaActual.Cells[4].Value.ToString();
            desnotaEntrada.Fecha = Convert.ToDateTime(filaActual.Cells[5].Value.ToString());
            desnotaEntrada.Estado = Convert.ToBoolean(filaActual.Cells[6].Value.ToString());
            desnotaEntrada.UsuarioID = Convert.ToInt32(filaActual.Cells[7].Value.ToString());

            txtProducto.Text = desnotaEntrada.ProductoID.ToString();
            txtCantidad.Text = desnotaEntrada.Cantidad.ToString();
            txtDescripcion.Text = desnotaEntrada.Descripcion.ToString();
            txtTienda.Text = desnotaEntrada.TiendaID.ToString();
            txtUsuario.Text = desnotaEntrada.UsuarioID.ToString();
            chbx_Estado.Checked = desnotaEntrada.Estado;

            btnDeshabilitar.Enabled = true;
            btnModificar.Enabled = true;
            gboDatos.Enabled = true;
            btnRegistrar.Enabled = false;
        }

        private void btnDeshabilitar_Click(object sender, EventArgs e)
        {
            try
            {

                bool resultado = logNotaEntrada.Instancia.DeshabilitarNotaEntrada(desnotaEntrada);

                if (resultado)
                {
                    MessageBox.Show("Nota de entrada deshabilitada con éxito");
                }
                else
                {
                    MessageBox.Show("Error al deshabilitar la nota de entrada");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

            btnDeshabilitar.Enabled = false;
            btnModificar.Enabled = false;
            gboDatos.Enabled = false;
            btnRegistrar.Enabled = false;

            LimpiarVariables();
            ListarEntrada();
        }
    }
}
