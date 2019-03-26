using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioNro_11
{
    class EjercicioNro_11
    {
        static void Main(string[] args)
        {
            /**
             * Ingresar 10 números enteros que pueden estar dentro de un rango de entre -100 y 100. 
             * Para ello realizar una clase llamada Validacion que posea un método estático llamado Validar, 
             * que posea la siguiente firma: bool Validar(int valor, int min, int max):
                    a. valor: dato a validar
                    b. min y max: rango en el cual deberá estar la variable valor.
             * Terminado el ingreso mostrar el valor mínimo, el valor máximo y el promedio. 
             * Nota: Utilizar variables escalares, NO utilizar vectores.
             */

            Console.Title = "EjercicioNro_11";

            int contador = 0;
            float acumulador = 0;
            int valorMin = 0;
            int valorMax = 0;
            int auxNumero;
            double promedio;

            do
            {
                Console.Clear();
                Console.Write("Ingrese 10 numeros entre [-100 Y 100] [N-" + (contador + 1) + "]: ");
                auxNumero = int.Parse(Console.ReadLine());

                if(Validacion.Validar(auxNumero, -100, 100))
                {
                    if(contador==0)
                    {
                        valorMin = auxNumero;
                        valorMax = auxNumero;
                    }
                    else if(auxNumero < valorMin)
                    {
                        valorMin = auxNumero;
                    }
                    else if(auxNumero > valorMax)
                    {
                        valorMax = auxNumero;
                    }

                    acumulador = acumulador + auxNumero;
                    contador++;
                }
                else
                {
                    Console.WriteLine("ERROR. Numero fuera de rango. REINGRESE.");
                    Console.ReadKey();
                }
                

            } while (contador<10);

            promedio = acumulador / 10.0;

            Console.Clear();
            Console.WriteLine("PROMEDIO: {0:#,###.00}", promedio);
            Console.WriteLine("MAXIMO: {0}", valorMax);
            Console.WriteLine("MINIMO: {0}", valorMin);
            Console.ReadKey();
        }
    }
}
