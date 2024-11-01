using CapaDatos;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SoftwareMinimarket
{
    public partial class ModuloEntradaProductos : Form
    {
        private entProductos desProducto;
        private entNotaEntrada desnotaEntrada;
        private List<entDetalleNotaEntrada> detallesNotaEntrada;
        //Fields
        private int borderRadius = 20;
        private int borderSize = 2;
        private Color borderColor = Color.RoyalBlue;
        public ModuloEntradaProductos()
        {
            InitializeComponent();
            ListarEntrada();
            detallesNotaEntrada = new List<entDetalleNotaEntrada>();
            desProducto = new entProductos();
            desnotaEntrada = new entNotaEntrada();
            btn_Modificar.Enabled = false;
            btn_Deshabilitar.Enabled = false;
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
                // Validación de UsuarioID
                if (string.IsNullOrWhiteSpace(txtUsuario.Text) || !int.TryParse(txtUsuario.Text, out int usuarioID) || usuarioID <= 0)
                {
                    MessageBox.Show("Por favor, ingrese un ID de usuario válido.");
                    return;
                }

                if (detallesNotaEntrada.Count > 0)
                {
                    entNotaEntrada nuevaNotaEntrada = new entNotaEntrada
                    {
                        Fecha = DateTime.Now,
                        Estado = true,
                        UsuarioID = Convert.ToInt32(txtUsuario.Text)
                    };

                    // Llamar a la función que insertará la nota de entrada y los detalles
                    bool resultado = logNotaEntrada.Instancia.InsertarNotaEntrada(nuevaNotaEntrada, detallesNotaEntrada);

                    if (resultado)
                    {
                        MessageBox.Show("Nota de Entrada insertada con éxito");

                        // Limpiar la lista y el DataGridView
                        detallesNotaEntrada.Clear();
                        dgvDetalles.DataSource = null; // Limpiar el DataGridView
                    }
                    else
                    {
                        MessageBox.Show("Error al insertar Nota de Entrada");
                    }
                }
                else
                {
                    MessageBox.Show("No hay detalles para insertar. \n Cancelando proceso...");
                    return;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

            LimpiarVariables();
            ListarEntrada();
        }
        private void LimpiarVariables()
        {
            txtUsuario.Text = "";
            txtDescripcion.Text = "";
            txtProducto.Text = "";
            txtCantidad.Text = "";
        }

        public void ListarEntrada()
        {
            var notasEntrada = logNotaEntrada.Instancia.ListarNotaEntrada();

            // Crear un DataTable para llenar el DataGridView
            DataTable dt = new DataTable();
            dt.Columns.Add("NotaEntradaID", typeof(int));
            dt.Columns.Add("Fecha", typeof(DateTime));
            dt.Columns.Add("Estado", typeof(bool));
            dt.Columns.Add("UsuarioID", typeof(int));

            // Llenar el DataTable con los datos
            foreach (var nota in notasEntrada)
            {
                dt.Rows.Add(nota.NotaEntradaID, nota.Fecha, nota.Estado, nota.UsuarioID);
            }

            // Asignar el DataTable como fuente de datos del DataGridView
            dgvEntradaProductos.DataSource = dt;
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
                    txtUsuario.Text = FormLogin.usuarioValido.id.ToString();
                }

            }
        }
        private void btn_Modificar_Click(object sender, EventArgs e)
        {
            if (desnotaEntrada == null)
            {
                MessageBox.Show("Seleccione una nota de entrada");
                return;
            }
            try
            {
                // Validación de UsuarioID
                if (string.IsNullOrWhiteSpace(txtUsuario.Text) || !int.TryParse(txtUsuario.Text, out int usuarioID) || usuarioID <= 0)
                {
                    MessageBox.Show("Por favor, ingrese un ID de usuario válido.");
                    return;
                }

                // Crear el objeto notaEntrada
                entNotaEntrada notaEntrada = new entNotaEntrada
                {
                    NotaEntradaID = desnotaEntrada.NotaEntradaID, // ID de la nota existente
                    Fecha = DateTime.Now,
                    Estado = desnotaEntrada.Estado,
                    UsuarioID = usuarioID
                };

                // Llamar al método de modificación y pasar la lista de detalles
                bool resultado = logNotaEntrada.Instancia.ModificarNotaEntrada(notaEntrada, detallesNotaEntrada);

                // Comprobar el resultado de la modificación
                if (resultado)
                {
                    MessageBox.Show("Nota de entrada actualizada con éxito");
                    dgvDetalles.DataSource = null; // Limpiar el DataGridView
                    ListarEntrada(); // Listar nuevamente para mostrar cambios
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

            LimpiarVariables(); // Limpiar controles después de modificar
            desnotaEntrada = null;
            detallesNotaEntrada.Clear(); // Limpiar la lista de detalles
            btn_Modificar.Enabled = false;
            btn_Deshabilitar.Enabled = false;
        }

        private void btnBuscarProducto_Click(object sender, EventArgs e)
        {
            AbrirReporteProductos();
        }

        private void dgvEntradaProductos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            btn_Modificar.Enabled = true;
            btn_Deshabilitar.Enabled = true;

            DataGridViewRow filaActual = dgvEntradaProductos.Rows[e.RowIndex];

            int notaEntradaID = Convert.ToInt32(filaActual.Cells["NotaEntradaID"].Value);

            // Llamar al método para obtener los detalles de la nota de entrada
            desnotaEntrada = logNotaEntrada.Instancia.ObtenerDetallesNotaEntrada(notaEntradaID);

            // Verificar si se obtuvo la nota de entrada
            if (desnotaEntrada != null)
            {
                // Asignar valores a los controles
                txtUsuario.Text = desnotaEntrada.UsuarioID.ToString();

                // Limpiar dgvDetalles antes de llenarlo
                dgvDetalles.DataSource = null;

                // Llenar el dgvDetalles con los detalles de la nota de entrada
                dgvDetalles.DataSource = desnotaEntrada.Detalles;

                detallesNotaEntrada.Clear();
                detallesNotaEntrada = desnotaEntrada.Detalles;
            }
            else
            {
                MessageBox.Show("No se encontraron detalles para esta nota de entrada.");
            }
        }
        private void btn_Deshabilitar_Click(object sender, EventArgs e)
        {
            if (desnotaEntrada == null)
            {
                MessageBox.Show("Seleccione una nota de entrada");
                return;
            }

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
            desnotaEntrada = null;
            detallesNotaEntrada.Clear();
            btn_Modificar.Enabled = false;
            btn_Deshabilitar.Enabled = false;
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

        private void btnAgregarDetalle_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtProducto.Text) ||
                string.IsNullOrWhiteSpace(txtCantidad.Text) ||
                string.IsNullOrWhiteSpace(txtDescripcion.Text))
            {
                MessageBox.Show("Complete todos los campos!");
                return;
            }

            if (detallesNotaEntrada.FirstOrDefault(n => n.ProductoID == desProducto.ProductoID) != null)
            {
                entDetalleNotaEntrada detalleEncontrado = detallesNotaEntrada.FirstOrDefault(n => n.ProductoID == desProducto.ProductoID);

                detalleEncontrado.Cantidad = Convert.ToInt32(txtCantidad.Text);
                dgvDetalles.DataSource = null;
                dgvDetalles.DataSource = detallesNotaEntrada;
                desProducto = null;
            }
            else
            {
                entDetalleNotaEntrada detalle = new entDetalleNotaEntrada
                {
                    ProductoID = Convert.ToInt32(txtProducto.Text),
                    Cantidad = Convert.ToInt32(txtCantidad.Text),
                    Descripcion = txtDescripcion.Text,
                };

                detallesNotaEntrada.Add(detalle);

                dgvDetalles.DataSource = null;
                dgvDetalles.DataSource = detallesNotaEntrada;
                desProducto = null;
            }
            
        }

        private void dgvDetalles_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            // Obtener la fila seleccionada
            DataGridViewRow filaSeleccionada = dgvDetalles.Rows[e.RowIndex];

            // Verificar si la fila no es la nueva (debe ser una fila de datos)
            if (!filaSeleccionada.IsNewRow)
            {
                txtCantidad.Text = filaSeleccionada.Cells["Cantidad"].Value.ToString();

                desProducto = null;
                desProducto = logProductos.Instancia.BuscarProductoPorID(Convert.ToInt32(filaSeleccionada.Cells["ProductoID"].Value.ToString()));

                txtProducto.Text = Convert.ToString(desProducto.ProductoID);
                txtDescripcion.Text = desProducto.descripcion;
            }
        }
    }
}
