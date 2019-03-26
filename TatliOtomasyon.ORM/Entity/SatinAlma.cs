using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TatliOtomasyon.ORM.Entity
{
    public class SatinAlma
    {
        public int Id { get; set; }
        public string  Aciklama { get; set; }
        public DateTime Tarih { get; set; }
        public decimal Ucret { get; set; }
        public bool aktif { get; set; }
    }
}
