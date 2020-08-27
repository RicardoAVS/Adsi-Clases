using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cls_Libreria
{
    public class Operaciones
    {
        #region Atributos
        private double primNum;
        private double segundoNum;
        private double tercerNum;
        private double promedio;
        private string error;
        #endregion
        #region Metodos Publicos
        public Operaciones()
        {
            primNum = 0;
            segundoNum = 0;
            tercerNum = 0;
            promedio = 0;
            error = "";
        }

        public Boolean calcularPromedio()
        {
            if (!validar())
                return false;
            try
            {
                promedio = (primNum + segundoNum + tercerNum) / 3;
                return true;
            } catch (Exception err)
            {
                error = err.Message;
                return false;
            }
        }


        public double PrimNum { set => primNum = value; }
        public double SegundoNum { set => segundoNum = value; }
        public double TercerNum { set => tercerNum = value; }
        public double Promedio { get => promedio; }
        public string Error { get => error; }
        #endregion

        #region Metodos Privados

        private Boolean validar()
        {
            if ((primNum >= 0 && primNum <= 5) && (segundoNum >= 0 && segundoNum <= 5) && (tercerNum >= 0 && tercerNum <= 5))
                return true;
            else
            {
                error = "Ingresar numeros entre 0 y 5";
                return false;
            }
        }
        #endregion
    }
}
