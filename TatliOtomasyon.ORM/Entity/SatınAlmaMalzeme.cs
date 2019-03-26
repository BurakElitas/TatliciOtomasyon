using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TatliOtomasyon.ORM.Entity
{
   public class SatınAlmaMalzeme
    {
        public int SatınAlmaId { get; set; }
        public int MalzemeId { get; set; }
        public decimal Miktar { get; set; }
    }
}
