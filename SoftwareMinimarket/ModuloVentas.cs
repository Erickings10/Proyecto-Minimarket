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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace SoftwareMinimarket
{
    public partial class ModuloVentas : Form
    {
        private List<entProductos> listaProductos = new List<entProductos>();
        public ModuloVentas()
        {
            InitializeComponent();
            CargarComboBoxClientes();
            CargarComboBoxMetodosPago();
            ConfigurarAutocompletarProductos();
            this.StartPosition = FormStartPosition.CenterScreen;
        }
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

        private void btnNuevoCliente_Click(object sender, EventArgs e)
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

        private void btnAgregarProducto_Click(object sender, EventArgs e)
        {

            if (txtProducto.Text == "" ||
                Convert.ToInt32(nupCantidad.Value) <=0)
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

        private async void btnRegistrar_Click(object sender, EventArgs e)
        {
            //enviar a la base de datos

            entVenta venta = new entVenta()
            {
                UsuarioID = Form1.usuarioValido.id,
                ClienteID = (int)cbClientes.SelectedValue,
                MetodoPagoID = (int)cbMetodoPago.SelectedValue,
                Fecha = DateTime.Now,
                Total = decimal.Parse(txtTotalVenta.Text)
            };

            List<entDetalleVenta> detallesVenta = new List<entDetalleVenta>();
            List<entDetalleFactura> details = new List<entDetalleFactura>();

            foreach (DataGridViewRow row in dgvResumenVenta.Rows)
            {
                entDetalleVenta detalle = new entDetalleVenta()
                {
                    ProductoID = logProductos.Instancia.BuscarProductoPorNombre(Convert.ToString(row.Cells["descripcion"].Value)).ProductoID,
                    Cantidad = Convert.ToInt32(row.Cells["cantidad"].Value),
                    PrecioUnitario = Convert.ToDecimal(row.Cells["precioVenta"].Value)
                };
                detallesVenta.Add(detalle);

                entDetalleFactura detailfactura = new entDetalleFactura
                {
                    codProducto = Convert.ToString(logProductos.Instancia.BuscarProductoPorNombre(Convert.ToString(row.Cells["descripcion"].Value)).ProductoID),
                    unidad = logUdMedida.Instancia.BuscarUnidadMedida(logProductos.Instancia.BuscarProductoPorNombre(Convert.ToString(row.Cells["descripcion"].Value)).unidadMedidaID).Descripcion,
                    descripcion = Convert.ToString(row.Cells["descripcion"].Value),
                    cantidad = Convert.ToInt32(row.Cells["cantidad"].Value),
                    mtoValorUnitario = Convert.ToDecimal(row.Cells["precioVenta"].Value),
                    mtoValorVenta = Convert.ToDecimal(row.Cells["precioVenta"].Value) * Convert.ToInt32(row.Cells["cantidad"].Value),
                    mtoBaseIgv = Convert.ToDecimal(row.Cells["precioVenta"].Value) * Convert.ToInt32(row.Cells["cantidad"].Value),
                    porcentajeIgv = 18,
                    igv = Convert.ToDecimal(row.Cells["precioVenta"].Value) * Convert.ToInt32(row.Cells["cantidad"].Value)*18/100,
                    tipAfeIgv = 10,
                    totalImpuestos = Convert.ToDecimal(row.Cells["precioVenta"].Value) * Convert.ToInt32(row.Cells["cantidad"].Value) * 18 / 100,
                    mtoPrecioUnitario = Convert.ToDecimal(row.Cells["precioVenta"].Value)
                };
                details.Add(detailfactura);

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

            //enviar a sunat
            entMetodoPago metodoPago = logMetodoPago.Instancia.BuscarMetodoPago((int)cbMetodoPago.SelectedValue);
            entCliente cliente = logCliente.Instancia.BuscarClientePorID((int)cbClientes.SelectedValue);
            string totalEnLetras = NumeroALetras(decimal.Parse(txtTotalVenta.Text) + (decimal.Parse(txtTotalVenta.Text) * 18 / 100));
            var factura = new entBoleta
            {
                ublVersion = "2.1",
                tipoOperacion = "0101",
                tipoDoc = "03",
                serie = "B001",
                correlativo = "1",
                fechaEmision = DateTime.Now.ToString("yyyy-MM-ddTHH:mm:sszzz"),
                formaPago = new entFormaPago { moneda = "PEN", tipo = metodoPago.Descripcion },
                tipoMoneda = "PEN",

                client = new entClienteFactura
                {
                    tipoDoc = "1",
                    numDoc = cliente.DNI,
                    rznSocial = cliente.NombreCompleto,
                    address = new entAddress
                    {
                        direccion = "Direccion cliente",
                        provincia = "LIMA",
                        departamento = "LIMA",
                        distrito = "LIMA",
                        ubigueo = "150101"
                    }
                },

                company = new entEmpresa
                {
                    ruc = "94822188311",
                    razonSocial = "Empresa ejemplo",
                    nombreComercial = "Mi empresa",
                    address = new entAddress
                    {
                        direccion = "Direccion empresa",
                        provincia = "LIMA",
                        departamento = "LIMA",
                        distrito = "LIMA",
                        ubigueo = "150101"
                    }
                },

                mtoOperGravadas = decimal.Parse(txtTotalVenta.Text),
                mtoIGV = decimal.Parse(txtTotalVenta.Text)*18/100,
                valorVenta = decimal.Parse(txtTotalVenta.Text),
                totalImpuestos = decimal.Parse(txtTotalVenta.Text)*18/100,
                subTotal = decimal.Parse(txtTotalVenta.Text)+(decimal.Parse(txtTotalVenta.Text)*18/100),
                mtoImpVenta = decimal.Parse(txtTotalVenta.Text) + (decimal.Parse(txtTotalVenta.Text) * 18 / 100),

                details = details,

                legends = new List<entLeyenda>
                {
                    new entLeyenda { code = "1000", value = totalEnLetras }
                }
            };

            // Llamada para generar la boleta
            string respuesta = await logBoleta.Instancia.GenerarBoletaAsync(factura);
            MessageBox.Show(respuesta);

            // Especifica la ruta donde guardar el PDF
            string rutaArchivo = @"C:\Users\94881\OneDrive\Escritorio\API\boleta.pdf";

            // Llama la función para generar el PDF y guardarlo
            string result = await logBoleta.Instancia.GenerarBoletaPDFAsync(factura, rutaArchivo);
            MessageBox.Show(result);

            if (metodoPago.MetododepagoID == 1)
            {
                PantallaYape formulario = new PantallaYape();
                formulario.Show();
            }
        }
        private string NumeroALetras(decimal numero)
        {
            string decimales = (numero % 1).ToString("0.00").Substring(2); // Extrae los decimales
            int entero = (int)Math.Floor(numero); // Extrae la parte entera del número
            string textoEntero = NumeroEnteroALetras(entero);

            return $"SON {textoEntero.ToUpper()} CON {decimales}/100 SOLES";
        }

        private string NumeroEnteroALetras(int numero)
        {
            if (numero == 0) return "CERO";

            string[] unidades = { "", "UN", "DOS", "TRES", "CUATRO", "CINCO", "SEIS", "SIETE", "OCHO", "NUEVE" };
            string[] decenas = { "", "", "VEINTE", "TREINTA", "CUARENTA", "CINCUENTA", "SESENTA", "SETENTA", "OCHENTA", "NOVENTA" };
            string[] centenas = { "", "CIENTO", "DOSCIENTOS", "TRESCIENTOS", "CUATROCIENTOS", "QUINIENTOS", "SEISCIENTOS", "SETECIENTOS", "OCHOCIENTOS", "NOVECIENTOS" };

            string texto = "";

            // Para centenas
            int centena = (numero / 100) % 10;
            if (centena > 0) texto += centenas[centena] + " ";

            // Para decenas y unidades
            int decena = (numero / 10) % 10;
            int unidad = numero % 10;

            if (decena == 1 && unidad > 0)
            {
                // Caso especial para los números del 11 al 19
                string[] especiales = { "ONCE", "DOCE", "TRECE", "CATORCE", "QUINCE", "DIECISEIS", "DIECISIETE", "DIECIOCHO", "DIECINUEVE" };
                texto += especiales[unidad - 1];
            }
            else
            {
                if (decena > 0) texto += decenas[decena] + " ";
                if (unidad > 0) texto += unidades[unidad];
            }

            return texto.Trim();
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void cbMetodoPago_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbMetodoPago.SelectedItem.ToString() == "Yape")
            {
                // Abrir el formulario secundario
                PantallaYape formulario = new PantallaYape();
                formulario.Show(); // O usa .ShowDialog() si quieres que sea modal
            }
        }
    }
}
