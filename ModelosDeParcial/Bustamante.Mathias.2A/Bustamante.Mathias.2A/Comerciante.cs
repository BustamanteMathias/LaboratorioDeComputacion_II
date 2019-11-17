using Bustamante.Mathias._2A;
using System;
using System.Collections.Generic;
using System.Text;

namespace Bustamante.Mathias._2A
{
    public class Comerciante
    {
        private string _apellido;
        private string _nombre;

        public Comerciante(string nombre, string apellido)
        {
            this._nombre = nombre;
            this._apellido = apellido;
        }

        public static bool operator ==(Comerciante c1, Comerciante c2)
        {
            bool rtn = false; 

            if(c1._nombre == c2._nombre && c1._apellido == c2._apellido)
            {
                rtn = true;
            }

            return rtn;
        }

        public static bool operator !=(Comerciante c1, Comerciante c2)
        {
            return !(c1 == c2);
        }

        public static implicit operator string(Comerciante c)
        {
            return c._nombre + " - " + c._apellido;
        }
    }
}
