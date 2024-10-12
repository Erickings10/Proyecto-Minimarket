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
    public partial class FormDetalleRequerimiento : Form
    {
        public FormDetalleRequerimiento()
        {
            InitializeComponent();
            ListarDetalles();
        }
        public void ListarDetalles() 
        {
            dgvDetallesReq.DataSource = logDetalleRequerimiento.Instancia.ListarDetalleRequerimiento();
        }
    }
}
