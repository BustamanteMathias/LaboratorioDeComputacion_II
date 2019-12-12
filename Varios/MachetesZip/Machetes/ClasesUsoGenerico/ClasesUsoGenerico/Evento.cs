using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesUsoGenerico
{
    public class Evento
    {
        int tiempo;
        // Delegado del evento
        public delegate void EventRaise(string mensaje);
        // Evento del tipo del delegado
        public event EventRaise EventoQueGenera;
    
        public Evento(int tiempo)
        {
            this.tiempo = tiempo;
        }
        
        public void esteMetodoGeneraEvento()
        {
            // Duermo el programa durante el tiempo dado
            System.Threading.Thread.Sleep(tiempo);
            // Lanzo el evento
            EventoQueGenera(String.Format("Evento lanzado a los {0} milisegundos", tiempo));
        }

        //************** ESTO ESTABA EN EL FORMULARIO DONDE SALTA EL EVENTO

        private void btnEvento_Click(object sender, EventArgs e)
        {
            // Clase que generará un evento, con un tiempo de 4s
            Evento lanzaEvento = new Evento(4000);
            // Agrego el método local EventoGenerado al manejador de eventos del objeto lanzaEvento
            lanzaEvento.EventoQueGenera += EventoGenerado;
            // Ejecuto un método de la clase que generará un evento
            lanzaEvento.esteMetodoGeneraEvento();
        }

        private void EventoGenerado(string mensaje)
        {
            // Mensaje del evento.
            //MessageBox.Show(mensaje); //Hacia dormir el hilo y despues de 4s salta el MessageBox
        }

    }
}
