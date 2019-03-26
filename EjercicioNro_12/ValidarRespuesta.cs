using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioNro_12
{
    class ValidarRespuesta
    {
       public static bool ValidaS_N(char c)
        {
            bool validarEntrada;
            
            if (c == 's' || c == 'S')
            {
                validarEntrada = true;
            }
            else
            {
                validarEntrada = false;
            }

            return validarEntrada;
        }
        
    }
}
