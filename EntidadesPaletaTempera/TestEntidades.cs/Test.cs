using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntidadesPaletaTempera;

namespace TestEntidades.cs
{
    class Test
    {
        static void Main(string[] args)
        {
            EntidadesPaletaTempera.Paleta p = 5;
            EntidadesPaletaTempera.Tempera t1 = new Tempera(ConsoleColor.Black, "Marca1", 100);
            EntidadesPaletaTempera.Tempera t2 = new Tempera(ConsoleColor.Black, "Marca1", 50);
            EntidadesPaletaTempera.Tempera t3 = new Tempera(ConsoleColor.Blue, "Marca2", 200);

            p = p + t2;

            Console.WriteLine("Paleta : " + (string)p);
            Console.WriteLine("Tempera 1: " + t1);
            Console.WriteLine("Tempera 2: " + t2);
            Console.WriteLine("Tempera 3: " + t3);

            Console.ReadKey();
        }
    }
}
