using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
  public class DetalleReserva
    {
        public int Guid { get; set; }
        public Reserva Reserva { get; set; }
        public double Precio { get; set; }
        public Room Room { get; set; }
 
        public int CantidadNoche { get; set; }
        public double Descuento { get; set; }

        


        public double SubTotal
        {
            get; set;
        }

        public double Impuesto
        {
            get; set;
        }


        public double Total
        {
            get; set;

        }

    }
}
