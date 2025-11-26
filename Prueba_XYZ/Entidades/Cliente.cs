using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prueba_XYZ.Entidades
{
    public  class Cliente
    {
        public int Id { get; set; }
        public string Nombre{ get; set; }
        public string Dui { get; set; }
        public string Telefono { get; set; }
        public string Correo { get; set; }
        public bool Estado { get; set; }
    }
}
