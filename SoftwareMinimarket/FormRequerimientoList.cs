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
    public partial class FormRequerimientoList : Form
    {
        public string RequerimientoID { get; set; }
        public FormRequerimientoList()
        {
            InitializeComponent();
            ListarRequerimientos();
        }

        private void dgvSeleccion_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow fila = dgvReq.Rows[e.RowIndex];
            RequerimientoID = fila.Cells[0].Value.ToString();

            DialogResult = DialogResult.OK;
            Close();
        }
        public void ListarRequerimientos()
        {
            dgvReq.DataSource = logRequerimiento.Instancia.ListarRequerimientos();
        }
    }
}
