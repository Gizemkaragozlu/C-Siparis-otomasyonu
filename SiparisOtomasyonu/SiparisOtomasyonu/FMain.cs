using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SiparisOtomasyonu
{
    public partial class FMain : Form
    {
        public FMain()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
       int aktif_yetki_id;
        private void FMain_Load(object sender, EventArgs e)
        {
            FLogin flogin = new FLogin();
            flogin.ShowDialog();

            aktif_yetki_id = flogin.aktif_kullanici_yetki_idsi;
            if(flogin.durum != "basarili")
            {
                this.Close();
            }
            
        }

        private void btnUrun_Click(object sender, EventArgs e)
        {
            FUrun furun = new FUrun();
            furun.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FMusteri fm = new FMusteri();
            fm.ShowDialog();

        }

        private void btnRezervasyon_Click(object sender, EventArgs e)
        {
            FRezervasyon fr = new FRezervasyon();
            fr.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            FSiparis fs = new FSiparis();
            fs.ShowDialog();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (aktif_yetki_id == 5)
            {
                FPersonel Fp = new FPersonel();
                Fp.ShowDialog();
            }
            else
                MessageBox.Show("Bu sekmeyi sadece yöneticiler erişebilir.");
        }
    }
}
