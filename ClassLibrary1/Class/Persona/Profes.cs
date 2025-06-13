using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class
{
    public class Profes : Persona
    {
        public int IdProfes { get; set; }
        public string Legajo { get; set; }
        public DateTime FechaNacimiento { get; set; }

        public void DarDeAltaProfe()
        {
            Nombre = Nombre;
            Apellido = Apellido;
            Dni = Dni;
            Direccion = Direccion;
            FechaNacimiento = FechaNacimiento;
            IdProfes = IdPersona ++;
            Legajo = Legajo;
        }
    }
}
