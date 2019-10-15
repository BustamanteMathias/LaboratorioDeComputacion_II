using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bustamante.Mathias._2D
{
  public class Planeta : Astro
  {
    #region ATRIBUTOS

    private int cantSatelites;
    private Tipo tipo;
    private List<Astro> satelites;
    #endregion

    #region PROPIEDADES

    public List<Astro> Satelites { get { return this.satelites; } }
    #endregion

    #region CONSTRUCTORES

    public Planeta(int duraOrbita, int duraRot, string nombre, int cantSatelites, Tipo tipo) : this(duraOrbita, duraRot, nombre)
    {
      this.cantSatelites = cantSatelites;
      this.tipo = tipo;
      this.satelites = new List<Astro>();
    }

    public Planeta(int duraOrbita, int duraRotacion, string nombre) : base(duraOrbita, duraRotacion, nombre)
    {

    }
    #endregion

    #region METODOS

    public string Rotar()
    {
      return string.Format("Rota el planeta: {0}", this.nombre);
    }
    public override string Orbitar()
    {
      return string.Format("Orbita el planeta: {0}", this.nombre);
    }

    public static bool operator !=(Planeta planeta, Planeta planeta2)
    {
      return !(planeta == planeta2);
    }
    public static bool operator !=(Planeta planeta, Satelite satelite)
    {
      return !(planeta == satelite);
    }
    public static bool operator ==(Planeta planeta, Planeta planeta2)
    {
      bool rtn = false;

      if (planeta.nombre == planeta2.nombre)
      {
        rtn = true;
      }

      return rtn;
    }
    public static bool operator ==(Planeta planeta, Satelite satelite)
    {
      bool rtn = false;

      if (Equals(planeta, null) && Equals(satelite, null))
      {
        rtn = true;
      }
      else
      {
        if (!Equals(planeta, null) && !Equals(satelite, null))
        {
          foreach (Astro item in planeta.Satelites)
          {
            if ((string)item == satelite.Nombre)
            {
              rtn = true;
              break;
            }
          }
        }
        else
        {
          rtn = false;
        }
      }

      return rtn;
    }
    public static bool operator +(Planeta planeta, Satelite satelite)
    {
      bool rtn = false;

      if (!Equals(satelite, null) && satelite is Satelite)
      {
        if (!(planeta == satelite) && planeta.Satelites.Count < planeta.cantSatelites)
        {
          planeta.Satelites.Add(satelite);
          rtn = true;
        }

      }

      return rtn;
    }
    public override string ToString()
    {
      StringBuilder s = new StringBuilder();

      s.AppendLine(this.Mostrar());
      s.AppendLine("Tipo: " + this.tipo.ToString());
      s.AppendLine("Cantidad de satelites: " + this.cantSatelites);

      return s.ToString();
    } 
    #endregion

  }
}
