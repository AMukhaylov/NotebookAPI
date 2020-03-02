using System.Data.Entity;

namespace NotebookAPI.Models
{
    public class PersonContext : DbContext
    {
        public DbSet<Person> People { get; set; }

        //public PersonContext() : base("name=PersonContext")
        //{
        //    this.Configuration.LazyLoadingEnabled = false;
        //    this.Configuration.ProxyCreationEnabled = false;
        //}
    }

}