using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioNro_14
{
    class EjercicioNro_14
    {
        static void Main(string[] args)
        {
            /**
             * Realizar una clase llamada CalculoDeArea que posea 3 métodos de clase (estáticos) 
             * que realicen el cálculo del área que corresponda:
                    a. double CalcularCuadrado(double)
                    b. double CalcularTriangulo(double, double)
                    c. double CalcularCirculo(double)
             * El ingreso de los datos como la visualización se deberán realizar desde el método Main().
             */
            Console.Title = "EjercicioNro_14";

            double ladoCuadrado = 10;
            double ladoBaseTriangulo = 10;
            double alturaTriangulo = 10;
            double diametroCirculo = 10;

            Console.WriteLine("LADO CUADRADO: "+ ladoCuadrado+" - AREA CUADRADO: "+CalculoDeArea.CalcularCuadrado(ladoCuadrado));
            Console.WriteLine("\nBASE TRIANGULO: " + ladoCuadrado + " - ALTURA TRIANGULO: "+alturaTriangulo+ " - AREA TRIANGULO: " + CalculoDeArea.CalcularTriangulo(ladoBaseTriangulo, alturaTriangulo));
            Console.WriteLine("\nDIAMETRO DE CIRCULO: " + diametroCirculo + " - AREA CIRCULO: " + CalculoDeArea.CalcularCirculo(diametroCirculo));

            Console.Read();
        }
    }
}
