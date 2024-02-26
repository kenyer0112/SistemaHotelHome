using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Room
    {
       
       public int Id { get; set; }
       public int IdCategoria { get; set; }
       public int IdPiso { get; set; }
       public decimal Precio { get; set; } 
       public string Estado { get; set; }
       public DateTime Fecha { get; set; }
      
       
       public int Capacidad { get; set; }
    }  
}
