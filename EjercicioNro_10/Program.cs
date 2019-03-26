using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioNro_10
{
    class EjercicioNro_10
    {
        static void Main(string[] args)
        {
            /**
             * Partiendo de la base del ejercicio anterior, se pide realizar un programa que imprima por pantalla 
             * una pirámide como la siguiente:
             
                            *
                           ***
                          *****
                         *******
                        *********
                        
             * Nota: Utilizar estructuras repetitivas y selectivas.
             */

            Console.Title = "EjercicioNro_10";

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
                for (int drawSpace = 0; drawSpace < (userNumber-lineActual); drawSpace++)
                {
                    Console.Write(" ");
                }
                for (int drawAster = 0; drawAster < (lineActual*2) -1; drawAster++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            
            Console.ReadKey();
        }
    }
}
