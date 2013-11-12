using System.Data.Entity;

namespace s00117372CA1.Models
{
    public class OrderContext : DbContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, add the following
        // code to the Application_Start method in your Global.asax file.
        // Note: this will destroy and re-create your database with every model change.
        // 
        // System.Data.Entity.Database.SetInitializer(new System.Data.Entity.DropCreateDatabaseIfModelChanges<s00117372CA1.Models.OrderContext>());

        public OrderContext()
            : base("name=MvcMusicStoreEntities1")
        {
        }

        public DbSet<Order> Orders { get; set; }
    }
}
