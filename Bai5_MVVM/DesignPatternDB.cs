namespace Bai5_MVVM
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class DesignPatternDB : DbContext
    {
        public DesignPatternDB()
            : base("name=DesignPatternDB")
        {
        }

        public virtual DbSet<Student> Students { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Student>()
                .Property(e => e.Phone)
                .IsUnicode(false);
        }
    }
}
