using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{//proje class baglama
    public class NorthwindContext : DbContext//entıtyden geliyor
    {
        //override ettik override onconf. yazdık
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {//baglantı yapmak için veritabanına ,trusted ise sifreli giris yapmadan kullanmak için
            optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB; DataBase=master; Trusted_Connection=true");

        }
        public DbSet<Product> Products { get; set; }//classalar arası db  baglantı kodu
        public DbSet<Category> Categories { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Order> Order { get; set; }
    }
}