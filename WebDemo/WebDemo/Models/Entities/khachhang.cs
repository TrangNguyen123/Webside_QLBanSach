namespace WebDemo.Models.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("khachhang")]
    public partial class khachhang
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public khachhang()
        {
            donhangs = new HashSet<donhang>();
        }

        [Key]
        [StringLength(10)]
        public string makhachhang { get; set; }

        [StringLength(50)]
        public string tenkhachhang { get; set; }

        public bool? gioitinh { get; set; }

        public DateTime? ngaysinh { get; set; }

        [StringLength(50)]
        public string sodienthoai { get; set; }

        [StringLength(100)]
        public string diachi { get; set; }

        [StringLength(50)]
        public string email { get; set; }

        [StringLength(50)]
        public string taikhoan { get; set; }

        [StringLength(50)]
        public string matkhau { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<donhang> donhangs { get; set; }
    }
}
