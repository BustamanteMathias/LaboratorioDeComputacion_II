using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Serialization;

namespace Archivos
{
    public class Xml<T> : IArchivo<T>
  {

    public bool Guardar(string archivo, T datos)
    {
      bool rtn = false;
      try
      {
        XmlSerializer s = new XmlSerializer(typeof(T));
        StreamWriter f = new StreamWriter(archivo);
        s.Serialize(f, datos);
        f.Close();
        rtn = true;
      }
      catch (Exception e)
      {
        Console.WriteLine("Error XML/GUARDAR: " + e.Message);
      }

      return rtn;
    }
    
    public bool Leer(string archivo, out T datos)
    {
      bool rtn = false;
      datos = default(T);
      try
      {
        XmlSerializer s = new XmlSerializer(typeof(T));
        StreamReader f = new StreamReader(archivo);
        datos = (T)s.Deserialize(f);
        f.Close();
        rtn = true;
      }
      catch (Exception e)
      {
        Console.WriteLine("Error XML/LEER: " + e.Message);
      }

      return rtn;
    }
  }
}
