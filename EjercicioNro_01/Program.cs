using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioNro_01
{
    class EjercicioNro_01
    {
        static void Main(string[] args)
        {
            {
                /** 
                Ingresar 5 números por consola, guardándolos en una variable escalar. 
                Luego calcular y mostrar: el valor máximo, el valor mínimo y el promedio.
                */

                int auxNumber;
                int numberMax = 0;
                int numberMin = 0;
                int count = 0;
                float acumNumber = 0;
                float numberProm;

                Console.Title = "EjercicioNro_01";

                do
                {

                    Console.Write("\nINGRESE NUMERO {0}: ", count + 1);
                    auxNumber = int.Parse(Console.ReadLine());

                    if (count == 0)
                    {

                        numberMin = auxNumber;
                        numberMax = auxNumber;
                    }

                    if (auxNumber > numberMax)
                    {

                        numberMax = auxNumber;
                    }
                    else if (auxNumber < numberMin)
                    {

                        numberMin = auxNumber;
                    }

                    acumNumber = acumNumber + auxNumber;
                    count++;

                } while (count < 5);

                numberProm = acumNumber / 5;

                Console.WriteLine("\n\n[NUMERO MINIMO]: {0}", numberMin);
                Console.WriteLine("[NUMERO MAXIMO]: {0}", numberMax);
                Console.WriteLine("[VALOR PROMEDIO]: {0:#,###.00}", numberProm);

                Console.ReadKey();
            }
        }
    }
}
