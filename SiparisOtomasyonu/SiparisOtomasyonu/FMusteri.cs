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
    public partial class FMusteri : Form
    {
        public FMusteri()
        {
            InitializeComponent();
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        int s_musteriid;
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

                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    txtMusteriAd.Text = dt.Rows[i]["adsoyad"].ToString();
                    txtTel.Text = dt.Rows[i]["tel"].ToString();
                    txtEPosta.Text = dt.Rows[i]["eposta"].ToString();                   
                }

                cmd.Dispose();
                baglanti.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }

        }
        private void MusteriAdresListele(int musteriid)
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
                cmd.CommandText = "MusteriAdresListele";

                cmd.Parameters.AddWithValue("@musteriid", musteriid);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvMusteriAdres.DataSource = dt;
                dgvMusteriAdres.ClearSelection();
                dgvMusteriAdres.Columns["id"].Width = 30;
                dgvMusteriAdres.Columns["adres"].Width = 240;
            }
            catch (Exception e)
            {
                MessageBox.Show("Hata oluştu. Hata kodu:" + e.ToString(), "Hata",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void temizle()
        {
            txtAdres.Text = "";
            txtAdresBaslik.Clear();
            txtEPosta.Clear();
            txtMusteriAd.Clear();
            txtTel.Clear();

            s_musteriid = -1;

        }
        private void MusteriEkle(string MusteriAd, string Tel,string EPosta, string AdresBaslik, string Adres)
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
                cmd.CommandText = "MusteriKaydet";

                cmd.Parameters.AddWithValue("@MusteriAd", MusteriAd);
                cmd.Parameters.AddWithValue("@Tel", Tel);
                cmd.Parameters.AddWithValue("@EPosta", EPosta);
                cmd.Parameters.AddWithValue("@AdresBaslik", AdresBaslik);
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
        private void MusteriAdresEkle(int Musteriid,string AdresBaslik, string Adres)
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
                cmd.CommandText = "MusteriAdresEkle";

                cmd.Parameters.AddWithValue("@Musteriid", Musteriid);
                cmd.Parameters.AddWithValue("@AdresBaslik", AdresBaslik);
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
        private void MusteriAdressil(int adresid)
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
                cmd.CommandText = "MusteriAdresSil";

                cmd.Parameters.AddWithValue("@adresid", adresid);

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
        private void MusteriGuncelle(int MusteriID, string MusteriAd, string Telefon, string Eposta)
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
                cmd.CommandText = "MusteriGuncelle";

                cmd.Parameters.AddWithValue("@MusteriID", MusteriID);
                cmd.Parameters.AddWithValue("@MusteriAd", MusteriAd);
                cmd.Parameters.AddWithValue("@Telefon", Telefon);
                cmd.Parameters.AddWithValue("@Eposta", Eposta);

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

        private void MusteriAdresGuncelle(int AdresId, string Adres, string Baslik)
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
                cmd.CommandText = "MusteriAdresGuncelle";

                cmd.Parameters.AddWithValue("@AdresId", AdresId);
                cmd.Parameters.AddWithValue("@Adres", Adres);
                cmd.Parameters.AddWithValue("@Baslik", Baslik);

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

      
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (txtMusteriAd.Text == "" || txtTel.Text == "    ." || txtAdres.Text == "" || txtAdresBaslik.Text == "")
            {
                MessageBox.Show("Tüm Kırmızı alanları doldurmanız gerekmektedir.", "Uyarı",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            MusteriEkle(txtMusteriAd.Text, txtTel.Text, txtEPosta.Text, txtAdresBaslik.Text,txtAdres.Text);
            temizle();
        }

        private void btnMusteriBul_Click(object sender, EventArgs e)
        {
            FMusteriAra fma = new FMusteriAra();
            fma.ShowDialog();

            s_musteriid = fma.secilen_musteri_id;
            //MessageBox.Show(s_musteriid.ToString());
            if (s_musteriid > 0)
            {
                MusteriListele(fma.secilen_musteri_id);
                MusteriAdresListele(s_musteriid);
                btnKaydet.Enabled = false;
            }
        }

        private void btnAdresEkle_Click(object sender, EventArgs e)
        {
            if(s_musteriid >0)
            {
                if (txtAdres.Text == "" || txtAdresBaslik.Text == "")
                {
                    MessageBox.Show("Adres Başlığı ve adres alanları doldurmanız gerekmektedir.", "Uyarı",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                MusteriAdresEkle(s_musteriid,txtAdresBaslik.Text,txtAdres.Text);
                MusteriAdresListele(s_musteriid);
                txtAdres.Text = "";
                txtAdresBaslik.Text = "";
            }
            else
            {
                MessageBox.Show("Öncelikle Müşteri Seçmelisiniz.");
            }
        }
        int currentMouseOverRow = -1;
        private void adresSilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //  dgvMusteriAdres_MouseClick(sender,e);

            //MessageBox.Show(dgvMusteriAdres.Rows[currentMouseOverRow].Cells[0].
            //   FormattedValue.ToString());




            //     int secili_adres = Convert.ToInt32(dgvMusteriAdres.Rows[e.RowIndex].Cells[0].ToString());
            //    if (Convert.ToInt32(dgvMusteriAdres.Rows[e.RowIndex].Cells[0].ToString())>-1)
            DialogResult cvp = MessageBox.Show("Eminmisin", "Soru", MessageBoxButtons.YesNoCancel);
            if (cvp == DialogResult.Yes)
            {
                MusteriAdressil(Convert.ToInt32(dgvMusteriAdres.Rows[currentMouseOverRow].Cells[0].
                      FormattedValue.ToString()));
                MusteriAdresListele(s_musteriid);
            }
        }

     

        private void dgvMusteriAdres_MouseClick(object sender, MouseEventArgs e)
        {
            
                currentMouseOverRow = dgvMusteriAdres.HitTest(e.X, e.Y).RowIndex;
            //MessageBox.Show(currentMouseOverRow.ToString());

        }
        int secili_adres_id = 0;
        private void adresGüncelleToolStripMenuItem_Click(object sender, EventArgs e)
        {

            
            try
            {
                secili_adres_id = Convert.ToInt32(dgvMusteriAdres.Rows[currentMouseOverRow].Cells[0].
                          FormattedValue.ToString());
                txtAdresBaslik.Text = dgvMusteriAdres.Rows[currentMouseOverRow].Cells[1].
                          FormattedValue.ToString();
                txtAdres.Text = dgvMusteriAdres.Rows[currentMouseOverRow].Cells[2].
                          FormattedValue.ToString();

            }
            catch
            {

            }
         


            MusteriAdresListele(s_musteriid);
           
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            
            if (s_musteriid > 0)
            {
                if (txtMusteriAd.Text == "" || txtTel.Text == "" )
                {
                    MessageBox.Show("Müşteri adı ve telefon alanları doldurmanız gerekmektedir.", "Uyarı",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                 MusteriGuncelle(s_musteriid, txtMusteriAd.Text, txtTel.Text, txtEPosta.Text);

                if (secili_adres_id > 0)
                {
                    if (txtAdres.Text == "" || txtAdresBaslik.Text == "")
                    {
                        MessageBox.Show("Adres ve adres başlık alanları doldurmanız gerekmektedir.", "Uyarı",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                   MusteriAdresGuncelle(secili_adres_id, txtAdres.Text, txtAdresBaslik.Text);
                    MusteriAdresListele(s_musteriid);
                }
              
            }
            else
            {
                MessageBox.Show("Öncelikle Güncellenecek veri seçmelisiniz");
            }
            
        }
     
        private void dgvMusteriAdres_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {

                secili_adres_id = Convert.ToInt32(dgvMusteriAdres.Rows[e.RowIndex].Cells[0].FormattedValue.ToString());
                txtAdresBaslik.Text = dgvMusteriAdres.Rows[e.RowIndex].Cells[1].FormattedValue.ToString();
                txtAdres.Text = dgvMusteriAdres.Rows[e.RowIndex].Cells[2].FormattedValue.ToString();
            }
        }
    }
}
