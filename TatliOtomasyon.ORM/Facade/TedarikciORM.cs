using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TatliOtomasyon.ORM.Entity;

namespace TatliOtomasyon.ORM.Facade
{
    public class TedarikciORM:ORMBase<Tedarikci>
    {
        public DataTable Ara(string ad)
        {
            SqlDataAdapter adp = new SqlDataAdapter();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = Tools.Baglanti;
            cmd.CommandText = "pro_Tedarikci_Ara";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("Adi", ad);
            adp.SelectCommand = cmd;
            DataTable dt = new DataTable();
            adp.Fill(dt);
            return dt;
        }
    }
}
