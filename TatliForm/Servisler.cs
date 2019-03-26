namespace TatliForm
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Servisler")]
    public partial class Servisler
    {
        public int Id { get; set; }

        [StringLength(50)]
        public string PlakaNo { get; set; }

        [StringLength(50)]
        public string SoforId { get; set; }

        public virtual Personel Personel { get; set; }
    }
}
