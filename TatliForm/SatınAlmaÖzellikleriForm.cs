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
    public partial class SatınAlmaÖzellikleriForm : Form
    {
        public SatınAlmaÖzellikleriForm()
        {
            InitializeComponent();
        }
        
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        SatinAlmaORM stORM = new SatinAlmaORM();
        MalzemeORM mzORM = new MalzemeORM();
        SatinAlmaMalzemeORM stmORM = new SatinAlmaMalzemeORM();
        SatınAlmaMalzeme stEntity = new SatınAlmaMalzeme();
        TedarikciORM tdOrm = new TedarikciORM();
        private void SatınAlmaÖzellikleriForm_Load(object sender, EventArgs e)
        {
            comboTedarik.DataSource = tdOrm.Listele();
            comboTedarik.DisplayMember = "Adi";
            comboTedarik.ValueMember = "Id";
            comboTedarik.SelectedValue = 1;
          
            comboSatin.DataSource = stORM.Listele();
            comboSatin.DisplayMember = "Id";
            comboSatin.ValueMember = "Id";
            comboSatin.SelectedValue = 1;
            MalzemeListele();
            
            
            //dataGridView1.DataSource = stmORM.Listele();
            listele();
            
        }
        void MalzemeListele()
        {
            SqlDataAdapter adp = new SqlDataAdapter();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = Tools.Baglanti;
            cmd.CommandText = "pro_Malzeme_Listele2";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("TedarikciId", comboTedarik.SelectedValue);
            adp.SelectCommand = cmd;
            DataTable dt = new DataTable();
            adp.Fill(dt);
            listMalzeme.DataSource = dt;
            listMalzeme.DisplayMember = "Adi1";
            listMalzeme.ValueMember = "Id1";

        }
        void listele()
        {
            SqlDataAdapter adp = new SqlDataAdapter();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = Tools.Baglanti;
            cmd.CommandText= "pro_SatinAlmaMalzeme_Listele";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("SatınAlmaId", comboSatin.SelectedValue);
            adp.SelectCommand = cmd;
            DataTable dt = new DataTable();
            adp.Fill(dt);
            dataGridView1.DataSource = dt;
            dataGridView1.Columns["Id"].Visible = false;
            dataGridView1.Columns["Fiyat"].Visible = false;
            dataGridView1.Columns["Tarih"].Visible = false;
            dataGridView1.Columns["Ucret"].Visible = false;
            dataGridView1.Columns["Aciklama"].Visible = false;
            dataGridView1.Columns["Aktif"].Visible = false;
            dataGridView1.Columns["Id1"].Visible = false;
            dataGridView1.Columns["SatınAlmaId"].Visible = false;
            dataGridView1.Columns["MalzemeId"].Visible = false;


        }

        private void comboSatin_SelectionChangeCommitted(object sender, EventArgs e)
        {
            listele();
        }
        void temizle()
        {
            txtMiktar.Clear();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            stEntity.SatınAlmaId = (int)comboSatin.SelectedValue;
            stEntity.MalzemeId = (int)listMalzeme.SelectedValue;
            stEntity.Miktar = Convert.ToDecimal(txtMiktar.Text);
            bool sonuc = stmORM.Ekle(stEntity);
            if(sonuc)
                MessageBox.Show("Malzeme Eklendi!");
            else
                MessageBox.Show("Malzeme Eklenirken Hata Oluştu");
            listele();
            temizle();
        }

        private void comboTedarik_SelectionChangeCommitted(object sender, EventArgs e)
        {
            MalzemeListele();
        }

        private void comboSatin_SelectedValueChanged(object sender, EventArgs e)
        {
           
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMiktar.Text = dataGridView1.CurrentRow.Cells["Miktar"].Value.ToString();
            //comboSatin.Text = dataGridView1.CurrentRow.Cells["Adi1"].Value.ToString();
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            if(dataGridView1.CurrentRow!=null)
            {
                stEntity.SatınAlmaId = (int)dataGridView1.CurrentRow.Cells["Id"].Value;
                stEntity.MalzemeId = (int)dataGridView1.CurrentRow.Cells["MalzemeId"].Value;
                stEntity.Miktar = Convert.ToDecimal(txtMiktar.Text);
                bool sonuc = stmORM.Guncelle(stEntity);
                if(sonuc)
                    MessageBox.Show("Guncelleme Başarılı!");
                else
                    MessageBox.Show("Güncelleme Başarısız!");
                temizle();
                listele();
            }
        }

        private void silToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(dataGridView1.CurrentRow!=null)
            {
                stEntity.SatınAlmaId = (int)dataGridView1.CurrentRow.Cells["Id"].Value;
                stEntity.MalzemeId = (int)dataGridView1.CurrentRow.Cells["MalzemeId"].Value;
                stEntity.Miktar = Convert.ToDecimal(txtMiktar.Text);
                bool sonuc = stmORM.Sil(stEntity);
                if (sonuc)
                    MessageBox.Show("Silme İşlemi Başarılı!");
                else
                    MessageBox.Show("Silme İşlemi Başarısız!");
                temizle();
                listele();
            }
        }
    }
}
