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
    public partial class FUrunAra : Form
    {
        public FUrunAra()
        {
            InitializeComponent();
        }
      
        public int secilen_urun_id;
        private void UrunListelelikeli(string urunad, string barkod)
        {
            try
            {
                FLogin flogin = new FLogin();
                SqlConnection baglanti = new SqlConnection(flogin.str);
                if (baglanti.State == ConnectionState.Closed) baglanti.Open();

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = baglanti;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "UrunListeleLike";
                cmd.Parameters.AddWithValue("@urunad", urunad);
                cmd.Parameters.AddWithValue("@barkod", barkod);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvUrun.DataSource = dt;
                dgvUrun.ClearSelection();
            }
            catch (Exception e)
            {
                MessageBox.Show("Hata oluştu. Hata kodu:" + e.ToString(), "Hata",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }



        private void FUrunAra_Load(object sender, EventArgs e)
        {

        }

        private void txtUrunAd_TextChanged(object sender, EventArgs e)
        {
            UrunListelelikeli(txtUrunAd.Text, txtBarkod.Text);
        }

        private void dgvUrun_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                secilen_urun_id = Convert.ToInt32(dgvUrun.Rows[e.RowIndex].Cells[0].
                    FormattedValue.ToString());
                this.Close();
            }
            else
            {
                MessageBox.Show("Seçim Hatalı", "Bilgi");
            }
        }

        private void btnSec_Click(object sender, EventArgs e)
        {          
            if (secilen_urun_id > 0)
            {
                this.Close();
            }
            else
                MessageBox.Show("Lütfen bir ürün seçiniz.", "Uyarı");
        }

        private void dgvUrun_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                secilen_urun_id = Convert.ToInt32(dgvUrun.Rows[e.RowIndex].Cells[0].
                FormattedValue.ToString());
            }
            else
            {
                MessageBox.Show("Seçim Hatalı", "Bilgi");
            }
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            secilen_urun_id = 0;
            this.Close();
        }
    }
}
