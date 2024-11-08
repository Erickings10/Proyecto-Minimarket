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
    public partial class FormOrdenCompra : Form
    {
        //Fields
        private int borderRadius = 20;
        private int borderSize = 2;
        private Color borderColor = Color.RoyalBlue;
        public FormOrdenCompra()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;

            txtCantidad.Enabled = false;
            txtTotal.Enabled = false;

            chkEstado.Checked = true;
            chkEstado.Enabled = false;

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
        private void FormOrdenCompra_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        private void panelTitleBar_MouseDown(object sender, MouseEventArgs e)
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
        private void FormOrdenCompra_Paint(object sender, PaintEventArgs e)
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
        private void FormOrdenCompra_ResizeEnd(object sender, EventArgs e)
        {
            this.Invalidate();
        }
        private void FormOrdenCompra_SizeChanged(object sender, EventArgs e)
        {
            this.Invalidate();
        }
        private void FormOrdenCompra_Activated(object sender, EventArgs e)
        {
            this.Invalidate();
        }
        //----------------------------------------------------------------------------------------------
        private void AbrirProveedor()
        {
            using (FormReporteProveedor FRP = new FormReporteProveedor())
            {
                if (FRP.ShowDialog() == DialogResult.OK)
                {
                    txtProveedorID.Text = FRP.idProv;
                }
            }
        }

        private void btnProveedor_Click(object sender, EventArgs e)
        {
            AbrirProveedor();

        }
        private void btnConfirmarOrden_Click(object sender, EventArgs e)
        {
            if (dgvSeleccion.Rows.Count < 1)
            {
                MessageBox.Show("No se ha seleccionado ningún requerimiento.", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            // Crear objeto para la Orden de Compra
            entOrdenCompra orden = new entOrdenCompra();
            orden.ProveedorID = Convert.ToInt32(txtProveedorID.Text);
            orden.Fecha = DateTime.Now;
            decimal montoTotal = 0;

            // Calcular el total sumando los precios de cada requerimiento
            foreach (DataGridViewRow fila in dgvSeleccion.Rows)
            {
                decimal precioRequerimiento = Decimal.Parse(fila.Cells[2].Value?.ToString());
                montoTotal += precioRequerimiento;
            }
            orden.Total = montoTotal;
            orden.Estado = chkEstado.Checked; // Asignar estado 

            // Llamada para insertar la Orden de Compra en la capa lógica
            if (logOrdenCompra.Instancia.InsertarOrdenCompra(ref orden))
            {
                // Iterar sobre las filas para insertar detalles de la Orden de Compra
                foreach (DataGridViewRow fila in dgvSeleccion.Rows)
                {
                    entDetalleOrdenCompra detalle = new entDetalleOrdenCompra();
                    detalle.OrdendecompraID = orden.OrdenCompraID;
                    detalle.RequerimientoID = int.Parse(fila.Cells[1].Value?.ToString());
                    detalle.Cantidad = int.Parse(txtCantidad.Text);
                    detalle.Precio = decimal.Parse(fila.Cells[2].Value?.ToString());

                    // Insertar el detalle en la capa lógica
                    logDetalleOrdenCompra.Instancia.InsertarDetOrdenCompra(detalle);
                }

                // Confirmación de la inserción
                MessageBox.Show("Orden de Compra creada exitosamente. ID de Orden: " + orden.OrdenCompraID, "CONFIRMACIÓN", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Error al crear la Orden de Compra.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            // Limpiar el formulario
            dgvSeleccion.Rows.Clear();
            txtProveedorID.Text = "";
            txtTotal.Text = "";
        }

        private int idTemporal = 1;
        private int cantidadActual = 0;
        private void btnAgregarReq_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtRequerimientoID.Text) ||
                string.IsNullOrEmpty(txtPrecioRequerimiento.Text) ||
                string.IsNullOrEmpty(txtProveedorID.Text))
            {
                MessageBox.Show("Por favor, complete todos los campos del requerimiento.", "ALERTA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Agregar el requerimiento al DataGridView
            dgvSeleccion.Rows.Add(idTemporal, txtRequerimientoID.Text, txtPrecioRequerimiento.Text, txtProveedorID.Text);

            // Incrementar los contadores de ID temporal y cantidad
            idTemporal++;
            cantidadActual++;

            int requerimientoID = int.Parse(txtRequerimientoID.Text);
            bool estado = false;
            logRequerimiento.Instancia.CambiarEstadoRequerimiento(requerimientoID, estado);

            // Limpiar los campos de texto
            txtRequerimientoID.Text = "";
            txtPrecioRequerimiento.Text = "";
            txtCantidad.Text = cantidadActual.ToString(); // Mostrar la cantidad incrementada

            // Calcular y mostrar el total
            CalcularTotal();          

        }
        private void CalcularTotal()
        {
            decimal total = 0;
            foreach (DataGridViewRow row in dgvSeleccion.Rows)
            {
                if (row.Cells[2].Value != null)
                {
                    decimal precioRequerimiento = Convert.ToDecimal(row.Cells[2].Value);
                    total += precioRequerimiento;
                }
            }
            txtTotal.Text = total.ToString("C2");
        }
        private void btnEliminarReq_Click(object sender, EventArgs e)
        {
            if (dgvSeleccion.SelectedRows.Count > 0)
            {
                int requerimientoID = Convert.ToInt32(dgvSeleccion.SelectedRows[0].Cells["RequerimientoID"].Value);
                bool estado = true;
                logRequerimiento.Instancia.CambiarEstadoRequerimiento(requerimientoID, estado);
                dgvSeleccion.Rows.RemoveAt(dgvSeleccion.SelectedRows[0].Index);
            }
            CalcularTotal();
        }
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            ModuloAbastecimiento abas = new ModuloAbastecimiento();
            abas.Show();
            this.Close();
        }
        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnRequerimiento_Click(object sender, EventArgs e)
        {
            using (FormRequerimientoList FRP = new FormRequerimientoList())
            {
                if (FRP.ShowDialog() == DialogResult.OK)
                {
                    txtRequerimientoID.Text = FRP.RequerimientoID;
                }
            }
        }
    }
}
