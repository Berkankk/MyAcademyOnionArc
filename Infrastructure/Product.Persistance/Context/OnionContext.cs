using Microsoft.EntityFrameworkCore;
using Product.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Product.Persistance.Context
{
    public class OnionContext : DbContext
    {
        public OnionContext(DbContextOptions options) : base(options)  //programcs içerisinde tanııtığım tanıttık
        {

        }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Domain.Entities.Product> Products { get; set; }  //proje adı da product olduğu için bu şekilde yazdık
        public DbSet<Customer> Customers { get; set; }
    }
}
