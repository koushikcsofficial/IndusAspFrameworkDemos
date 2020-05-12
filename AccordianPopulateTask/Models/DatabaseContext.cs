namespace AccordianPopulateTask.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class DatabaseContext : DbContext
    {
        public DatabaseContext()
            : base("name=DatabaseContext")
        {
        }

        public virtual DbSet<Accordion> Accordions { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Accordion>()
                .Property(e => e.Accordion_HeadLine)
                .IsUnicode(false);

            modelBuilder.Entity<Accordion>()
                .Property(e => e.Accordion_Description)
                .IsUnicode(false);
        }
    }
}
