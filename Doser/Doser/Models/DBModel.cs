

using System.Data.Entity;

namespace Doser.Models
{
    public class DBModel: DbContext
    {
        public DBModel() : base("Server=(localdb)\\mssqllocaldb;Database=DoserDB;Trusted_Connection=True;MultipleActiveResultSets=true")
        {
        }

        public DbSet<Bunker> Bunkers { get; set; }
        public DbSet<Component> Components { get; set; }
        public DbSet<Consumer> Consumers { get; set; }
        public DbSet<Line> Lines { get; set; }
        public DbSet<Material> Materials { get; set; }
        public DbSet<Port> Ports { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Protocol> Protocols { get; set; }
        public DbSet<Recipe> Recipes { get; set; }
        public DbSet<RecipeElement> RecipeElements { get; set; }
        public DbSet<Terminal> Terminals { get; set; }
        public DbSet<User> Users { get; set; }
    }
}