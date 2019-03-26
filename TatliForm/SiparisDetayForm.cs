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
    public partial class SiparisDetayForm : Form
    {
        public SiparisDetayForm()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        SiparisORM siparisOrm = new SiparisORM();
        UrunlerORM uorm = new UrunlerORM();
        private void SiparisDetayForm_Load(object sender, EventArgs e)
        {
            comboSip.SelectedValue = 1;
            comboSip.DataSource = siparisOrm.Listele();
            comboSip.DisplayMember = "Id";
            comboSip.ValueMember = "Id";
            //comboSip.SelectedValue = 1;
            listUrun.DataSource = uorm.Listele();
            listUrun.DisplayMember = "Adi";
            listUrun.ValueMember = "Id";
            listUrun.SelectedValue = 1;
            goster();



        }
        void goster()
        {
            
            SqlDataAdapter adp = new SqlDataAdapter();
            SqlCommand cmd = new SqlCommand();
           
                cmd.Connection = Tools.Baglanti;
                cmd.CommandText = "pro_SiparisUrunIcerik";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@SiparisId", (int)comboSip.SelectedValue);
                adp.SelectCommand = cmd;
                DataTable dt = new DataTable();
                adp.Fill(dt);
                
                dataGridView1.DataSource = dt;
                dataGridView1.Columns["Personel"].Visible = false;
                dataGridView1.Columns["SiparisTutari"].Visible = false;
                dataGridView1.Columns["OdemeYapildiMi"].Visible = false;
                dataGridView1.Columns["HazirMi"].Visible = false;
                dataGridView1.Columns["Aktif"].Visible = false;
                dataGridView1.Columns["Id"].Visible = false;
                dataGridView1.Columns["Aktif1"].Visible = false;
                dataGridView1.Columns["Fiyat"].Visible = false;
                dataGridView1.Columns["SiparisId"].Visible = false;
                dataGridView1.Columns["UrunId"].Visible = false;
                dataGridView1.Columns["Id"].Visible = false;
                //dataGridView1.Columns["Aktif2"].Visible = false;
                dataGridView1.Columns["OnaylandiMi"].Visible = false;
            dataGridView1.Columns["Tarih"].Visible = false;
            dataGridView1.Columns["Id1"].Visible = false;











        }
        private void btnguncelle_Click(object sender, EventArgs e)
        {

        }
        SiparisUrun sEntity = new SiparisUrun();
        SiparisUrunORM sORM = new SiparisUrunORM();
        private void btnEkle_Click(object sender, EventArgs e)
        {
            sEntity.SiparisId = (int)comboSip.SelectedValue;
            sEntity.UrunId = (int)listUrun.SelectedValue;
            sEntity.Miktar =Convert.ToDecimal(txtMiktar.Text);
            bool sonuc = sORM.Ekle(sEntity);
            if(sonuc)
                MessageBox.Show("Ürün Eklendi!");
            else
                MessageBox.Show("Ürün Eklenirken Hata Meydana Geldi");
            goster();

        }

        private void comboSip_SelectionChangeCommitted(object sender, EventArgs e)
        {
            goster();
        }
    }
}
