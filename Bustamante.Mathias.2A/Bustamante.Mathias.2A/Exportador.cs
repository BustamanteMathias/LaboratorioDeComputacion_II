using System;
using System.Collections.Generic;
using System.Text;

namespace Bustamante.Mathias._2A
{
    public class Exportador : Comercio
    {
        public ETipoProducto tipo;

        public Exportador(string nombreComercio, float precioAlquiler, string nombre, string apellido, ETipoProducto tipo) : base (precioAlquiler, nombreComercio, nombre, apellido)
        {
            this.tipo = tipo;
        }

        public string Mostrar()
        {
            return
                "\nNOMBRE: " + base._nombre +
                "\nCANTIDAD DE EMPLEADOS: " + base._cantidadDeEmpleados +
                "\nCOMERCIANTE: " + _comerciante + //ARREGLAR
                "\nPRECIO ALQUILER: " + base._precioAlquiler +
                "\nTipo: " + tipo.ToString();
        }

        public static bool operator ==(Exportador e1, Exportador e2)
        {
            bool rtn = false;

            if(e1._nombre == e2._nombre && e1.tipo == e2.tipo)
            {
                rtn = true;
            }
            return rtn;
        }

        public static bool operator !=(Exportador e1, Exportador e2)
        { 
            return !(e1 == e2);
        }

        public static implicit operator double(Exportador e)
        {
            return e._precioAlquiler;
        }

    }
}
