﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication6
{
   public class SoapShopDB:DbContext
    {
       public SoapShopDB() : base("SoapShopDB")
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
