using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Entidades;

namespace Archivos
{
    public class Texto : IArchivo<Queue<Patente>>
  {

    public bool Guardar(string archivo, Queue<Patente> datos)
    {
      bool rtn = false;

      try
      {
        StreamWriter f = new StreamWriter(archivo);
        //f.Write(datos);

        foreach (Patente item in datos)
        {
          f.WriteLine(item);
        }

        f.Close();
        rtn = true;
      }
      catch (Exception e)
      {
        Console.WriteLine("Error TEXTO/GUARDAR: " + e.Message);
      }

      return rtn;
    }
    
    public bool Leer(string archivo, out Queue<Patente> datos)
    {
      bool rtn = false;
      datos = null;

      try
      {
        StreamReader f = new StreamReader(archivo);
        //datos = f.ReadToEnd();
        string aux = f.ReadToEnd();
        while (f.EndOfStream)
        {
          //datos.Enqueue((Patente)f.ReadLine());
        }
        
        f.Close();
        rtn = true;
      }
      catch (Exception e)
      {
        Console.WriteLine("Error TEXTO/LEER: " + e.Message);
      }

      return rtn;
    }
  }
}
