using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication6
{
   public class SoapShopDb:DbContext
    {
       public SoapShopDb() : base("SoapShopDb")
       {
       }
       //public SoapShopDB()
       //             :base("SoapShopDB")
       //{

       //}
       public DbSet<Customer> Customers { get; set; }

       public DbSet<SoapProduct> SoapProducts { get; set; }
    }
}
