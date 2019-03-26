using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;



namespace TatliOtomasyon.ORM
{
    public class ORMBase<TT> : IORM<TT>where TT:class
    {
        Type Tipgetir
        {
            get
            {
                return typeof(TT);
            }
        }
        public bool Ekle(TT entity)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = Tools.Baglanti;
            cmd.CommandText = string.Format("pro_{0}_Ekle", Tipgetir.Name);
            cmd.CommandType = CommandType.StoredProcedure;
            

            PropertyInfo[] properties = Tipgetir.GetProperties();

            foreach (PropertyInfo pi in properties)
            {
                string Padi ="@"+pi.Name;
                object Pdeger = pi.GetValue(entity);
                cmd.Parameters.AddWithValue(Padi, Pdeger);
            }
            
            return Tools.ExecuteNonQuery(cmd);
           
        }

        public bool Guncelle(TT entity)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = Tools.Baglanti;
            cmd.CommandText = string.Format("pro_{0}_Guncelle", Tipgetir.Name);
            cmd.CommandType = CommandType.StoredProcedure;
            PropertyInfo[] properties = Tipgetir.GetProperties();
            foreach (PropertyInfo pi in properties)
            {
                string Padi ="@"+pi.Name;
                object Pdeger = pi.GetValue(entity);
                cmd.Parameters.AddWithValue(Padi, Pdeger);
            }
            return Tools.ExecuteNonQuery(cmd);

        }

        public DataTable Listele()
        {
            SqlDataAdapter adp = new SqlDataAdapter();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = Tools.Baglanti;
            cmd.CommandText = string.Format("pro_{0}_Listele", Tipgetir.Name);
            cmd.CommandType = CommandType.StoredProcedure;
            adp.SelectCommand = cmd;
            DataTable dt = new DataTable();
            adp.Fill(dt);
            return dt;
        }

        public bool Sil(TT entity)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = Tools.Baglanti;
            cmd.CommandText = string.Format("pro_{0}_Sil", Tipgetir.Name);
            cmd.CommandType = CommandType.StoredProcedure;
            PropertyInfo[] properties = Tipgetir.GetProperties();
            foreach (PropertyInfo pi in properties)
            {
                string Padi = "@" + pi.Name;
                object Pdeger = pi.GetValue(entity);
                cmd.Parameters.AddWithValue(Padi, Pdeger);
            }
            return Tools.ExecuteNonQuery(cmd);
        }
    }
}
