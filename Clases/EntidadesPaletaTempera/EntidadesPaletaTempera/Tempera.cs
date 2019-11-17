using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesPaletaTempera
{
    public class Tempera
    {
        private ConsoleColor color;
        private string marca;
        private int cantidad;

        public Tempera(ConsoleColor color, string marca, int cantidad)
        {
            this.color = color;
            this.marca = marca;
            this.cantidad = cantidad;
        }

        private string Mostrar()
        {
            return string.Format("Color: {0} | Marca: {1} | Cantidad: {2}", this.color.ToString(), this.marca, this.cantidad.ToString());
        }

        public static implicit operator string (Tempera t)
        {
            return t.Mostrar();
        }

        public static bool operator ==(Tempera t1, Tempera t2)
        {
            bool rtn = false;

            if(t1.marca == t2.marca && t1.color == t2.color)
            {
                rtn = true;
            }
            return rtn;
        }

        public static bool operator !=(Tempera t1, Tempera t2)
        {
            return !(t1 == t2);
        }

        public static Tempera operator +(Tempera t, int n)
        {
            t.cantidad = t.cantidad + n;
            return t;
        }

        public static Tempera operator +(Tempera t1, Tempera t2)
        {
            if(t1 == t2)
            {
                t1.cantidad = t1.cantidad + t2.cantidad;
            }
            return t1;
        }
    }
}
