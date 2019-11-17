using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SqlClient;
using System.Data;
using Entidades;

namespace Archivos
{
    public class Sql
    {
    private SqlCommand comando;
    private SqlConnection conexion;

    public Sql()
    {
      string dataConexion = "Data Source=.\\SQLEXPRESS;Initial Catalog =patentes-sp-2018; Integrated Security = True";
      this.conexion = new SqlConnection(dataConexion);

      this.comando = new SqlCommand();
      this.comando.CommandType = CommandType.Text;
      this.comando.Connection = conexion;
    }

    public void Guardar(string tabla, Queue<Patente> datos)
    {
      foreach (Patente item in datos)
      {
        string consulta = "INSERT INTO " + tabla + " (patente, tipo) VALUES('" + item.CodigoPatente + "', )";
      }
      

    }

    public void Leer(string tabla, Queue<Patente> datos)
    {
      
      try
      {
        this.comando.CommandText = "SELECT * FROM " + tabla;
        this.conexion.Open();
        SqlDataReader oDr = comando.ExecuteReader();

        while (oDr.Read())
        {
          string patente  = oDr["patente"].ToString();
          string tipo     = oDr["tipo"].ToString();

          if (tipo == "Mercosur")
          {
            datos.Enqueue(new Patente(patente, Patente.Tipo.Mercosur));
          }
          else
          {
            datos.Enqueue(new Patente(patente, Patente.Tipo.Vieja));
          }
        }
      }
      catch (Exception e)
      {
        Console.WriteLine("Error Leer SQL" + e.Message);
      }
      finally
      {
        this.conexion.Close();
      }

    }

  }
}
