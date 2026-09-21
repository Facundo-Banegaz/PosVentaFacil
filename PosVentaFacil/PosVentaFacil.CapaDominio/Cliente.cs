using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PosVentaFacil.CapaDominio
{
    public class Cliente
    {
        public int Id_Cliente { get; set; }

        public string Nombre { get; set; }

        public string Telefono { get; set; }
        public decimal SaldoCuentaCorriente { get; set; }

        public bool Activo { get; set; }
    }
}
