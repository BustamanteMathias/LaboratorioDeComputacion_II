using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace ClasesUsoGenerico
{
    public class SQLConexion
    {

        /** Environment.GetFolderPath(Environment.SpecialFolder.Desktop)        // path al escritorio
            Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)    // Mis Documentos
            Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles)   // archivos de programa */


        public bool Leer()
        {
            bool rtn = false;
            //Creando variable de conexion
            SqlConnection conexion = new SqlConnection();
            //Asignando conexion
            conexion.ConnectionString = GenerarCadenaConexion("Instancia", "BaseDeDatos");
            
            try
            {
                //Abro conexion
                conexion.Open();
                //Creando comando sql
                SqlCommand command = new SqlCommand("SELECT * FROM prueba", conexion);
                //Creando un lector sql para leer los datos del comando.
                using (SqlDataReader lector = command.ExecuteReader())
                {
                    //Mientras lector tenga texto
                    while (lector.Read())
                    {
                        //Escribira los siguientes datos
                        Console.WriteLine(String.Format("{0} | {1} ", lector[0], lector[1]));
                    }
                }

                rtn = true;
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

            return rtn;
        }

        public bool Guardar()
        {
            bool rtn = false;
            //Creando variable de conexion
            SqlConnection conexion = new SqlConnection();
            //Asignando conexion
            conexion.ConnectionString = GenerarCadenaConexion("Instancia", "BaseDeDatos");
            //Creo Query
            string sqlQuery = string.Empty; //= "INSERT INTO dbo.Satelites (nombre, duracion_orbita, duracion_rotacion) VALUES ('" + satelite.Nombre + "', '" + satelite.DuraOrbita + "', '" + satelite.DuraRotacion + "')";
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

                rtn = true;
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

            return rtn;
        }

        private string GenerarCadenaConexion(string InstanciaServidor, string BaseDeDatos)
        {
            return String.Format("Data Source={0};Initial Catalog={1};Integrated Security=True", InstanciaServidor, BaseDeDatos);
        }
    }
}
