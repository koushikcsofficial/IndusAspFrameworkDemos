namespace Web.RegisterPageTask.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class DatabaseContext : DbContext
    {
        public DatabaseContext() : base("name=DbConnectionString")
        {

        }

        public virtual DbSet<Registration> Registrations { get; set; }
    }
}
