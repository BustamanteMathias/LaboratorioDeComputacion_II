using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioNro_12
{
    class EjercicioNro_12
    {
        static void Main(string[] args)
        {
            /**
             * Realizar un programa que sume números enteros hasta que el usuario lo determine, 
             * por medio de un mensaje "¿Continuar? (S/N)". 
             * En el método estático ValidaS_N(char c) de la clase ValidarRespuesta, 
             * se validará el ingreso de opciones. El método devolverá un valor de tipo booleano, 
             * TRUE si se ingresó una 'S' y FALSE si se ingresó cualquier otro valor.
             */
             
            Console.Title = "EjercicioNro_12";

            int numeroUser=0;
            char c;
            do
            {
                Console.Write("\nINTRODUCIR NUMERO PARA SUMAR: ");
                numeroUser = numeroUser + int.Parse(Console.ReadLine());

                Console.Write("¿Continuar ? (S / N): ");
                c = char.Parse(Console.ReadLine());

            } while (ValidarRespuesta.ValidaS_N(c));

            Console.Write("\n\nSUMA TOTAL: {0:#,###}", numeroUser);
            Console.Read();
        }
    }
}
