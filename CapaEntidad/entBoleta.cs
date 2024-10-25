using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class entBoleta
    {
        public string ublVersion { get; set; }
        public string tipoOperacion { get; set; }
        public string tipoDoc { get; set; }
        public string serie { get; set; }
        public string correlativo { get; set; }
        public string fechaEmision { get; set; }
        public entFormaPago formaPago { get; set; }
        public string tipoMoneda { get; set; }
        public entClienteFactura client { get; set; }
        public entEmpresa company { get; set; }
        public decimal mtoOperGravadas { get; set; }
        public decimal mtoIGV { get; set; }
        public decimal valorVenta { get; set; }
        public decimal totalImpuestos { get; set; }
        public decimal subTotal { get; set; }
        public decimal mtoImpVenta { get; set; }
        public List<entDetalleFactura> details { get; set; }
        public List<entLeyenda> legends { get; set; }
    }

    public class entFormaPago
    {
        public string moneda { get; set; }
        public string tipo { get; set; }
    }

    public class entClienteFactura
    {
        public string tipoDoc { get; set; }
        public string numDoc { get; set; }
        public string rznSocial { get; set; }
        public entAddress address { get; set; }
    }

    public class entEmpresa
    {
        public string ruc { get; set; }
        public string razonSocial { get; set; }
        public string nombreComercial { get; set; }
        public entAddress address { get; set; }
    }

    public class entAddress
    {
        public string direccion { get; set; }
        public string provincia { get; set; }
        public string departamento { get; set; }
        public string distrito { get; set; }
        public string ubigueo { get; set; }
    }

    public class entDetalleFactura
    {
        public string codProducto { get; set; }
        public string unidad { get; set; }
        public string descripcion { get; set; }
        public int cantidad { get; set; }
        public decimal mtoValorUnitario { get; set; }
        public decimal mtoValorVenta { get; set; }
        public decimal mtoBaseIgv { get; set; }
        public decimal porcentajeIgv { get; set; }
        public decimal igv { get; set; }
        public int tipAfeIgv { get; set; }
        public decimal totalImpuestos { get; set; }
        public decimal mtoPrecioUnitario { get; set; }
    }

    public class entLeyenda
    {
        public string code { get; set; }
        public string value { get; set; }
    }

}
