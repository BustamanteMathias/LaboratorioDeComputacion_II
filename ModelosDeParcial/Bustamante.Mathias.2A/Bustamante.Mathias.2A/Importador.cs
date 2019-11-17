using System;
using System.Collections.Generic;
using System.Text;

namespace Bustamante.Mathias._2A
{
    public class Importador : Comercio
    {
        public EPaises paisOrigen;

        public Importador(string nombreComercio, float precioAlquiler, Comerciante comerciante, EPaises paisOrigen) : base (nombreComercio, comerciante, precioAlquiler)
        {
            this.paisOrigen = paisOrigen;
        }

        public string Mostrar()
        {
            return
                "\nNOMBRE COMERCIO: " + base._nombre +          //ARREGLAR
                "\nCOMERCIANTE: " + _comerciante +      
                "\nPRECIO ALQUILER: " + base._precioAlquiler +
                "\nTipo: " + paisOrigen.ToString();
        }

        public static bool operator ==(Importador i1, Importador i2)
        {
            bool rtn = false;

            if(i1._nombre == i2._nombre && i1.paisOrigen == i2.paisOrigen)
            {
                rtn = true;
            }

            return rtn;
        }

        public static bool operator !=(Importador i1, Importador i2)
        { 
            return !(i1 == i2);
        }

        public static implicit operator double(Importador i)
        {
            return i._precioAlquiler;
        }
    }
}
