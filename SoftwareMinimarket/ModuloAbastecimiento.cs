using CapaEntidad;
using CapaLogica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SoftwareMinimarket
{
    public partial class ModuloAbastecimiento : Form
    {
        //Fields
        private int borderRadius = 20;
        private int borderSize = 2;
        private Color borderColor = Color.RoyalBlue;
        public ModuloAbastecimiento()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            CMBPrioridad();
            txtID.Enabled = false;
            txtProducto.ReadOnly = true;
            this.FormBorderStyle = FormBorderStyle.None;
            this.Padding = new Padding(borderSize);
            this.panelTitleBar.BackColor = borderColor;
            this.BackColor = borderColor;
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.Style |= 0x20000;
                return cp;
            }
        }
        private void panelTitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        private void ModuloAbastecimiento_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        private GraphicsPath GetRoundedPath(Rectangle rect, float radius)
        {
            GraphicsPath path = new GraphicsPath();
            float curveSize = radius * 2F;
            path.StartFigure();
            path.AddArc(rect.X, rect.Y, curveSize, curveSize, 180, 90);
            path.AddArc(rect.Right - curveSize, rect.Y, curveSize, curveSize, 270, 90);
            path.AddArc(rect.Right - curveSize, rect.Bottom - curveSize, curveSize, curveSize, 0, 90);
            path.AddArc(rect.X, rect.Bottom - curveSize, curveSize, curveSize, 90, 90);
            path.CloseFigure();
            return path;
        }

        private void FormRegionAndBorder(Form form, float radius, Graphics graph, Color borderColor, float borderSize)
        {
            if (this.WindowState != FormWindowState.Minimized)
            {
                using (GraphicsPath roundPath = GetRoundedPath(form.ClientRectangle, radius))
                using (Pen penBorder = new Pen(borderColor, borderSize))
                using (Matrix transform = new Matrix())
                {
                    graph.SmoothingMode = SmoothingMode.AntiAlias;
                    form.Region = new Region(roundPath);
                    if (borderSize >= 1)
                    {
                        Rectangle rect = form.ClientRectangle;
                        float scaleX = 1.0F - ((borderSize + 1) / rect.Width);
                        float scaleY = 1.0F - ((borderSize + 1) / rect.Height);
                        transform.Scale(scaleX, scaleY);
                        transform.Translate(borderSize / 1.6F, borderSize / 1.6F);
                        graph.Transform = transform;
                        graph.DrawPath(penBorder, roundPath);
                    }
                }
            }
        }

        private void ControlRegionAndBorder(Control control, float radius, Graphics graph, Color borderColor)
        {
            using (GraphicsPath roundPath = GetRoundedPath(control.ClientRectangle, radius))
            using (Pen penBorder = new Pen(borderColor, 1))
            {
                graph.SmoothingMode = SmoothingMode.AntiAlias;
                control.Region = new Region(roundPath);
                graph.DrawPath(penBorder, roundPath);
            }
        }

        private void DrawPath(Rectangle rect, Graphics graph, Color color)
        {
            using (GraphicsPath roundPath = GetRoundedPath(rect, borderRadius))
            using (Pen penBorder = new Pen(color, 3))
            {
                graph.DrawPath(penBorder, roundPath);
            }
        }

        private struct FormBoundsColors
        {
            public Color TopLeftColor;
            public Color TopRightColor;
            public Color BottomLeftColor;
            public Color BottomRightColor;
        }
        private FormBoundsColors GetFormBoundsColors()
        {
            var fbColor = new FormBoundsColors();
            using (var bmp = new Bitmap(1, 1))
            using (Graphics graph = Graphics.FromImage(bmp))
            {
                Rectangle rectBmp = new Rectangle(0, 0, 1, 1);
                //Top Left
                rectBmp.X = this.Bounds.X - 1;
                rectBmp.Y = this.Bounds.Y;
                graph.CopyFromScreen(rectBmp.Location, Point.Empty, rectBmp.Size);
                fbColor.TopLeftColor = bmp.GetPixel(0, 0);
                //Top Right
                rectBmp.X = this.Bounds.Right;
                rectBmp.Y = this.Bounds.Y;
                graph.CopyFromScreen(rectBmp.Location, Point.Empty, rectBmp.Size);
                fbColor.TopRightColor = bmp.GetPixel(0, 0);
                //Bottom Left
                rectBmp.X = this.Bounds.X;
                rectBmp.Y = this.Bounds.Bottom;
                graph.CopyFromScreen(rectBmp.Location, Point.Empty, rectBmp.Size);
                fbColor.BottomLeftColor = bmp.GetPixel(0, 0);
                //Bottom Right
                rectBmp.X = this.Bounds.Right;
                rectBmp.Y = this.Bounds.Bottom;
                graph.CopyFromScreen(rectBmp.Location, Point.Empty, rectBmp.Size);
                fbColor.BottomRightColor = bmp.GetPixel(0, 0);
            }
            return fbColor;
        }
        private void panelContainer_Paint(object sender, PaintEventArgs e)
        {
            ControlRegionAndBorder(panelContainer, borderRadius - (borderSize / 2), e.Graphics, borderColor);
        }
        private void ModuloAbastecimiento_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            Rectangle rectForm = this.ClientRectangle;
            int mWidht = rectForm.Width / 2;
            int mHeight = rectForm.Height / 2;
            var fbColors = GetFormBoundsColors();
            //Top Left
            DrawPath(rectForm, e.Graphics, fbColors.TopLeftColor);

            //Top Right
            Rectangle rectTopRight = new Rectangle(mWidht, rectForm.Y, mWidht, mHeight);
            DrawPath(rectTopRight, e.Graphics, fbColors.TopRightColor);

            //Bottom Left
            Rectangle rectBottomLeft = new Rectangle(rectForm.X, rectForm.X + mHeight, mWidht, mHeight);
            DrawPath(rectBottomLeft, e.Graphics, fbColors.BottomLeftColor);

            //Bottom Right
            Rectangle rectBottomRight = new Rectangle(mWidht, rectForm.Y + mHeight, mWidht, mHeight);
            DrawPath(rectBottomRight, e.Graphics, fbColors.BottomRightColor);

            FormRegionAndBorder(this, borderRadius, e.Graphics, borderColor, borderSize);
        }
        private void ModuloAbastecimiento_ResizeEnd(object sender, EventArgs e)
        {
            this.Invalidate();
        }
        private void ModuloAbastecimiento_SizeChanged(object sender, EventArgs e)
        {
            this.Invalidate();
        }
        private void ModuloAbastecimiento_Activated(object sender, EventArgs e)
        {
            this.Invalidate();
        }
        //-----------------------------------------------------------------------------------------------
        private void CMBPrioridad() 
        {
            string[] prioridad = {"Alta", "Media", "Baja" };
            cmbPrior.DataSource = prioridad;
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
        private void btnRegistrarReque_Click(object sender, EventArgs e)
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
        private void btnAgregarProd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtProducto.Text) ||
                string.IsNullOrEmpty(txtCantidad.Text) ||
                string.IsNullOrEmpty(cmbPrior.SelectedItem.ToString()))
            {
                MessageBox.Show("Complete todos los campos", "ALERTA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            dgvDetalleRequerimiento.Rows.Add(idTemporal, txtProducto.Text, txtCantidad.Text, cmbPrior.SelectedItem.ToString());
            idTemporal++;

            txtProducto.Text = "";
            txtCantidad.Text = "";
            cmbPrior.SelectedIndex = -1;
        }
        private void dgvDetalleRequerimiento_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow fila = dgvDetalleRequerimiento.Rows[e.RowIndex];
            txtID.Text = fila.Cells[0].Value.ToString();
            txtProducto.Text = fila.Cells[1].Value.ToString();
            txtCantidad.Text = fila.Cells[2].Value.ToString();
            cmbPrior.Text = fila.Cells[3].Value.ToString();
        }

        private void ModuloAbastecimiento_Load(object sender, EventArgs e)
        {
            dgvDetalleRequerimiento.AllowUserToAddRows = false;
        }
        private void btnMostrarDetalle_Click(object sender, EventArgs e)
        {
            FormDetalleRequerimiento formdr = new FormDetalleRequerimiento();
            formdr.Show();
        }
        private void btnAbrirOC_Click(object sender, EventArgs e)
        {
            FormOrdenCompra orden = new FormOrdenCompra();
            orden.Show();
            this.Close();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            ModuloGerente MG = new ModuloGerente();
            MG.Show();
            this.Close();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }


    }
}
