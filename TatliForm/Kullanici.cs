namespace TatliForm
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Kullanici")]
    public partial class Kullanici
    {
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string KullaniciAdi { get; set; }

        public int? KullaniciTip { get; set; }

        [Required]
        [StringLength(50)]
        public string Sifre { get; set; }

        public int? Soruid { get; set; }

        [Required]
        [StringLength(50)]
        public string Cevap { get; set; }

        public bool Aktif { get; set; }

        public virtual GuvenlikSoru GuvenlikSoru { get; set; }

        public virtual KullaniciTip KullaniciTip1 { get; set; }
    }
}
