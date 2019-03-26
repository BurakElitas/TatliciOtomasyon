using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TatliOtomasyon.ORM.Facade;

namespace TatliForm
{
    public partial class UretimForm : Form
    {
        public UretimForm()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        SiparisORM sorm = new SiparisORM();
        private void UretimForm_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = sorm.Listele();
        }
    }
}
