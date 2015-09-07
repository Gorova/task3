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

    public void Add<T>(T data) where T:class
        {
            soapShopDB.Set<T>().Add(data);
        }

    public IEnumerable<T> Get<T>() where T : class
        {
            return soapShopDB.Set<T>();
        }

    public T Get<T>(int id) where T:class
        {
           return soapShopDB.Set<T>().Find(id);
        }
             
    public void Delete<T>(int id) where T:class
       {
           var comp = soapShopDB.Set<T>().Find(id);
           if(comp != null)
           {
               soapShopDB.Set<T>().Remove(comp);
           }
       }

    public void Save()
       {
            soapShopDB.SaveChanges();
       }
    }
}
