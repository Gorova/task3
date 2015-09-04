using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication6
{
    public class SoapProduct
    {
      public int Id { get;set; }

      public int? CustomerId { get;set; }

      public string Tittle { get; set; }

      public decimal Price { get; set; }

      public int Mass { get;set; }

      public virtual Customer Customer { get; set; }
        
    }
}
