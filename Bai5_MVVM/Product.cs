namespace Bai5_MVVM
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Product")]
    public partial class Product
    {
        public int ID { get; set; }

        [StringLength(100)]
        public string Name { get; set; }

        public decimal? Price { get; set; }

        [StringLength(250)]
        public string Description { get; set; }
    }
}
