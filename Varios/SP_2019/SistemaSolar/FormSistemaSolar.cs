using Entidades;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Windows.Forms;

namespace SistemaSolar
{
    public partial class FormSistemaSolar : Form
    {
        private Planeta<Satelite> planeta;

        public FormSistemaSolar()
        {
            InitializeComponent();
            this.Text = "Bustamante Mathias 2C";
        }
        
        private void FormSistemaSolar_Load(object sender, EventArgs e)
        {
            this.planeta = new Planeta<Satelite>(20, 20, "Jupiter");

            ////Traer Satelites que haya en la base de datos
            //SateliteDB db = new SateliteDB();
            //List<Satelite> s = db.Leer();
            ////Si la lista de la DB no es nula os agrego de a uno a la lista de Planetas
            //if (!object.Equals(s, null))
            //{
            //    foreach (Satelite item in s)
            //    {
            //        this.planeta.Satelites.Add(item);
            //    }
            //}
        }

        private void btnRotarPlaneta_Click(object sender, EventArgs e)
        {
            if (object.Equals(this.planeta.HiloRotacion, null))
            {
                // ESTO NO LO ENTENDI, REVISAR PORQUE MANDE FRUTA
                Thread t = new Thread(new ThreadStart(this.planeta.RunEvntRotar));
            }
        }

        private void btnOrbitarSatelite_Click(object sender, EventArgs e)
        {
            /** a. Chequear si el evento del satélite tiene manejadores asignados.
                b. Si no tiene agregarlo.????????????????? */
            
            this.planeta.AstroEvent += this.planeta.InvocarEvento;

            foreach (Satelite item in this.planeta.Satelites)
            {
                if (object.Equals(item.HiloOrbita, null) || !item.HiloOrbita.IsAlive)
                {
                    // ESTO NO LO ENTENDI, REVISAR PORQUE MANDE FRUTA
                    Thread t = new Thread(new ThreadStart(this.planeta.RunEvntOrb));
                }
                else
                {
                    this.MostrarMensaje("No se puedo iniciar la Orbita");
                }
            }
        }

        private void btnSatelite_Click(object sender, EventArgs e)
        {
            Satelite s;
            int orbita;
            int rotacion;

            if (this.txNombre.Text != string.Empty)
            {
                if (int.TryParse(this.txOrbita.Text, out orbita) && int.TryParse(this.txRota.Text, out rotacion))
                {
                    //Instancia Satelite
                    s = new Satelite(orbita, rotacion, this.txNombre.Text);
                    //Agrega el Satelite a la lista
                    this.planeta.Satelites.Add(s);
                    ////Instancia de clase SateliteDB
                    //SateliteDB db = new SateliteDB();
                    ////Guarda Satelite en Base de datos
                    //db.Guardar(s);
                }
            }
        }

        public void MostrarMensaje(string mensaje)
        {
            MessageBox.Show(mensaje);
        }
    }
}
