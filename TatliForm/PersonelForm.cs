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
    public partial class PersonelForm : Form
    {
        public PersonelForm()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            AnasayfaForm.pf.Close();
        }
         void personelGoster()
        {
            dataGridView1.DataSource = persOrm.Listele();
            dataGridView1.Columns["Id"].Visible = false;
            dataGridView1.Columns["MedeniDurum"].Visible = false;
            dataGridView1.Columns["EgitimId"].Visible = false;
            dataGridView1.Columns["Aktif"].Visible = false;
        }
        PersonelORM persOrm = new PersonelORM();
        Personel personEntity = new Personel();
        EgitimORM Eorm = new EgitimORM();
        private void PersonelForm_Load(object sender, EventArgs e)
        {
            personelGoster();
            comboEgitim.DataSource = Eorm.Listele();
            comboEgitim.DisplayMember = "Adi";
            comboEgitim.ValueMember = "Id";



            
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            personEntity.Adi = txtAd.Text.ToUpper();
            personEntity.Soyadi = txtsoyad.Text.ToUpper();
            personEntity.Maas =Convert.ToDecimal(numMaas.Value);
            personEntity.Tckn = txtTc.Text;
            personEntity.TelNo = txtTel.Text;
            personEntity.Mail = txtMail.Text;
            personEntity.IsegirisTarih = dateIs.Value;
            personEntity.DogumTarih = dateDogum.Value;
            personEntity.EgitimId =(int)comboEgitim.SelectedValue;
            personEntity.Adres = txtAdres.Text;
            if ((string)comboMedeni.Text == "Evli")
                personEntity.MedeniDurum = true;
            else 
                personEntity.MedeniDurum = false;
          bool sonuc=persOrm.Ekle(personEntity);
            if(sonuc)
                MessageBox.Show("Ekleme İşlemi Başarılı!");
            else
                MessageBox.Show("Ekleme İşlemi Başarısız!");
            personelGoster();



        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(dataGridView1.CurrentRow!=null)
            {
                txtAd.Text = dataGridView1.CurrentRow.Cells["Adi"].Value.ToString();
                txtsoyad.Text = dataGridView1.CurrentRow.Cells["Soyadi"].Value.ToString();
                numMaas.Text = dataGridView1.CurrentRow.Cells["Maas"].Value.ToString();
                txtTc.Text = dataGridView1.CurrentRow.Cells["Tckn"].Value.ToString();
                if (Convert.ToBoolean(dataGridView1.CurrentRow.Cells["MedeniDurum"].Value) == true)
                    comboMedeni.Text = "Evli";
                else
                    comboMedeni.Text = "Bekar";
                dateDogum.Text =dataGridView1.CurrentRow.Cells["DogumTarih"].Value.ToString();
                dateIs.Text = dataGridView1.CurrentRow.Cells["IsegirisTarih"].Value.ToString();
                txtTel.Text= dataGridView1.CurrentRow.Cells["TelNo"].Value.ToString();
                txtMail.Text= dataGridView1.CurrentRow.Cells["Mail"].Value.ToString();
                if (Convert.ToInt32(dataGridView1.CurrentRow.Cells["EgitimId"].Value) == 1)
                {
                    comboEgitim.Text = "Üniversite";
                }
                else if (Convert.ToInt32(dataGridView1.CurrentRow.Cells["EgitimId"].Value) == 2)
                    comboEgitim.Text = "Lise";
                else if (Convert.ToInt32(dataGridView1.CurrentRow.Cells["EgitimId"].Value) == 3)
                    comboEgitim.Text = "Ortaokul";
                else if (Convert.ToInt32(dataGridView1.CurrentRow.Cells["EgitimId"].Value) == 4)
                    comboEgitim.Text = "İlkokul";
                else if (Convert.ToInt32(dataGridView1.CurrentRow.Cells["EgitimId"].Value) == 5)
                    comboEgitim.Text = "Yüksek Lisans";
                else
                    comboEgitim.Text = "Doktora";

                txtAdres.Text = dataGridView1.CurrentRow.Cells["Adres"].Value.ToString();
                
            }

            
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {   
            personelGoster();
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            personEntity.Id =(int)dataGridView1.CurrentRow.Cells["Id"].Value;
            personEntity.Adi = txtAd.Text.ToUpper();
            personEntity.Soyadi = txtsoyad.Text.ToUpper();
            personEntity.Maas = Convert.ToDecimal(numMaas.Value);
            personEntity.Tckn = txtTc.Text;
            personEntity.TelNo = txtTel.Text;
            personEntity.Mail = txtMail.Text;
            personEntity.IsegirisTarih = dateIs.Value;
            personEntity.DogumTarih = dateDogum.Value;
            personEntity.EgitimId = (int)comboEgitim.SelectedValue;
            personEntity.Adres = txtAdres.Text;
            if (Convert.ToString(comboMedeni.Text) == "Evli")
                personEntity.MedeniDurum = true;
            else
                personEntity.MedeniDurum = false;
            bool sonuc = persOrm.Guncelle(personEntity);
            if (sonuc)
                MessageBox.Show("Guncelleme İşlemi Başarılı!");
            else
                MessageBox.Show("Guncelleme İşlemi Başarısız!");
            personelGoster();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            txtAd.Clear();
            txtsoyad.Clear();
            txtAdres.Clear();
            txtTc.Clear();
            txtTel.Clear();
            txtMail.Clear();
            numMaas.Value = 0;

        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = Tools.Ara(txtAd.Text.ToUpper(), txtsoyad.Text.ToUpper(), "Personel");
        }

        private void silToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(dataGridView1.CurrentRow!=null)
            {
                personEntity.Id = (int)dataGridView1.CurrentRow.Cells["Id"].Value;
                personEntity.Adi = txtAd.Text.ToUpper();
                personEntity.Soyadi = txtsoyad.Text.ToUpper();
                personEntity.Maas = Convert.ToDecimal(numMaas.Value);
                personEntity.Tckn = txtTc.Text;
                personEntity.TelNo = txtTel.Text;
                personEntity.Mail = txtMail.Text;
                personEntity.IsegirisTarih = dateIs.Value;
                personEntity.DogumTarih = dateDogum.Value;
                personEntity.EgitimId = (int)comboEgitim.SelectedValue;
                personEntity.Adres = txtAdres.Text;
                if (Convert.ToString(comboMedeni.Text) == "Evli")
                    personEntity.MedeniDurum = true;
                else
                    personEntity.MedeniDurum = false;
                bool sonuc = persOrm.Sil(personEntity);
                if (sonuc)
                    MessageBox.Show("Silme İşlemi Başarılı!");
                else
                    MessageBox.Show("Silme İşlemi Başarısız!");
                personelGoster();
                
                txtAd.Clear();
                txtsoyad.Clear();
                txtAdres.Clear();
                txtTc.Clear();
                txtTel.Clear();
                txtMail.Clear();
                numMaas.Value = 0;

            }
        }
    }
}
