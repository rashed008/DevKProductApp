using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ProductApp.Models
{
    public class Context:DbContext
    {
        public DbSet<Product> Products { get; set; }
    }
}