namespace TatliForm
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Siparis
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Siparis()
        {
            SiparisUrun = new HashSet<SiparisUrun>();
            Musteri = new HashSet<Musteri>();
        }

        public int Id { get; set; }

        [Column(TypeName = "date")]
        public DateTime Tarih { get; set; }

        [StringLength(50)]
        public string Personel { get; set; }

        public bool OnaylandiMi { get; set; }

        [Column(TypeName = "money")]
        public decimal SiparisTutari { get; set; }

        public bool OdemeYapildiMi { get; set; }

        public bool HazirMi { get; set; }

        public bool Aktif { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SiparisUrun> SiparisUrun { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Musteri> Musteri { get; set; }
    }
}
