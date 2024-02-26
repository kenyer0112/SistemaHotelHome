using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Piso
    {
        public Guid Id { get; set; }
        public string Descripcion { get; set; }
        public int Stock { get; set; }

        public DateTime Fecha { get; set; }
    }
}
