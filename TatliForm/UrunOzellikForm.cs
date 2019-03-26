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
    public partial class UrunOzellikForm : Form
    {
        public UrunOzellikForm()
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
        MalzemeORM mz = new MalzemeORM();
        UrunlerORM u = new UrunlerORM();
        MalzemeUrunORM malzemeurun = new MalzemeUrunORM();
        Malzeme_Urun mzurun = new Malzeme_Urun();

        private void UrunOzellikForm_Load(object sender, EventArgs e)
        {
            
            listMalzeme.SelectedItem = 1;
            comboUrun.DataSource = u.Listele();
            comboUrun.DisplayMember = "Adi";
            comboUrun.ValueMember = "Id";
            listMalzeme.DataSource = mz.Listele();
            listMalzeme.ValueMember = "Id";
            listMalzeme.DisplayMember = "Adi";
            icerikgoster();





        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            mzurun.UrunId = (int)comboUrun.SelectedValue;
            mzurun.MalzemeId = (int)listMalzeme.SelectedValue;
            mzurun.Miktar = Convert.ToDecimal(numMiktar.Value);
            bool sonuc = malzemeurun.Ekle(mzurun);
            if (sonuc)
                MessageBox.Show("Ekleme İşlemi Başarılı!");
            else
                MessageBox.Show("Malzeme Daha Önceden Eklenmiş Olabilir Lütfen Kontrol Ediniz");
            numMiktar.Value = 0;
            icerikgoster();
        }
        
        
        private void listMalzeme_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }
        private void listMalzeme_SelectedValueChanged(object sender, EventArgs e)
        {

           

        }

        private void comboUrun_SelectionChangeCommitted(object sender, EventArgs e)
        {
            icerikgoster();

        }

        void icerikgoster()
        {
            int urunid = (int)comboUrun.SelectedValue;
            SqlCommand cmd = new SqlCommand();
            SqlDataAdapter adp = new SqlDataAdapter();
            try
            {
                cmd.Connection = Tools.Baglanti;
                cmd.CommandText = "pro_Urun_Icerik";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@UrunId", urunid);
                adp.SelectCommand = cmd;
                DataTable dt = new DataTable();
                adp.Fill(dt);
                dataGridView1.DataSource = dt;
                dataGridView1.Columns["Id"].Visible = false;
                dataGridView1.Columns["Id1"].Visible = false;
                dataGridView1.Columns["Adi"].Visible = false;
                dataGridView1.Columns["Fiyat"].Visible = false;
                dataGridView1.Columns["Aktif"].Visible = false;
                dataGridView1.Columns["UrunId"].Visible = false;
                dataGridView1.Columns["MalzemeId"].Visible = false;
                dataGridView1.Columns["Fiyat1"].Visible = false;
            }
            catch
            {
                MessageBox.Show("Hata oluştu");
            }
        }
        private void btnArama_Click(object sender, EventArgs e)
        {

           
            icerikgoster();


        }

        private void comboUrun_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(dataGridView1.CurrentRow!=null)
            {
                numMiktar.Value =Convert.ToDecimal(dataGridView1.CurrentRow.Cells["Miktar"].Value);


            }
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            if(dataGridView1.CurrentRow!=null)
            {
                mzurun.UrunId =(int) dataGridView1.CurrentRow.Cells["Id"].Value;
                mzurun.MalzemeId = (int)dataGridView1.CurrentRow.Cells["Id1"].Value;
                mzurun.Miktar = Convert.ToDecimal(numMiktar.Value);
               bool sonuc=malzemeurun.Guncelle(mzurun);
                if(sonuc)
                    MessageBox.Show("Güncelleme İşlemi Başarılı!");
                else
                    MessageBox.Show("Güncelleme Başarısız!");
                icerikgoster();
                numMiktar.Value = 0;

            }
        }

        private void silToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(dataGridView1.CurrentRow!=null)
            {
                mzurun.UrunId = (int)dataGridView1.CurrentRow.Cells["UrunId"].Value;
                mzurun.MalzemeId = (int)dataGridView1.CurrentRow.Cells["MalzemeId"].Value;
                mzurun.Miktar = Convert.ToDecimal(dataGridView1.CurrentRow.Cells["Miktar"].Value);
               bool sonuc= malzemeurun.Sil(mzurun);
                if(sonuc)
                    MessageBox.Show("Kayıt Silinmiştir!");
                else
                    MessageBox.Show("Kayıt Silinirken Hata Oluştu!");
                icerikgoster();

            }
        }
    }
}
