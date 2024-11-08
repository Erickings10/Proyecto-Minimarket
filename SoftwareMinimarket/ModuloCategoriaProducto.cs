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
    public partial class ModuloCategoriaProducto : Form
    {
        entCategoria desCategoria = new entCategoria();
        //Fields
        private int borderRadius = 20;
        private int borderSize = 2;
        private Color borderColor = Color.RoyalBlue;
        public ModuloCategoriaProducto()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            dgvCategoriaProducto.ReadOnly = true;
            ListarCategoria();
            CambiarEncabezados();
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
        private void ModuloCategoriaProducto_MouseDown(object sender, MouseEventArgs e)
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

        private void ModuloCategoriaProducto_Paint(object sender, PaintEventArgs e)
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
        private void ModuloCategoriaProducto_ResizeEnd(object sender, EventArgs e)
        {
            this.Invalidate();
        }
        private void ModuloCategoriaProducto_SizeChanged(object sender, EventArgs e)
        {
            this.Invalidate();
        }
        private void ModuloCategoriaProducto_Activated(object sender, EventArgs e)
        {
            this.Invalidate();
        }
        //----------------------------------------------------------------------------------------------
        private void btn_Agregar_Click(object sender, EventArgs e)
        {
            try
            {

                if (string.IsNullOrWhiteSpace(txtDescripcion.Text))
                {
                    MessageBox.Show("Por favor, ingresa una descripción para la categoría.");
                    return;
                }


                entCategoria categoria = new entCategoria
                {
                    Descripcion = txtDescripcion.Text.Trim(),
                    Estado = chbxEstado.Checked
                };


                logCategoria.Instancia.InsertarCategoria(categoria);
                MessageBox.Show("Categoría de producto agregada exitosamente.");


                ListarCategoria();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar la categoría: " + ex.Message);
            }
            Limpiar();
            DialogResult = DialogResult.OK;  // Esto cierra el formulario y devuelve el resultado a FormPrincipal
            Close();
        }
        private void btn_Modificar_Click(object sender, EventArgs e)
        {
            try
            {
                entCategoria categoria = new entCategoria();
                categoria.CategoriaID = desCategoria.CategoriaID;
                categoria.Descripcion = txtDescripcion.Text.Trim();
                categoria.Estado = chbxEstado.Checked;
                logCategoria.Instancia.ModificarCategoria(categoria);
                MessageBox.Show("Categoría modificada exitosamente.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al modificar: " + ex.Message);
            }
            Limpiar();
            ListarCategoria();
        }
        private void btn_Deshabilitar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvCategoriaProducto.SelectedRows.Count > 0)
                {
                    int categoriaId = Convert.ToInt32(dgvCategoriaProducto.SelectedRows[0].Cells["CategoriaID"].Value);
                    entCategoria categoria = new entCategoria
                    {
                        CategoriaID = categoriaId
                    };


                    logCategoria.Instancia.DeshabilitarCategoria(categoria);
                    MessageBox.Show("Categoría de producto deshabilitada exitosamente.");


                    ListarCategoria();
                }
                else
                {
                    MessageBox.Show("Por favor, selecciona una categoría para deshabilitar.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        public void CambiarEncabezados()
        {
            dgvCategoriaProducto.Columns["CategoriaID"].HeaderText = "ID Categoria";
            dgvCategoriaProducto.Columns["Descripcion"].HeaderText = "Descripción";
            dgvCategoriaProducto.Columns["Estado"].HeaderText = "Estado";
        }

        private void Limpiar()
        { 
            txtDescripcion.Clear();
            dgvCategoriaProducto.ClearSelection();
        }

        public void ListarCategoria()
        {
            try
            {
                var lista = logCategoria.Instancia.ListarCategoria();
                dgvCategoriaProducto.DataSource = lista;
                dgvCategoriaProducto.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al listar categorías: " + ex.Message);
            }
        }

        private void dgvCategoriaProducto_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow fila = dgvCategoriaProducto.Rows[e.RowIndex];
            desCategoria.CategoriaID = Convert.ToInt32(fila.Cells["CategoriaID"].Value.ToString());
            desCategoria.Descripcion = fila.Cells["Descripcion"].Value.ToString();
            txtDescripcion.Text = fila.Cells["Descripcion"].Value.ToString();
            chbxEstado.Checked = Convert.ToBoolean(fila.Cells["Estado"].Value);
            desCategoria.Estado = Convert.ToBoolean(fila.Cells["Estado"].Value);
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
