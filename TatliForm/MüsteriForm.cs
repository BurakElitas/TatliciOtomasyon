using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
    public partial class MüsteriForm : Form
    {
        FirmaORM firma = new FirmaORM();
        Musteri musteriEntity = new Musteri();
        MusteriORM musteri = new MusteriORM();
        public MüsteriForm()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            AnasayfaForm.musterifrm.Close();
        }
        void Liste()
        {
            dataGridView1.DataSource = musteri.Listele();
            dataGridView1.Columns["Id"].Visible = false;
            dataGridView1.Columns["FirmaId"].Visible = false;
            dataGridView1.Columns["Aktif"].Visible = false;
            dataGridView1.Columns["Adi1"].Visible = false;
            dataGridView1.Columns["Adres"].Visible = false;
            dataGridView1.Columns["Id1"].Visible = false;
            dataGridView1.Columns["TelNo1"].Visible = false;
            dataGridView1.Columns["Mail1"].Visible = false;
            dataGridView1.Columns["Aktif1"].Visible = false;

        }
        void firmalist()
        {
            comboFirma.DisplayMember = "Adi";
            comboFirma.ValueMember = "Id";
            comboFirma.DataSource = firma.Listele();
        }
        private void MüsteriForm_Load(object sender, EventArgs e)
        {
            firmalist();
            Liste();
           

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(dataGridView1.CurrentRow!=null)
            {
                txtMusad.Text = dataGridView1.CurrentRow.Cells["Adi"].Value.ToString();
                txtSoyad.Text = dataGridView1.CurrentRow.Cells["Soyadi"].Value.ToString();
                txtTc.Text = dataGridView1.CurrentRow.Cells["Tckn"].Value.ToString();
                txtTel.Text = dataGridView1.CurrentRow.Cells["TelNo"].Value.ToString();
                txtMail.Text= dataGridView1.CurrentRow.Cells["Mail"].Value.ToString();
                comboFirma.Text = dataGridView1.CurrentRow.Cells["Adi1"].Value.ToString();


            }
        }
        

        private void btnEkle_Click(object sender, EventArgs e)
        {
            musteriEntity.Adi = txtMusad.Text.ToUpper();
            musteriEntity.Soyadi = txtSoyad.Text.ToUpper();
            musteriEntity.Tckn = txtTc.Text;
            musteriEntity.TelNo = txtTel.Text;
            musteriEntity.Mail = txtMail.Text;
            musteriEntity.FirmaId =Convert.ToInt32(comboFirma.SelectedValue);
           bool sonuc= musteri.Ekle(musteriEntity);
            if (sonuc)
                MessageBox.Show("Kayıt Başarılı Bir Şekilde Eklendi!");
            else
                MessageBox.Show("Kayıt Eklenemedi!");
            Liste();
            Temizle();
        }

       
        private void btnguncelle_Click(object sender, EventArgs e)
        {
            musteriEntity.Id =(int)dataGridView1.CurrentRow.Cells["Id"].Value;
            musteriEntity.Adi = txtMusad.Text.ToUpper();
            musteriEntity.Soyadi = txtSoyad.Text.ToUpper();
            musteriEntity.Tckn = txtTc.Text;
            musteriEntity.TelNo = txtTel.Text;
            musteriEntity.Mail = txtMail.Text;
            musteriEntity.FirmaId =Convert.ToInt32(comboFirma.SelectedValue);
           bool sonuc= musteri.Guncelle(musteriEntity);
            if(sonuc)
                MessageBox.Show("Kayıt Başarılı Bir Şekilde Güncellendi!");
            else
                MessageBox.Show("Kayıt Güncellenemedi!");
            Liste();
            Temizle();
        }

        private void btnArama_Click(object sender, EventArgs e)
        {
            
          dataGridView1.DataSource = Tools.Ara(txtMusad.Text.ToUpper(), txtSoyad.Text.ToUpper(),"Musteri");
            dataGridView1.Columns["Id"].Visible = false;
            dataGridView1.Columns["FirmaId"].Visible = false;
            dataGridView1.Columns["Aktif"].Visible = false;
            dataGridView1.Columns["Adi1"].Visible = false;
            dataGridView1.Columns["Adres"].Visible = false;
            dataGridView1.Columns["Id1"].Visible = false;
            dataGridView1.Columns["TelNo1"].Visible = false;
            dataGridView1.Columns["Mail1"].Visible = false;
            dataGridView1.Columns["Aktif1"].Visible = false;



        }

        private void btnYenile_Click(object sender, EventArgs e)
        {
            Liste();
        }
        void Temizle()
        {
            txtMusad.Clear();
            txtMail.Clear();
            txtSoyad.Clear();
            txtTc.Clear();
            txtTel.Clear();
        }
        private void btnTemizle_Click(object sender, EventArgs e)
        {
            Temizle();
        }

        private void txtMusad_Enter(object sender, EventArgs e)
        {
            
        }

        private void txtMusad_TextChanged(object sender, EventArgs e)
        {

        }

        private void silToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(dataGridView1.CurrentRow!=null)
            {

                musteriEntity.Id = (int)dataGridView1.CurrentRow.Cells["Id"].Value;
                musteriEntity.Adi = txtMusad.Text;
                musteriEntity.Soyadi = txtSoyad.Text;
                musteriEntity.Tckn = txtTc.Text;
                musteriEntity.TelNo = txtTel.Text;
                musteriEntity.Mail = txtMail.Text;
                musteriEntity.FirmaId = Convert.ToInt32(comboFirma.SelectedValue);
                bool sonuc = musteri.Sil(musteriEntity);
                if (sonuc)
                    MessageBox.Show("Kayıt Başarılı Bir Şekilde Silindi!");
                else
                    MessageBox.Show("Kayıt Silinmesi Sırasında Hata Oluştu");
                Liste();
                Temizle();
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Liste();
            firmalist();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Temizle();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (AnasayfaForm.firmafrm.IsDisposed)
                AnasayfaForm.firmafrm = new FirmaForm();
            AnasayfaForm.firmafrm.Show();
        }
    }
}
