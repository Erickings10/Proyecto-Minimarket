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
    public partial class FormReporteProveedor : Form
    {
        public string idProv { get; set; }
        public FormReporteProveedor()
        {
            InitializeComponent();
            listarProveedores();
        }
        private void CambiarEncabezados()
        {
            dgvProveedores.Columns["idProv"].HeaderText = "ID";
            dgvProveedores.Columns["rucProv"].HeaderText = "RUC";
            dgvProveedores.Columns["idRubro"].HeaderText = "Rubro";
            dgvProveedores.Columns["ubiProv"].HeaderText = "Ubigeo";
            dgvProveedores.Columns["nameProv"].HeaderText = "Nombre";
            dgvProveedores.Columns["telfProv"].HeaderText = "Telefono";
            dgvProveedores.Columns["fechaProv"].HeaderText = "Fecha";
            dgvProveedores.Columns["estProv"].HeaderText = "Estado";
        }
        public void listarProveedores()
        {
            dgvProveedores.DataSource = logProveedor.Instancia.ListarProveedor();
            CambiarEncabezados();
        }

        private void dgvProveedores_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow fila = dgvProveedores.Rows[e.RowIndex];
            idProv = fila.Cells[0].Value.ToString();

            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnAgregarProveedor_Click(object sender, EventArgs e)
        {
            ModuloProveedor pro = new ModuloProveedor();
            pro.Show();
            this.Close();
        }
    }
}
