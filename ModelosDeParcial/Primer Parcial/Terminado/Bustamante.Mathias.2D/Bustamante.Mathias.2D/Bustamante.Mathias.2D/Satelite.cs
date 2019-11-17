using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bustamante.Mathias._2D
{
  public class Satelite : Astro
  {
    #region PROPIEDADES

    public string Nombre { get { return this.nombre; } }
    #endregion

    #region CONSTRUCTOR

    public Satelite(int duraOrbita, int duraRotacion, string nombre) : base(duraOrbita, duraRotacion, nombre)
    {

    }
    #endregion

    #region METODOS

    public override string Orbitar()
    {
      return string.Format("Orbitar el satelite: {0}", (string)this);
    }

    public override string ToString()
    {
      StringBuilder s = new StringBuilder();
      
      s.AppendLine(this.Mostrar());

      return s.ToString();
    } 
    #endregion

  }
}
