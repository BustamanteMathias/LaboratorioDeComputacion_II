using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioNro_13
{
    class EjercicioNro_13
    {
        static void Main(string[] args)
        {
            /**
             * Desarrollar una clase llamada Conversor, 
             * que posea dos métodos de clase (estáticos): 
             
               string DecimalBinario(double). Convierte un número de decimal a binario. 
               double BinarioDecimal(string). Convierte un número binario a decimal.
             */

            Console.Title = "EjercicioNro_13";

            double n = 1234;
            string stringBinario;
            double doubleDecimal;
           
            
            stringBinario = Conversor.DecimalBinario(n);
            doubleDecimal = Conversor.BinarioDecimal(stringBinario);
            Console.WriteLine("N = {0}\n\nDECIMAL-BINARIO: {1}\nBINARIO-DECIMAL: {2}", n, stringBinario, doubleDecimal);
            Console.Read();
        }
    }
}
