using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioNro_11
{
    class Validacion
    {
        public static bool Validar(int valor, int min, int max)
        {
            bool validacion;

            if (valor < min || valor > max)
            {
                validacion = false;
            }
            else
            {
                validacion = true;
            }
            return validacion;
        }
    }
}
