using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen1
{
    internal class Vendedores
    {
        private static Dictionary<string, string> vendedores = new Dictionary<string, string>()
        {
           {"1", "Roberto"},
           {"2", "Camila"},
         
        };

        public Vendedores() { }

        public static void ListadoVendedores()
        {
            foreach (var ven in vendedores)
            {
                Console.WriteLine($"Codigo:{ven.Key} Nombre del Vendedor: {ven.Value}");
            }
        }
        public static String DetalleVendedor(string valor)
        {
            string resultado;
            if (vendedores.TryGetValue(valor, out resultado))
            {
                Console.WriteLine(resultado);
            }
            return resultado;
        }



    }
}
