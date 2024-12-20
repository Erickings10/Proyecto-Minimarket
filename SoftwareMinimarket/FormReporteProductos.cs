﻿using CapaEntidad;
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
    public partial class FormReporteProductos : Form
    {
        public entProductos producto = new entProductos();
        //Fields
        private int borderRadius = 20;
        private int borderSize = 2;
        private Color borderColor = Color.RoyalBlue;
        public FormReporteProductos()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            ListarProductos();
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
        private void FormReporteProductos_MouseDown(object sender, MouseEventArgs e)
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
        private void FormReporteProductos_Paint(object sender, PaintEventArgs e)
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
        private void FormReporteProductos_ResizeEnd(object sender, EventArgs e)
        {
            this.Invalidate();
        }
        private void FormReporteProductos_SizeChanged(object sender, EventArgs e)
        {
            this.Invalidate();
        }
        private void FormReporteProductos_Activated(object sender, EventArgs e)
        {
            this.Invalidate();
        }
        //----------------------------------------------------------------------------------------------
        public void ListarProductos()
        {
            dgvReporteProductos.DataSource = logProductos.Instancia.ListarProductos();
            CambiarEncabezados();
        }
        private void CambiarEncabezados()
        {
            dgvReporteProductos.Columns["ProductoID"].HeaderText = "ID Producto";
            dgvReporteProductos.Columns["CategoriaproductoID"].HeaderText = "ID Categoria";
            dgvReporteProductos.Columns["unidadMedidaID"].HeaderText = "ID Medida";
            dgvReporteProductos.Columns["descripcion"].HeaderText = "Descripcion";
            dgvReporteProductos.Columns["precioVenta"].HeaderText = "Venta";
            dgvReporteProductos.Columns["cantidad"].HeaderText = "Cantidad";
            dgvReporteProductos.Columns["fecha"].HeaderText = "Fecha";
            dgvReporteProductos.Columns["estado"].HeaderText = "Estado";
        }
        private void dgvReporteProductos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                producto.ProductoID = Convert.ToInt32(dgvReporteProductos.Rows[e.RowIndex].Cells[0].Value.ToString());
                producto.CategoriaproductoID = Convert.ToInt32(dgvReporteProductos.Rows[e.RowIndex].Cells[1].Value.ToString());
                producto.descripcion = dgvReporteProductos.Rows[e.RowIndex].Cells[3].Value.ToString();
                producto.unidadMedidaID = Convert.ToInt32(dgvReporteProductos.Rows[e.RowIndex].Cells[2].Value.ToString());
                producto.precioVenta = Convert.ToDecimal(dgvReporteProductos.Rows[e.RowIndex].Cells[4].Value.ToString());
                producto.cantidad = Convert.ToInt32(dgvReporteProductos.Rows[e.RowIndex].Cells[5].Value.ToString());
                producto.fecha = Convert.ToDateTime(dgvReporteProductos.Rows[e.RowIndex].Cells[6].Value.ToString());
                producto.estado = Convert.ToBoolean(dgvReporteProductos.Rows[e.RowIndex].Cells[7].Value.ToString());

                DialogResult = DialogResult.OK;  // Esto cierra el formulario y devuelve el resultado a FormPrincipal
                Close();
            }          
        }
        private void btnAgregarProd_Click(object sender, EventArgs e)
        {
            AbrirAgregarProducto();
        }
        private void AbrirAgregarProducto()
        {
            using (ModuloAgregarProducto formAgregarProducto = new ModuloAgregarProducto())
            {
                this.Hide();
                if (formAgregarProducto.ShowDialog() == DialogResult.OK)
                {
                    ListarProductos();
                }
                this.Show();
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}
