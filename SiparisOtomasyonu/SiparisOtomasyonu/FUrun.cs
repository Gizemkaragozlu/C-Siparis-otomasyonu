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
    public partial class FUrun : Form
    {
        public FUrun()
        {
            InitializeComponent();
        }
        int s_urunid=-1;

        private void temizle()
        {
            txtAciklama.Text = "";
            txtBarkod.Clear();
            txtFiyat.Clear();
            txtUrunAdi.Clear();

            s_urunid = -1;

                
        }
        private void UrunSil(int UrunID)
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
                cmd.CommandText = "UrunSil";
                cmd.Parameters.AddWithValue("@UrunID", UrunID);

                int i = cmd.ExecuteNonQuery();
                if (i == 0)
                {
                    MessageBox.Show("Silme Başarısız.");
                }
                else if (i > 0)
                {
                    MessageBox.Show("Silme Başarılı.");

                }

                cmd.Dispose();
                baglanti.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }

        }

        private void UrunEkle(string UrunAd, string Barkod, double UrunFiyat, string Aciklama)
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
                cmd.CommandText = "UrunKaydet";

                cmd.Parameters.AddWithValue("@UrunAd", UrunAd);
                cmd.Parameters.AddWithValue("@Barkod", Barkod);
                cmd.Parameters.AddWithValue("@Fiyat", UrunFiyat);
                cmd.Parameters.AddWithValue("@Aciklama", Aciklama);

                int i = cmd.ExecuteNonQuery();
                if (i == 0)
                {
                    MessageBox.Show("Kayıt Başarısız.");
                }
                else if(i>0)
                {
                    MessageBox.Show("Kayıt Başarılı.");

                }

                cmd.Dispose();
                baglanti.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }

        }

        private void UrunGuncelle(int UrunId ,string UrunAd, string Barkod, double UrunFiyat, string Aciklama)
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
                cmd.CommandText = "UrunGuncelle";

                cmd.Parameters.AddWithValue("@UrunId", UrunId);
                cmd.Parameters.AddWithValue("@UrunAd", UrunAd);
                cmd.Parameters.AddWithValue("@Barkod", Barkod);
                cmd.Parameters.AddWithValue("@Fiyat", UrunFiyat);
                cmd.Parameters.AddWithValue("@Aciklama", Aciklama);

                int i = cmd.ExecuteNonQuery();
                if (i == 0)
                {
                    MessageBox.Show("Kayıt Başarısız.");
                }
                else if (i > 0)
                {
                    MessageBox.Show("Kayıt Başarılı.");

                }

                cmd.Dispose();
                baglanti.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }

        }

        private void UrunListele(int urunid)
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
                    cmd.CommandText = "UrunListele";

                    cmd.Parameters.AddWithValue("@urunid", urunid);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    urunid = Convert.ToInt16(dt.Rows[i]["id"].ToString());
                    txtUrunAdi.Text = dt.Rows[i]["ad"].ToString();
                    txtBarkod.Text = dt.Rows[i]["barkod"].ToString();
                    double a=Convert.ToDouble( dt.Rows[i]["fiyat"].ToString());
                   // txtFiyat.Text =Convert.ToString(Convert.ToDouble(dt.Rows[i]["fiyat"].ToString()));                   
                    txtFiyat.Text =a.ToString();                   
                    txtAciklama.Text = dt.Rows[i]["aciklama"].ToString();
                }

                cmd.Dispose();
                baglanti.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }

        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {


            if (txtUrunAdi.Text == "" || txtFiyat.Text == "" || txtBarkod.Text == "" )                   
            {
                MessageBox.Show("Tüm Kırmızı alanları doldurmanız gerekmektedir.", "Uyarı",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
                UrunEkle(txtUrunAdi.Text,txtBarkod.Text,Convert.ToDouble(txtFiyat.Text),
                txtAciklama.Text );
                temizle();
        }

        private void txtFiyat_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void btnYeni_Click(object sender, EventArgs e)
        {
            temizle();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FUrunAra fua = new FUrunAra();
            fua.ShowDialog();
            s_urunid = fua.secilen_urun_id;
            UrunListele(fua.secilen_urun_id);
            // MessageBox.Show("seçili ürün id:" + fua.secilen_urun_id);
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (s_urunid > 0)
            {
                if (txtUrunAdi.Text == "" || txtFiyat.Text == "" || txtBarkod.Text == "")
                {
                    MessageBox.Show("Tüm Kırmızı alanları doldurmanız gerekmektedir.", "Uyarı",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                UrunGuncelle(s_urunid, txtUrunAdi.Text, txtBarkod.Text, Convert.ToDouble(txtFiyat.Text), txtAciklama.Text);
                temizle();
            }
            else
            {
                MessageBox.Show("Öncelikle Güncellenecek veri seçmelisiniz");
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (s_urunid > 0)
            {
                DialogResult cevap = MessageBox.Show("Silmek istediğinizden emin misiniz?",
                    "Onay", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question); 
                if (cevap == DialogResult.Yes)
                {
                    UrunSil(s_urunid);
                    temizle();
                }
                else
                    MessageBox.Show("İşlem iptal edildi");
            }
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
