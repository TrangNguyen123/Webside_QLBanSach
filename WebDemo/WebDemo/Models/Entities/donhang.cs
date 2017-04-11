namespace WebDemo.Models.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("donhang")]
    public partial class donhang
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public donhang()
        {
            chitietdonhangs = new HashSet<chitietdonhang>();
        }

        [Key]
        [StringLength(10)]
        public string madonhang { get; set; }

        public DateTime? ngaygiaohang { get; set; }

        public DateTime? ngaydathang { get; set; }

        [StringLength(50)]
        public string tennguoinhan { get; set; }

        [StringLength(100)]
        public string diachi { get; set; }

        [StringLength(10)]
        public string makhachhang { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<chitietdonhang> chitietdonhangs { get; set; }

        public virtual khachhang khachhang { get; set; }
    }
}
