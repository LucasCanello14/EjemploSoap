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
            bool ocupado = instanciaEdificio.EstadoAscensor(codigo);
            if (ocupado)
            {
                estado = "El ascensor esta ocupado";
            }
            else
            {
                estado = "El ascensor esta desocupado";
            }
            return estado;
        }

        [WebMethod]
        public string SolicitarAscensor(int codigo, int nroPiso)
        {
            int pisoInicial = instanciaEdificio.SolicitarAscensor(nroPiso, codigo);
            string pisoAscensor = $"El piso inicial del ascensor es el piso nro. {pisoInicial}";
            return pisoAscensor;
        }
        [WebMethod]

        
    }
}


    

        
      
    
        
    

   

