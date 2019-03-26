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
    public partial class TedarikciForm : Form
    {
        public TedarikciForm()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        void temizle()
        {
            txtAd.Clear();
            txtAdres.Clear();
            txtMail.Clear();
            txtTel.Clear();
        }
        private void pictureBox4_Click(object sender, EventArgs e)
        {
            temizle();
        }
        void TedarikciGoster()
        {
            dataGridView1.DataSource = tORM.Listele();
            dataGridView1.Columns["Id"].Visible = false;
            dataGridView1.Columns["Aktif"].Visible = false;

        }
        Tedarikci tEntity = new Tedarikci();
        TedarikciORM tORM = new TedarikciORM();
        private void btnEkle_Click(object sender, EventArgs e)
        {
            tEntity.Adi = txtAd.Text.ToUpper();
            tEntity.Adres = txtAdres.Text;
            tEntity.Mail = txtMail.Text;
            tEntity.TelNo = txtTel.Text;

            bool sonuc=tORM.Ekle(tEntity);
            if(sonuc)
                MessageBox.Show("Ekleme İşlemi Başarılı!");
            else
                MessageBox.Show("Ekleme Yapılırken Hata Oluştu!");
            TedarikciGoster();
            temizle();

        }

        private void TedarikciForm_Load(object sender, EventArgs e)
        {
            TedarikciGoster();

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(dataGridView1.CurrentRow!=null)
            {
                txtAd.Text = dataGridView1.CurrentRow.Cells["Adi"].Value.ToString();
                txtAdres.Text = dataGridView1.CurrentRow.Cells["Adres"].Value.ToString();
                txtMail.Text = dataGridView1.CurrentRow.Cells["Mail"].Value.ToString();
                txtTel.Text = dataGridView1.CurrentRow.Cells["TelNo"].Value.ToString();

            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            TedarikciGoster();
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            tEntity.Adi = txtAd.Text.ToUpper();
            tEntity.Adres = txtAdres.Text;
            tEntity.Mail = txtMail.Text;
            tEntity.TelNo = txtTel.Text;
            tEntity.Id =(int)dataGridView1.CurrentRow.Cells["Id"].Value;
            bool sonuc = tORM.Guncelle(tEntity);
            if(sonuc)
                MessageBox.Show("Güncelleme Başarılı!");
            else
                MessageBox.Show("Güncelleme Başarısız!");
            TedarikciGoster();
            temizle();

        }

        private void btnArama_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = tORM.Ara(txtAd.Text.ToUpper());
        }

        private void silToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(dataGridView1.CurrentRow!=null)
            {
                tEntity.Id = (int)dataGridView1.CurrentRow.Cells["Id"].Value;
                tEntity.Adi = txtAd.Text;
                tEntity.Adres = txtAdres.Text;
                tEntity.Mail = txtMail.Text;
                tEntity.TelNo = txtTel.Text;
                bool sonuc = tORM.Sil(tEntity);
                if(sonuc)
                    MessageBox.Show("Kayıt Silindi!");
                else
                    MessageBox.Show("Kayıt Silinirken Hata Oluştu");
                temizle();
                TedarikciGoster();

            }
        }
    }
}
