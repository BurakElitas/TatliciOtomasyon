using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TatliOtomasyon.ORM;
using TatliOtomasyon.ORM.Entity;
using TatliOtomasyon.ORM.Facade;

namespace TatliForm
{
    public partial class GirisForm : Form
    {
        public static int soruid;
        public static int tip;
        
        public GirisForm()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        public static string kullaniciadi = "";

        AnasayfaForm anafrm = new AnasayfaForm();
        private void button1_Click(object sender, EventArgs e)
        {

           
        }
        SifreYenileme sy = new SifreYenileme();
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if(sy.IsDisposed)
            {
                sy = new SifreYenileme();
            }
            sy.Show();

        }

        private void GirisForm_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

            string sifre = "";
            kullaniciadi = txtkullanici.Text.ToString();
            sifre = txtSifre.Text.ToString();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = Tools.Baglanti;
            cmd.CommandText = "select * from Kullanici where KullaniciAdi='" + kullaniciadi + "'and Sifre='" + sifre + "'";
            //cmd.CommandType = CommandType.StoredProcedure;
            //cmd.Parameters.AddWithValue("@kullaniciadi", kullaniciadi);
            //cmd.Parameters.AddWithValue("@sifre", sifre);
            if (cmd.Connection.State == ConnectionState.Closed)
            {
                cmd.Connection.Open();
            }
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {

                soruid = reader.GetInt32(4);
                tip = reader.GetInt32(2);

            }


            if (reader.HasRows)
            {
                if (anafrm.IsDisposed)
                {
                    anafrm = new AnasayfaForm();
                }
                anafrm.Show();
                this.Visible = false;
            }
            else
            {
                MessageBox.Show("Hatalı kullanıcı adı veya şifre!");

                txtSifre.Clear();
            }
            if (cmd.Connection.State == ConnectionState.Open)
            {
                cmd.Connection.Close();
            }
        }
    }
}
