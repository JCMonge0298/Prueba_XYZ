using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prueba_XYZ.Entidades
{
    public class Venta
    {
        public int Id { get; set; }
        public DateTime Fecha { get; set; }
        public decimal MontoTotal { get; set; }
        public int Id_TipoPago { get; set; }
        public int Id_Cliente { get; set; }
    }
}
