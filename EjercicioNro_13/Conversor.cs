using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioNro_13
{
    class Conversor
    {
        public static string DecimalBinario(double num)
        {
            String cadena = "";

            if (num > 0)
            {
                while (num > 0)
                {
                    if (num % 2 == 0)
                    {
                        cadena = "0" + cadena;
                    }
                    else
                    {
                        cadena = "1" + cadena;
                    }
                    num = (int)(num / 2);
                }
            }
            else
            {
                if (num == 0)
                {
                    cadena = "0";
                }
                else
                {
                    Console.WriteLine("Ingrese solo numeros positivos");
                }
            }

            return cadena;
        }

        //*******************************************************************************

        public static double BinarioDecimal(string cad)
        {
            char[] array = cad.ToCharArray();
            // Se invierte de derecha a izquierda: 16-8-4-2-1
            Array.Reverse(array);

            double suma = 0;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == '1')
                {
                    suma += (double)Math.Pow(2, i);
                }
            }
            return suma;
        }
    }
}
