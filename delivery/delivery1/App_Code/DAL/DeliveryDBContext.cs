using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using delivery1.App_Code.Model;

namespace delivery1.DAL
{
    public class DeliveryDBContext : DbContext
    {
       public DeliveryDBContext()
            : base("DeliveryDBContext")
        { }

        public DbSet<Order> Orders { get; set; }
        public DbSet<Item> Items { get; set; }
        public DbSet<Client> Clients { get; set; }
    }

    public class DeliveryDBInitializer : DropCreateDatabaseIfModelChanges<DeliveryDBContext>
    {
        protected override void Seed(DeliveryDBContext context)
        {

            context.SaveChanges();
        }
    }
}