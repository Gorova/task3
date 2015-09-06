using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication6
{
   public class Customer
    {
       public int Id { get; set;}

       public string CustomerName { get; set; }

       public string CustomerPhone { get; set; }

       public virtual ICollection<SoapProduct> SoapProducts { get; set; }
       
    }
}
