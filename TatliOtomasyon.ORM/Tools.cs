using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace TatliOtomasyon.ORM
{
   public class Tools
    {
        private static SqlConnection baglanti;
        public static SqlConnection Baglanti
        {
            get
            {
                if(baglanti==null)
                {
                    baglanti = new SqlConnection(ConfigurationManager.ConnectionStrings["local"].ConnectionString);
                }
                return baglanti;
            }
           
        }

        public static bool ExecuteNonQuery(SqlCommand cmd)
        {
            try
            {
                if (cmd.Connection.State != ConnectionState.Open)
                {
                    cmd.Connection.Open();
                }

                int etk = cmd.ExecuteNonQuery();
                if (etk>0)
                    return true;
                else
                    return false;
            }
            catch(Exception)
            {
                
                return false;
            }
            finally
            {
                if (cmd.Connection.State == ConnectionState.Open)
                    cmd.Connection.Close();
            }
        }
        public static DataTable Ara(string ad, string soyad,string classadi)
        {
            SqlDataAdapter adp = new SqlDataAdapter();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = Baglanti;
            cmd.CommandText = string.Format("pro_{0}_Ara",classadi);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Ad", ad);
            cmd.Parameters.AddWithValue("@Soyad", soyad);
            //cmd.Parameters.AddWithValue("@FirmaId", firmaid);
            adp.SelectCommand = cmd;
            DataTable dt = new DataTable();
            adp.Fill(dt);
            return dt;
        }
    }
}
