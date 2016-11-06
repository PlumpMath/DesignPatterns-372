namespace Bai5_MVVM
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class DesignPatternDB : DbContext
    {
        protected DesignPatternDB()
            : base("name=DesignPatternDB")
        {
        }
        private static DesignPatternDB db;
        public static DesignPatternDB ConnectDB()
        {
            if (db == null)
                db = new DesignPatternDB();
            return db;
        }


        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<Student> Students { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>()
                .Property(e => e.Price)
                .HasPrecision(18, 0);

            modelBuilder.Entity<Student>()
                .Property(e => e.Phone)
                .IsUnicode(false);
        }
    }
}
