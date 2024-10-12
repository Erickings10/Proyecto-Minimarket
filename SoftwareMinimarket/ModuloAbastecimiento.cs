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
    public partial class ModuloAbastecimiento : Form
    {
        public ModuloAbastecimiento()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            CMBPrioridad();
            txtID.Enabled = false;
            txtProducto.ReadOnly = true;
        }
        private void CMBPrioridad() 
        {
            string[] prioridad = {"Alta", "Media", "Baja" }; 
            cmbPrioridad.DataSource = prioridad;
        }

        private void btn_regresar_Click(object sender, EventArgs e)
        {
            ModuloGerente MG = new ModuloGerente();
            MG.Show();
            this.Close();
        }
        private void AbrirProductoBajoStock() 
        {
            using (FormProductoBajoStock pbs = new FormProductoBajoStock()) 
            {
                if (pbs.ShowDialog() == DialogResult.OK) 
                {
                    txtProducto.Text = pbs.productoID;   
                }
            }
        }
        private void btnBajoStock_Click(object sender, EventArgs e)
        {
            AbrirProductoBajoStock();
        }

        private void btnRegistrarReq_Click(object sender, EventArgs e)
        {
            if (dgvDetalleRequerimiento.Rows.Count < 1)
            {
                MessageBox.Show("No se ha agregado ningún producto al requerimiento.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            entRequerimiento req = new entRequerimiento();
            req.UsuarioID = 1;
            req.Fecha = DateTime.Now;
            req.Estado = chbEstado.Checked;

            if (logRequerimiento.Instancia.InsertarRequerimiento(ref req))
            {
                foreach (DataGridViewRow fila in dgvDetalleRequerimiento.Rows)
                {
                    entDetalleRequerimiento detReq = new entDetalleRequerimiento();
                    detReq.RequerimientoID = req.RequerimientoID;
                    detReq.ProductoID = Convert.ToInt32(fila.Cells["Producto"].Value);
                    detReq.Cantidad = Convert.ToInt32(fila.Cells["Cantidad"].Value);
                    detReq.Prioridad = fila.Cells["Prioridad"].Value.ToString();

                    logDetalleRequerimiento.Instancia.InsertarDetalleRequerimiento(detReq);
                }

                MessageBox.Show("Requerimiento registrado con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                dgvDetalleRequerimiento.Rows.Clear();
            }
            else 
            {
                MessageBox.Show("Error al registrar el requerimiento.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
        
        private int idTemporal = 1;
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtProducto.Text) || 
                string.IsNullOrEmpty(txtCantidad.Text) ||
                string.IsNullOrEmpty(cmbPrioridad.SelectedItem.ToString())) 
            {
                MessageBox.Show("Complete todos los campos", "ALERTA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            dgvDetalleRequerimiento.Rows.Add(idTemporal, txtProducto.Text, txtCantidad.Text, cmbPrioridad.SelectedItem.ToString());
            idTemporal++;

            txtProducto.Text = "";
            txtCantidad.Text = "";
            cmbPrioridad.SelectedIndex = -1;
        }
        private void dgvDetalleRequerimiento_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow fila = dgvDetalleRequerimiento.Rows[e.RowIndex];
            txtID.Text = fila.Cells[0].Value.ToString();
            txtProducto.Text = fila.Cells[1].Value.ToString();
            txtCantidad.Text = fila.Cells[2].Value.ToString();
            cmbPrioridad.Text = fila.Cells[3].Value.ToString();
        }

        private void ModuloAbastecimiento_Load(object sender, EventArgs e)
        {
            dgvDetalleRequerimiento.AllowUserToAddRows = false;
        }

        private void btnMostrarDet_Click(object sender, EventArgs e)
        {
            FormDetalleRequerimiento formdr = new FormDetalleRequerimiento();
            formdr.Show();
        }

        private void btnMostrarOC_Click(object sender, EventArgs e)
        {
            FormOrdenCompra orden = new FormOrdenCompra();
            orden.Show();
            this.Close();
        }
    }
}
