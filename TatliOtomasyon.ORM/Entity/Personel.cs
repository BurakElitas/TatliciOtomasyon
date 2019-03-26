using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TatliOtomasyon.ORM.Entity
{
    public class Personel
    {
        public int Id { get; set; }
        public string Adi { get; set; }
        public string Soyadi { get; set; }
        public decimal Maas { get; set; }
        public string Tckn { get; set; }
        public DateTime DogumTarih { get; set; }
        public DateTime IsegirisTarih { get; set; }
        public string Adres { get; set; }
        public string TelNo { get; set; }
        public string Mail { get; set; }
        public bool MedeniDurum { get; set; }
        public int EgitimId { get; set; }
        public bool Aktif { get; set; }
    }
}
