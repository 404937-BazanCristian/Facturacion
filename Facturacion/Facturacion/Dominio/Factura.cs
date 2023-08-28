using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facturacion.Dominio
{
    internal class Factura
    {
        public int NroFactura { get; set; }
        public DateTime Fecha { get; set; }
        public FormaPago FormaPago { get; set; }
        public string Cliente { get; set; }
        public List<DetalleFactura> DetallesFactura { get; set; }

        public Factura()
        {
            DetallesFactura = new List<DetalleFactura>();
        }

        public void AgregarDetalle(DetalleFactura detalle)
        {
            DetallesFactura.Add(detalle);
        }

        public void QuitarDetalle(int posicion)
        {
            DetallesFactura.RemoveAt(posicion);
        }
    }
}
