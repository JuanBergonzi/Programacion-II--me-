using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class
{
    public class Socio : Persona
    {
        public int IdSocio { get; set; }
        public DateTime FechaAlta { get; set; }
        public void DarAltaSocio()
        {
            Nombre = Nombre;
            Apellido = Apellido;
            Dni = Dni;
            Direccion = Direccion;
            IdSocio = IdPersona++;
            FechaAlta = DateTime.Now;
        }
    }
}
