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
    public partial class SatinAlmaForm : Form
    {
        public SatinAlmaForm()
        {
            InitializeComponent();
        }
        void Goster()
        {
            dataGridView1.DataSource = stORM.Listele();
            //dataGridView1.Columns["Id"].Visible = false;
            dataGridView1.Columns["aktif"].Visible = false;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        TedarikciORM tOrm = new TedarikciORM();
        private void SatinAlmaForm_Load(object sender, EventArgs e)
        {
            Goster();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
        void temizle()
        {
            txtAciklama.Clear();
            txtUcret.Clear();
            
        }
        private void label3_Click(object sender, EventArgs e)
        {

        }
        SatinAlma stEntity = new SatinAlma();
        SatinAlmaORM stORM = new SatinAlmaORM();
        private void btnEkle_Click(object sender, EventArgs e)
        {
            stEntity.Tarih =Convert.ToDateTime(dateTimePicker1.Text);
            stEntity.Aciklama = txtAciklama.Text;
            stEntity.Ucret =Convert.ToDecimal(txtUcret.Text);
            bool sonuc = stORM.Ekle(stEntity);
            if(sonuc)
                MessageBox.Show("Satın Alma Eklenmiştir!");
            else
                MessageBox.Show("Hata Meydana Geldi Lütfen Alanları Kontrol Ediniz!");
            Goster();

            temizle();

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(dataGridView1.CurrentRow!=null)
            {
                txtAciklama.Text = dataGridView1.CurrentRow.Cells["Aciklama"].Value.ToString();
                txtUcret.Text = dataGridView1.CurrentRow.Cells["Ucret"].Value.ToString();
                dateTimePicker1.Text =Convert.ToString(dataGridView1.CurrentRow.Cells["Tarih"].Value);
            }
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            stEntity.Tarih = Convert.ToDateTime(dateTimePicker1.Text);
            stEntity.Aciklama = txtAciklama.Text;
            stEntity.Ucret =Convert.ToDecimal(txtUcret.Text);
            stEntity.Id = (int)dataGridView1.CurrentRow.Cells["Id"].Value;
            bool sonuc = stORM.Guncelle(stEntity);
            if (sonuc)
            {
                MessageBox.Show("Güncelleme Başarılı!");
                Goster();
                temizle();
            }
            else
                MessageBox.Show("Güncelleme Başarısız");

            


        }

        private void silToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                stEntity.Id = (int)dataGridView1.CurrentRow.Cells["Id"].Value;
                stEntity.Aciklama = txtAciklama.Text;
                stEntity.Ucret = Convert.ToDecimal(txtUcret.Text);
                stEntity.Tarih = Convert.ToDateTime(dateTimePicker1.Value);
                bool sonuc = stORM.Sil(stEntity);
                if (sonuc)
                    MessageBox.Show("Kayıt Silinmiştir!");
                else
                    MessageBox.Show("Kayıt Silinirken Hata Meydana Geldi!");
                Goster();
                temizle();
            }



        }
        }
    }

