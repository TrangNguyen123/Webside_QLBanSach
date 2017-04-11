namespace WebDemo.Models.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("chitietdonhang")]
    public partial class chitietdonhang
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(10)]
        public string madonhang { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(10)]
        public string masach { get; set; }

        public int? soluong { get; set; }

        [Column(TypeName = "money")]
        public decimal? dongia { get; set; }

        public virtual donhang donhang { get; set; }

        public virtual sach sach { get; set; }
    }
}
