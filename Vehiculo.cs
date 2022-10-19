using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen1
{
    internal class Vehiculo
    {
        static String buscarCodigo = "";

        static String[] Codigo = new String[5];
        static String[] Marca = new String[5];
        static double[] Costo = new double[5];
        static String[] Modelo = new String[5];

        protected int codigo { get; set; }
        protected string marca { get; set; }
        protected double costo { get; set; }
        protected string modelo { get; set; }

        public Vehiculo() { }

        public Vehiculo(int codigo, String marca, double costo, String modelo)
        {
            this.codigo = codigo;
            this.marca = marca;
            this.costo = costo;
            this.modelo = modelo;
        }
            
        public static void AgregarVehiculo()
        {
            //Console.Clear();

            for (int i = 0; i < 5; i++)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("***********  INGRESE DATOS DEL VEHÍCULO  ***********");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Ingrese el código del vehiculo: ");
                Console.ForegroundColor = ConsoleColor.White;
                Codigo[i] = Console.ReadLine();
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Ingrese la marca del vehiculo: ");
                Console.ForegroundColor = ConsoleColor.White;
                Marca[i] = Console.ReadLine();
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Ingrese el costo del Vehiculo: ");
                Console.ForegroundColor = ConsoleColor.White;
                Costo[i] = double.Parse(Console.ReadLine());
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Ingrese el modelo (Año) del vehiculo: ");
                Console.ForegroundColor = ConsoleColor.White;
                Modelo[i] = Console.ReadLine();
                
            }
        }


        public static void ModificarVehiculo()
        {

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("*********************************************************");
            Console.WriteLine("   Ingrese el codigo del vehículo que desea modificar: ");
            Console.WriteLine("*********************************************************");
            buscarCodigo = Console.ReadLine();
            for (int i = 0; i < 5; i++)
            {
                if (Codigo[i] == buscarCodigo)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("Ingrese la marca del vehiculo: ");
                    Console.ForegroundColor = ConsoleColor.White;
                    Marca[i] = Console.ReadLine();
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("Ingrese el costo del Vehiculo: ");
                    Console.ForegroundColor = ConsoleColor.White;
                    Costo[i] = double.Parse(Console.ReadLine());
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("Ingrese el modelo (Año) del vehiculo: ");
                    Console.ForegroundColor = ConsoleColor.White;
                    Modelo[i] = Console.ReadLine();
                }


            }
        }

        public static void ConsultarVehiculo()
        {
            Console.WriteLine("Ingrese el Codigo del Vehiculo a Consultar");
            buscarCodigo = Console.ReadLine();

            for (int i = 0; i < Codigo.Length; i++)
            {
                if (Codigo[i] == buscarCodigo)
                {
                    Console.WriteLine("Codigo encontrado satisfactoriamente");
                    Console.WriteLine("---------------------------------------------------------------------------------");

                    Console.WriteLine("Codigo del Vehiculo: " + Codigo[i]);

                    Console.WriteLine("Marca del Vehiculo: " + Marca[i]);

                    Console.WriteLine("Costo del Vehiculo: " + Costo[i]);

                    Console.WriteLine("Modelo del Vehiculo: " + Modelo[i]);
                    Console.WriteLine("---------------------------------------------------------------------------------");

                }
            }
        }

        public static void ListadoVehiculos()
        {

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("*********************************************************");
                Console.WriteLine("Codigo del Vehiculo: " + Codigo[i]);

                Console.WriteLine("Marca del Vehiculo: " + Marca[i]);

                Console.WriteLine("Costo del Vehiculo: " + Costo[i]);

                Console.WriteLine("Modelo del Vehiculo: " + Modelo[i]);
                Console.WriteLine("*********************************************************");

            }


        }



    }

 }
 

