using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabajo_Final_BM
{
    public class Persona
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int Edad { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public string DNI { get; set; }

        List<Entradas> ListaEntradas = new List<Entradas>();

        public void CalcularEdad()
        {
            //calculo la edad por medio dela fecha de nacimiento, devuelvo mensaje.
            Edad = DateTime.Today.Year - FechaNacimiento.Year;
            DateTime fechaCalculada = DateTime.Today.AddYears(-Edad);

            if (FechaNacimiento > fechaCalculada)
            {
                //todavía no cumplio años, entonces resto 1 a los años de la persona
                Edad--;
            }
        }

        public bool EsMenorDeEdad(int edadMinima)
        {
            return (Edad < edadMinima);
        }

        public void IngresoNombre()
        {
            //Ingreso de Nombre y valido el ingreso, devuelvo mensaje.
            do
            {
                Console.Write("Ingrese su Nombre: ");
                Nombre = Console.ReadLine();

                if (string.IsNullOrEmpty(Nombre))
                {
                    Console.WriteLine(" Usted a ingresado un campo Vacio o Nulo, por favor cargue un dato valido");
                }

            } while (string.IsNullOrEmpty(Nombre));
        }

        public void IngresoApellido()
        {
            //Ingreso de apellido y valido el ingreso, devuelvo mensaje.

            do
            {
                Console.Write("Ingrese su Apellido: ");
                Apellido = Console.ReadLine();

                if (string.IsNullOrEmpty(Apellido))
                {
                    Console.WriteLine(" Usted a ingresado un campo Vacio o Nulo, por favor cargue un dato valido");
                }

            } while (string.IsNullOrEmpty(Apellido));
        }

        public void IngresoDNI()
        {
            //Ingreso de DNI y valido el ingreso, devuelvo mensaje.
            string Dni;
            do
            {
                Console.Write("Ingrese su Dni: ");
                DNI = Console.ReadLine();

                if (string.IsNullOrEmpty(DNI))
                {
                    Console.WriteLine(" Usted a ingresado un campo Vacio o Nulo, por favor cargue un dato valido");
                }

            } while (string.IsNullOrEmpty(DNI));
        }

        public void IngresoFechaNacimiento()
        {
            //Ingreso de fecha de nacimiento y valido el ingreso, devuelvo mensaje.

            string fechaNacStr;
            bool fechavalida = false;

            do
            {
                Console.Write("Ingrese su fecha de nacimiento, por favor utilice el siguiente formato de ejemplo dd-mm-aaaa (12-01-1900): ");
                fechaNacStr = Console.ReadLine();

                try
                {
                    FechaNacimiento = DateTime.ParseExact(fechaNacStr, "dd-MM-yyyy", CultureInfo.InvariantCulture);
                    fechavalida = true;
                    CalcularEdad();
                }
                catch (Exception ex)
                {
                    //Console.WriteLine(ex.Message);
                    // Console.WriteLine();
                    Console.WriteLine(" La fecha de nacimiento ingresada no es valida. Por favor, ingresela nuevamente en el formato dd-mm-aaaa.");
                }

            } while (fechavalida == false);

            Console.WriteLine(" Su edad es," + Edad + "Años");
        }
    }
}
