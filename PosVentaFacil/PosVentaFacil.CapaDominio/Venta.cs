using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PosVentaFacil.CapaDominio
{
    public class Venta
    {
        public int Id_Venta { get; set; }
        public DateTime Fecha { get; set; } = DateTime.Now;
        public decimal Total { get; set; }

        public bool Estado { get; set; }
        public string Tipo_Comprobante { get; set; }
        public string MetodoPago { get; set; }
        public string Serie { get; set; }
        public string Correlativo { get; set; }
        public Usuario Usuario { get; set; }

        public string Cliente { get; set; } = "CONSUMIDOR FINAL";






        public List<DetalleVenta> Detalles { get; set; }
    }

}
