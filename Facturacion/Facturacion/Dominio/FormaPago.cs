using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facturacion.Dominio
{
    internal class FormaPago
    {
        public string Nombre { get; set; }
        public FormaPago(string nombre)
        {
            Nombre = nombre;
        }
    }
}
