using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Mascota
    {
        private string _nombre;
        private string _raza;

        public Mascota( string nombre, string raza)
        {
            this._nombre = nombre;
            this._raza = raza;
        }

        private string nombre;

        public string Nombre
        {
            get { return this._nombre; }
        }

        private string raza;

        public string Raza
        {
            get { return this._raza; }
        }

        protected abstract string Ficha();

        protected virtual string DatosComplementos()
        {
            return this._nombre + " " + this.raza;
        }
    }
}
