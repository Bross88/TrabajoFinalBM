using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabajo_Final_BM
{
    public class Entradas
    {
        public string Obra { get; set; }
        public string Ubicacion { get; set; }
        public double Precio { get; set; }
        public DateTime FechaHora { get; set; }

        public string NombreEspectador { get; set; }
        public string ApellidoEspectador { get; set; }
        public string DNIEspectador { get; set; }


        public void ComprarEntradas()
        {
            string CantidadCompra;
            do
            {
                int ubicacion;
                string Captura;
                do
                {
                    Console.WriteLine("Seleccione la Ubicacion: ");
                    Console.WriteLine();
                    Console.WriteLine("seleccione 1 para Platea A");
                    Console.WriteLine("seleccione 2 para Platea B");
                    Console.WriteLine("seleccione 3 para Platea C");
                    Console.WriteLine("seleccione 4 para Sector Popular");
                    Captura = Console.ReadLine();
                    ubicacion = int.Parse(Captura);

                    if (string.IsNullOrEmpty(Captura))
                    {
                        Console.WriteLine(" Usted a ingresado un campo Vacio o Nulo, por favor cargue un dato valido");
                    }
                }
                while (string.IsNullOrEmpty(Captura));




                Console.WriteLine(" Ingrese la cantidad de entrardas que desea comprar: ");
                Console.WriteLine("1");
                Console.WriteLine("2");
                Console.WriteLine("3");
                CantidadCompra = Console.ReadLine();
                int CCompra = Convert.ToInt32(CantidadCompra);

                if (string.IsNullOrEmpty(CantidadCompra))
                {
                    Console.WriteLine(" Usted a ingresado un campo Vacio o Nulo, por favor cargue un dato valido");
                }
                else
                {

                    if (CCompra <= Constantes.MaxEntradas)
                    {
                        Console.WriteLine("Usted a seleccionado la compra de " + CCompra + " entradas para la ubicacion  " + ubicacion );

                        if (CCompra >= 2)
                        {
                            Console.WriteLine(" Se aplicara un descuento al finalizar");
                        }




                        switch (ubicacion)
                        {
                            case 1:
                                {
                                    int PlateaA = Constantes.ButacasPlateaA - CCompra;

                                }
                                break;
                            case 2:
                                {
                                    int PlateaB = Constantes.ButacasPlateaB - CCompra;
                                }
                                break;
                            case 3:
                                {
                                    int PlateaC = Constantes.ButacasPlateaC - CCompra;
                                }
                                break;
                            case 4:
                                {
                                    int Popular = Constantes.ButacasPopular - CCompra;
                                }
                                break;





                        }

                        //switch que aplique los descuentos por cada case
                        switch (ubicacion)
                        {
                            case 1:                                             //PLATEA-A
                                switch (CCompra)
                                {
                                    case 1:
                                        {
                                            //sin descuento;
                                            double Total = Constantes.PrecioPlateaA * CCompra;
                                            Console.WriteLine("El total de su compra es " + Total + " $ pesos ");
                                            Console.WriteLine();
                                            break;
                                        }
                                    case 2:
                                        {
                                            //10% de descuento;
                                            double Total = Constantes.PrecioPlateaA * CCompra;
                                            double descuento = Total * 10 / 100;
                                            double PrecioFinal = Total - descuento;
                                            Console.WriteLine("El total de su compra es " + Total + " $ pesos y aplica un descuento de $ " + descuento + " pesos ");
                                            Console.WriteLine();
                                            break;
                                        }
                                    case 3:
                                        {
                                            //30% de descuento
                                            double Total = Constantes.PrecioPlateaA * CCompra;
                                            double descuento = Total * 30 / 100;
                                            double PrecioFinal = Total - descuento;
                                            Console.WriteLine("El total de su compra es " + Total + " $ pesos y aplica un descuento de $ " + descuento + " pesos ");
                                            Console.WriteLine();
                                            break;
                                        }
                                    default:
                                        break;
                                }



                                break;
                            case 2:                                             //PLATEA-B

                                switch (CCompra)
                                {
                                    case 1:
                                        {
                                            //sin descuento;
                                            double Total = Constantes.PrecioPlateaB * CCompra;
                                            Console.WriteLine("El total de su compra es " + Total + " $ pesos ");
                                            Console.WriteLine();

                                            break;
                                        }
                                    case 2:
                                        {
                                            //10% de descuento;
                                            double Total = Constantes.PrecioPlateaB * CCompra;
                                            double descuento = Total * 10 / 100;
                                            double PrecioFinal = Total - descuento;
                                            Console.WriteLine("El total de su compra es " + Total + " $ pesos y aplica un descuento de $ " + descuento + " pesos ");
                                            Console.WriteLine();
                                            break;
                                        }
                                    case 3:
                                        {
                                            //30% de descuento
                                            double Total = Constantes.PrecioPlateaB * CCompra;
                                            double descuento = Total * 30 / 100;
                                            double PrecioFinal = Total - descuento;
                                            Console.WriteLine("El total de su compra es " + Total + " $ pesos y aplica un descuento de $ " + descuento + " pesos ");
                                            Console.WriteLine();
                                            break;
                                        }
                                    default:
                                        break;
                                }
                                break;
                            case 3:                                         //PLATEA-C

                                switch (CCompra)
                                {
                                    case 1:
                                        {
                                            //sin descuento;
                                            double Total = Constantes.PrecioPlateaC * CCompra;
                                            Console.WriteLine("El total de su compra es " + Total + " $ pesos ");
                                            Console.WriteLine();

                                            break;
                                        }
                                    case 2:
                                        {
                                            //10% de descuento;
                                            double Total = Constantes.PrecioPlateaC * CCompra;
                                            double descuento = Total * 10 / 100;
                                            double PrecioFinal = Total - descuento;
                                            Console.WriteLine("El total de su compra es " + Total + " $ pesos y aplica un descuento de $ " + descuento + " pesos ");
                                            Console.WriteLine();
                                            break;
                                        }
                                    case 3:
                                        {
                                            //30% de descuento
                                            double Total = Constantes.PrecioPlateaC * CCompra;
                                            double descuento = Total * 30 / 100;
                                            double PrecioFinal = Total - descuento;
                                            Console.WriteLine("El total de su compra es " + Total + " $ pesos y aplica un descuento de $ " + descuento + " pesos ");
                                            Console.WriteLine();
                                            break;
                                        }
                                    default:
                                        break;
                                }
                                break;
                            case 4:                                         //POPULAR

                                switch (CCompra)
                                {
                                    case 1:
                                        {
                                            //sin descuento;
                                            double Total = Constantes.PrecioPopular * CCompra;
                                            Console.WriteLine("El total de su compra es " + Total + " $ pesos ");
                                            Console.WriteLine();

                                            break;
                                        }
                                    case 2:
                                        {
                                            //10% de descuento;
                                            double Total = Constantes.PrecioPopular * CCompra;
                                            double descuento = Total * 10 / 100;
                                            double PrecioFinal = Total - descuento;
                                            Console.WriteLine("El total de su compra es " + Total + " $ pesos y aplica un descuento de $ " + descuento + " pesos ");
                                            Console.WriteLine();
                                            break;
                                        }
                                    case 3:
                                        {
                                            //30% de descuento
                                            double Total = Constantes.PrecioPopular * CCompra;
                                            double descuento = Total * 30 / 100;
                                            double PrecioFinal = Total - descuento;
                                            Console.WriteLine("El total de su compra es " + Total + " $ pesos y aplica un descuento de $ " + descuento + " pesos ");
                                            Console.WriteLine();
                                            break;
                                        }
                                    default:
                                        break;
                                }
                                break;

                        }       
    
                    }
                }



            } while (string.IsNullOrEmpty(CantidadCompra));
        }



    }





}
