using CapaEntidad;
using CapaLogica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Printing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SoftwareMinimarket
{
    public partial class ModuloEntradaProductos : Form
    {
        private entProductos desProducto = new entProductos();
        private entNotaEntrada desnotaEntrada = new entNotaEntrada();
        //Fields
        private int borderRadius = 20;
        private int borderSize = 2;
        private Color borderColor = Color.RoyalBlue;
        public ModuloEntradaProductos()
        {
            InitializeComponent();
            ListarEntrada();
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
        private void ModuloEntradaProductos_MouseDown(object sender, MouseEventArgs e)
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
        private void ModuloEntradaProductos_Paint(object sender, PaintEventArgs e)
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
        private void ModuloEntradaProductos_ResizeEnd(object sender, EventArgs e)
        {
            this.Invalidate();
        }
        private void ModuloEntradaProductos_SizeChanged(object sender, EventArgs e)
        {
            this.Invalidate();
        }
        private void ModuloEntradaProductos_Activated(object sender, EventArgs e)
        {
            this.Invalidate();
        }
        //------------------------------------------------------------------------------------------
        private void btn_Registrar_Click(object sender, EventArgs e)
        {
            try
            {
                // Validación de ProductoID
                if (desProducto == null || desProducto.ProductoID <= 0)
                {
                    MessageBox.Show("Producto no válido. Seleccione un producto.");
                    return;
                }

                // Validación de cantidad
                if (string.IsNullOrWhiteSpace(txtCantidad.Text) || !int.TryParse(txtCantidad.Text, out int cantidad) || cantidad <= 0)
                {
                    MessageBox.Show("Por favor, ingrese una cantidad válida.");
                    return;
                }

                // Validación de TiendaID
                if (string.IsNullOrWhiteSpace(txtTienda.Text) || !int.TryParse(txtTienda.Text, out int tiendaID) || tiendaID <= 0)
                {
                    MessageBox.Show("Por favor, ingrese un ID de tienda válido.");
                    return;
                }

                // Validación de UsuarioID
                if (string.IsNullOrWhiteSpace(txtUsuario.Text) || !int.TryParse(txtUsuario.Text, out int usuarioID) || usuarioID <= 0)
                {
                    MessageBox.Show("Por favor, ingrese un ID de usuario válido.");
                    return;
                }

                // Validación de descripción
                if (string.IsNullOrWhiteSpace(txtDescripcion.Text))
                {
                    MessageBox.Show("La descripción no puede estar vacía.");
                    return;
                }

                entNotaEntrada nuevaNotaEntrada = new entNotaEntrada
                {
                    ProductoID = desProducto.ProductoID,
                    Cantidad = Convert.ToInt32(txtCantidad.Text),
                    TiendaID = Convert.ToInt32(txtTienda.Text),
                    Descripcion = txtDescripcion.Text,
                    UsuarioID = Convert.ToInt32(txtUsuario.Text),
                    Fecha = DateTime.Now,
                    Estado = chbx_Estado.Checked
                };

                bool resultado = logNotaEntrada.Instancia.InsertarNotaEntrada(nuevaNotaEntrada);

                if (resultado)
                {
                    MessageBox.Show("Nota de Entrada insertada con éxito");
                }
                else
                {
                    MessageBox.Show("Error al insertar Nota de Entrada");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }

            LimpiarVariables();

            ListarEntrada();
        }
        private void LimpiarVariables()
        {
            txtTienda.Text = "";
            txtUsuario.Text = "";
            txtDescripcion.Text = "";
            txtProducto.Text = "";
            txtCantidad.Text = "";
            chbx_Estado.Checked = false;
        }

        public void ListarEntrada()
        {
            dgvEntradaProductos.DataSource = logNotaEntrada.Instancia.ListarNotaEntrada();
        }

        private void AbrirReporteProductos()
        {
            using (FormReporteProductos formReporteProducto = new FormReporteProductos())
            {
                if (formReporteProducto.ShowDialog() == DialogResult.OK)
                {
                    desProducto = formReporteProducto.producto;
                    txtProducto.Text = desProducto.ProductoID.ToString();
                    txtDescripcion.Text = desProducto.descripcion;
                    txtTienda.Text = "1";
                    txtUsuario.Text = FormLogin.usuarioValido.id.ToString();
                }

            }
        }
        private void btn_Modificar_Click(object sender, EventArgs e)
        {
            try
            {
                entNotaEntrada notaEntrada = new entNotaEntrada
                {
                    NotaEntradaID = desnotaEntrada.NotaEntradaID,
                    ProductoID = Convert.ToInt32(txtProducto.Text),
                    Cantidad = Convert.ToInt32(txtCantidad.Text),
                    TiendaID = Convert.ToInt32(txtTienda.Text),
                    Descripcion = txtDescripcion.Text,
                    Fecha = DateTime.Now,
                    Estado = chbx_Estado.Checked,
                    UsuarioID = Convert.ToInt32(txtUsuario.Text)
                };

                bool resultado = logNotaEntrada.Instancia.ModificarNotaEntrada(notaEntrada);

                if (resultado)
                {
                    MessageBox.Show("Nota de entrada actualizada con éxito");
                }
                else
                {
                    MessageBox.Show("Error al actualizar la nota de entrada");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

            LimpiarVariables();
            ListarEntrada();
        }

        private void btnBuscarProducto_Click(object sender, EventArgs e)
        {
            AbrirReporteProductos();
        }

        private void dgvEntradaProductos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow filaActual = dgvEntradaProductos.Rows[e.RowIndex];

            desnotaEntrada.NotaEntradaID = Convert.ToInt32(filaActual.Cells[0].Value.ToString());
            desnotaEntrada.ProductoID = Convert.ToInt32(filaActual.Cells[1].Value.ToString());
            desnotaEntrada.Cantidad = Convert.ToInt32(filaActual.Cells[2].Value.ToString());
            desnotaEntrada.TiendaID = Convert.ToInt32(filaActual.Cells[3].Value.ToString());
            desnotaEntrada.Descripcion = filaActual.Cells[4].Value.ToString();
            desnotaEntrada.Fecha = Convert.ToDateTime(filaActual.Cells[5].Value.ToString());
            desnotaEntrada.Estado = Convert.ToBoolean(filaActual.Cells[6].Value.ToString());
            desnotaEntrada.UsuarioID = Convert.ToInt32(filaActual.Cells[7].Value.ToString());

            txtProducto.Text = desnotaEntrada.ProductoID.ToString();
            txtCantidad.Text = desnotaEntrada.Cantidad.ToString();
            txtDescripcion.Text = desnotaEntrada.Descripcion.ToString();
            txtTienda.Text = desnotaEntrada.TiendaID.ToString();
            txtUsuario.Text = desnotaEntrada.UsuarioID.ToString();
            chbx_Estado.Checked = desnotaEntrada.Estado;
        }
        private void btn_Deshabilitar_Click(object sender, EventArgs e)
        {
            try
            {

                bool resultado = logNotaEntrada.Instancia.DeshabilitarNotaEntrada(desnotaEntrada);

                if (resultado)
                {
                    MessageBox.Show("Nota de entrada deshabilitada con éxito");
                }
                else
                {
                    MessageBox.Show("Error al deshabilitar la nota de entrada");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            LimpiarVariables();
            ListarEntrada();
        }
        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            ModuloGerente MG = new ModuloGerente();
            MG.Show();
            this.Close();
        }
    }
}
