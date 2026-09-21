using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PosVentaFacil.CapaDominio
{
    public class MovimientoCuentaCorriente
    {
        public int Id_MovimientoCuentaCorriente { get; set; }

        public Cliente Cliente { get; set; }

        public Venta Venta { get; set; }

        public Usuario Usuario { get; set; }

        public DateTime Fecha { get; set; }

        // Lo que debe
        public decimal Debe { get; set; }

        // Lo que pagó
        public decimal Haber { get; set; }

        // Saldo luego del movimiento
        public decimal Saldo { get; set; }

        public string Descripcion { get; set; }
    }
}
