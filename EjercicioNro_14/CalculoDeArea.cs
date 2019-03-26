using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioNro_14
{
    class CalculoDeArea
    {
        public static double CalcularCuadrado(double lado)
        {
            double areaCuadrado;

            areaCuadrado = lado * lado;

            return areaCuadrado;
        }

        public static double CalcularTriangulo(double ladoBase, double altura)
        {
            double areaTriangulo;

            areaTriangulo = (ladoBase * altura) / 2;

            return areaTriangulo;
        }

        public static double CalcularCirculo(double diametro)
        {
            double areaCirculo;

            areaCirculo = (Math.PI) * diametro;

            return areaCirculo;
        }
    }
}
