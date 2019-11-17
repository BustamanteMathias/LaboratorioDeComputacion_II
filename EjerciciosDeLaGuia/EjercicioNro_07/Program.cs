using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioNro_07
{
    class EjercicioNro_07
    {
        static void Main(string[] args)
        {
            /**
             * Hacer un programa que pida por pantalla la fecha de nacimiento de una persona (día, mes y año) 
             * y calcule el número de días vividos por esa persona hasta la fecha actual 
             * (tomar la fecha del sistema con DateTime.Now). 
             * Nota: Utilizar estructuras selectivas. Tener en cuenta los años bisiestos.
             */

            Console.Title = "EjercicioNro_07";

            int ageUserDay;
            int ageUserMonth;
            int ageUserAge;
            int ageActual;


            DateTime fechaNacimiento;
            DateTime fechaActual = DateTime.Today;

            do
            {
                Console.Write("\nINGRESE DIA DE NACIMIENTO: ");
                ageUserDay = int.Parse(Console.ReadLine());

                if (ageUserDay < 1 || ageUserDay > 32)
                {
                    Console.WriteLine("ERROR. El DIA ingresado tiene que ser mayor a 1 hasta 31 inclusive. REINGRESE.");
                    Console.ReadKey();
                    Console.Clear();
                }
            } while (ageUserDay < 1 || ageUserDay > 32);

            do
            {
                Console.Write("\nINGRESE MES DE NACIMIENTO: ");
                ageUserMonth = int.Parse(Console.ReadLine());

                if (ageUserMonth < 1 || ageUserMonth > 13)
                {
                    Console.WriteLine("ERROR. El MES ingresado tiene que ser mayor a 1 hasta 12 inclusive. REINGRESE.");
                    Console.ReadKey();
                    Console.Clear();
                }
            } while (ageUserMonth < 1 || ageUserMonth > 13);

            do
            {
                Console.Write("\nINGRESE AÑO DE NACIMIENTO: ");
                ageUserAge = int.Parse(Console.ReadLine());

                if (ageUserAge < 1 || ageUserAge > 9999)
                {
                    Console.WriteLine("ERROR. El AÑO ingresado tiene que ser mayor a 1 hasta 9999 inclusive. REINGRESE.");
                    Console.ReadKey();
                    Console.Clear();
                }
            } while (ageUserAge < 1 || ageUserAge > 9999);

            fechaNacimiento = new DateTime(ageUserAge, ageUserMonth, ageUserDay);
            ageActual = fechaActual.Subtract(fechaNacimiento).Days;

   

            Console.Clear();
            Console.WriteLine("Fecha nacimiento: " + ageUserDay+"-"+ageUserMonth+"-"+ageUserAge);
            Console.WriteLine("Fecha actual: "+ DateTime.Now.ToString("dd-MM-yyyy"));
            Console.WriteLine("> {0:#,###} Dias de vida.", ageActual);
            Console.ReadKey();
        }
    }
}
