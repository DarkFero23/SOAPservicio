using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace SOAPservicio
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
        public int Suma(int x, int y)
        {

            return x + y;

        }
        [WebMethod]
        public int Resta(int x, int y)
        {
            return x - y;
        }
        [WebMethod]
        public int Multiplicación(int x, int y)
        {
            return x * y;
        }
        [WebMethod]
        public int División(int x, int y)
        {
            return x / y;
        }
    }
}

