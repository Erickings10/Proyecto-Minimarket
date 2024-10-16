﻿using CapaEntidad;
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

namespace SoftwareMinimarket
{
    public partial class ModuloVentas : Form
    {
        private List<entProductos> listaProductos = new List<entProductos>();
        public ModuloVentas()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            CargarComboBoxClientes();
            CargarComboBoxMetodosPago();
            ConfigurarAutocompletarProductos();
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

        private void btnRegistrar_Click(object sender, EventArgs e)
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

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            ModuloGerente mg = new ModuloGerente();
            mg.Show();
            this.Close();
        }
    }
}
