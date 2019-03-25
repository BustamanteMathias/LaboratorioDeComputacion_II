using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioNro_09
{
    class EjercicioNro_09
    {
        static void Main(string[] args)
        {
            /**
             * Escribir un programa que imprima por pantalla una pirámide como la siguiente:
             
                        *
                        ***
                        *****
                        *******
                        *********
             * El usuario indicará cuál será la altura de la pirámide ingresando un número entero positivo. 
             * Para el ejemplo anterior la altura ingresada fue de 5. 
             * Nota: Utilizar estructuras repetitivas y selectivas.
             */

            Console.Title = "EjercicioNro_09";

            int userNumber;
            int lineActual;

            do
            {
                Console.Write("INGRESE LA ALTURA DE LA PIRAMIDE: ");
                userNumber = Convert.ToInt32(Console.ReadLine());

                if (userNumber < 1)
                {
                    Console.WriteLine("ERROR. Ingrese numero mayor a 1 o inclusive. REINGRESE.");
                    Console.ReadKey();
                    Console.Clear();
                }
            } while (userNumber < 1);

            Console.Clear();
            Console.WriteLine("\nPIRAMIDE CON ALTURA DE " + userNumber);

            for (lineActual = 1; lineActual <= userNumber; lineActual++)
            {
                for (int drawAster = 0; drawAster < (lineActual * 2) - 1; drawAster++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
