namespace Website_BanSach.Models.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class QUYEN_NGUOIDUNG
    {
        [Key]
        [StringLength(50)]
        public string tenND { get; set; }

        public int? IDquyen { get; set; }

        public virtual QUYEN QUYEN { get; set; }
    }
}
