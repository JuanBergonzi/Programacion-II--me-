﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public class TipoDoc
    {
        public int IdTipoDoc { get; set; }
        public string Descripcion { get; set; }
        public List<Cliente> clientes { get; set; } 
    }
}
