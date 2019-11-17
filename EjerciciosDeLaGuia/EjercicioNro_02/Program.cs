using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioNro_02
{
    class EjercicioNro_02
    {
        static void Main(string[] args)
        {
            /**
             * Ingresar un número y mostrar: el cuadrado y el cubo del mismo. 
             * Se debe validar que el número sea mayor que cero, caso contrario, 
             * mostrar el mensaje: "ERROR. ¡Reingresar número!". 
             * Nota: Utilizar el método ‘Pow’ de la clase Math para realizar la operación.
             */

            int auxNumber;
            double numberCuadrado;
            double numberCubo;

            Console.Title = "EjercicioNro_02";

            do
            {
                Console.Write("\nINGRESE UN NUMERO PARA CALCULAR SU [CUADRADO] Y [CUBO]: ");
                auxNumber = int.Parse(Console.ReadLine());

                if (auxNumber < 1)
                {
                    Console.WriteLine("ERROR. ¡Reingresar número!");
                    Console.ReadKey();
                    Console.Clear();
                }

            } while (auxNumber < 1);

            numberCuadrado = Math.Pow(auxNumber, 2);
            numberCubo = Math.Pow(auxNumber, 3);

            Console.WriteLine("EL NUMERO INGRESADO ES: {0:#,###}\n", auxNumber);
            Console.WriteLine("[EL CUADRADO DE {0} ES]: {1:#,###.00}", auxNumber, numberCuadrado);
            Console.WriteLine("[EL CUBO DE {0} ES]: {1:#,###.00}", auxNumber, numberCubo);

            Console.ReadKey();
        }
    }
}
