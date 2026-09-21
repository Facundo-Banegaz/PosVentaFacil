using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PosVentaFacil.CapaDominio
{
    public class TipoMovimientoCaja
    {
        public int Id_TipoMovimientoCaja { get; set; }

        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public string Movimiento { get; set; } // 'E' para Entrada, 'S' para Salida


        public override string ToString()
        {
            return Nombre;
        }
    }
}
