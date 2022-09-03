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
    public partial class FSiparis : Form
    {
        public FSiparis()
        {
            InitializeComponent();
        }

        private void FSiparis_Load(object sender, EventArgs e)
        {/*
            int j = 0;
            for (int i = 40; i < 791; i=i+170)
            {
                j++;
                Button btn = new Button();
         
                btn.Location = new System.Drawing.Point(i, 70);
                btn.Size  = new Size(130,100);
                btn.Text = "Masa"+j;

                this.Controls.Add(btn);
            }
            for (int i = 40; i < 791; i = i + 170)
            {
                j++;
                Button btn = new Button();

                btn.Location = new System.Drawing.Point(i, 210);
                btn.Size = new Size(130, 100);
                btn.Text = "Masa" + j;

                this.Controls.Add(btn);
            }
            */


        }
       
        private void btnMasa1_Click(object sender, EventArgs e)
        {            
            FSiparisDetay fsd = new FSiparisDetay();
            fsd.secilen_masa = "Masa 1";
            fsd.secilen_masa_id = 1;
            fsd.ShowDialog();
        }

        private void btnMasa2_Click(object sender, EventArgs e)
        {
            FSiparisDetay fsd = new FSiparisDetay();
            fsd.secilen_masa = "Masa 2";
            fsd.secilen_masa_id = 2;
            fsd.ShowDialog();
        }

        private void btnMasa3_Click(object sender, EventArgs e)
        {
            FSiparisDetay fsd = new FSiparisDetay();
            fsd.secilen_masa = "Masa 3";
            fsd.secilen_masa_id = 3;
            fsd.ShowDialog();
        }

        private void btnMasa4_Click(object sender, EventArgs e)
        {
            FSiparisDetay fsd = new FSiparisDetay();
            fsd.secilen_masa = "Masa 4";
            fsd.secilen_masa_id = 4;
            fsd.ShowDialog();
        }

        private void btnMasa5_Click(object sender, EventArgs e)
        {
            FSiparisDetay fsd = new FSiparisDetay();
            fsd.secilen_masa = "Masa 5";
            fsd.secilen_masa_id = 5;
            fsd.ShowDialog();
        }

        private void btnMasa6_Click(object sender, EventArgs e)
        {
            FSiparisDetay fsd = new FSiparisDetay();
            fsd.secilen_masa = "Masa 6";
            fsd.secilen_masa_id = 6;
            fsd.ShowDialog();
        }

        private void btnMasa7_Click(object sender, EventArgs e)
        {
            FSiparisDetay fsd = new FSiparisDetay();
            fsd.secilen_masa = "Masa 7";
            fsd.secilen_masa_id = 7;
            fsd.ShowDialog();
        }

        private void btnMasa8_Click(object sender, EventArgs e)
        {
            FSiparisDetay fsd = new FSiparisDetay();
            fsd.secilen_masa = "Masa 8";
            fsd.secilen_masa_id = 8;
            fsd.ShowDialog();
        }

        private void btnMasa9_Click(object sender, EventArgs e)
        {
            FSiparisDetay fsd = new FSiparisDetay();
            fsd.secilen_masa = "Masa 9";
            fsd.secilen_masa_id = 9;
            fsd.ShowDialog();
        }

        private void btnMasa10_Click(object sender, EventArgs e)
        {
            FSiparisDetay fsd = new FSiparisDetay();
            fsd.secilen_masa = "Masa 10";
            fsd.secilen_masa_id = 10;
            fsd.ShowDialog();
        }
    }
}
