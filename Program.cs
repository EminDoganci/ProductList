using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace ConsoleApp1
{
    public class ShopContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.("data source = shopdb.db");
        }


    }

    public class Product
    {
        public int ProductId { get; set; }

        [MaxLength(100)]
        [Required]
        public string Name { get; set; }
        public decimal Price { get; set; }
    }

    public class Category
    {
        public int CategoryId { get; set; }

        public string Name { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
