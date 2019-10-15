using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bustamante.Mathias._2D;

namespace FormSistemaSolar
{
  public partial class formSistemaSolar : Form
  {
    #region ATRIBUTOS

        public static List<Astro>   planetas;
    #endregion

    #region CONSTRUCTORES

    static formSistemaSolar()
    {
      formSistemaSolar.planetas = new List<Astro>();
    }

    public formSistemaSolar()
    {
      InitializeComponent();
    }
    #endregion

    #region EVENTOS

    private void formSistemaSolar_Load(object sender, EventArgs e)
    {
            this.Text = "Bustamante Mathias 2D";

            this.txtNombrePlaneta.Text = "";
            this.txtNombreSatelite.Text = "";
            

            this.cmbTipo.Items.Add(Tipo.Gaseoso.ToString());
            this.cmbTipo.Items.Add(Tipo.Rocoso.ToString());
            this.cmbTipo.SelectedItem = Tipo.Gaseoso.ToString();
    }

    private void btnAgregarPlaneta_Click(object sender, EventArgs e)
    {
            Planeta planeta;

            string infoPlaneta = "";
            bool validarCampos = true;


            string nombrePlaneta = "";
            if (this.txtNombrePlaneta.Text == string.Empty)
            {
                infoPlaneta += "Nombre planeta vacio\n";
                validarCampos = false;
            }
            else
            {
                nombrePlaneta = this.txtNombrePlaneta.Text;
                nombrePlaneta = nombrePlaneta.ToUpper();
            }

            int duraOrbita;
            if (!int.TryParse(this.txtOrbitaPlaneta.Text, out duraOrbita) || duraOrbita < 0)
            {
                infoPlaneta += "Duracion de orbita invalida\n";
                validarCampos = false;
            }

            int duraRot;
            if (!int.TryParse(this.numRotacion.Text, out duraRot) || duraRot < 0)
            {
                infoPlaneta += "Rotacion invalida\n";
                validarCampos = false;
            }

            int cantSatelites;
            if (!int.TryParse(this.numSatelite.Text, out cantSatelites) || cantSatelites < 0)
            {
                infoPlaneta += "Cantidad de satelite invalido\n";
                validarCampos = false;
            }
            
            Tipo tipo = Tipo.Gaseoso;
            if (this.cmbTipo.Text == "Rocoso")
            {
                tipo = Tipo.Rocoso;
            }

            bool validarExistenciaPlaneta = true;
            foreach (Planeta item in formSistemaSolar.planetas)
            {
                if ((string)item == nombrePlaneta)
                {
                    validarExistenciaPlaneta = false;
                    infoPlaneta = "Este planeta ya existe.";
                    break;
                }
            }

            //CREAR PLANETA SI TODOSLOS CAMPOS SON CORRECTOS
            if (validarCampos && validarExistenciaPlaneta)
            {
                planeta = new Planeta(duraOrbita, duraRot, nombrePlaneta, cantSatelites, tipo);

                formSistemaSolar.planetas.Add(planeta);
                this.cmbPlanetas.Items.Add((string)planeta);

                this.richTextBox1.Text = planeta.ToString();
            }
            else
            {
                this.richTextBox1.Text = infoPlaneta;
            }
    }
        #endregion

        private void btnAgregarSatelite_Click(object sender, EventArgs e)
        {
            string infoSatelite = "";
            bool validarCampos = true;

            string nombreSatelite = "";
            if (this.txtNombreSatelite.Text == string.Empty)
            {
                infoSatelite += "Nombre satelite vacio\n";
                validarCampos = false;
            }
            else
            {
                nombreSatelite = this.txtNombreSatelite.Text;
                nombreSatelite = nombreSatelite.ToUpper();
            }

            int orbSatelite;
            if (!int.TryParse(this.numOrbitaSatelite.Text, out orbSatelite) || orbSatelite < 0)
            {
                infoSatelite += "Orbita de satelite invalida\n";
                validarCampos = false;
            }

            int rotSatelite;
            if (!int.TryParse(this.numRotacionSatelite.Text, out rotSatelite) || rotSatelite < 0)
            {
                infoSatelite += "Rotacion de satelite invalida\n";
                validarCampos = false;
            }

            // AGREGAR SATELITE A PLANETA SI TODOS SUS CAMPOS SON CORRECTOS
            if (validarCampos && this.cmbPlanetas.Text != string.Empty)
            {
                Satelite satelite = new Satelite(orbSatelite, rotSatelite, nombreSatelite);

                foreach (Planeta item in formSistemaSolar.planetas)
                {
                    if ((string)item == this.cmbPlanetas.Text)
                    {
                        if (item + satelite)
                        {
                            infoSatelite = satelite.ToString();
                        }
                        else
                        {
                            infoSatelite = "ERROR. Este satelite ya se encuenta dentro del planeta o la cantidad maxima de satelites soportados por este planeta ya llego a su tope.";
                        }
                        break;
                    }
                }

                this.richTextBox1.Text = infoSatelite;
            }
            else
            {
                if (this.cmbPlanetas.Text == string.Empty)
                {
                    infoSatelite += "Seleccioonar un planeta valido\n";
                }

                this.richTextBox1.Text = infoSatelite;
            }
            
        }

        private void btnInfo_Click(object sender, EventArgs e)
        {
            SistemaSolar sistemaSolar = new SistemaSolar();
            sistemaSolar.Planetas = formSistemaSolar.planetas;
            
            this.richTextBox1.Text = sistemaSolar.MostrarInformacionAstros();
        }

        private void btnMoverAstros_Click(object sender, EventArgs e)
        {
            StringBuilder s = new StringBuilder();
            List<Astro> lista = formSistemaSolar.planetas;

            if (!Equals(lista, null))
            {
                if (lista.Count == 0)
                {
                    s.Append("SIN ASTROS PARA MOVER.");
                }
                else
                {
                    foreach (Planeta planeta in lista)
                    {
                        s.AppendLine("--------------------------------------------");
                        s.AppendLine("Planeta...");
                        s.AppendLine(planeta.Orbitar());
                        s.AppendLine(planeta.Rotar());

                        if (planeta.Satelites.Count > 0)
                        {
                            s.AppendLine("Satelites...");
                            foreach (Satelite satelite in planeta.Satelites)
                            {
                                s.AppendLine(satelite.Rotar());
                            }
                        }
                    }
                    s.AppendLine("--------------------------------------------");
                }
            }

            this.richTextBox1.Text = s.ToString();
        }
    }
}
