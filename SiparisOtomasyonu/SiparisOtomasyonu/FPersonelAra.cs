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
    public partial class FPersonelAra : Form
    {
        public FPersonelAra()
        {
            InitializeComponent();
        }
        public int secilen_personel_id;
        private void PersonelListelelikeli(string AdSoyad, string KimlikNo,string Tel, int YetkiID)
        {
            try
            {
                FLogin flogin = new FLogin();
                SqlConnection baglanti = new SqlConnection(flogin.str);
                if (baglanti.State == ConnectionState.Closed) baglanti.Open();

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = baglanti;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "PersonelListeleLike";
                cmd.Parameters.AddWithValue("@AdSoyad", AdSoyad);
                cmd.Parameters.AddWithValue("@KimlikNo", KimlikNo);
                cmd.Parameters.AddWithValue("@Tel", Tel);
                cmd.Parameters.AddWithValue("@YetkiID", YetkiID);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvPersonel.DataSource = dt;
                dgvPersonel.ClearSelection();
            }
            catch (Exception e)
            {
                MessageBox.Show("Hata oluştu. Hata kodu:" + e.ToString(), "Hata",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

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
        private void txtUrunAd_TextChanged(object sender, EventArgs e)
        {
           // PersonelListelelikeli("aa", "", txtKimlikNo.Text, -1);
            /*
             olasılıklar 
            yetki     tel    
            -----------------
            nulll     (   ) -
            not null  (   ) -
            null      (543)444-1122
            not null  (543)444-1122
             */
            
           int secili_yetki;
           string tel;

           if (cbYetki.SelectedValue == null) secili_yetki = -1;
           else secili_yetki =Convert.ToInt32(cbYetki.SelectedValue.ToString());

           if (txtTel.Text == "(   )    -") tel = "";
           else tel = txtTel.Text;

           PersonelListelelikeli(txtAdSoyad.Text, tel,txtKimlikNo.Text,secili_yetki);
           
        }

        private void FPersonelAra_Load(object sender, EventArgs e)
        {
            YetkiListele(-1);
        }

        private void cbYetki_SelectedIndexChanged(object sender, EventArgs e)
        {
            int secili_yetki;
            string tel;
            try
            {

                if (cbYetki.SelectedValue == null) secili_yetki = -1;
                else secili_yetki = Convert.ToInt32(cbYetki.SelectedValue.ToString());

                if (txtTel.Text == "(   )    -") tel = "";
                else tel = txtTel.Text;

                PersonelListelelikeli(txtAdSoyad.Text, tel, txtKimlikNo.Text, secili_yetki);
            }
            catch
            {

            }
        }

        private void btnSec_Click(object sender, EventArgs e)
        {
            if (secilen_personel_id > 0)
            {
                this.Close();
            }
            else
                MessageBox.Show("Lütfen bir personel seçiniz.", "Uyarı");
        }

        private void dgvPersonel_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                secilen_personel_id = Convert.ToInt32(dgvPersonel.Rows[e.RowIndex].Cells[0].
                FormattedValue.ToString());
            }
            else
            {
                MessageBox.Show("Seçim Hatalı", "Bilgi");
            }
        }

        private void dgvPersonel_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                secilen_personel_id = Convert.ToInt32(dgvPersonel.Rows[e.RowIndex].Cells[0].
                    FormattedValue.ToString());
                this.Close();
            }
            else
            {
                MessageBox.Show("Seçim Hatalı", "Bilgi");
            }
        }
    }
}
