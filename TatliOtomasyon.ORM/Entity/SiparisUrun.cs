using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TatliOtomasyon.ORM.Entity
{
   public class SiparisUrun
    {
        public int SiparisId { get; set; }
        public int UrunId { get; set; }
        public decimal Miktar { get; set; }
    }
}
