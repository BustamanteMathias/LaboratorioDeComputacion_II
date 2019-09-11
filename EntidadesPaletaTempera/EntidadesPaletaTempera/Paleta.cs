using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesPaletaTempera
{
    public class Paleta
    {
        private Tempera[] temperas;
        private int cantidadMaximaDeTemperas;

        private Paleta() : this(5)
        {
        }

        private Paleta(int cantidad)
        {
            this.temperas = new Tempera[this.cantidadMaximaDeTemperas];
            this.cantidadMaximaDeTemperas = cantidad;
        }

        public static implicit operator Paleta(int cantidad)
        {
            return new Paleta(cantidad);
        }

        private string Mostrar()
        {
            string s = string.Format("Cantidad maxima de temperas: {0} | Temperas:\n ", this.cantidadMaximaDeTemperas);

            foreach (Tempera item in this.temperas)
            {
                s += item + "\n";
            }
            return s;
        }

        public static explicit operator string (Paleta p)
        {
            return p.Mostrar();
        }

        public static bool operator == (Paleta p, Tempera t)
        {
            bool rtn = false;
            
            if(p.Equals(null) || t.Equals(null))
            {
                rtn = false;
            }
            else
            {
                foreach (Tempera item in p.temperas)
                {
                    if (item == t)
                    {
                        rtn = true;
                        break;
                    }
                }
            }
            return rtn;
        }
        public static bool operator !=(Paleta p, Tempera t)
        {
            return !(p == t);
        }

        private int ObtenerEspacioLibre()
        {
            int rtn = -1;

            if (this != null)
            {
                for (int i = 0; i < this.cantidadMaximaDeTemperas; i++)
                {
                    if (this.temperas[i] == null)
                    {
                        rtn = i;
                        break;
                    }
                }
            }
            
            return rtn;
        }

        private int ObtenerIndiceTempera (Tempera t)
        {
            int rtn = -1;

            if (this != null)
            {
                for (int i = 0; i < this.temperas.Length; i++)
                {
                    if (this.temperas[i] == t)
                    {
                        rtn = i;
                        break;
                    }
                }
            }

            return rtn;
        }

        public static int operator |(Paleta p, Tempera t)
        {
            int rtn = -1;

            if(p != null)
            {
                for (int i = 0; i < p.temperas.Length; i++)
                {
                    if (p.temperas[i] == t)
                    {
                        rtn = i;
                        break;
                    }
                }
            }
            
            return rtn;
        }

        public static Paleta operator +(Paleta p, Tempera t)
        {
            
            if (p != null && t != null)
            {
                if (p.ObtenerIndiceTempera(t) == -1)    // SI NO EXISTE LA TEMPERA
                {
                    if(p.ObtenerEspacioLibre() != -1)   // SI HAY ESPACIO
                    {
                        p.temperas[p.ObtenerEspacioLibre()] = t;    // AGREGO TEMPERA AL INDICE QUE ME DA EL METODO DE OBTENER ESPACIO LIBRE
                    }
                }
                else    // SI EXISTE
                {
                    p.temperas[p.ObtenerIndiceTempera(t)] = p.temperas[p.ObtenerIndiceTempera(t)] + t; // SUMO SUS CANTIDADES CON SOBRECARGA DE + EN TEMPERAS
                }
            }
            return p;
        }
    }
}
