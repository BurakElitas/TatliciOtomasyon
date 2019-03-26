using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TatliForm
{
    public partial class AnasayfaForm : Form
    {
        public AnasayfaForm()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
       public static MüsteriForm musterifrm = new MüsteriForm();
        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
           
            

        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
           if (musterifrm.IsDisposed)
            {

             musterifrm = new MüsteriForm();
            }
            musterifrm.Show();

        }
       public static SiparisForm SiparisForm = new SiparisForm();
        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {
            btnsip.Visible = true;
            btndetay.Visible = true;
        }
        
        private void AnasayfaForm_Load(object sender, EventArgs e)
        {
            kullanici.Text = GirisForm.kullaniciadi;
            if(GirisForm.tip==2)
            {
                btnSatin.Enabled = false;
                btnMalzeme.Enabled = false;
                btnStok.Enabled = false;
                btnPersonel.Enabled = false;
                btnKullanicilar.Enabled = false;
                btnFirmalar.Enabled = false;
                btnTedarik.Enabled = false;
            }
            else if(GirisForm.tip==3)
            {
                btnMusteri.Enabled = false;
                btnSatin.Enabled = false;
                btnPersonel.Enabled = false;
                btnFirmalar.Enabled = false;
                btnTedarik.Enabled = false;
                btnStok.Enabled = false;
                btnKullanicilar.Enabled = false;
                btnSiparis.Enabled = false;
            }
            else if(GirisForm.tip==4)
            {
                btnMusteri.Enabled = false;
                btnPersonel.Enabled = false;
                btnKullanicilar.Enabled = false;
                btnFirmalar.Enabled = false;
                btnUretim.Enabled = false;
                btnSiparis.Enabled = false;


            }
        }
        
        private void btnCikis_Click(object sender, EventArgs e)
        {
            Application.Exit();

           

        }
        public static UrunlerForm uform = new UrunlerForm();
        private void btnUrun_Click(object sender, EventArgs e)
        {
            btnUrunekle.Visible = true;
            btnUrunoz.Visible = true;
        }
       public static PersonelForm pf = new PersonelForm();

        private void btnPersonel_Click(object sender, EventArgs e)
        {
            if (pf.IsDisposed)
                pf = new PersonelForm();
            pf.Show();
        }
        KullaniciForm kform = new KullaniciForm();
        private void btnKullanicilar_Click(object sender, EventArgs e)
        {
            if (kform.IsDisposed)
                kform = new KullaniciForm();
            kform.Show();

        }
        MalzemeForm mzform = new MalzemeForm();
        private void btnMalzeme_Click(object sender, EventArgs e)
        {
            if (mzform.IsDisposed)
                mzform = new MalzemeForm();
            mzform.Show();
        }
       public static FirmaForm firmafrm = new FirmaForm();

        private void btnFirmalar_Click(object sender, EventArgs e)
        {
            if (firmafrm.IsDisposed)
                firmafrm = new FirmaForm();
            firmafrm.Show();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void bunifuFlatButton2_Click_1(object sender, EventArgs e)
        {

        }

        private void btnTedarik_MouseHover(object sender, EventArgs e)
        {
            btntedarikekle.Visible = true;
            btntedariközel.Visible = true;
        }

        private void btnTedarik_Click(object sender, EventArgs e)
        {
            btntedarikekle.Visible = true;
            btntedariközel.Visible = true;

        }

        private void btntedarikekle_MouseLeave(object sender, EventArgs e)
        {
            //btntedarikekle.Visible = false;

        }

        private void btntedariközel_MouseLeave(object sender, EventArgs e)
        {
           
        }

        private void btntedarikekle_Leave(object sender, EventArgs e)
        {
           
        }

        private void AnasayfaForm_MouseHover(object sender, EventArgs e)
        {
            btntedarikekle.Visible = false;
            btntedariközel.Visible = false;
            btnUrunoz.Visible = false;
            btnUrunekle.Visible = false;
            btnsatinözellik.Visible = false;
            btnsatinlamaekle.Visible = false;
            btnsip.Visible = false;
            btndetay.Visible = false;
        }
    
        private void btntedariközel_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox6_MouseHover(object sender, EventArgs e)
        {
            btntedarikekle.Visible = false;
            btntedariközel.Visible = false;
            btnUrunoz.Visible = false;
            btnUrunekle.Visible = false;
            btnsatinözellik.Visible = false;
            btnsatinlamaekle.Visible = false;
            btnsip.Visible = false;
            btndetay.Visible = false;
        
        }

        private void panel1_MouseHover(object sender, EventArgs e)
        {
            btntedarikekle.Visible = false;
            btntedariközel.Visible = false;
            btnUrunoz.Visible = false;
            btnUrunekle.Visible = false;
            btnsatinözellik.Visible = false;
            btnsatinlamaekle.Visible = false;
            btnsip.Visible = false;
            btndetay.Visible = false;
        }

        private void btnUrunekle_Click(object sender, EventArgs e)
        {
            if (uform.IsDisposed)
                uform = new UrunlerForm();
            uform.Show();
        }

        private void btnUrun_MouseHover(object sender, EventArgs e)
        {
            btnUrunekle.Visible = true;
            btnUrunoz.Visible = true;
        }
        UrunOzellikForm urunozform = new UrunOzellikForm();
        private void btnUrunoz_Click(object sender, EventArgs e)
        {
            if (urunozform.IsDisposed)
                urunozform = new UrunOzellikForm();
            urunozform.Show();

        }
        TedarikciForm tdform = new TedarikciForm();
        private void btntedarikekle_Click(object sender, EventArgs e)
        {
            if (tdform.IsDisposed)
                tdform = new TedarikciForm();
            tdform.Show();
        }
        TedarikciOzellikForm tedarikOzellik = new TedarikciOzellikForm();
        private void btntedariközel_Click_1(object sender, EventArgs e)
        {
            if (tedarikOzellik.IsDisposed)
                tedarikOzellik = new TedarikciOzellikForm();
            tedarikOzellik.Show();

        }
        SatinAlmaForm stform = new SatinAlmaForm();
        private void btnSatin_Click(object sender, EventArgs e)
        {
           

            btnsatinlamaekle.Visible = true;
            btnsatinözellik.Visible = true;

        }

        private void btnsatinlamaekle_Click(object sender, EventArgs e)
        {
            if (stform.IsDisposed)
                stform = new SatinAlmaForm();
            stform.Show();
        }

        private void btnSatin_MouseHover(object sender, EventArgs e)
        {
            btnsatinlamaekle.Visible = true;
            btnsatinözellik.Visible = true;
        }
        SatınAlmaÖzellikleriForm stoz = new SatınAlmaÖzellikleriForm();
        private void btnsatinözellik_Click(object sender, EventArgs e)
        {
            if (stoz.IsDisposed)
                stoz = new SatınAlmaÖzellikleriForm();
            stoz.Show();

        }

        private void btnsip_Click(object sender, EventArgs e)
        {
            if (SiparisForm.IsDisposed)
                SiparisForm = new SiparisForm();
            SiparisForm.Show();
        }
        SiparisDetayForm spdeta = new SiparisDetayForm();
        private void btndetay_Click(object sender, EventArgs e)
        {
            if (spdeta.IsDisposed)
                spdeta = new SiparisDetayForm();
            spdeta.Show();

        }
        UretimForm uretimfrm = new UretimForm();
        private void btnUretim_Click(object sender, EventArgs e)
        {
            if (uretimfrm.IsDisposed)
                uretimfrm = new UretimForm();
            uretimfrm.Show();
        }
    }
}
