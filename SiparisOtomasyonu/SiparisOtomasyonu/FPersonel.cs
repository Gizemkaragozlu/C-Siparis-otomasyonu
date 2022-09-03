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
    public partial class FPersonel : Form
    {
        public FPersonel()
        {
            InitializeComponent();
        }
       
    private void YetkiListele(int yetki_id)
        {
            try
            {
                FLogin flogin = new FLogin();
                SqlConnection baglanti = new SqlConnection(flogin.str);
                if (baglanti.State == ConnectionState.Closed) baglanti.Open();

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = baglanti;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "YetkiListele";
                cmd.Parameters.AddWithValue("@yetki_id", yetki_id);
                SqlDataAdapter da = new SqlDataAdapter(cmd);

                System.Data.DataTable dt = new System.Data.DataTable();
                da.Fill(dt);
                cbYetki.DataSource = dt;
                cbYetki.DisplayMember = "aciklama";
                cbYetki.ValueMember = "id";
                cbYetki.SelectedIndex = -1;
            }
            catch (Exception e)
            {
                MessageBox.Show("Hata oluştu. Hata kodu:" + e.ToString(), "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public int s_personelid;
        private void temizle()
        {
            txtAdSoyad.Text = "";
            txtKimlikNo.Clear();
            txtKulAd.Clear();
            txtSifre.Clear();
            txtTel.Clear();
            txtAdres.Clear();
            cbYetki.SelectedIndex = -1;

            s_personelid = -1;
        }
        private void PersonelEkle(string AdSoyad, string KimlikNo, string Tel, string KulAd, string Sifre, int YetkiId, string Adres)
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
                cmd.CommandText = "PersonelKaydet";

                cmd.Parameters.AddWithValue("@AdSoyad", AdSoyad);
                cmd.Parameters.AddWithValue("@KimlikNo", KimlikNo);
                cmd.Parameters.AddWithValue("@Tel", Tel);
                cmd.Parameters.AddWithValue("@KulAd", KulAd);
                cmd.Parameters.AddWithValue("@Sifre", Sifre);
                cmd.Parameters.AddWithValue("@YetkiId", YetkiId);
                cmd.Parameters.AddWithValue("@Adres", Adres);

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
        private void PersonelListele(int personelid)
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
                cmd.CommandText = "PersonelListele";

                cmd.Parameters.AddWithValue("@personelid", personelid);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    txtAdSoyad.Text = dt.Rows[i]["adsoyad"].ToString();
                    txtKimlikNo.Text = dt.Rows[i]["kimlik_no"].ToString();

                    cbYetki.SelectedValue = Convert.ToInt32(dt.Rows[i]["yetki_id"].ToString());
                           
                    txtTel.Text = dt.Rows[i]["tel"].ToString();
                    txtAdres.Text = dt.Rows[i]["adres"].ToString();
                    txtKulAd.Text = dt.Rows[i]["kullanici_ad"].ToString();
                    txtSifre.Text = dt.Rows[i]["sifre"].ToString();
                }

                cmd.Dispose();
                baglanti.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }

        }

        private void FPersonel_Load(object sender, EventArgs e)
        {
            YetkiListele(-1);
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {            
            if (txtAdSoyad.Text == "" || txtKimlikNo.Text == "" || txtTel.Text == "(   )    -" || txtSifre.Text == "" || txtKulAd.Text == "" || cbYetki.SelectedIndex == -1)
            {
                MessageBox.Show("Tüm Kırmızı alanları doldurmanız gerekmektedir.", "Uyarı",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            PersonelEkle(txtAdSoyad.Text, txtKimlikNo.Text,txtTel.Text, txtKulAd.Text,txtSifre.Text, Convert.ToInt32(cbYetki.SelectedValue.ToString()),
            txtAdres.Text);
            temizle();
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            FPersonelAra fpa = new FPersonelAra();
            fpa.ShowDialog();
            s_personelid = fpa.secilen_personel_id;
            PersonelListele(fpa.secilen_personel_id);


        }

        private void chkSifreGoster_CheckedChanged(object sender, EventArgs e)
        {
            if (chkSifreGoster.Checked==true)
                txtSifre.PasswordChar = '\0';
            else
                txtSifre.PasswordChar = '*';

        }

        private void txtSifre_MouseUp(object sender, MouseEventArgs e)
        {
           
        }
    }
}
