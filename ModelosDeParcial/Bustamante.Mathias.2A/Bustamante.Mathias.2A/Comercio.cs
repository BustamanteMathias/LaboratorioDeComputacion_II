using System;

namespace Bustamante.Mathias._2A
{
    public class Comercio
    {
        protected int _cantidadDeEmpleados;
        protected Comerciante _comerciante;
        protected static Random _generadorDeEmpleados;
        protected string _nombre;
        protected float _precioAlquiler;

        public int CantidadDeEmpleados
        {
            get { return CantidadDeEmpleados; }
        }

        private Comercio()
        {
            if (this._cantidadDeEmpleados == 0)
            {
                _generadorDeEmpleados = new Random();
                _cantidadDeEmpleados = _generadorDeEmpleados.Next(0, 101);
            }
        }
        public Comercio(string nombre, Comerciante comerciante, float precioAlquiler) : this()
        {
            this._precioAlquiler = precioAlquiler;
            this._nombre = nombre;
            this._comerciante = comerciante;
            
        }
        public Comercio(float precioAlquiler, string nombreComercio, string nombre, string apellido) : this()
        {
            this._nombre = nombreComercio;
            this._comerciante = new Comerciante(nombre, apellido);
            this._precioAlquiler = precioAlquiler;
        }

        private string Mostrar(Comercio c)
        {
            return (string)c;
        }

        public static bool operator ==(Comercio c1, Comercio c2)
        {
            bool rtn = false;
            if (c1._nombre == c2._nombre && c1._comerciante == c2._comerciante)
            {
                rtn = true;
            }

            return rtn;
        }

        public static bool operator !=(Comercio c1, Comercio c2)
        { 
            return !(c1 == c2);
        }

        public static implicit operator string(Comercio c)
        {
            string rtn;
            rtn =
                "\nNOMBRE: " + c._nombre +
                "\nCANTIDAD DE EMPLEADOS: " + c._cantidadDeEmpleados +
                "\nCOMERCIANTE: " + (string)c +
                "\nPRECIO ALQUILER: " + c._precioAlquiler;

            return rtn;
        }
    }
}
