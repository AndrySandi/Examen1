using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen1
{
    internal class Tipo
    {
        public virtual void TipoVehiculo()
        {
            Console.WriteLine("Existen diferentes tipos de vehículos");
        }

        List<String> TipoLista = new List<String>()

        {"Automovil" , "Motocicleta" , "Dron"};

        public Tipo()
        {

        }

        public void ListadoVehiculos()
        {

            foreach (var i in TipoLista)
            {
                Console.WriteLine(i);
            }

        }


        public Boolean BuscarTipo(string valor)
        {

            Boolean result = TipoLista.Contains(valor);
            Console.WriteLine("El tipo indicado se encuentra disponible");

            return result;

        }

    }
}
