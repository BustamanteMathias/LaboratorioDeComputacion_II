using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioNro_04
{
    class EjercicioNro_04
    {
        static void Main(string[] args)
        {
            /**
             * Un número perfecto es un entero positivo, que es igual a la suma de todos los enteros positivos 
             * (excluido el mismo) que son divisores del número. El primer número perfecto es 6, 
             * ya que los divisores de 6 son 1, 2 y 3; y 1 + 2 + 3 = 6. 
             * Escribir una aplicación que encuentre los 4 primeros números perfectos. 
             * Nota: Utilizar estructuras repetitivas y selectivas.
             */

            int numberPerfect = 0;
            int acumulador = 0;
            int i = 1;

            Console.Title = "EjercicioNro_04";

            while( numberPerfect < 4)
            {
                for (int j = 1; j < i ; j++)
                {
                    if (i % j == 0)
                    {
                        acumulador = acumulador + j;
                    }
                }
                if (acumulador == i)
                {
                    if(numberPerfect==0)
                    {
                        Console.WriteLine("LOS PRIMEROS 4 NUMEROS PERFECTOS SON: \n\n");
                    }
                    Console.WriteLine("{0:#,###}", i);
                    numberPerfect++;
                }
                acumulador = 0;
                i++;
            }
            Console.ReadKey();
        }
    }
}
