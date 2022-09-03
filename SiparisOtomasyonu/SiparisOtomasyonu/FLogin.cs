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

namespace SiparisOtomasyonu
{
    public partial class FLogin : Form
    {
        public string str = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDBFilename=
        |DataDirectory|\dbSiparis.mdf;Integrated Security=True";

        public FLogin()
        {
            InitializeComponent();
        }
        public string durum;
        public int aktif_kullanici_yetki_idsi;
        private void btnIptal_Click(object sender, EventArgs e)
        {
            this.Close();
            durum = "basarisiz";
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(str);
            if (conn.State == ConnectionState.Closed)
                conn.Open();

            SqlCommand sorgula = new SqlCommand("Select * from personel where kullanici_ad ='" +
                txtKullaniciAdi.Text + "' and sifre = '" + txtSifre.Text + "'",conn);
            SqlDataReader dr = sorgula.ExecuteReader();

            
            if (dr.Read())
            {
                durum = "basarili";
                aktif_kullanici_yetki_idsi=Convert.ToInt32(dr["yetki_id"].ToString());
                this.Close();
            }
            else
            {
                MessageBox.Show("Hatalı giriş yaptınız");
            }


        }

        private void txtKullaniciAdi_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == 13)
            {
                txtSifre.Focus();
            }
        }

        private void txtSifre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
                btnGiris_Click(sender, e);
        }
    }
}
