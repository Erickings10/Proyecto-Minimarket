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
    public partial class ModuloGerente : Form
    {
        public ModuloGerente()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void btn_almacen_Click(object sender, EventArgs e)
        {
            ModuloEntradaProductos mep = new ModuloEntradaProductos();
            mep.Show();
            this.Hide();
        }

        private void btn_ventas_Click(object sender, EventArgs e)
        {
            ModuloVentas mv = new ModuloVentas();
            mv.Show();
            this.Hide();
        }

        private void btn_abastecimiento_Click(object sender, EventArgs e)
        {
            ModuloAbastecimiento ma = new ModuloAbastecimiento();
            ma.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            logUsuario.Instancia.ActualizarInicioSesion(Form1.usuarioValido.id, false);
        }
    }
}
