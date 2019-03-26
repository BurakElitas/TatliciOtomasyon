using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TatliOtomasyon.ORM
{
   public interface IORM<T>where T:class
    {
        DataTable Listele();
        bool Ekle(T entity);
        bool Guncelle(T entity);
        bool Sil(T entity);
    }
}
