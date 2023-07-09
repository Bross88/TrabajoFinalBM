//      Crear un programa de ventas de entradas a un recital.

//      --El Teatro no permite el ingreso de niños menores de 13 años.
//      --La persona que compre las entradas solo podrá comparar un máximo de 3
//          entradas y tendrá un descuento en la entrada del 10% comprando 2 o del 30% comprando 3
//      entradas.
//                  entradas max 3
//                  10% comprando 2
//                  30% comprando 3

//      Si la persona titular comprara más de 1 entrada se deberá pedir los mismos datos para
//      las entradas adicionales. No se podrá vender un lugar ya ocupado por otra persona.



//      Para la compra de entradas es necesario pedir los siguientes datos:
//      Nombre
//      Apellido
//      Fecha de nacimiento
//      DNI
//      Edad: (este campo se llenará según la fecha de nacimiento)




//      El Teatro tendrá la siguiente ubicación, cantidad y precios
//      Platea A: tendrá un total de 20 lugares (desde 1A al 20A) a un precio de $6mil
//      Platea B: tendrá un total de 40 lugares (desde 1B al 40B) a un precio de $5mil
//      Platea C: tendrá un total de 60 lugares (desde 1C al 60C) a un precio de $4mil
//      Popular: tendrá 80 lugares (1P a 80P) a un precio de $2mil

//      Al finalizar la venta de la entrada al cliente el programa calculará el monto a pagar.
//      El programa deberá finalizar apretando una letra detallada en el menú.
//      Al salir imprimirá la cantidad de entradas vendidas, los lugares ocupados y el importe recaudado.




using Trabajo_Final_BM;

internal class Program
{
    private static void Main(string[] args)
    {

        bool esMenor;

        Teatro teatro = new Teatro();
        teatro.ListadoObras = new List<Obras>();
        teatro.CargarObras(
            Constantes.ButacasPlateaA,
            Constantes.ButacasPlateaB,
            Constantes.ButacasPlateaC,
            Constantes.ButacasPopular

        );
        Entradas entradas = new Entradas(); // instancio la nueva entrada
       






              //Compra de entardas e Ingreso de datos

        do
        {
            Console.WriteLine(" ~~ ~~ Bienvenido a la compra de entardas del Teatro Opera ~~ ~~ ");
            Console.WriteLine(" --> Por favor ingrese sus datos: ");
            Persona persona = new Persona();

            persona.IngresoNombre();
            persona.IngresoApellido();
            persona.IngresoDNI();
            persona.IngresoFechaNacimiento();

            esMenor = persona.EsMenorDeEdad(Constantes.EdadMinima);
            if (esMenor == true)
            {
                Console.WriteLine("Es menor de edad no puede realizar compra de entardas.");
                Console.WriteLine("Presione una tecla para finalizar el programa:");
                Console.ReadLine();
                return;
            }

        } while (esMenor == true);


        //ver obras o comprar entradas
        int opcion = 0;
        do
        {
            Console.WriteLine("Ingrese la opcion deseada:");
            Console.WriteLine("1-Ver Obras");
            Console.WriteLine("2-Comprar Entradas");
            Console.WriteLine("0-Salir");
            string ingreso = Console.ReadLine();
            if (ingreso != string.Empty)
            {


                opcion = Convert.ToInt32(ingreso);

                switch (opcion)
                {
                    case 1:
                        {
                            teatro.VerObras();
                            break;
                        }
                    case 2:
                        {
                            entradas.ComprarEntradas();
                            break;
                        }
                    case 0:
                        {
                            //salir
                            break;
                        }
                    default:
                        break;
                }
            }
        }
        while (opcion != 0);




        Console.WriteLine("Finalizando programa");
    }
}