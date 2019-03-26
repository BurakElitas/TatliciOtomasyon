using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TatliOtomasyon.ORM.Entity
{
   public class Musteri
    {
        public int Id { get; set; }
        public string Adi { get; set; }
        public string Soyadi { get; set; }
        public string Tckn { get; set; }
        public string TelNo { get; set; }
        public string Mail { get; set; }
        public int FirmaId { get; set; }
        public bool Aktif { get; set; }

    }
}
