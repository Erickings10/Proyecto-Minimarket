using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.Json;
using System.Runtime.InteropServices;
using System.Drawing.Drawing2D;

namespace SoftwareMinimarket
{
    public partial class PantallaYape : Form
    {
        public string ClienteNombre { get; set; }
        public decimal MontoTotal { get; set; }
        public bool PagoExitoso { get; private set; } = false;

        //Fields
        private int borderRadius = 20;
        private int borderSize = 2;
        private Color borderColor = Color.RoyalBlue;

        public PantallaYape(string clienteNombre, decimal montoTotal)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.None;
            this.Padding = new Padding(borderSize);
            this.panelTitleBar.BackColor = borderColor;
            this.BackColor = borderColor;

            // Asignar valores recibidos a las propiedades
            ClienteNombre = clienteNombre;
            MontoTotal = montoTotal;

            // Asignar valores a los controles
            txtCliente.Text = ClienteNombre;
            txtTotal.Text = $"S/. {MontoTotal:F2}";
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
        private void PantallaYape_MouseDown(object sender, MouseEventArgs e)
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

        private void PantallaYape_Paint(object sender, PaintEventArgs e)
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
        private void PantallaYape_ResizeEnd(object sender, EventArgs e)
        {
            this.Invalidate();
        }

        private void PantallaYape_SizeChanged(object sender, EventArgs e)
        {
            this.Invalidate();
        }

        private void PantallaYape_Activated(object sender, EventArgs e)
        {
            this.Invalidate();
        }
        //----------------------------------------------------------------------------------------

        private async void btnConfirmarPago_Click(object sender, EventArgs e)
        {
            try
            {
                // Validar campos de entrada
                if (string.IsNullOrWhiteSpace(txtCorreo.Text) ||
                    string.IsNullOrWhiteSpace(txtNumYape.Text) ||
                    string.IsNullOrWhiteSpace(txtOTP.Text))
                {
                    MessageBox.Show("Por favor, completa todos los campos.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Capturar datos ingresados
                string correo = txtCorreo.Text;
                string telefono = txtNumYape.Text;
                string otp = txtOTP.Text;

                // Confirmar pago con Yape
                await ConfirmarPagoYape(telefono, otp, MontoTotal, correo);

                // Si el pago es exitoso, habilitar el botón Confirmar Venta
                PagoExitoso = true;
                MessageBox.Show("Pago confirmado. Ahora puedes registrar la venta.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al procesar el pago: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async Task ConfirmarPagoYape(string telefono, string otp, decimal monto, string correo)
        {
            try
            {
                var yapeService = new MercadoPagoYapeService();

                // Generar ID de Yape
                string id = await yapeService.GenerateYapeToken(telefono, otp);

                // Crear el pago usando el ID como 'token'
                string resultadoPago = await yapeService.CreatePayment(id, monto, correo);

                if (resultadoPago != "Pago aprobado")
                {
                    throw new Exception("El pago fue rechazado.");
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Error al procesar el pago: {ex.Message}");
            }
        }

        private void btnConfirmarVenta_Click(object sender, EventArgs e)
        {
            if (!PagoExitoso)
            {
                MessageBox.Show("Primero confirma el pago antes de registrar la venta.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Confirmar cierre del formulario y notificar éxito
            DialogResult = DialogResult.OK;
            Close();
        }

        
    }
}

