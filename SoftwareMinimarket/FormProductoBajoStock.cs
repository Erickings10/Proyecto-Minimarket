using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaEntidad;
using CapaLogica;

namespace SoftwareMinimarket
{
    public partial class FormProductoBajoStock : Form
    {
        public string productoID { get; private set; }
        public FormProductoBajoStock()
        {
            InitializeComponent();
            Listar();
        }
        public void Listar() 
        {
            dgvBajoStock.DataSource = logProductos.Instancia.ListarProductos();
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            try
            {
                int cantidadlimite = int.Parse(txtCantidad.Text);
                dgvBajoStock.DataSource = logProductos.Instancia.ListarProductosBajoStock(cantidadlimite);
                txtCantidad.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: Ingrese un numero " + ex.Message);
            }
        }

        private void dgvBajoStock_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow fila = dgvBajoStock.Rows[e.RowIndex];
            productoID = fila.Cells[0].Value.ToString();
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
