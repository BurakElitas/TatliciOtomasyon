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
    public partial class TedarikciOzellikForm : Form
    {
        public TedarikciOzellikForm()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        TedarikciORM tOrm = new TedarikciORM();
        MalzemeORM mzOrm = new MalzemeORM();
        private void groupBox1_Enter(object sender, EventArgs e)
        {
            
        }
        TedarikciMalzeme tMEntity = new TedarikciMalzeme();
        TedarikciMalzemeORM tmORM = new TedarikciMalzemeORM();

        void goster()
        {
            SqlDataAdapter adp = new SqlDataAdapter();
            SqlCommand cmd = new SqlCommand();
            try
            {
                cmd.Connection = Tools.Baglanti;
                cmd.CommandText = "pro_TedarikciMalzeme_Icerik";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@TedarikciId", (int)comboTedarik.SelectedValue);
                adp.SelectCommand = cmd;
                DataTable dt = new DataTable();
                adp.Fill(dt);
                dataGridView1.DataSource = dt;
                dataGridView1.Columns["Id"].Visible = false;
                dataGridView1.Columns["Id1"].Visible = false;
                dataGridView1.Columns["Adi"].Visible = false;
                //dataGridView1.Columns["Adi1"].Visible = false;
                dataGridView1.Columns["Adres"].Visible = false;
                dataGridView1.Columns["TelNo"].Visible = false;
                dataGridView1.Columns["TedarikciId"].Visible = false;
                dataGridView1.Columns["MalzemeId"].Visible = false;
                dataGridView1.Columns["Fiyat"].Visible = false;
                dataGridView1.Columns["Aktif"].Visible = false;
                dataGridView1.Columns["Mail"].Visible = false;



            }
            catch (Exception)
            {
                MessageBox.Show("Hata Meydana Geldi");
            }
        }
        private void TedarikciOzellikForm_Load(object sender, EventArgs e)
        {
            comboTedarik.SelectedValue = 1;
            comboTedarik.DataSource = tOrm.Listele();
            comboTedarik.DisplayMember = "Adi";
            comboTedarik.ValueMember = "Id";
            listMalzeme.DataSource = mzOrm.Listele();
            listMalzeme.ValueMember = "Id";
            listMalzeme.DisplayMember = "Adi";
            goster();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            tMEntity.TedarikciId =(int)comboTedarik.SelectedValue;
            tMEntity.MalzemeId = (int)listMalzeme.SelectedValue;
            bool sonuc=tmORM.Ekle(tMEntity);
            if(sonuc)
                MessageBox.Show("Ekleme İşlemi Başarılı!");
            else
                MessageBox.Show("Bu Malzeme Daha Önce Eklenmiş Olabilir Lütfen Kontrol Ediniz!");
            goster();
        }

        private void comboTedarik_SelectionChangeCommitted(object sender, EventArgs e)
        {
            goster();

        }

        private void silToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(dataGridView1.CurrentRow!=null)
            {
                tMEntity.TedarikciId = (int)comboTedarik.SelectedValue;
                tMEntity.MalzemeId =(int)dataGridView1.CurrentRow.Cells["MalzemeId"].Value;
                bool sonuc = tmORM.Sil(tMEntity);
                if (sonuc)
                    MessageBox.Show("Kayıt Başarı İle Silinmiştir.");
                else
                    MessageBox.Show("Kayıt Silinmedi!");
                goster();


            }
        }

        private void comboTedarik_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
