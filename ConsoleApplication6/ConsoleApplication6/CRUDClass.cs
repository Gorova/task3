using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication6
{
    public class CRUDClass<T>
    {
        SoapShopDB soapShopDB;
        public CRUDClass()
        {
           soapShopDB = new SoapShopDB();
        }
       public void AddOperation()
        {
            var p1 = new SoapProduct { CustomerId = 1, Tittle = "Eucalyptus", Mass = 100, Price = 25.2M };
            var p2 = new SoapProduct { CustomerId = 1, Tittle = "Camomile", Mass = 100, Price = 32.0M };
            var p3 = new SoapProduct { CustomerId = 1, Tittle = "Honey", Mass = 100, Price = 28.1M };
            soapShopDB.SoapProducts.AddRange(new List<SoapProduct> { p1, p2, p3 });

            var cust1 = new Customer { CustomerName = "Nata", CustomerPhone = "0679000000" };
            var cust2 = new Customer { CustomerName = "Olga", CustomerPhone = "0679111111" };
            var cust3 = new Customer { CustomerName = "Nina", CustomerPhone = "0679222222" };
            soapShopDB.Customers.AddRange(new List<Customer> { cust1, cust2, cust3 });

            soapShopDB.SaveChanges();
        }
        public void DelOperation()
       {
           //var listDelCustomers = soapShopDB.Customers.FirstOrDefault(c => c.CustomerPhone == "0679111111");
           //soapShopDB.Customers.Remove(listDelCustomers);
           
           var listDelSoapProd = soapShopDB.SoapProducts.FirstOrDefault(s => s.Tittle == "Camomile");
           soapShopDB.SoapProducts.Remove(listDelSoapProd);

           soapShopDB.SaveChanges();
       }
        public void ReadOperation()
        {
            foreach (var customer in soapShopDB.Customers.ToList())
            {
                Console.WriteLine("{1}, {2}", customer.Id, customer.CustomerName, customer.CustomerPhone);
            }

            foreach (var soapProd in soapShopDB.SoapProducts.ToList())
            {
                Console.WriteLine("{1}, {2}", soapProd.Id, soapProd.Tittle, soapProd.Price);
            }
        }
    }
}
