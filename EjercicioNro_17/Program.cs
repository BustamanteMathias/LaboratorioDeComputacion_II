using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NameSpaceBoligrafo;

namespace EjercicioNro_17
{
    class EjercicioNro_17
    {
        static void Main(string[] args)
        {
            short tintaBoligrafoAzul = 100;
            short tintaBoligrafoRojo = 50;
            string test;

            
            Boligrafo boligrafoRojo = new Boligrafo(tintaBoligrafoRojo, ConsoleColor.Red);

            boligrafoRojo.Pintar(10, out test);
            Console.WriteLine(test);
            Console.ReadKey();

            Boligrafo boligrafoAzul = new Boligrafo(tintaBoligrafoAzul, ConsoleColor.Blue);

            boligrafoAzul.Pintar(25, out test);
            Console.WriteLine(test);
            Console.ReadKey();

        }
    }
}
