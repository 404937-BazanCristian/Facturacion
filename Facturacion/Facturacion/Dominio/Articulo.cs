using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facturacion.Dominio
{
    internal class Articulo
    {
        public int Codigo { get; set; }
        public string Nombre { get; set; }
        public double PrecioUnitario { get; set; }
        public Articulo(int codigo, string nombre, double precio)
        {
            Codigo = codigo;
            Nombre = nombre;
            PrecioUnitario = precio;
        }
    }
}
