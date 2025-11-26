using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prueba_XYZ.Entidades
{
    public class Producto
    {
        public int Id { get; set; }                // Identificador interno (generado manualmente)
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public decimal Precio { get; set; }
        public int Stock { get; set; }
        public bool Estado { get; set; }
    }
}
