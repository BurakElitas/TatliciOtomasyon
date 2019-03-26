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
    public partial class UrunlerForm : Form
    {
        public UrunlerForm()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            AnasayfaForm.uform.Close();
        }
        UrunlerORM urunorm = new UrunlerORM();
        Urunler uEntity = new Urunler();
        void urunGoster()
        {
            dataGridView1.DataSource = urunorm.Listele();
            dataGridView1.Columns["Id"].Visible = false;
            dataGridView1.Columns["Aktif"].Visible = false;
        }
        private void UrunlerForm_Load(object sender, EventArgs e)
        {
            urunGoster();

        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            uEntity.Adi = txtUrunad.Text.ToUpper();
            uEntity.Fiyat = Convert.ToDecimal(numericUpDown1.Value);
            bool sonuc = urunorm.Ekle(uEntity);
            if (sonuc)
                MessageBox.Show("Ürün Başarılı Bir Şekilde Eklendi!");
            else
                MessageBox.Show("Ürün Ekleme Hatası!");
            urunGoster();
            txtUrunad.Clear();
            

        }

        private void silToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(dataGridView1.CurrentRow!=null)
            {

                uEntity.Id = (int)dataGridView1.CurrentRow.Cells["Id"].Value;
                uEntity.Adi = dataGridView1.CurrentRow.Cells["Adi"].Value.ToString();
                uEntity.Fiyat = Convert.ToDecimal(dataGridView1.CurrentRow.Cells["Fiyat"].Value);



               bool sonuc= urunorm.Sil(uEntity);
                if(sonuc)
                    MessageBox.Show("Ürün Başarılı Bir Şekilde Silindi!");
                else
                    MessageBox.Show("Ürün Silme İşlemi Başarısız");
                urunGoster();
                txtUrunad.Clear();

            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtUrunad.Text = dataGridView1.CurrentRow.Cells["Adi"].Value.ToString();
            numericUpDown1.Value =Convert.ToDecimal (dataGridView1.CurrentRow.Cells["Fiyat"].Value);
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            uEntity.Id = (int)dataGridView1.CurrentRow.Cells["Id"].Value;
            uEntity.Adi = txtUrunad.Text.ToUpper();
            uEntity.Fiyat =Convert.ToDecimal(numericUpDown1.Value);
            bool sonuc=urunorm.Guncelle(uEntity);
            if(sonuc)
                MessageBox.Show("Güncelleme İşlemi Başarılı");
            else
                MessageBox.Show("Güncelleme Başarısız!!");
            urunGoster();
            txtUrunad.Clear();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            txtUrunad.Clear();

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            urunGoster();
        }
    }
}
