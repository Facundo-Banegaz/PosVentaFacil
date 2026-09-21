using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PosVentaFacil.CapaDominio
{
    public class Producto
    {
        public int Id_Producto { get; set; }

        public string Nombre { get; set; }

        public string CodigoBarra { get; set; }

        public decimal Precio { get; set; }

        public decimal Stock { get; set; }

        [DisplayName("Stock Minimo")]
        public decimal StockMinimo { get; set; } = 0;
        public bool PermiteDecimales { get; set; } = false;
        public string Unidad { get; set; }
        public int Id_Categoria { get; set; }

        public bool Activo { get; set; }

        public DateTime FechaCreacion { get; set; }


        [DisplayName("Fecha Ultima Actualizacion Precio")]
        public DateTime? FechaActualizacionPrecio { get; set; }

        public override string ToString()
        {
            return Nombre;
        }
    }

}
