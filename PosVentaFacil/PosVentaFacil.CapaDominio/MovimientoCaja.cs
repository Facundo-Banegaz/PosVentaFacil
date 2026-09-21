using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PosVentaFacil.CapaDominio
{
    public class MovimientoCaja
    {
        public int Id_MovimientoCaja { get; set; }

        public Caja Caja { get; set; }

        public Usuario Usuario { get; set; }
        public Venta Venta { get; set; }
        public MovimientoCuentaCorriente MovimientoCuentaCorriente { get; set; }
        public DateTime Fecha { get; set; }

        // INGRESO / EGRESO
        public TipoMovimientoCaja TipoMovimientoCaja { get; set; }

        public decimal Monto { get; set; }

        public string Descripcion { get; set; }
    }
}
