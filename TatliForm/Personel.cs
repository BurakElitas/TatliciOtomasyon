namespace TatliForm
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Personel")]
    public partial class Personel
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Personel()
        {
            Servisler = new HashSet<Servisler>();
        }

        [StringLength(50)]
        public string Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Adi { get; set; }

        [Required]
        [StringLength(50)]
        public string Soyadi { get; set; }

        [Column(TypeName = "money")]
        public decimal? Maas { get; set; }

        [Required]
        [StringLength(11)]
        public string Tckn { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DogumTarih { get; set; }

        [Column(TypeName = "date")]
        public DateTime? IsegirisTarih { get; set; }

        [StringLength(500)]
        public string Adres { get; set; }

        [Required]
        [StringLength(15)]
        public string TelNo { get; set; }

        [StringLength(50)]
        public string Mail { get; set; }

        public bool? MedeniDurum { get; set; }

        public int? EgitimId { get; set; }

        public bool Aktif { get; set; }

        public virtual Egitim Egitim { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Servisler> Servisler { get; set; }
    }
}
