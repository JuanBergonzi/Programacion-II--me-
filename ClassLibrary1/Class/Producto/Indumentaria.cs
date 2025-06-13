using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class
{
    public class Indumentaria : Producto
    {
        public string Talle { get; set; }
        public string Color { get; set; }
        public void DarDeAltaIndumentaria()
        {
            CodProducto = CodProducto++;
            Nombre = Nombre;
            Descripcion = Descripcion;
            Stock = Stock;
            Talle = Talle;
            Color = Color;
        }
    }
}
