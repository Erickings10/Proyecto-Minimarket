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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SoftwareMinimarket
{
    public partial class ModuloAgregarProducto : Form
    {
        //Fields
        private int borderRadius = 20;
        private int borderSize = 2;
        private Color borderColor = Color.RoyalBlue;
        public ModuloAgregarProducto()
        {
            InitializeComponent();
            ListarProductos();
            ListarMedidas();
            this.StartPosition = FormStartPosition.CenterScreen;
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
        private void ModuloAgregarProducto_MouseDown(object sender, MouseEventArgs e)
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

        private void ModuloAgregarProducto_Paint(object sender, PaintEventArgs e)
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
        private void ModuloAgregarProducto_ResizeEnd(object sender, EventArgs e)
        {
            this.Invalidate();
        }
        private void ModuloAgregarProducto_SizeChanged(object sender, EventArgs e)
        {
            this.Invalidate();
        }
        private void ModuloAgregarProducto_Activated(object sender, EventArgs e)
        {
            this.Invalidate();
        }
        //-----------------------------------------------------------------------------------------------
        private void FormAgregarProducto_Load(object sender, EventArgs e)
        {

        }

        private void LimpiarVariables()
        {
            txtPrecioVenta.Text = "";
            txtDescripcion.Text = "";
            txtCategoriaID.Text = "";
            chbx_Estado.Checked = false;
        }
        private void btnAbrirCat_Click(object sender, EventArgs e)
        {
            AbrirReporteCategoria();
        }
        private void AbrirReporteCategoria()
        {
            using (FormReporteCategorias forReporteCategorias = new FormReporteCategorias())
            {
                if (forReporteCategorias.ShowDialog() == DialogResult.OK)
                {
                    txtIDCategoria.Text= forReporteCategorias.categoria.CategoriaID.ToString();
                }
            }
        }
        private void btnAbrirUdMed_Click(object sender, EventArgs e)
        {
            AbrirAgregarMedida();
        }
        private void AbrirAgregarMedida()
        {
            using (ModuloMedidaProducto moduloAgregarMedida = new ModuloMedidaProducto())
            {
                if (moduloAgregarMedida.ShowDialog() == DialogResult.OK)
                {
                    ListarMedidas();
                }
            }
        }
        public class ComboBoxItem
        {
            public string Text { get; set; } 
            public object Tag { get; set; }

            public override string ToString()
            {
                return Text;
            }
        }

        public void ListarMedidas()
        {
            for (int i = 0; i < logUdMedida.Instancia.ListarMedidaProducto().Count; i++)
            {
                ComboBoxItem item = new ComboBoxItem();
                item.Text = logUdMedida.Instancia.ListarMedidaProducto()[i].Descripcion;

                // Guardar el ID del producto en la propiedad Tag del item
                item.Tag = logUdMedida.Instancia.ListarMedidaProducto()[i].UnidadmedidaID;

                // Agregar el item al ComboBox
                cboUMedida.Items.Add(item);
            }
        }
        public void ListarProductos()
        {
            dgvProductos.DataSource = logProductos.Instancia.ListarProductos();
            CambiarEncabezados();
        }
        private void CambiarEncabezados() 
        {
            dgvProductos.Columns["ProductoID"].HeaderText = "ID Producto";
            dgvProductos.Columns["CategoriaproductoID"].HeaderText = "ID Categoria";
            dgvProductos.Columns["unidadMedidaID"].HeaderText = "ID Medida";
            dgvProductos.Columns["descripcion"].HeaderText = "Descripcion";
            dgvProductos.Columns["precioVenta"].HeaderText = "Venta";
            dgvProductos.Columns["cantidad"].HeaderText = "Cantidad";
            dgvProductos.Columns["fecha"].HeaderText = "Fecha";
            dgvProductos.Columns["estado"].HeaderText = "Estado";
        }
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                // Validación de ID de categoría
                if (string.IsNullOrWhiteSpace(txtIDCategoria.Text) || !int.TryParse(txtIDCategoria.Text, out int categoriaID))
                {
                    MessageBox.Show("Por favor, ingrese un ID de categoría válido.");
                    return;
                }

                // Validación de unidad de medida seleccionada
                if (medidaSeleccionada <= 0)
                {
                    MessageBox.Show("Por favor, seleccione una unidad de medida válida.");
                    return;
                }

                // Validación de descripción
                if (string.IsNullOrWhiteSpace(txtDescripcion.Text))
                {
                    MessageBox.Show("La descripción no puede estar vacía.");
                    return;
                }

                // Validación de precio de venta
                if (string.IsNullOrWhiteSpace(txtPrecioVenta.Text) || !decimal.TryParse(txtPrecioVenta.Text, out decimal precioVenta))
                {
                    MessageBox.Show("Por favor, ingrese un precio de venta válido.");
                    return;
                }

                entProductos nuevoProducto = new entProductos()
                {
                    CategoriaproductoID = Convert.ToInt32(txtIDCategoria.Text),
                    unidadMedidaID = medidaSeleccionada,
                    descripcion = txtDescripcion.Text,
                    precioVenta = Convert.ToDecimal(txtPrecioVenta.Text),
                    cantidad = 0,
                    fecha = DateTime.Now,
                    estado = chbx_Estado.Checked
                };

                bool resultado = logProductos.Instancia.InsertarProducto(nuevoProducto);

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

            ListarProductos();
            DialogResult = DialogResult.OK;  // Esto cierra el formulario y devuelve el resultado a FormPrincipal
            Close();
        }
        private int medidaSeleccionada = 0;
        private void cboUMedida_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBoxItem itemSeleccionado = cboUMedida.SelectedItem as ComboBoxItem;
            if (itemSeleccionado != null)
            {
                int idProducto = (int)itemSeleccionado.Tag;             
                MessageBox.Show("Producto seleccionado: " + itemSeleccionado.Text +
                                "\nID del producto: " + idProducto);
                medidaSeleccionada = idProducto;
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
