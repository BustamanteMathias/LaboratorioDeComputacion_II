using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioNro_06
{
    class EjercicioNro_06
    {
        static void Main(string[] args)
        {
            /**
             * Escribir un programa que determine si un año es bisiesto. Un año es bisiesto si es múltiplo de 4. 
             * Los años múltiplos de 100 no son bisiestos, salvo si ellos también son múltiplos de 400. 
             * Por ejemplo: el año 2000 es bisiesto pero 1900 no.
             * Pedirle al usuario un año de inicio y otro de fin y mostrar todos los años bisiestos en ese rango. 
             * Nota: Utilizar estructuras repetitivas, selectivas y la función módulo (%).
             */

            Console.Title = "EjercicioNro_06";

            int anioInicio = 0;
            int anioFin = 0;
            int contador = 0;

            do
            {
                do
                {
                    Console.Write("\nINGRESE INICIO DE AÑO: ");
                    anioInicio = int.Parse(Console.ReadLine());

                    if (anioInicio < 1)
                    {
                        Console.WriteLine("ERROR. El numero ingresado tiene que ser mayor a 1 o inclusive. REINGRESE.");
                        Console.ReadKey();
                        Console.Clear();
                    }
                } while (anioInicio < 1);

                do
                {
                    Console.Write("\nINGRESE AÑO FINAL: ");
                    anioFin = int.Parse(Console.ReadLine());

                    if (anioFin < 1)
                    {
                        Console.WriteLine("ERROR. El numero ingresado tiene que ser mayor a 1 o inclusive. REINGRESE.");
                        Console.ReadKey();
                        Console.Clear();
                    }
                } while (anioFin < 1);

                if (anioFin < anioInicio)
                {
                    Console.WriteLine("ERROR. El año FINAL no puede ser menor que el INICIAL. REINGRESE.");
                    Console.ReadKey();
                    Console.Clear();
                }
            } while (anioFin < anioInicio);

            Console.Clear();
            Console.Write("AÑOS BISIESTOS\n\n\n");
            for (int i=anioInicio; i<=anioFin; i++)
            {
                if ((i%4)==0 && (i%100 !=0 || i%400 ==0))
                {
                    contador++;
                    Console.Write("{0,7:#,###}",i);

                    if(contador==10)
                    {
                        Console.Write("\n\n");
                        contador = 0;
                    }
                }
            }

            Console.ReadKey();
        }
    }
}
