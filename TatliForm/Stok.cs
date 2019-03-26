namespace TatliForm
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Stok")]
    public partial class Stok
    {
        public int Id { get; set; }

        public int MalzemeId { get; set; }

        public double Miktar { get; set; }

        public virtual Malzeme Malzeme { get; set; }
    }
}
