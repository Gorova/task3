using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication6
{
    class Program
    {
        static void Main(string[] args)
        {
            var soapShopDb = new SoapShopDb();
            var component = new Repository(soapShopDb);

            // adding
            component.Add(new Customer { CustomerName = "Nata", CustomerPhone = "679011198" });
            component.Save();
            component.Add(new SoapProduct { Tittle = "Eucalyptus", Mass = 100, Price = 25.2M });
            component.Save();

            ////delating
            var comp = soapShopDb.Set<Customer>().FirstOrDefault(i => i.CustomerName == "Nata");
            component.Delete(comp);
            component.Save();

            ////reading
            var list = component.Get<Customer>();
            foreach (var item in list)
            {
                Console.WriteLine(item.Id + " " + item.CustomerName + " " + item.CustomerPhone + "\n");
            }

            //// find one
            var comp2 = component.Get<Customer>(3);
            Console.WriteLine(comp2.CustomerName);
        }
    }
}

