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
    public partial class FormReporteCategorias : Form
    {
        public entCategoria categoria = new entCategoria();
        public FormReporteCategorias()
        {
            InitializeComponent();
            ListarCategorias();
        }
        public void ListarCategorias()
        {
            dgvReporteCategorias.DataSource = logCategoria.Instancia.ListarCategoria();
        }

        private void dgvReporteCategorias_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                categoria.CategoriaID = Convert.ToInt32(dgvReporteCategorias.Rows[e.RowIndex].Cells[0].Value.ToString());
                categoria.Descripcion = dgvReporteCategorias.Rows[e.RowIndex].Cells[1].Value.ToString();
                categoria.Estado = Convert.ToBoolean(dgvReporteCategorias.Rows[e.RowIndex].Cells[2].Value);

                DialogResult = DialogResult.OK;  // Esto cierra el formulario y devuelve el resultado a FormPrincipal
                Close();
            }
        }

        private void btnAgregarCategoria_Click(object sender, EventArgs e)
        {
            AbrirAgregarCategoria();
        }
        private void AbrirAgregarCategoria()
        {
            using (ModuloCategoriaProducto formCategoria = new ModuloCategoriaProducto())
            {
                if (formCategoria.ShowDialog() == DialogResult.OK)
                {
                    ListarCategorias();
                }
            }
        }
    }
}
