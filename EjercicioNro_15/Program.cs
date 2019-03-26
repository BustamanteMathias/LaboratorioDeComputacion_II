using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioNro_15
{
    class EjercicioNro_15
    {
        static void Main(string[] args)
        {
            /**
             * Realizar un programa que permita realizar operaciones matemáticas simples 
             * (suma, resta, multiplicación y división). 
             * Para ello se le debe pedir al usuario que ingrese dos números y la operación que desea realizar 
             * (pulsando el caracter +, -, * ó /). 
             * El usuario decidirá cuándo finalizar el programa. 
             * Crear una clase llamada Calculadora que posea tres métodos estáticos (de clase):
                a. Calcular (público): Recibirá tres parámetros, el primer número, el segundo número 
                   y la operación matemática. El método devolverá el resultado de la operación.
                b. Validar (privado): Recibirá como parámetro el segundo número. 
                   Este método se debe utilizar sólo cuando la operación elegida sea la DIVISIÓN. 
                   Este método devolverá TRUE si el número es distinto de CERO.
             */

            Console.Title = "EjercicioNro_15";

            double numA;
            double numB;
            string operacion;
            byte continuar = 1;
            
            while(continuar == 1)
            {

                Console.Write("INGRESE NUMERO 1: ");
                numA = double.Parse(Console.ReadLine());

                Console.Write("INGRESE NUMERO 2: ");
                numB = double.Parse(Console.ReadLine());

                Console.Write("INGRESE OPERACION [+ - * /]:");
                operacion = Console.ReadLine();

                Console.Clear();
                Console.WriteLine("{0:#,###.00}", Calculadora.Calcular(numA, numB, operacion));
                Console.Write("\nCONTINUAR? [S] Si - [CUALQUIER TECLA] No: ");

                if (Console.ReadLine() == "S" || Console.ReadLine() == "s")
                {
                    continuar = 1;
                    Console.Clear();
                }
                else
                {
                    continuar = 0;
                }

            }
            
        }
    }
}
