using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace WebServices
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
        public double Resta(double numeroUno, double numeroDos)
        {
            return numeroUno - numeroDos;
        }

        [WebMethod]
        public double suma(double numeroUno, double numeroDos)
        {
            return numeroUno + numeroDos;
        }

        [WebMethod]
        public double Circunferencia(double radio)
        {
            const float PI = 3.14f;
            return PI * (radio * radio);
        }

        [WebMethod]
        public double TrianguloEq(double lado)
        {
            return (Math.Sqrt(3) * (lado * lado)) / 4;
        }

        [WebMethod]
        public double Rectangulo(double altura, double baseL)
        {
            return 2 * (baseL + altura);
        }

        [WebMethod]
        public double Cilindro(double radio, double altura)
        {
            const float PI = 3.14f;
            return PI * (radio * radio) * altura;
        }
    }
}
