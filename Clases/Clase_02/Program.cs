using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_02
{
  class Program
  {
    static void Main(string[] args)
    {
      //SET
      Sello.color = ConsoleColor.Red;
      Sello.mensaje = "Hola!";

      Console.WriteLine("TEXTO CON FORMATO\n");
      Console.WriteLine(Sello.Imprimir());

      Console.WriteLine("TEXTO CON FORMATO Y COLOR\n");
      Sello.ImprimirEnColor();

      
      Sello.Borrar();
      Console.WriteLine("TEXTO BORRADO Y COLOR ORIGINAL\n");
      Console.WriteLine(Sello.Imprimir());

      Console.ReadKey();
    }
  }
}
