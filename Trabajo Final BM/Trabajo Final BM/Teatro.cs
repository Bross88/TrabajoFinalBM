using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabajo_Final_BM
{
    public class Teatro
    {
        public List<Obras> ListadoObras { get; set; }

        public void CargarObras(int butacasPlateaA, int butacasPlateaB, int butacasPlateaC, int butacasPopular)
        {
            Obras obra1 = new Obras();

            obra1.Nombre = "Casados con Hijos";
            obra1.EntradasDisponiblesPlateaA = IniciarListaDeButacasDisponibles(butacasPlateaA);
            obra1.EntradasDisponiblesPlateaB = IniciarListaDeButacasDisponibles(butacasPlateaB);
            obra1.EntradasDisponiblesPlateaC = IniciarListaDeButacasDisponibles(butacasPlateaC);
            obra1.EntradasDisponiblesPopular = IniciarListaDeButacasDisponibles(butacasPopular);

            List<string> listaActores = new List<string>();

            listaActores.Add("Pepe");
            listaActores.Add("Moni");
            listaActores.Add("Coqui");
            listaActores.Add("Paola");

            obra1.Reparto = listaActores;
            obra1.FechaYHora = new DateTime(2023, 5, 15, 15, 00,00);


            ListadoObras.Add(obra1);

            Obras obra2 = new Obras();

            obra2.Nombre = "Los Simpsons";
            obra2.EntradasDisponiblesPlateaA = IniciarListaDeButacasDisponibles(butacasPlateaA);
            obra2.EntradasDisponiblesPlateaB = IniciarListaDeButacasDisponibles(butacasPlateaB);
            obra2.EntradasDisponiblesPlateaC = IniciarListaDeButacasDisponibles(butacasPlateaC);
            obra2.EntradasDisponiblesPopular = IniciarListaDeButacasDisponibles(butacasPopular);

            List<string> listaActores2 = new List<string>();

            listaActores2.Add("Bart");
            listaActores2.Add("Lisa");
            listaActores2.Add("Homero");
            listaActores2.Add("Marge");
            listaActores2.Add("Maggie");

            obra2.Reparto = listaActores2;
            obra2.FechaYHora = new DateTime(2023, 3, 19, 11, 00, 00);

            ListadoObras.Add(obra2);
        }

        public List<int> IniciarListaDeButacasDisponibles(int cantidadButacas)
        {
            List<int> listadoButacas = new List<int>();

            for (var i = 1; i <= cantidadButacas; i++)
            {
                listadoButacas.Add(i);
            }

            return listadoButacas;
        }

        public void VerObras()
        {
            Console.WriteLine("-------------------------------------------------------------------------------");
            Console.WriteLine("Listado de Obras: ");
            foreach (var obra in ListadoObras)
            {
                Console.WriteLine("Nombre de la Obra: " + obra.Nombre);
                Console.WriteLine("Fecha y Hora: " + obra.FechaYHora.ToString());
                Console.WriteLine();
                Console.WriteLine("Reparto: ");
                foreach (var actor in obra.Reparto)
                {                    
                    Console.WriteLine(actor);
                }
                Console.WriteLine();
                Console.WriteLine("Entradas Disponibles para Platea A: " + obra.EntradasDisponiblesPlateaA.Count);
                Console.WriteLine("Entradas Disponibles para Platea B: " + obra.EntradasDisponiblesPlateaB.Count);
                Console.WriteLine("Entradas Disponibles para Platea C: " + obra.EntradasDisponiblesPlateaC.Count);
                Console.WriteLine("Entradas Disponibles para Popular: " + obra.EntradasDisponiblesPopular.Count);
                Console.WriteLine("-------------------------------------------------------------------------------");
                
            }
        }


        



    }
}
