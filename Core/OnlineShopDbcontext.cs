using Core.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    public class OnlineShopDbcontext : DbContext
    {
        public OnlineShopDbcontext(DbContextOptions options):base(options)
        {

        }

        //public DbSet<Product> products { get; set; }

        public DbSet<Product> products => Set<Product>();
    }
}
