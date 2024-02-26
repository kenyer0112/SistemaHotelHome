using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Room
    {
       
       public Guid Id { get; set; }
    
       public decimal Precio { get; set; } 
       public string Estado { get; set; }
       public DateTime Fecha { get; set; }
      
        public Categoria Categoria { get; set; }

        public Piso Piso { get; set; }

        public int Capacidad { get; set; }
    }  
}
