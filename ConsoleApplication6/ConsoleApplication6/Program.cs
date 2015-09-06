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
            customers.AddOperation();
            soapProduct.AddOperation();

            //delating
            //customers.DelOperation();
            //soapProduct.DelOperation();

            //reading
              //customers.ReadOperation();
              //soapProduct.ReadOperation();
            //var soapShopDB = new SoapShopDB();

            ////ADD
            //var p1 = new SoapProduct { CustomerId = 1, Tittle = "Eucalyptus", Mass = 100, Price = 25.2M };
            //var p2 = new SoapProduct { CustomerId = 1, Tittle = "Camomile", Mass = 100, Price = 32.0M };
            //var p3 = new SoapProduct { CustomerId = 1, Tittle = "Honey", Mass = 100, Price = 28.1M };
            //soapShopDB.SoapProducts.AddRange(new List<SoapProduct> { p1, p2, p3 });

            //var cust1 = new Customer { CustomerName = "Nata", CustomerPhone = "0679000000" };
            //var cust2 = new Customer { CustomerName = "Olga", CustomerPhone = "0679111111" };
            //var cust3 = new Customer { CustomerName = "Nina", CustomerPhone = "0679222222" };
            //soapShopDB.Customers.AddRange(new List<Customer> { cust1, cust2, cust3 });
            //soapShopDB.SaveChanges();

            //UPDATE
            //var customer = soapShopDB.Customers.Where(c => c.CustomerName == "Nata").FirstOrDefault();
            //customer.CustomerPhone = "**********";
            //Console.WriteLine(customer.CustomerName + customer.CustomerPhone);
            //soapShopDB.SaveChanges();

            //READ
            //var customerList = soapShopDB.Customers.ToList();
            //var listRead = from item in customerList
            //                select new { Id = item.Id, CustomerName = item.CustomerName, CustomerPhone = item.CustomerPhone };
            //foreach (var item2 in listRead)
            //{
            //    Console.WriteLine(item2.Id + " " + item2.CustomerName + " " + item2.CustomerPhone);
            //}
            //foreach (var customer1 in soapShopDB.Customers.ToList())
            //{
            //    Console.WriteLine("{0} {1} {2}", customer1.Id,  customer1.CustomerName, customer1.CustomerPhone);
            //}
            ///*foreach (var customer in soapShopDB.Customers.ToList())
            //{
            //    Console.WriteLine("{0} {1} {2}", customer.Id, customer.CustomerName, customer.CustomerPhone);
            //}*/
            ////DELETE
            //var listDel = soapShopDB.Customers.FirstOrDefault(c => c.CustomerName == "Nina");
            //soapShopDB.Customers.Remove(listDel);
            //soapShopDB.SaveChanges();
            //Console.WriteLine("---------------");
            //foreach (var item2 in soapShopDB.Customers)
            //{
            //    Console.WriteLine(item2.Id + " " + item2.CustomerName + " " + item2.CustomerPhone);
            //}
            ////ADD
            //soapShopDB.Customers.Add(new Customer { CustomerName = "Vika", CustomerPhone = "0202020222" });
            //soapShopDB.SaveChanges();
            //IQueryable<Customer> n = soapShopDB.Customers;
           
        }
    }
}
