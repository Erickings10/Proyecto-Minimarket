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
    public partial class ModuloVentas : Form
    {
        private List<entProductos> listaProductos = new List<entProductos>();

        //Fields
        private int borderRadius = 20;
        private int borderSize = 2;
        private Color borderColor = Color.RoyalBlue;
        public ModuloVentas()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            CargarComboBoxClientes();
            CargarComboBoxMetodosPago();
            ConfigurarAutocompletarProductos();
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
        private void ModuloVentas_MouseDown(object sender, MouseEventArgs e)
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
        private void ModuloVentas_Paint(object sender, PaintEventArgs e)
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
        private void ModuloVentas_ResizeEnd(object sender, EventArgs e)
        {
            this.Invalidate();
        }
        private void ModuloVentas_SizeChanged(object sender, EventArgs e)
        {
            this.Invalidate();
        }
        private void ModuloVentas_Activated(object sender, EventArgs e)
        {
            this.Invalidate();
        }
        //-------------------------------------------------------------------------------------------------
        private void CargarComboBoxClientes()
        {
            try
            {
                List<entCliente> listaClientes = logCliente.Instancia.ListarClientes();

                cbClientes.DataSource = listaClientes;
                cbClientes.DisplayMember = "NombreCompleto";
                cbClientes.ValueMember = "ClienteID";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        private void CargarComboBoxMetodosPago()
        {
            try
            {
                List<entMetodoPago> listaMetodosPago = logMetodoPago.Instancia.ListarMetodoPago();

                cbMetodoPago.DataSource = listaMetodosPago;
                cbMetodoPago.DisplayMember = "Descripcion";
                cbMetodoPago.ValueMember = "MetododepagoID";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        private void ConfigurarAutocompletarProductos()
        {
            try
            {
                List<entProductos> listaProductos = logProductos.Instancia.ListarProductos();

                AutoCompleteStringCollection coleccionProductos = new AutoCompleteStringCollection();

                foreach (var producto in listaProductos)
                {
                    coleccionProductos.Add(producto.descripcion);
                }

                // Configurar el TextBox para usar el autocompletado
                txtProducto.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                txtProducto.AutoCompleteSource = AutoCompleteSource.CustomSource;
                txtProducto.AutoCompleteCustomSource = coleccionProductos;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al configurar el autocompletado: " + ex.Message);
            }
        }
        private void btnNewCliente_Click(object sender, EventArgs e)
        {
            AbrirAgregarCliente();
        }
        private void AbrirAgregarCliente()
        {
            using (FormAgregarCliente formAgregarCliente = new FormAgregarCliente())
            {
                if (formAgregarCliente.ShowDialog() == DialogResult.OK)
                {
                    CargarComboBoxClientes();
                }
            }
        }
        private void btnAgregarProd_Click(object sender, EventArgs e)
        {
            if (txtProducto.Text == "" ||
                Convert.ToInt32(nupCantidad.Value) <= 0)
            {
                MessageBox.Show("Por favor, ingresa datos válidos.");
                return;
            }

            entProductos nuevoProducto = new entProductos()
            {
                descripcion = txtProducto.Text,
                cantidad = Convert.ToInt32(nupCantidad.Value),
                precioVenta = logProductos.Instancia.BuscarProductoPorNombre(txtProducto.Text).precioVenta
            };
            listaProductos.Add(nuevoProducto);

            dgvResumenVenta.DataSource = null; // Para evitar problemas de enlazado
            dgvResumenVenta.DataSource = listaProductos.Select(p => new
            {
                p.descripcion,
                p.cantidad,
                p.precioVenta,
                Subtotal = p.precioVenta * p.cantidad
            }).ToList();

            decimal totalVenta = 0;
            foreach (DataGridViewRow row in dgvResumenVenta.Rows)
            {
                if (row.Cells["Subtotal"].Value != null)
                {
                    totalVenta += Convert.ToDecimal(row.Cells["Subtotal"].Value);
                }
            }
            txtTotalVenta.Text = totalVenta.ToString("F2");

            txtProducto.Clear();
            nupCantidad.Value = 0;
        }
        private void btnConfirmarVenta_Click(object sender, EventArgs e)
        {
            entVenta venta = new entVenta()
            {
                UsuarioID = FormLogin.usuarioValido.id,
                ClienteID = (int)cbClientes.SelectedValue,
                MetodoPagoID = (int)cbMetodoPago.SelectedValue,
                Fecha = DateTime.Now,
                Total = decimal.Parse(txtTotalVenta.Text)
            };

            List<entDetalleVenta> detallesVenta = new List<entDetalleVenta>();

            foreach (DataGridViewRow row in dgvResumenVenta.Rows)
            {
                entDetalleVenta detalle = new entDetalleVenta()
                {
                    ProductoID = logProductos.Instancia.BuscarProductoPorNombre(Convert.ToString(row.Cells["descripcion"].Value)).ProductoID,
                    Cantidad = Convert.ToInt32(row.Cells["cantidad"].Value),
                    PrecioUnitario = Convert.ToDecimal(row.Cells["precioVenta"].Value)
                };
                detallesVenta.Add(detalle);
            }

            bool resultado = logVenta.Instancia.RegistrarVenta(venta, detallesVenta);

            if (resultado)
            {
                MessageBox.Show("Venta registrada exitosamente");
            }
            else
            {
                MessageBox.Show("Ocurrió un error al registrar la venta");
            }
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
