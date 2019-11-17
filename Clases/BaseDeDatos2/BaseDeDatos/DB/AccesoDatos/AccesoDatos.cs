using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using DB;

namespace DB
{
    public class AccesoDatoss
    {
        private SqlConnection _sqlConnection;   //PARA ESTABLECER CONEXION CON BASE DE DATOS
        private SqlCommand _sqlCommand;         //PARA CONSULTAS
        private List<Persona> _listaPersonas;

        public AccesoDatoss()
        {
            this._sqlConnection = new SqlConnection("Data Source=LAB5PC08\\SQLEXPRESS;Integrated Security=True");
            this._listaPersonas = new List<Persona>();
        }

        public List<Persona> TraerTodos()
        {
            this._sqlCommand = new SqlCommand();

            this._sqlCommand.Connection = this._sqlConnection;
            this._sqlCommand.CommandType = CommandType.Text;
            this._sqlCommand.CommandText = "SELECT id, nombre, apellido, edad FROM Padron.dbo.Personas";

            try
            {
                this._sqlConnection.Open();
                SqlDataReader _sqlDataReader = this._sqlCommand.ExecuteReader();

                while(_sqlDataReader.Read())
                {
                    Persona miPersona = new Persona((int)_sqlDataReader["id"], _sqlDataReader["nombre"].ToString(),
                      _sqlDataReader["apellido"].ToString(), (int)_sqlDataReader["edad"]);
          
                    this._listaPersonas.Add(miPersona);
                }
                this._sqlConnection.Close();
            }
            catch (Exception)
            {
                throw;
            }

            return this._listaPersonas;
        }

        public bool AgregarPersona( Persona p)
        {
          bool rtn = false;
      try
      {
        this._sqlCommand = new SqlCommand();

        this._sqlCommand.Connection = this._sqlConnection;
        this._sqlCommand.CommandType = CommandType.Text;
        this._sqlCommand.CommandText =
        "INSERT INTO Padron.dbo.Personas " +
        "(nombre, apellido, edad) " +
        "VALUES('" + p.nombre + "','" + p.apellido + "'," + p.edad.ToString() + ")";

        this._sqlConnection.Open();
        if(this._sqlCommand.ExecuteNonQuery()>0)
        {
          rtn = true;
        }
        this._sqlConnection.Close();
      }
      catch (Exception)
        {
          throw;
        }
            return rtn;
        }

    public bool ModificarPersona(Persona p)
    {
      bool rtn = false;

      try
      {
        this._sqlCommand = new SqlCommand();

        this._sqlCommand.Connection = this._sqlConnection;
        this._sqlCommand.CommandType = CommandType.Text;
        this._sqlCommand.CommandText =
        "UPDATE Padron.dbo.Personas " +
        "SET nombre = '" + p.nombre + "', apellido = '" + p.apellido + "', edad = " + p.edad.ToString() +
        "WHERE id = " + p.id;

        this._sqlConnection.Open();
        if (this._sqlCommand.ExecuteNonQuery() > 0)
        {
          rtn = true;
        }
        this._sqlConnection.Close();
      }
      catch (Exception)
      {
        throw;
      }
      return rtn;
    }

    public bool EliminarPersona(int id)
    {
      bool rtn = false;
        try
        {
        this._sqlCommand = new SqlCommand();

        this._sqlCommand.Connection = this._sqlConnection;
        this._sqlCommand.CommandType = CommandType.Text;
        this._sqlCommand.CommandText =
        "DELETE FROM Padron.dbo.Personas " +
        "WHERE id = " + id;

        this._sqlConnection.Open();
        if (this._sqlCommand.ExecuteNonQuery() > 0)
        {
          rtn = true;
        }
        this._sqlConnection.Close();
        }
        catch (Exception)
        {
        throw;
        }
      return rtn;
    }

    public DataTable TraerTablaPersonas()
    {
      DataTable dataTable = new DataTable("Personas");
      this._sqlCommand = new SqlCommand();

      this._sqlCommand.Connection = this._sqlConnection;
      this._sqlCommand.CommandType = CommandType.Text;
      this._sqlCommand.CommandText = "SELECT id, nombre, apellido, edad FROM Padron.dbo.Personas";

      try
      {
        this._sqlConnection.Open();
        SqlDataReader _sqlDataReader = this._sqlCommand.ExecuteReader();
        dataTable.Load(_sqlDataReader);

        //while (_sqlDataReader.Read())
        //{
        //  Persona miPersona = new Persona((int)_sqlDataReader["id"], _sqlDataReader["nombre"].ToString(),
        //    _sqlDataReader["apellido"].ToString(), (int)_sqlDataReader["edad"]);

        //  this._listaPersonas.Add(miPersona);
        //}
        this._sqlConnection.Close();
      }
      catch (Exception)
      {
        throw;
      }
      return dataTable;
    }
    }

    public class Persona
    {
        public int id;
        public string nombre;
        public string apellido;
        public int edad;

    public Persona(int id, string nombre, string apellido, int edad)
    {
      this.id = id;
      this.nombre = nombre;
      this.apellido = apellido;
      this.edad = edad;
    }
        public override string ToString()
        {
            return string.Format("ID: {0}\tNOMBRE COMPLETO: {1}, {2}\tEDAD: {3}\n", this.id, this.apellido, this.nombre, this.edad);
        }
    }
}
