using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DB;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Persona> listaPersonas = new List<Persona>();
            DB.AccesoDatoss accesoDatos = new DB.AccesoDatoss();
            DataTable traerTabla = new DataTable("Personas");
      //accesoDatos.EliminarPersona(7);
      //listaPersonas = accesoDatos.TraerTodos();

      //foreach (Persona item in listaPersonas)
      //      {
      //          Console.Write(item.ToString());
      //      }
            // = accesoDatos.TraerTablaPersonas();
      //foreach (DataRow item in traerTabla.Rows)
      //{
      //  //Console.WriteLine((int)item["id"] + (string)item["nombre"] + (string)item["apellido"] + (int)item["edad"]);
      //  Persona p = new Persona((int)item["id"], (string)item["nombre"], (string)item["apellido"], (int)item["edad"]);
      //  listaPersonas.Add(p);
      //}
      //foreach (Persona item in listaPersonas)
      //{
      //  Console.WriteLine(item.ToString());
      //}

      //traerTabla.WriteXmlSchema("Personas_Esquema.xml");  //GUARDA ESQUEMA DE TABLASERIALIZADA
      //traerTabla.WriteXml("Personas_Datos.xml");          //GUARDA LOS DATOS DE LA TABLA SERIALIZADA
      traerTabla.ReadXmlSchema("Personas_Esquema.xml");     //LEE ESQUEMA EN ARCHIVO XML DE DATETABLE GUARDADO
      traerTabla.ReadXml("Personas_Datos.xml");             //LEE DATOS Y LOS CARGA AL ESQUEMA DE LA DATETABLE

      Console.ReadKey();
        }
    }
}
