using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_02
{
  public class Sello
  {
    public static string mensaje;
    public static ConsoleColor color;

    public static string Imprimir()
    {
      return ArmarFormatoMensaje();
    }

    public static void Borrar()
    {
      Sello.mensaje = "";
    }

    public static void ImprimirEnColor()
    {
      Console.ForegroundColor = Sello.color;

      Console.WriteLine(Sello.Imprimir());

      Sello.color = ConsoleColor.Gray;

      Console.ForegroundColor = Sello.color;

      Console.WriteLine("COLOR ORIGINAL");
    }

    private static string ArmarFormatoMensaje()
    {
      string cadena = "";

      for (int i = 0; i < Sello.mensaje.Length + 2; i++)
      {
        cadena += "*";
  
      }

      cadena += "\n*" + Sello.mensaje + "*\n" + cadena;

      return cadena;
    }

   }
}
