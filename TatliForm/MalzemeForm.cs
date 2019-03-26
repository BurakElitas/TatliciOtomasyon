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
    public partial class MalzemeForm : Form
    {
        public MalzemeForm()
        {
            InitializeComponent();
        }
        void MalzemeGoster()
        {
           dataGridView1.DataSource=mzOrm.Listele();
            dataGridView1.Columns["Id"].Visible = false;

        }
        private void MalzemeForm_Load(object sender, EventArgs e)
        {
            MalzemeGoster();

           

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        Malzeme mzentity = new Malzeme();
        MalzemeORM mzOrm = new MalzemeORM();
        private void btnEkle_Click(object sender, EventArgs e)
        {
            mzentity.Adi = txtmalad.Text.ToUpper();
            mzentity.Fiyat =Convert.ToDecimal(numFiyat.Value);
            bool sonuc = mzOrm.Ekle(mzentity);
            if(sonuc)
                MessageBox.Show("Malzeme Başarıyla Eklendi!");
            else
                MessageBox.Show("Malzeme Eklenirken Hata Meydana Geldi!");
            txtmalad.Clear();
            numFiyat.Value = 0;
            MalzemeGoster();
            
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            txtmalad.Clear();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            MalzemeGoster();
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            mzentity.Id =(int)dataGridView1.CurrentRow.Cells["Id"].Value;
            mzentity.Adi = txtmalad.Text.ToUpper();
            mzentity.Fiyat = (decimal)numFiyat.Value;
            bool sonuc = mzOrm.Guncelle(mzentity);
            if(sonuc)
                MessageBox.Show("Güncelleme Başarılı!");
            else
                MessageBox.Show("Güncelleme Başarısız");
            MalzemeGoster();
            txtmalad.Clear();
            numFiyat.Value = 0;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(dataGridView1.CurrentRow!=null)
            {
                txtmalad.Text = dataGridView1.CurrentRow.Cells["Adi"].Value.ToString();
                
                numFiyat.Value =Convert.ToDecimal(dataGridView1.CurrentRow.Cells["Fiyat"].Value);
            }
        }
    }
}
