namespace TatliForm
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SatinAlma")]
    public partial class SatinAlma
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SatinAlma()
        {
            SatınAlmaMalzeme = new HashSet<SatınAlmaMalzeme>();
        }

        public int Id { get; set; }

        [Column(TypeName = "date")]
        public DateTime Tarih { get; set; }

        [Column(TypeName = "money")]
        public decimal Ucret { get; set; }

        [Required]
        [StringLength(500)]
        public string Aciklama { get; set; }

        public bool aktif { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SatınAlmaMalzeme> SatınAlmaMalzeme { get; set; }
    }
}
