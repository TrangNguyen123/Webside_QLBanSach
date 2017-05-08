namespace Website_BanSach.Models.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("KHACHHANG")]
    public partial class KHACHHANG
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public KHACHHANG()
        {
            HOADONs = new HashSet<HOADON>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int maKH { get; set; }

        [StringLength(50)]
        public string tenKH { get; set; }

        [StringLength(10)]
        public string gioitinh { get; set; }

        [StringLength(10)]
        public string sodienthoai { get; set; }

        [StringLength(50)]
        public string email { get; set; }

        [StringLength(50)]
        public string diachi { get; set; }

        [StringLength(10)]
        public string taikhoan { get; set; }

        [StringLength(10)]
        public string matkhau { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HOADON> HOADONs { get; set; }
    }
}
