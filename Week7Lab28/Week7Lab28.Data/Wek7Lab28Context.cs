using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Week7Lab28.Domain.Models;
using Week7Lab28.Data.Maps;


namespace Week7Lab28.Data
{
    public class Week7Lab28Context : DbContext
    {
        public Week7Lab28Context() : base("test")
        {
            Database.SetInitializer(new Week7Lab28Initializer());
        }
        public DbSet<Movie> Movies { get; set; }
       
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new MovieMap());

            base.OnModelCreating(modelBuilder);
        }
    }
}
