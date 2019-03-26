using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TatliOtomasyon.ORM.Entity
{
   public class Stok
    {
        public int Id { get; set; }
        public int MalzemeId { get; set; }
        public decimal Miktar { get; set; }
    }
}
