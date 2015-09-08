using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleApplication6
{
    public class Repository : IRepository
    {
        private DbContext context; 
       
        public Repository(DbContext context)
        {
            this.context = context;
        }
         
        public void Add<T>(T data) where T : class
        {
            context.Set<T>().Add(data);
        }

        public IQueryable<T> Get<T>() where T : class
        {
            return context.Set<T>();
        }

        public T Get<T>(int id) where T : class
        {
            return context.Set<T>().Find(id);
        }
             
        public void Delete<T>(T data) where T : class
        {
            context.Set<T>().Remove(data);
        }

        public void Save()
        {
            context.SaveChanges();
        }
    }
}
