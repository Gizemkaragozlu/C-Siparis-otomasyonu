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
using Microsoft.VisualBasic;

namespace SiparisOtomasyonu
{
    public partial class FSiparisDetay : Form
    {
        public FSiparisDetay()
        {
            InitializeComponent();
        }
        public string secilen_masa = "-";
        public int secilen_masa_id=-1;
        int aktif_siparis_id = 0;
        private void UrunListele()
        {
            try
            {
                FLogin flogin = new FLogin();
                SqlConnection baglanti = new SqlConnection(flogin.str);
                if (baglanti.State == ConnectionState.Closed) baglanti.Open();

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = baglanti;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "UrunListele2";
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvUrun.DataSource = dt;
                dgvUrun.ClearSelection();
                dgvUrun.Columns["id"].Visible = false;
                dgvUrun.Columns["fiyat"].Width = 50;

            }
            catch (Exception e)
            {
                MessageBox.Show("Hata oluştu. Hata kodu:" + e.ToString(), "Hata",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void SiparisDetayListele(int siparis_id)
        {
            try
            {
                FLogin flogin = new FLogin();
                SqlConnection baglanti = new SqlConnection(flogin.str);
                if (baglanti.State == ConnectionState.Closed) baglanti.Open();

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = baglanti;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "SiparisDetayListele";
                cmd.Parameters.AddWithValue("@siparis_id", siparis_id);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvSiparisDetay.DataSource = dt;
                dgvSiparisDetay.ClearSelection();
              //  dgvSiparisDetay.Columns["id"].Visible = false;
                dgvSiparisDetay.Columns["fiyat"].Width = 50;

            }
            catch (Exception e)
            {
                MessageBox.Show("Hata oluştu. Hata kodu:" + e.ToString(), "Hata",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void SiparisOlustur(int restoran,int musteri_id,int teslimat_adres_id, 
            int @toplam_tutar, int teslim_eden,int masa_id)
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
                cmd.CommandText = "SiparisOlustur";

                cmd.Parameters.AddWithValue("@restoran", restoran);
                cmd.Parameters.AddWithValue("@musteri_id", musteri_id);
                cmd.Parameters.AddWithValue("@teslimat_adres_id", teslimat_adres_id);
                cmd.Parameters.AddWithValue("@toplam_tutar", toplam_tutar);
                cmd.Parameters.AddWithValue("@teslim_eden", teslim_eden);
                cmd.Parameters.AddWithValue("@masa_id", masa_id);

                int i = cmd.ExecuteNonQuery();
               
                if (i == 0)
                {                    
                   // MessageBox.Show("Kayıt Başarısız.");
                }
                else if (i > 0)
                {
                    aktif_siparis_id = i;
                    //MessageBox.Show("Kayıt Başarılı.");
                }

                cmd.Dispose();
                baglanti.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }

        }

        private void SiparisDetayOlustur(int siparis_id, int urun_id, int adet)
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
                cmd.CommandText = "SiparisDetayOlustur";

                cmd.Parameters.AddWithValue("@siparis_id", siparis_id);
                cmd.Parameters.AddWithValue("@urun_id", urun_id);
                cmd.Parameters.AddWithValue("@adet", adet);

                int i = cmd.ExecuteNonQuery();

                if (i == 0)
                {
                    // MessageBox.Show("Kayıt Başarısız.");
                }
                else if (i > 0)
                {
                   
                    //MessageBox.Show("Kayıt Başarılı.");
                }

                cmd.Dispose();
                baglanti.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }

        }

        private void FSiparisDetay_Load(object sender, EventArgs e)
        {          
            FSiparis a = new FSiparis();
            lblSeciliMasa.Text= secilen_masa;


            /* Ürünleri  Listele*/
            UrunListele();

            SiparisOlustur(1, 3, -1, -1, -1, secilen_masa_id);

        }

        private void dgvUrun_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {

                 int adet = Convert.ToInt32(Interaction.InputBox("Adet Sayısı", "Soru","1"));
                 int secili_urun_id = Convert.ToInt32(dgvUrun.Rows[e.RowIndex].Cells["id"].FormattedValue.ToString());

                SiparisDetayOlustur(aktif_siparis_id, secili_urun_id, adet);
                SiparisDetayListele(aktif_siparis_id);

            }

        }
    }
}
