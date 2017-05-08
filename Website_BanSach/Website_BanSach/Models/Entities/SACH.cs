namespace Website_BanSach.Models.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SACH")]
    public partial class SACH
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SACH()
        {
            CHITIET_HD = new HashSet<CHITIET_HD>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int masach { get; set; }

        [StringLength(50)]
        public string tensach { get; set; }

        public int? giaban { get; set; }

        [StringLength(50)]
        public string mota { get; set; }

        public string urlAnh { get; set; }

        [Column(TypeName = "date")]
        public DateTime? namXB { get; set; }

        public bool? tinhtrang { get; set; }

        public int? sotrang { get; set; }

        public int? soluong { get; set; }

        public int? maNXB { get; set; }

        public int? maDMS { get; set; }

        public int? maTG { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CHITIET_HD> CHITIET_HD { get; set; }

        public virtual DANHMUCSACH DANHMUCSACH { get; set; }

        public virtual NHAXUATBAN NHAXUATBAN { get; set; }

        public virtual TACGIA TACGIA { get; set; }
    }
}
