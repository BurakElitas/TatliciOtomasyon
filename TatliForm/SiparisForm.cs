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
    public partial class SiparisForm : Form
    {
        public SiparisForm()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            AnasayfaForm.SiparisForm.Close();
        }
        SiparisORM siparisOrm = new SiparisORM();
        //PersonelORM personelOrm = new PersonelORM();
        KullaniciORM kullaniciOrm = new KullaniciORM();
        MusteriORM musOrm = new MusteriORM();
        MusteriSiparisORM musteriSiparisOrm = new MusteriSiparisORM();
        DataTable list()
        {
            SqlCommand cmd = new SqlCommand();
            SqlDataAdapter adp = new SqlDataAdapter();
            cmd.Connection = Tools.Baglanti;
            cmd.CommandText = "select Id,(Adi + ' ' + Soyadi) AS NAME FROM Musteri where Aktif=1";
            adp.SelectCommand = cmd;
            DataTable dt = new DataTable();
            adp.Fill(dt);
            return dt;
            

        }
        private void SiparisForm_Load(object sender, EventArgs e)
        {
            comboMüsteri.DataSource = list();
            comboMüsteri.DisplayMember = "NAME";
            comboMüsteri.ValueMember = "Id";
            txtPerson.Text = GirisForm.kullaniciadi;
            goster();
        }
        SiparisORM sORM = new SiparisORM();
        Siparis sEntity = new Siparis();
        MusteriSiparis musterisparisEntity = new MusteriSiparis();
        private void btnEkle_Click(object sender, EventArgs e)
        {
            sEntity.Tarih = Convert.ToDateTime(dateTarih.Value);
            sEntity.Personel = txtPerson.Text;
            sEntity.SiparisTutari = Convert.ToDecimal(txtUcret.Text);
            if (comboOdeme.Text == "Yapıldı")
                sEntity.OdemeYapildiMi = true;
            else
                sEntity.OdemeYapildiMi = false;

            bool sonuc = sORM.Ekle(sEntity);
            if (sonuc)
            {
                MessageBox.Show("Siparis Eklendi!");

            }

            else
                MessageBox.Show("Siparis Eklenemedi!");

            SqlCommand cmd = new SqlCommand();
            try
            {
                //int sayi = dataGridView1.Rows.Count - 1;

                cmd.Connection = Tools.Baglanti;
                cmd.CommandText = "pro_Son";
                cmd.CommandType = CommandType.StoredProcedure;
                if (cmd.Connection.State == ConnectionState.Closed)
                    cmd.Connection.Open();

                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    musterisparisEntity.SiparisId = Convert.ToInt32(reader.GetInt32(0));
                    musterisparisEntity.MusteriId = (int)comboMüsteri.SelectedValue;
                    bool sonuc2 = musteriSiparisOrm.Ekle(musterisparisEntity);
                    if (sonuc2)
                        MessageBox.Show("Çoka çoka Eklendi");
                    else
                        MessageBox.Show("Müsteride Hata var");
                }
            }

            catch (Exception)
            {
                MessageBox.Show("Catche düştü");
            }
            finally
            {
                if (cmd.Connection.State == ConnectionState.Open)
                    cmd.Connection.Close();
            }





            goster();
            txtUcret.Clear();
        }



        void goster()
        {
            dataGridView1.DataSource = sORM.Listele();
            dataGridView1.Columns["OdemeYapildiMi"].Visible = false;
            dataGridView1.Columns["OnaylandiMi"].Visible = false;
            dataGridView1.Columns["HazirMi"].Visible = false;
            dataGridView1.Columns["Aktif"].Visible = false;
            dataGridView1.Columns["Id"].Visible = false;
            dataGridView1.Columns["MusteriId"].Visible = false;
            //dataGridView1.Columns["MüteriIid"].Visible = false;
            dataGridView1.Columns["Id1"].Visible = false;
            dataGridView1.Columns["Mail"].Visible = false;
            dataGridView1.Columns["TelNo"].Visible = false;
            dataGridView1.Columns["Aktif1"].Visible = false;
            dataGridView1.Columns["Tckn"].Visible = false;
            dataGridView1.Columns["FirmaId"].Visible = false;


        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                dateTarih.Text = dataGridView1.CurrentRow.Cells["Tarih"].Value.ToString();
                txtUcret.Text = dataGridView1.CurrentRow.Cells["SiparisTutari"].Value.ToString();
                if (Convert.ToBoolean(dataGridView1.CurrentRow.Cells["OdemeYapildiMi"].Value) == true)
                    comboOdeme.Text = "Yapıldı";
                else
                    comboOdeme.Text = "Yapılmadı";
                comboMüsteri.Text = dataGridView1.CurrentRow.Cells["Soyadi"].Value.ToString();
            }
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                musterisparisEntity.MusteriId = (int)comboMüsteri.SelectedValue;
                musterisparisEntity.SiparisId = (int)dataGridView1.CurrentRow.Cells["Id"].Value;
                bool sonuc1 = musteriSiparisOrm.Guncelle(musterisparisEntity);
                if (sonuc1)
                {

                    sEntity.Id = (int)dataGridView1.CurrentRow.Cells["Id"].Value;
                    sEntity.Tarih = Convert.ToDateTime(dateTarih.Value);
                    sEntity.Personel = txtPerson.Text;
                    sEntity.SiparisTutari = Convert.ToDecimal(txtUcret.Text);
                    if (comboOdeme.Text == "Yapıldı")
                        sEntity.OdemeYapildiMi = true;
                    else
                        sEntity.OdemeYapildiMi = false;

                    bool sonuc = sORM.Guncelle(sEntity);
                    if (sonuc)
                        MessageBox.Show("Siparis Guncellendi");
                    else
                        MessageBox.Show("Siparis Guncellenemedi!");
                }

                goster();
                txtUcret.Clear();
            }
        }

        private void silToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {

                sEntity.Id = (int)dataGridView1.CurrentRow.Cells["Id"].Value;
                sEntity.Tarih = Convert.ToDateTime(dateTarih.Value);
                sEntity.Personel = txtPerson.Text;
                sEntity.SiparisTutari = Convert.ToDecimal(txtUcret.Text);
                if (comboOdeme.Text == "Yapıldı")
                    sEntity.OdemeYapildiMi = true;
                else
                    sEntity.OdemeYapildiMi = false;

                bool sonuc = sORM.Sil(sEntity);
                if (sonuc)
                    MessageBox.Show("Siparis Silindi");
                else
                    MessageBox.Show("Siparis Silinemedi!");

                goster();
                txtUcret.Clear();
            }
        }
        //MüsteriForm mf = new MüsteriForm();
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (AnasayfaForm.musterifrm.IsDisposed)
                AnasayfaForm.musterifrm = new MüsteriForm();
            AnasayfaForm.musterifrm.Show();
            
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            comboMüsteri.DataSource = list();
            comboMüsteri.DisplayMember = "NAME";
            comboMüsteri.ValueMember = "Id";
            
        }
    }
}
