using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen1
{
    static class Menu
    {

        static int opcion = 0;
        static int bucle1 = 0;
        static int bucle2 = 0;

        static Menu() { }

        public static void Principal()
        {
            int opcion = 1;

            Console.Clear();

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("*********** MENÚ PRINCIPAL ********");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("1- ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Vehículos");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("2- ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Ventas");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("3- ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Reportes");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("4- ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Salir");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("***********************************");

            do
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("Digite una opción: ");
                opcion = int.Parse(Console.ReadLine());

                if (opcion <= 0 || opcion >= 5)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("********************************");
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("¡DIGITE UNA OPCIÓN VÁLIDA! ");
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("********************************");
                }

            } while (opcion > 4);

            Vehiculo vehiculos = new Vehiculo();
            Vendedores vendedores = new Vendedores();
            Tipo tipo = new Tipo();

            switch (opcion)
            {
                case 1:

                    do
                    {

                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("*********** SUB MENÚ VEHÍCULO ********");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write("1- ");
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("Agregar Vehículo");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write("2- ");
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("Modificar Vehículo");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write("3- ");
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("Consultar Vehículo");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write("4- ");
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("Salir");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("**************************************");

                        do
                        {
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.Write("Digite una opción: ");
                            opcion = int.Parse(Console.ReadLine());

                            if (opcion <= 0 || opcion >= 5)
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("********************************");
                                Console.ForegroundColor = ConsoleColor.Yellow;
                                Console.WriteLine("¡DIGITE UNA OPCIÓN VÁLIDA! ");
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("********************************");
                            }

                        } while (opcion > 4);

                        switch (opcion)
                        {
                            case 1:
                                Vehiculo.AgregarVehiculo();
                                break;

                            case 2:
                                Vehiculo.ModificarVehiculo();
                                break;

                            case 3:
                                Vehiculo.ConsultarVehiculo();
                                break;

                            case 4:
                                bucle2 = 1;
                                break;
                        }

                    } while (bucle2 == 0);



                    break;


                case 2:
                    Vehiculo.ConsultarVehiculo();

                    Console.WriteLine("Ingrese el tipo de Categoria: ");
                    String buscar = Console.ReadLine();

                    tipo.BuscarTipo(buscar);
                    Console.WriteLine("Venta Completada Satisfactoriamente");
                    break;

                case 3:

                    do
                    {
                        Console.Clear();

                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("*********** MENÚ REPORTES ********");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write("1- ");
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("Generar reporte");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write("2- ");
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("Volver al menú principal");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("*********************************");
                        opcion = int.Parse(Console.ReadLine());

                        switch (opcion)
                        {

                            case 1:

                                Console.WriteLine("********** REPORTE DE VENDEDORES **********");
                                Vendedores.ListadoVendedores();
                                Console.WriteLine("********** REPORTE DE TIPOS **********");
                                tipo.ListadoVehiculos();
                                Console.WriteLine("********** REPORTE DE VEHICULOS **********");
                                Vehiculo.ListadoVehiculos();
                                break;

                            case 2:
                                bucle2 = 1;
                                break;
                        }

                    } while (bucle2 == 0);

                    break;
                case 4:
                    bucle1 = 1;
                    break;

            } while (bucle1 == 0) ;





        }










    }
}


                
