using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioNro_05
{
    class EjercicioNro_05
    {
        static void Main(string[] args)
        {
            /**
             * Un centro numérico es un número que separa una lista de números enteros (comenzando en 1) 
             * en dos grupos de números, cuyas sumas son iguales. El primer centro numérico es el 6, 
             * el cual separa la lista (1 a 8) en los grupos: (1; 2; 3; 4; 5) y (7; 8) 
             * cuyas sumas son ambas iguales a 15. El segundo centro numérico es el 35, 
             * el cual separa la lista (1 a 49) en los grupos: (1 a 34) y (36 a 49) 
             * cuyas sumas son ambas iguales a 595. 
             * Se pide elaborar una aplicación que calcule los centros numéricos entre 1 y el número 
             * que el usuario ingrese por consola. 
             * Nota: Utilizar estructuras repetitivas y selectivas.
             */

            Console.Title = "EjercicioNro_05";

            int numberUsuario;
            int acumNeg = 0;
            int acumPos = 0;
            int auxAcumPos = 0;
            int control = 0;


            do
            {
                Console.Write("\nINGRESE UN NUMERO PARA BUSCAR CENTROS NUMERICOS HASTA EL INDICADO: ");
                numberUsuario = int.Parse(Console.ReadLine());

                if (numberUsuario < 1)
                {
                    Console.WriteLine("ERROR. El numero ingresado tiene que ser mayor a 1 o inclusive. REINGRESE.");
                    Console.ReadKey();
                    Console.Clear();
                }

            } while (numberUsuario < 1);

            for (int i=1; i<=numberUsuario; i++)
            {
                while ( i>1 )
                {

                    for (int j = 1; j < i; j++)
                    {
                        acumNeg = acumNeg + j;
                    }
                    
                    acumPos = i + 1;
                    auxAcumPos = i + 1;

                    while (acumNeg >= acumPos)
                    {
                        if (acumNeg == acumPos)
                        {
                            Console.WriteLine("GRUPO - CENTRO NUMERICO: 1..." + (i-1) +" ["+i+"] "+(i+1)+"..."+auxAcumPos);
                            break;
                        }
                        else
                        {
                            auxAcumPos = auxAcumPos + 1;
                            acumPos = acumPos + auxAcumPos;
                        }  
                    }

                    acumPos = 0;
                    acumNeg = 0;
                    control = 0;
                    auxAcumPos = 0;

                    break;
                }
            }
            

            Console.ReadKey();
        }
    }
}
