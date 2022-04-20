using Implements.Models;
using Microsoft.EntityFrameworkCore;

namespace Implements
{
   public class DataBaseContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (optionsBuilder.IsConfigured == false)
            {
                optionsBuilder.UseSqlServer(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=AbstractCarShopDatabase;Integrated Security=True;MultipleActiveResultSets=True;");
            }
            base.OnConfiguring(optionsBuilder);
        }
        public virtual DbSet<City> Citys { set; get; }
        public virtual DbSet<School> Schooles { set; get; }
        public virtual DbSet<Classes> Classeses { set; get; }
        public virtual DbSet<Student> Students { set; get; }
        public virtual DbSet<Advancements> Advancementses { set; get; }
    }
}
