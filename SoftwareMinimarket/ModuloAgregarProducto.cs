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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SoftwareMinimarket
{
    public partial class ModuloAgregarProducto : Form
    {
        public ModuloAgregarProducto()
        {
            InitializeComponent();
            ListarProductos();
            ListarMedidas();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void FormAgregarProducto_Load(object sender, EventArgs e)
        {

        }

        private void LimpiarVariables()
        {
            txtPrecioVenta.Text = "";
            txtDescripcion.Text = "";
            txtCategoriaID.Text = "";
            chbx_Estado.Checked = false;
        }
        private void btnAbrirCat_Click(object sender, EventArgs e)
        {
            AbrirReporteCategoria();
        }
        private void AbrirReporteCategoria()
        {
            using (FormReporteCategorias forReporteCategorias = new FormReporteCategorias())
            {
                if (forReporteCategorias.ShowDialog() == DialogResult.OK)
                {
                    txtIDCategoria.Text= forReporteCategorias.categoria.CategoriaID.ToString();
                }
            }
        }
        private void btnAbrirUdMed_Click(object sender, EventArgs e)
        {
            AbrirAgregarMedida();
        }
        private void AbrirAgregarMedida()
        {
            using (ModuloMedidaProducto moduloAgregarMedida = new ModuloMedidaProducto())
            {
                if (moduloAgregarMedida.ShowDialog() == DialogResult.OK)
                {
                    ListarMedidas();
                }
            }
        }
        public class ComboBoxItem
        {
            public string Text { get; set; } 
            public object Tag { get; set; }

            public override string ToString()
            {
                return Text;
            }
        }

        public void ListarMedidas()
        {
            for (int i = 0; i < logUdMedida.Instancia.ListarMedidaProducto().Count; i++)
            {
                ComboBoxItem item = new ComboBoxItem();
                item.Text = logUdMedida.Instancia.ListarMedidaProducto()[i].Descripcion;

                // Guardar el ID del producto en la propiedad Tag del item
                item.Tag = logUdMedida.Instancia.ListarMedidaProducto()[i].UnidadmedidaID;

                // Agregar el item al ComboBox
                cboUMedida.Items.Add(item);
            }
        }
        public void ListarProductos()
        {
            dgvProductos.DataSource = logProductos.Instancia.ListarProductos();
        }

        private void btnAgregarProducto_Click(object sender, EventArgs e)
        {
            try
            {
                // Validación de ID de categoría
                if (string.IsNullOrWhiteSpace(txtIDCategoria.Text) || !int.TryParse(txtIDCategoria.Text, out int categoriaID))
                {
                    MessageBox.Show("Por favor, ingrese un ID de categoría válido.");
                    return;
                }

                // Validación de unidad de medida seleccionada
                if (medidaSeleccionada <= 0)
                {
                    MessageBox.Show("Por favor, seleccione una unidad de medida válida.");
                    return;
                }

                // Validación de descripción
                if (string.IsNullOrWhiteSpace(txtDescripcion.Text))
                {
                    MessageBox.Show("La descripción no puede estar vacía.");
                    return;
                }

                // Validación de precio de venta
                if (string.IsNullOrWhiteSpace(txtPrecioVenta.Text) || !decimal.TryParse(txtPrecioVenta.Text, out decimal precioVenta))
                {
                    MessageBox.Show("Por favor, ingrese un precio de venta válido.");
                    return;
                }

                entProductos nuevoProducto = new entProductos()
                {
                    CategoriaproductoID = Convert.ToInt32(txtIDCategoria.Text),
                    unidadMedidaID = medidaSeleccionada,
                    descripcion = txtDescripcion.Text,
                    precioVenta = Convert.ToDecimal(txtPrecioVenta.Text),
                    cantidad = 0,
                    fecha = DateTime.Now,
                    estado = chbx_Estado.Checked
                };

                bool resultado = logProductos.Instancia.InsertarProducto(nuevoProducto);

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

            ListarProductos();
            DialogResult = DialogResult.OK;  // Esto cierra el formulario y devuelve el resultado a FormPrincipal
            Close();
        }
        private int medidaSeleccionada = 0;
        private void cboUMedida_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBoxItem itemSeleccionado = cboUMedida.SelectedItem as ComboBoxItem;
            if (itemSeleccionado != null)
            {
                int idProducto = (int)itemSeleccionado.Tag;             
                MessageBox.Show("Producto seleccionado: " + itemSeleccionado.Text +
                                "\nID del producto: " + idProducto);
                medidaSeleccionada = idProducto;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }
    }
}
