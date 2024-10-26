namespace ReportDemoVip.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SACH")]
    public partial class SACH
    {
        [Key]
        [StringLength(10)]
        public string MaSach { get; set; }

        [Required]
        [StringLength(255)]
        public string TenSach { get; set; }

        public int NamXuatBan { get; set; }

        public int MaLoai { get; set; }

        public virtual LOAISACH LOAISACH { get; set; }
    }
}
