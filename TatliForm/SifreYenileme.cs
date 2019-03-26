using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data.SqlClient;
using TatliOtomasyon.ORM;
using TatliOtomasyon.ORM.Entity;
using TatliOtomasyon.ORM.Facade;

namespace TatliForm
{
    public partial class SifreYenileme : Form
    {
        SqlCommand cmd;
        string vericevap = "";
        public SifreYenileme()
        {
            InitializeComponent();
        }
        void ConnectionOpen()
        {
            if (cmd.Connection.State == ConnectionState.Closed)
            {
                cmd.Connection.Open();
            }
           


        }
        void ConnectionClose()
        {
            if (cmd.Connection.State == ConnectionState.Open)
            {
                cmd.Connection.Close();
            }
        }
        private void btnonay_Click(object sender, EventArgs e)
        {
             cmd = new SqlCommand();
            cmd.Connection = Tools.Baglanti;
            cmd.CommandText = "pro_SifreYenile";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Kullaniciadi", txtkullan.Text);
            ConnectionOpen();
            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.Read())
            { 
                labelsoru.Text = reader.GetString(0);
            }
            else
            {
                MessageBox.Show("Sistemde Böyle Bir Kullanıcı Adı Kayıtlı Değil!");
            }
            ConnectionClose();
           

            
        }

        private void SifreYenileme_Load(object sender, EventArgs e)
        {
            txtkullan.Text = GirisForm.kullaniciadi.ToString();

            lblyenisifre.Visible = false;
            txtyenisifre.Visible = false;
            btnyenisifre.Visible = false;
        }

        private void txtkullan_TextChanged(object sender, EventArgs e)
        {

        }

        private void btncevap_Click(object sender, EventArgs e)
        {
           
            string cevap = txtcevap.Text;
            SqlCommand cmd2 = new SqlCommand();
            cmd2.Connection = Tools.Baglanti;
            cmd2.CommandText = string.Format("select Cevap from Kullanici where KullaniciAdi='{0}'", txtkullan.Text);
            ConnectionOpen();

            SqlDataReader reader = cmd2.ExecuteReader();
            if(reader.Read())
            {
                 vericevap = reader.GetString(0);
            }

            ConnectionClose();
            
            if(cevap==vericevap)
            {
                lblyenisifre.Visible = true;
                txtyenisifre.Visible = true;
                btnyenisifre.Visible = true;

            }
            else
            {
                MessageBox.Show("Cevabınız Doğru Değil! Lütfen Tekrar Deneyiniz!");
            }
            





        }

        private void btnyenisifre_Click(object sender, EventArgs e)
        {
            

            SqlCommand cmd3 = new SqlCommand();
            cmd3.Connection = Tools.Baglanti;
            cmd3.CommandText = string.Format("Update Kullanici set Sifre='{0}' where KullaniciAdi='{1}'", txtyenisifre.Text, txtkullan.Text);
            bool sonuc = Tools.ExecuteNonQuery(cmd3);
            if (sonuc)
            {
                MessageBox.Show("Şifreniz Güncellendi");
                this.Close();
            }

            else
                MessageBox.Show("Şifre Güncellemesi Başarısız");
        }
    }
}
