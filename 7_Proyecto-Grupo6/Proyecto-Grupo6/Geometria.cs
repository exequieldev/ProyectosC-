using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Grupo6
{
    //Calculado geometrica, para el calculo de area
    internal class Geometria
    {
        public double CalcularAreaCirculo(double radio)
        {
            return Math.PI * radio * radio;
        }

        public double CalcularAreaCuadrado(double lado)
        {
            return lado * lado;
        }

        public double CalcularAreaRectangulo(double baseRect, double altura)
        {
            return baseRect * altura;
        }

        public double CalcularAreaTriangulo(double baseTri, double altura)
        {
            return (baseTri * altura) / 2;
        }
    }

}

