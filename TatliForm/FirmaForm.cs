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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace TatliForm
{
    public partial class FirmaForm : Form
    {
        public FirmaForm()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = dataGridView1.DataSource = Tools.Ara(txtAd.Text.ToUpper(), "", "Firma");
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
        Firma frm = new Firma();
        FirmaORM frmOrm = new FirmaORM();
        void firmaGoster()
        {
            dataGridView1.DataSource = frmOrm.Listele();
            dataGridView1.Columns["Id"].Visible = false;
            dataGridView1.Columns["Aktif"].Visible = false;
        }
        private void pictureBox4_Click(object sender, EventArgs e)
        {
            txtAd.Clear();
            txtMail.Clear();
            txtTel.Clear();
            txtadres.Clear();
            
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {
           
        }

        private void FirmaForm_Load(object sender, EventArgs e)
        {
            firmaGoster();
        }
       
        private void btnEkle_Click(object sender, EventArgs e)
        {
            frm.Adi = txtAd.Text.ToUpper();
            frm.Adres = txtadres.Text;
            frm.TelNo = txtTel.Text;
            frm.Mail = txtMail.Text;
            bool sonuc = frmOrm.Ekle(frm);
            if(sonuc)
                MessageBox.Show("Ekleme İşlemi Başarılı");
            else
                MessageBox.Show("Ekleme İşlemi Başarısız!");

            firmaGoster();
         

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            firmaGoster();
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            frm.Id =(int)dataGridView1.CurrentRow.Cells["Id"].Value;
            frm.Adi = txtAd.Text.ToUpper();
            frm.Adres = txtadres.Text;
            frm.TelNo = txtTel.Text;
            frm.Mail = txtMail.Text;
            bool sonuc = frmOrm.Guncelle(frm);
            if (sonuc)
                MessageBox.Show("Güncelleme İşlemi Başarılı");
            else
                MessageBox.Show("Güncelleme İşlemi Başarısız!");

            firmaGoster();
            txtAd.Clear();
            txtMail.Clear();
            txtTel.Clear();
            txtadres.Clear();

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(dataGridView1.CurrentRow!=null)
            {
                txtAd.Text = dataGridView1.CurrentRow.Cells["Adi"].Value.ToString();
                txtadres.Text = dataGridView1.CurrentRow.Cells["Adres"].Value.ToString();
                txtMail.Text = dataGridView1.CurrentRow.Cells["Mail"].Value.ToString();
                txtTel.Text = dataGridView1.CurrentRow.Cells["TelNo"].Value.ToString();
            }
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            
        }

        private void silToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(dataGridView1.CurrentRow!=null)
            {
                frm.Id = (int)dataGridView1.CurrentRow.Cells["Id"].Value;
                frm.Adi = txtAd.Text.ToUpper();
                frm.Adres = txtadres.Text;
                frm.Mail = txtMail.Text;
                frm.TelNo = txtTel.Text;

               bool sonuc=frmOrm.Sil(frm);
                if(sonuc)
                    MessageBox.Show("Silme İşlemi Başarılı!");
                else
                    MessageBox.Show("Hata Oluştu!");
                firmaGoster();
                txtAd.Clear();
                txtMail.Clear();
                txtTel.Clear();
                txtadres.Clear();


            }
        }
    }
}
