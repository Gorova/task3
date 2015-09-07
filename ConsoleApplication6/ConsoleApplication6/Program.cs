using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication6
{
    class Program
    {
        static void Main(string[] args)
        {
            CRUDClass<Customer> customers = new CRUDClass<Customer>();
            CRUDClass<SoapProduct> soapProduct = new CRUDClass<SoapProduct>();

            // adding
            customers.Add(new Customer { CustomerName = "Nata", CustomerPhone = "679011198" });
            customers.Save();
            soapProduct.Add(new SoapProduct { Tittle = "Eucalyptus", Mass = 100, Price = 25.2M });
            soapProduct.Save();

            //delating
            customers.Delete<Customer>(2);
            customers.Save();

            //reading
            var list = customers.Get<Customer>();
            foreach(var item in list)
            {
                Console.WriteLine(item.Id + " " + item.CustomerName+ " " + item.CustomerPhone + "\n");
            }
            
            // find one
            var comp = customers.Get<Customer>(1);
            Console.WriteLine(comp.CustomerName);
       }
    }
}
