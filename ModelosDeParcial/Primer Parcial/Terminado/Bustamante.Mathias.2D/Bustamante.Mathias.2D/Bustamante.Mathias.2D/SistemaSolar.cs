using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bustamante.Mathias._2D
{
  public class SistemaSolar
  {
    #region ATRIBUTOS

    private List<Astro> planetas;
    #endregion

    #region PROPIEDADES

    public List<Astro> Planetas { get { return this.planetas; } set { this.planetas = value; } }
    #endregion

    #region CONSTRUCTOR

    public SistemaSolar()
    {
      this.planetas = new List<Astro>();
    }
    #endregion

    #region METODOS

    public string MostrarInformacionAstros()
    {
            StringBuilder s = new StringBuilder();

            byte contadorPlanetas = 1;

            if (!Equals(this.Planetas, null))
            {
                if (this.Planetas.Count == 0)
                {
                    s.Append("SIN PLANETAS PARA INFORMAR.");
                }
                else
                {
                    foreach (Planeta planeta in this.Planetas)
                    {
                        s.AppendLine("**************************************************");
                        s.AppendFormat("----------> Planeta N°{0}\n", contadorPlanetas);
                        s.AppendLine(planeta.ToString());

                        if (planeta.Satelites.Count > 0)
                        {
                            s.AppendLine("---> Satelites:\n");

                            foreach (Satelite satelite in planeta.Satelites)
                            {
                                s.AppendLine(satelite.ToString());
                            }
                        }
                        contadorPlanetas++;
                    }
                    s.AppendLine("**************************************************");
                }
            }

            return s.ToString();
    }
    #endregion
  }
}
