using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PosVentaFacil.CapaDominio
{
    public class Caja
    {
        public int Id_Caja { get; set; }

        public Usuario Usuario { get; set; }

        public DateTime FechaApertura { get; set; }

        public DateTime? FechaCierre { get; set; }

        public decimal MontoInicial { get; set; }
        public decimal MontoFinal { get; set; }
        public bool Estado { get; set; }

        public string Observacion { get; set; }
        public List<MovimientoCaja> Movimientos { get; set; }
    }
}
