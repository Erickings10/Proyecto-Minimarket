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
    public partial class ModuloRubro : Form
    {
        public ModuloRubro()
        {
            InitializeComponent();
            listaRubro();
            dgvRubros.ReadOnly = true;
            txtID.Enabled = false;
        }

        private void Encabezados()
        {
            dgvRubros.Columns["idRubro"].HeaderText = "ID";
            dgvRubros.Columns["nameRubro"].HeaderText = "Rubro";
            dgvRubros.Columns["estRubro"].HeaderText = "Estado";
        }
        public void listaRubro()
        {
            dgvRubros.DataSource = logRubroProv.Instancia.ListarRubro();
            Encabezados();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                entRubroProv rub = new entRubroProv();
                rub.nameRubro = txtRubro.Text.Trim();
                rub.estRubro = chbEstado.Checked;
                logRubroProv.Instancia.InsertaRubro(rub);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar" + ex);
            }
            Limpiar();
            listaRubro();
        }
        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                entRubroProv r = new entRubroProv();
                r.idRubro = int.Parse(txtID.Text.Trim());
                r.nameRubro = txtRubro.Text.Trim();
                r.estRubro = chbEstado.Checked;
                logRubroProv.Instancia.EditaRubro(r);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar" + ex);
            }
            Limpiar();
            listaRubro();
        }
        private void btnDeshabilitar_Click(object sender, EventArgs e)
        {
            try
            {
                entRubroProv r = new entRubroProv();
                r.idRubro = int.Parse(txtID.Text.Trim());
                chbEstado.Checked = false;
                r.estRubro = chbEstado.Checked;
                logRubroProv.Instancia.DeshabilitaRubro(r);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al deshabilitar" + ex);
            }
            Limpiar();
            listaRubro();
        }
        private void Limpiar() 
        {
            txtID.Text = " ";
            txtRubro.Text = " ";
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvRubros_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow fila = dgvRubros.Rows[e.RowIndex];
            txtID.Text = fila.Cells[0].Value.ToString();
            txtRubro.Text = fila.Cells[1].Value.ToString();
            chbEstado.Checked = Convert.ToBoolean(fila.Cells[2].Value);
        }
    }
}
