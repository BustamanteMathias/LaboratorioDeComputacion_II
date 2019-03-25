using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioNro_03
{
    class EjercicioNro_03
    {
        static void Main(string[] args)
        {
            /**
             * Mostrar por pantalla todos los números primos que haya hasta el número que ingrese el usuario por consola.
             * Nota: Utilizar estructuras repetitivas, selectivas y la función módulo (%).
             */

            int auxNumber;
            int count = 0;

            Console.Title = "EjercicioNro_03";
            do
            {
                Console.Write("\nINGRESE UN NUMERO PARA BUSCAR NUMEROS PRIMOS HASTA EL INDICADO: ");
                auxNumber = int.Parse(Console.ReadLine());

                if (auxNumber <= 1)
                {
                    if(auxNumber == 1)
                    {
                        Console.WriteLine("ERROR! 1 No es considerado un numero primo! REINGRESE. ");
                    }
                    else
                    {
                        Console.WriteLine("ERROR! Los numeros por debajo de 1 no son primos! REINGRESE. ");
                    }

                    Console.ReadKey();
                    Console.Clear();
                }
            } while (auxNumber <= 1);
            
            for (int i = 2; i <= auxNumber; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    if( i % j == 0)
                    {
                        count++;
                    }
                }
                if (count == 2)
                {
                    Console.Write(i + "-");
                }
                count = 0;
                
            }
            Console.ReadKey();
        }
    }
}
