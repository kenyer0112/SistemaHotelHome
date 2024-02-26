using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Reserva
    {

        public Guid Id { get; set; }

        public DateTime Fecha { get; set; }

        public Cliente Cliente { get; set; }

        public Room Room {get; set;}

        public double TotalSubtotal {  get; set; }
     
        public double Impuesto { get; set; }

        public double Descuento { get; set; }

        public double Total { get; set; }

        public DateTime FechaLLegada { get; set; }
        public DateTime FechaSalida { get; set; }

        public List<DetalleReserva> detalleReservas { get; set; }


    }
}
