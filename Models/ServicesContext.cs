using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
namespace Hrutik.Models
{
    public class ServicesContext : DbContext
    {
        public DbSet<Product> Prod { get; set;}
    }
}