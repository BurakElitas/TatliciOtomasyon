using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TatliOtomasyon.ORM.Entity
{
   public class KullaniciTip
    {
        public int Id { get; set; }
        public string Tip { get; set; }
        public bool Aktif { get; set; }
    }
}
