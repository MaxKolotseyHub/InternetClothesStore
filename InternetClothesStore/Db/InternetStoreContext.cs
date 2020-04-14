using InternetClothesStore.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace InternetClothesStore.Db
{
    public class InternetStoreContext:DbContext
    {
        static InternetStoreContext()
        {
            Database.SetInitializer<InternetStoreContext>(new DbContextInitializer());
        }
        public InternetStoreContext(string connectionString = "Default") : base(connectionString)
        {

        }
        public DbSet<Item> Items{ get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Image> Images { get; set; }
        public DbSet<Purchase> Purchases { get; set; }
        public DbSet<Client> Clients { get; set; }
    }
}