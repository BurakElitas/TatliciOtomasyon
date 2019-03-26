using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TatliOtomasyon.ORM.Entity
{
   public class Siparis
    {
        public int Id { get; set; }
        public DateTime Tarih { get; set; }
        public string Personel { get; set; }
        public bool OnaylandiMi { get; set; }
        public decimal SiparisTutari { get; set; }
        public bool OdemeYapildiMi { get; set; }
        public bool HazirMi { get; set; }
        public bool Aktif { get; set; }



    }
}
