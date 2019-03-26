using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TatliOtomasyon.ORM.Entity
{
   public class Kullanici
    {
        public int Id { get; set; }
        public string KullaniciAdi { get; set; }
        public int KullaniciTip { get; set; }
        public string Sifre { get; set; }
        public int Soruid { get; set; }
        public string Cevap { get; set; }
        public bool Aktif { get; set; }
    }
}
