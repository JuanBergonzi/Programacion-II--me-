﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Timers;
using System.Web;
using System.Web.Services;
using Clasess;


namespace WebApplication1
{
    /// <summary>
    /// Descripción breve de WebService1
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class WebService1 : System.Web.Services.WebService
    {

        [WebMethod]
        public string CrearTipoDocumento(TipoDoc TiposDoc)
        {
            TipoDoc.CrearTipoDoc(TiposDoc);
            return "OK";
        }

        [WebMethod]
        public string EliminarTipoDocumento(string Codigo)
        {
            TipoDoc.EliminarTipoDoc(Codigo);
            return "OK";
        }


        [WebMethod]
        public List<TipoDoc> ObtenerListaDoc()
        {
            return TipoDoc.listita_modelo;
        }



    }
}
