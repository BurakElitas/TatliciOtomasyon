namespace TatliForm
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Gider")]
    public partial class Gider
    {
        public int Id { get; set; }

        [Column(TypeName = "money")]
        public decimal Ucret { get; set; }

        [Column(TypeName = "date")]
        public DateTime Tarih { get; set; }

        public bool Aktif { get; set; }
    }
}
