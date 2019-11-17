using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioNro_08
{
    class EjercicioNro_08
    {
        static void Main(string[] args)
        {
            /**
             * Por teclado se ingresa el valor hora, el nombre, la antigüedad (en años) y la cantidad de horas 
             * trabajadas en el mes de N empleados de una fábrica. Se pide calcular el importe a cobrar teniendo 
             * en cuenta que el total (que resulta de multiplicar el valor hora por la cantidad de horas trabajadas), 
             * hay que sumarle la cantidad de años trabajados multiplicados por $ 150, y al total de todas esas operaciones 
             * restarle el 13% en concepto dedescuentos.
             * Mostrar el recibo correspondiente con el nombre, la antigüedad, el valor hora, el total a cobrar en bruto, 
             * el total de descuentos y el valor neto a cobrar de todos los empleados ingresados. 
             * Nota: Utilizar estructuras repetitivas y selectivas.
             */

            Console.Title = "EjercicioNro_08";

            int contadorEmpleados = 0;
            float valorHora;
            string nombreEmpleado;
            int antiguedadEmpleado;
            float cantidadHorasTrabajadas;
            string continuarCiclo = "S";

            string acumuladorDatosImprimir = "\n";
            float totalBruto;
            float totalDescuento;
            float totalNeto;

            while (continuarCiclo == "S")
            {
                do
                {
                    Console.WriteLine("ID: "+ contadorEmpleados);

                    Console.Write("INGRESE EL VALOR HORA: ");
                    valorHora = float.Parse(Console.ReadLine());

                    if (valorHora < 1)
                    {
                        Console.WriteLine("ERROR. Ingrese numero mayor a 1 o inclusive. REINGRESE.");
                        Console.ReadKey();
                        Console.Clear();
                    }
                } while (valorHora < 1);

                Console.Write("INGRESE NOMBRE DE EMPLEADO: ");
                nombreEmpleado = Console.ReadLine();

                do
                {
                    Console.Write("INGRESE ANTIGUEDAD DEL EMPLEADO EN AÑOS: ");
                    antiguedadEmpleado = int.Parse(Console.ReadLine());

                    if (antiguedadEmpleado < 0)
                    {
                        Console.WriteLine("ERROR. La antiguedad NO puede ser menor a 0 años. REINGRESE.");
                        Console.ReadKey();
                        Console.Clear();
                    }
                } while (antiguedadEmpleado < 0);

                do
                {
                    Console.Write("CANTIDAD HORAS TRABAJADAS EN EL MES: ");
                    cantidadHorasTrabajadas = int.Parse(Console.ReadLine());

                    if (cantidadHorasTrabajadas < 0)
                    {
                        Console.WriteLine("ERROR. La cantidad de horas trabajadas NO puede ser menor a 0. REINGRESE.");
                        Console.ReadKey();
                        Console.Clear();
                    }
                } while (cantidadHorasTrabajadas < 0);

                totalBruto = (valorHora * cantidadHorasTrabajadas) + (antiguedadEmpleado * 150);
                totalDescuento = (totalBruto / 100) * 13;
                totalNeto = totalBruto - totalDescuento;

                acumuladorDatosImprimir = acumuladorDatosImprimir + (
                    "ID EMPLEADO: "+contadorEmpleados +
                    "\nNombre: "+nombreEmpleado +
                    "\nAntiguedad: "+ antiguedadEmpleado +
                    "\nValor hora de trabajo: " + valorHora +
                    "\nTotal sueldo BRUTO: "+ totalBruto +
                    "\nTotal sueldo NETO: "+ totalNeto +
                    "\nTotal DESCUENTO: " + totalDescuento + "\n\n");

                Console.WriteLine("CARGA EXITOSA");
                Console.Write("\nDESEA CONTINUAR? [S] SI - [CUALQUIER TECLA]- NO: ");

                continuarCiclo = Console.ReadLine();
                continuarCiclo = continuarCiclo.ToUpper();

                if (continuarCiclo == "S")
                {
                    valorHora = 0;
                    nombreEmpleado = "";
                    antiguedadEmpleado = 0;
                    cantidadHorasTrabajadas = 0;
                    totalBruto = 0;
                    totalDescuento = 0;
                    totalNeto = 0;
                    contadorEmpleados++;

                    Console.Clear();
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine(acumuladorDatosImprimir);
                    Console.ReadKey();
                }
            }

        }
        
    }
}
