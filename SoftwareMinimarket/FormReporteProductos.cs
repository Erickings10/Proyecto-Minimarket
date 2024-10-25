using CapaEntidad;
using CapaLogica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SoftwareMinimarket
{
    public partial class FormReporteProductos : Form
    {
        public entProductos producto = new entProductos();
        public FormReporteProductos()
        {
            InitializeComponent();
            ListarProductos();
        }

        public void ListarProductos()
        {
            dgvReporteProductos.DataSource = logProductos.Instancia.ListarProductos();
        }

        private void dgvReporteProductos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                producto.ProductoID = Convert.ToInt32(dgvReporteProductos.Rows[e.RowIndex].Cells[0].Value.ToString());
                producto.CategoriaproductoID = Convert.ToInt32(dgvReporteProductos.Rows[e.RowIndex].Cells[1].Value.ToString());
                producto.descripcion = dgvReporteProductos.Rows[e.RowIndex].Cells[3].Value.ToString();
                producto.unidadMedidaID = Convert.ToInt32(dgvReporteProductos.Rows[e.RowIndex].Cells[2].Value.ToString());
                producto.precioVenta = Convert.ToDecimal(dgvReporteProductos.Rows[e.RowIndex].Cells[4].Value.ToString());
                producto.cantidad = Convert.ToInt32(dgvReporteProductos.Rows[e.RowIndex].Cells[5].Value.ToString());
                producto.fecha = Convert.ToDateTime(dgvReporteProductos.Rows[e.RowIndex].Cells[6].Value.ToString());
                producto.estado = Convert.ToBoolean(dgvReporteProductos.Rows[e.RowIndex].Cells[7].Value.ToString());

                DialogResult = DialogResult.OK;  // Esto cierra el formulario y devuelve el resultado a FormPrincipal
                Close();
            }          
        }

        private void btnAgregarProducto_Click(object sender, EventArgs e)
        {
            AbrirAgregarProducto();
        }
        private void AbrirAgregarProducto()
        {
            using (ModuloAgregarProducto formAgregarProducto = new ModuloAgregarProducto())
            {
                if (formAgregarProducto.ShowDialog() == DialogResult.OK)
                {
                    ListarProductos();
                }
            }
        }
    }
}
