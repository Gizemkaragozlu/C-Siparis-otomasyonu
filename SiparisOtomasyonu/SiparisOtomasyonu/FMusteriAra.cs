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
    public partial class FMusteriAra : Form
    {
        public FMusteriAra()
        {
            InitializeComponent();
        }
        public int secilen_musteri_id;
        private void MusteriListelelikeli(string musteriad, string tel,string adres)
        {
            try
            {
                FLogin flogin = new FLogin();
                SqlConnection baglanti = new SqlConnection(flogin.str);
                if (baglanti.State == ConnectionState.Closed) baglanti.Open();

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = baglanti;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "MusteriListeleLike";
                cmd.Parameters.AddWithValue("@musteriad", musteriad);
                cmd.Parameters.AddWithValue("@tel", tel);
                cmd.Parameters.AddWithValue("@adres", adres);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvMusteri.DataSource = dt;
                dgvMusteri.ClearSelection();
            }
            catch (Exception e)
            {
                MessageBox.Show("Hata oluştu. Hata kodu:" + e.ToString(), "Hata",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }


        private void txtMusteriAd_TextChanged(object sender, EventArgs e)
        {
            MusteriListelelikeli(txtMusteriAd.Text, txtTel.Text,txtAdres.Text);
        }

        private void dgvMusteri_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dgvMusteri_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                secilen_musteri_id = Convert.ToInt32(dgvMusteri.Rows[e.RowIndex].Cells[0].
                    FormattedValue.ToString());
                this.Close();
            }
            else
            {
                MessageBox.Show("Seçim Hatalı", "Bilgi");
            }
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            secilen_musteri_id = 0;
            this.Close();
        }

        private void btnSec_Click(object sender, EventArgs e)
        {
            if (secilen_musteri_id > 0)
            {
                this.Close();
            }
            else
                MessageBox.Show("Lütfen bir müşteri seçiniz.", "Uyarı");
        }

        private void dgvMusteri_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                secilen_musteri_id = Convert.ToInt32(dgvMusteri.Rows[e.RowIndex].Cells[0].
                FormattedValue.ToString());
            }
            else
            {
                MessageBox.Show("Seçim Hatalı", "Bilgi");
            }
        }

        private void FMusteriAra_Load(object sender, EventArgs e)
        {

        }
    }
}
