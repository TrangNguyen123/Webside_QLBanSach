namespace WebDemo.Models.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("sach")]
    public partial class sach
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public sach()
        {
            chitietdonhangs = new HashSet<chitietdonhang>();
        }

        [Key]
        [StringLength(10)]
        public string masach { get; set; }

        [StringLength(50)]
        public string tensach { get; set; }

        [Column(TypeName = "money")]
        public decimal? giaban { get; set; }

        [StringLength(100)]
        public string mota { get; set; }

        [StringLength(100)]
        public string anhbia { get; set; }

        public DateTime? namxuatban { get; set; }

        public bool? tinhtrang { get; set; }

        [StringLength(50)]
        public string kichco { get; set; }

        public int? sotrang { get; set; }

        public int? soluong { get; set; }

        [StringLength(10)]
        public string manhaxuatban { get; set; }

        [StringLength(10)]
        public string machudesach { get; set; }

        [StringLength(10)]
        public string matacgia { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<chitietdonhang> chitietdonhangs { get; set; }

        public virtual chudesach chudesach { get; set; }

        public virtual nhaxuatban nhaxuatban { get; set; }

        public virtual tacgia tacgia { get; set; }
    }
}
