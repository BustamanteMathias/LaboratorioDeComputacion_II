using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Perro : Mascota
    {
        private int _edad;
        private bool _esAlfa;

        public Perro(string nombre, string raza) : base(nombre, raza)
        {
            //LOS INICIALIZA EN FALSE Y 0 POR DEFECTO
        }
        public Perro(string nombre, string raza, int edad, bool esAlfa) : this(nombre, raza)
        {
            this._edad = edad;
            this._esAlfa = esAlfa;
        }
        protected override string Ficha()
        {
            string rtn;

            if (this._esAlfa)
            {
                rtn = this.Nombre + " " + this.Raza + ", alfa de la manada, edad " + this._edad;
            }
            else
            {
                rtn = this.Nombre + " " + this.Raza + ", edad " + this._edad;
            }

            return rtn;
        }

        public static bool operator ==(Perro p1, Perro p2)
        {
            bool rtn = false;

            if (p1.Nombre == p2.Nombre && p1.Raza == p2.Raza && p1._edad == p2._edad)
            {
                rtn = true;
            }

            return rtn;
        }

        public static bool operator !=(Perro p1, Perro p2)
        {
            return !(p1 == p2);
        }
        public static explicit operator int(Perro p1)
        {
            return p1._edad;
        }

        public override string ToString()
        {
            return this.Ficha();
        }
        public override bool Equals(object obj)
        {
            bool rtn = false;

            if (obj is Perro)
            {
               if ((Perro)obj == this)
                {
                    rtn = true;
                }
            }
            return rtn;
        }

    }
}
