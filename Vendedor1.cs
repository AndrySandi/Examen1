using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Examen1
{
    internal class Vendedor1 : IVendedor1
    {
        public string nombreVendedor;

        public Vendedor1(string nomb)
        {
            nombreVendedor = "Roberto";
        }
        public void VentasContado() { }

    }
}
