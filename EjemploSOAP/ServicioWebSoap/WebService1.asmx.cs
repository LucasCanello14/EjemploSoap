using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using EjemploSOAP;

namespace ServicioWebSoap
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
        Edificio instanciaEdificio = new Edificio();

        [WebMethod]
       public string EstadoAscensor(int codigo)
        {
           
            string estado;
          bool ocupado=  instanciaEdificio.EstadoAscensor(codigo);
            if (ocupado)
            {
                estado = "esta ocupado";
            }
            else
            {
                estado = "esta desocupado";
            }
            return estado;
        }
    }
}
