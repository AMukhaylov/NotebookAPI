using System;
using System.Data.Entity;

namespace NotebookAPI.Models
{
    public class ContactTypeContext : DbContext
    {
        public DbSet<ContactType> ContactTypes { get; set; }

        //public ContactTypeContext() : base("name=ContactTypeContext")
        //{
        //    this.Configuration.LazyLoadingEnabled = false;
        //    this.Configuration.ProxyCreationEnabled = false;
        //}
    }
}