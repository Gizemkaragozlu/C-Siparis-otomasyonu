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
    public partial class FRezervasyon : Form
    {
        public FRezervasyon()
        {
            InitializeComponent();
        }

        private void MusteriListele(int musteriid)
        {
            try
            {
                FLogin flogin = new FLogin();
                SqlConnection baglanti = new SqlConnection(flogin.str);
                SqlCommand cmd = new SqlCommand();
                if (baglanti.State == ConnectionState.Closed)
                    baglanti.Open();

                cmd.Connection = baglanti;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "MusteriListele";

                cmd.Parameters.AddWithValue("@musteriid", musteriid);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                
                cbMusteri.DataSource = dt;
                cbMusteri.ValueMember ="id";
                cbMusteri.DisplayMember = "adsoyad";
             

                

                cmd.Dispose();
                baglanti.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }

        }



        private void FRezervasyon_Load(object sender, EventArgs e)
        {
            dtpRezervasyonTarih.Format = DateTimePickerFormat.Custom;
            dtpRezervasyonTarih.CustomFormat = "dd/MM/yyyy hh:mm:ss";
            MusteriListele(-1);

        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
           
            if(dtpRezervasyonTarih.Value < DateTime.Today)
            {
                MessageBox.Show("Geçmiş tarihli rezervasyon yapılamaz");
            }
            // burada kaldık
            if (txtKiminAdina.Text == "" || txtTel.Text == "    ." || nudKisiSayisi.Text == "" )
            {
                MessageBox.Show("Tüm Kırmızı alanları doldurmanız gerekmektedir.", "Uyarı",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
           // MusteriEkle(txtMusteriAd.Text, txtTel.Text, txtEPosta.Text, txtAdresBaslik.Text, txtAdres.Text);
           // temizle();
        }
    }
}
