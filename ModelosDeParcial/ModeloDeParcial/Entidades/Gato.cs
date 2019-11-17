using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Gato : Mascota
    {
        public Gato(string n, string r) : base (n, r)
        {
        }

        protected override string Ficha()
        {
            return this.Nombre + " " + this.Raza;
        }

        public static bool operator ==(Gato g1, Gato g2)
        {
            bool rtn = false;
            
            if(g1.Nombre == g2.Nombre && g2.Nombre == g2.Raza)
            {
                rtn = true;
            }
            return rtn;
        }

        public static bool operator !=(Gato g1, Gato g2)
        {
            return !(g1 == g2);
        }
        public override string ToString()
        {
            return this.Ficha();
        }
        public override bool Equals(object obj)
        {
            bool rtn = false;

            if(obj is Gato)
            {
                if((Gato)obj == this)
                {
                    rtn = true;
                }
            }
            return rtn;
        }
    }
}
