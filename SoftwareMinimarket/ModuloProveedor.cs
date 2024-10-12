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
    public partial class ModuloProveedor : Form
    {
        public string idProv { get; set; }
        public ModuloProveedor()
        {
            InitializeComponent();
            listarProveedores();
            txtID.Enabled = false;
            dgvProveedores.ReadOnly = true;
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
        
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                entProveedor p = new entProveedor();
                p.rucProv = Convert.ToInt64(txtRUC.Text);
                p.idRubro = Convert.ToInt32(cbxRubro.SelectedValue);
                p.ubiProv = int.Parse(txtUbigeo.Text);
                p.nameProv = txtNombre.Text;
                p.telfProv = Convert.ToInt64(txtTelefono.Text);
                p.fechaProv = dtpFecha.Value;
                p.estProv = cbxEstado.Checked;
                logProveedor.Instancia.InsertaProveedor(p);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar.." + ex);
            }
            Limpiar();
            listarProveedores();
        }
        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                entProveedor p = new entProveedor();
                p.idProv = int.Parse(txtID.Text.Trim());
                p.rucProv = Convert.ToInt64(txtRUC.Text);
                p.idRubro = Convert.ToInt32(cbxRubro.SelectedValue);
                p.ubiProv = int.Parse(txtUbigeo.Text);
                p.nameProv = txtNombre.Text;
                p.telfProv = Convert.ToInt64(txtTelefono.Text);
                p.fechaProv = dtpFecha.Value;
                p.estProv = cbxEstado.Checked;
                logProveedor.Instancia.EditaProveedor(p);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al modificar..." + ex);
            }
            Limpiar();
            listarProveedores();
        }
        private void btnDeshabilitar_Click(object sender, EventArgs e)
        {
            try
            {
                entProveedor p = new entProveedor();
                p.idProv = int.Parse(txtID.Text.Trim());
                cbxEstado.Checked = false;
                p.estProv = cbxEstado.Checked;
                logProveedor.Instancia.DeshabilitaProveedor(p);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al deshabilitar..." + ex);
            }
            Limpiar();
            listarProveedores();
        }
        private void Limpiar() 
        {
            txtID.Text = " ";
            txtRUC.Text = " ";
            txtUbigeo.Text = " ";
            txtNombre.Text = " ";
            txtTelefono.Text = " ";

        }

        private void ListadeRubros() 
        {
            var rubro = logRubroProv.Instancia.ListaDeRubros();
            cbxRubro.DataSource = rubro;
            cbxRubro.DisplayMember = "idRubro";
            cbxRubro.ValueMember = "TipoproveedorID";
        }
        private void btnNuevoRubro_Click(object sender, EventArgs e)
        {
            ModuloRubro fr = new ModuloRubro();
            fr.Show();
        }

        private void FormProveedor_Load(object sender, EventArgs e)
        {
            ListadeRubros();
        }

        private void dgvProveedores_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow fila = dgvProveedores.Rows[e.RowIndex];
            txtID.Text = fila.Cells[0].Value.ToString();
            txtRUC.Text = fila.Cells[1].Value.ToString();
            cbxRubro.Text = fila.Cells[2].Value.ToString();
            txtUbigeo.Text = fila.Cells[3].Value.ToString();
            txtNombre.Text = fila.Cells[4].Value.ToString();
            txtTelefono.Text = fila.Cells[5].Value.ToString();
            dtpFecha.Text = fila.Cells[6].Value.ToString();
            cbxEstado.Checked = Convert.ToBoolean(fila.Cells[7].Value);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
