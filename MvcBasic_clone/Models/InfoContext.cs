namespace MvcBasic_clone.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class InfoContext : DbContext
    {
        public InfoContext()
            : base("name=InfoContext")
        {
        }

        public virtual DbSet<Employees> Employees { get; set; }
        public virtual DbSet<Friends> Friends { get; set; }
        public virtual DbSet<Info> Info { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
