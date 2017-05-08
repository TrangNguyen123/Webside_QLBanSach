namespace Website_BanSach.Models.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("HOADON")]
    public partial class HOADON
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public HOADON()
        {
            CHITIET_HD = new HashSet<CHITIET_HD>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int maHD { get; set; }

        [Column(TypeName = "date")]
        public DateTime? ngaygiaohang { get; set; }

        [Column(TypeName = "date")]
        public DateTime? ngaydathang { get; set; }

        [StringLength(50)]
        public string tennguoinhan { get; set; }

        [StringLength(50)]
        public string diachi { get; set; }

        public int? maKH { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CHITIET_HD> CHITIET_HD { get; set; }

        public virtual KHACHHANG KHACHHANG { get; set; }
    }
}
