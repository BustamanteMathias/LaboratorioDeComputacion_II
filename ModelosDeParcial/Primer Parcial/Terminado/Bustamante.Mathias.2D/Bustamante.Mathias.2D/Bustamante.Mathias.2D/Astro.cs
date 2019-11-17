using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bustamante.Mathias._2D
{
  public abstract class Astro
  {
    #region ATRIBUTOS

    private int duracionOrbita;
    private int duracionRotacion;
    protected string nombre;
    #endregion


    #region CONSTRUCTOR

    public Astro(int duraOrbita, int duraRotacion, string nombre)
    {
      this.duracionOrbita = duraOrbita;
      this.duracionRotacion = duraRotacion;
      this.nombre = nombre;
    }
    #endregion


    #region METODOS

    protected string Mostrar()
    {
      return string.Format("Astro: {0}\nÓrbita: {1}\nRotación: {2}", this.nombre, this.duracionOrbita, this.duracionRotacion);
    }

    public abstract string Orbitar();

    public virtual string Rotar()
    {
      return string.Format("Rotando. Tiempo estimado: {0}.", this.duracionRotacion);
    }

    public static explicit operator string(Astro a)
    {
      return a.nombre;
    } 
    #endregion

  }
}
