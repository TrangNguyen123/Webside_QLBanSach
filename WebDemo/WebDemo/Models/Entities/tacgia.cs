namespace WebDemo.Models.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tacgia")]
    public partial class tacgia
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tacgia()
        {
            saches = new HashSet<sach>();
        }

        [Key]
        [StringLength(10)]
        public string matacgia { get; set; }

        [StringLength(50)]
        public string tentacgia { get; set; }

        [StringLength(100)]
        public string diachi { get; set; }

        [StringLength(200)]
        public string tieusu { get; set; }

        [StringLength(50)]
        public string sodienthoai { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<sach> saches { get; set; }
    }
}
