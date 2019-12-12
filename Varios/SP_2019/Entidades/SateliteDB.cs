using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace Entidades
{
    public class SateliteDB
    {
        public bool Guardar(Satelite satelite)
        {
            //Creando variable de conexion
            SqlConnection conexion = new SqlConnection();
            //Asignando conexion
            conexion.ConnectionString = String.Format("Data Source={0};Initial Catalog={1};Integrated Security=True", "", "");
            //Creo Query
            string sqlQuery = "INSERT INTO dbo.Satelites (nombre, duracion_orbita, duracion_rotacion) VALUES ('" + satelite.Nombre + "', '" + satelite.DuraOrbita + "', '" + satelite.DuraRotacion + "')";
            //Creo Comando para ejecutar Query
            SqlCommand comando = new SqlCommand();
            comando.CommandType = CommandType.Text;
            comando.CommandText = sqlQuery;
            comando.Connection = conexion;

            try
            {
                //Abro conexion
                conexion.Open();
                //Ejecuto Query
                comando.ExecuteNonQuery();

                return true;
            }
            catch (Exception)
            {
                return false;
            }
            finally
            {
                //Cerrando conexion
                conexion.Close();
                conexion.Dispose();
            }
        }

        public List<Satelite> Leer()
        {
            List<Satelite> rtnLista = new List<Satelite>();

            //Creando variable de conexion
            SqlConnection conexion = new SqlConnection();
            //Asignando conexion
            conexion.ConnectionString = String.Format("Data Source={0};Initial Catalog={1};Integrated Security=True", "", "");

            try
            {
                //Abro conexion
                conexion.Open();
                //Creando comando sql
                SqlCommand command = new SqlCommand("SELECT * planetario.dbo.Satelites", conexion);
                //Creando un lector sql para leer los datos del comando.
                using (SqlDataReader lector = command.ExecuteReader())
                {
                    //Mientras lector tenga texto
                    while (lector.Read())
                    {
                        //Obtener datos y cargarlos
                        rtnLista.Add(new Satelite((int)lector[0], (int)lector[1], (string)lector[2]));
                    }
                }
            }
            catch (Exception)
            {
            }
            finally
            {
                //Cerrando conexion
                conexion.Close();
                conexion.Dispose();
            }

            return rtnLista;
        }
    }
}
