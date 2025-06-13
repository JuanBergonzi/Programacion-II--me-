using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class
{
    public class Libreria : Producto
    {
        public Tipo Tipos { get; set; }
        public string Tamanio { get; set; }

        public void DarDeAltaLibreria()
        {
            CodProducto = CodProducto;
            Nombre = Nombre;
            Descripcion = Descripcion;
            Stock = Stock;
            Tipos = Tipos;
            Tamanio = Tamanio;
        }
    }
}
