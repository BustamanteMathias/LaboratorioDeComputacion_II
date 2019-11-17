using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioNro_15
{
    class Calculadora
    {
        private static bool Validar(double numB)
        {
            bool validacion = true;

            if (numB == 0)
            {
                validacion = false;
            }

            return validacion;
        }

        public static string Calcular(double numA, double numB, string operacion)
        {
            string resultado;


            switch (operacion)
            {
                case "+":
                    {
                        resultado = (numA + numB).ToString();
                        break;
                    }
                case "-":
                    {
                        resultado = (numA - numB).ToString();
                        break;
                    }
                case "*":
                    {
                        resultado = (numA * numB).ToString();
                        break;
                    }
                case "/":
                    {
                        if (Validar(numB))
                        {
                            resultado = (numA / numB).ToString();
                        }
                        else
                        {
                            resultado = "NO SE PUEDE DIVIDIR POR CERO.";
                        }
                        break;
                    }
                default:
                    {
                        resultado = "ERROR EN LA OPERACION.";
                        break;
                    }
            }

            return resultado;
        }
    }
}
