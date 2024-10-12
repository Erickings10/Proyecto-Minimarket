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

namespace SoftwareMinimarket
{
    public partial class ModuloAbastecimiento : Form
    {
        public ModuloAbastecimiento()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;

        }

        private void AbrirProveedor() 
        {
            using (ModuloProveedor FP = new ModuloProveedor()) 
            {
                if (FP.ShowDialog() == DialogResult.OK) 
                {
                    txtProveedor.Text = FP.idProv;
                }
            }
        
        }

        private void btnProveedor_Click(object sender, EventArgs e)
        {
            AbrirProveedor();
        }
    }
}
