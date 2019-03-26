using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TatliOtomasyon.ORM.Entity;
using TatliOtomasyon.ORM.Facade;

namespace TatliForm
{
    public partial class KullaniciForm : Form
    {
        public KullaniciForm()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
        KullaniciORM kullaniciorm = new KullaniciORM();
        Kullanici kentity = new Kullanici();
        KullaniciTipORM korm = new KullaniciTipORM();
        GüvenlikSoruORM gorm = new GüvenlikSoruORM();
        private void KullaniciForm_Load(object sender, EventArgs e)
        {
            
            comboTip.DataSource = korm.Listele();
            comboTip.DisplayMember = "Tip";
            comboTip.ValueMember = "Id";
            comboGüvenlik.DataSource = gorm.Listele();
            comboGüvenlik.DisplayMember = "Soru";
            comboGüvenlik.ValueMember = "Id";
            comboTip.SelectedValue = 1;
            comboGüvenlik.SelectedValue = 1;
            Goster();

        }
        void Goster()
        {
            dataGridView1.DataSource = kullaniciorm.Listele();
            dataGridView1.Columns["Id"].Visible = false;
            dataGridView1.Columns["Sifre"].Visible = false;
            dataGridView1.Columns["SoruId"].Visible = false;
            dataGridView1.Columns["Aktif"].Visible = false;
            dataGridView1.Columns["KullaniciTip"].Visible = false;
            dataGridView1.Columns["Id1"].Visible = false;
            dataGridView1.Columns["Tip"].Visible = false;
            dataGridView1.Columns["Soru"].Visible = false;
            dataGridView1.Columns["Aktif1"].Visible = false;
            dataGridView1.Columns["Cevap"].Visible = false;
            dataGridView1.Columns["Id2"].Visible = false;


        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (txtSifre.Text == txtSifre2.Text)
            {
                kentity.KullaniciAdi = txtKullanici.Text;
               
                kentity.Sifre = txtSifre.Text;
                kentity.KullaniciTip =(int)comboTip.SelectedValue;
                kentity.Soruid = (int)comboGüvenlik.SelectedValue;
                kentity.Cevap = txtCevap.Text;
               bool sonuc= kullaniciorm.Ekle(kentity);
                if(sonuc)
                    MessageBox.Show("Kullanıcı Eklendi!");
                else
                    MessageBox.Show("Kullanıcı Eklenirken Hata Meydana geldi!");
                Goster();
            }
           
            temizle();

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(dataGridView1.CurrentRow!=null)
            {
                txtKullanici.Text = dataGridView1.CurrentRow.Cells["KullaniciAdi"].Value.ToString();
                txtCevap.Text = dataGridView1.CurrentRow.Cells["Cevap"].Value.ToString();
                comboTip.Text = dataGridView1.CurrentRow.Cells["Tip"].Value.ToString();
                comboGüvenlik.Text = dataGridView1.CurrentRow.Cells["Soru"].Value.ToString();
                txtSifre.Text = dataGridView1.CurrentRow.Cells["Sifre"].Value.ToString();
            }
        }

        private void label8_Click(object sender, EventArgs e)
        {

            if (Convert.ToString(txtCevap.PasswordChar) == "*")
            {
                txtCevap.PasswordChar = '\0';
                label8.Text = "Cevap Gizle";
            }
            else
            {
                txtCevap.PasswordChar = Convert.ToChar("*");
                label8.Text = "Cevap Göster";
            }
        }
        void temizle()
        {
            txtCevap.Clear();
            txtKullanici.Clear();
            txtSifre.Clear();
            txtSifre2.Clear();
        }
        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            if(dataGridView1.CurrentRow!=null)
            {
                if (txtSifre.Text == txtSifre2.Text)
                {
                    kentity.Id = (int)dataGridView1.CurrentRow.Cells["Id1"].Value;
                    kentity.KullaniciAdi = txtKullanici.Text;
                    kentity.Sifre = txtSifre.Text;
                    kentity.KullaniciTip = (int)comboTip.SelectedValue;
                    kentity.Soruid = (int)comboGüvenlik.SelectedValue;
                    kentity.Cevap = txtCevap.Text;

                    bool sonuc = kullaniciorm.Guncelle(kentity);
                    if (sonuc)
                        MessageBox.Show("Kayıt Güncellemesi Başarılı!");
                    else
                        MessageBox.Show("Kayıt Güncellenemedi!");
                }
                else
                    MessageBox.Show("Şifre Alanları Aynı Değil!");
                Goster();
            }
               
                temizle();
            }
        

        private void label9_Click(object sender, EventArgs e)
        {

            if (Convert.ToString(txtSifre.PasswordChar) == "*")
            {
                txtSifre.PasswordChar = '\0';
                label9.Text = "Şifre Gizle";
            }
            else
            {
                txtSifre.PasswordChar = Convert.ToChar("*");
                label9.Text = "Şifre Göster";
            }
        }

        private void silToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(dataGridView1.CurrentRow!=null)
            {
                kentity.KullaniciAdi = txtKullanici.Text;
                kentity.KullaniciTip = (int)comboTip.SelectedValue;
                kentity.Sifre = txtSifre.Text;
                kentity.Id = (int)dataGridView1.CurrentRow.Cells["Id1"].Value;
                kentity.Soruid = (int)comboGüvenlik.SelectedValue;
                kentity.Cevap = txtCevap.Text;
                bool sonuc = kullaniciorm.Sil(kentity);
                if(sonuc)
                    MessageBox.Show("Kayıt Silindi!");
                else
                    MessageBox.Show("Kayıt Silinirken Hata Meydana Geldi");
                Goster();
                temizle();

            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            temizle();
        }
    }
}
