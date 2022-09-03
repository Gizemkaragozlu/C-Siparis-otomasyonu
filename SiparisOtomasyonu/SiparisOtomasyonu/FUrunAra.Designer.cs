namespace SiparisOtomasyonu
{
    partial class FUrunAra
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtUrunAd = new System.Windows.Forms.TextBox();
            this.txtBarkod = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvUrun = new System.Windows.Forms.DataGridView();
            this.btnSec = new System.Windows.Forms.Button();
            this.btnAra = new System.Windows.Forms.Button();
            this.btnKapat = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUrun)).BeginInit();
            this.SuspendLayout();
            // 
            // txtUrunAd
            // 
            this.txtUrunAd.Location = new System.Drawing.Point(74, 13);
            this.txtUrunAd.Name = "txtUrunAd";
            this.txtUrunAd.Size = new System.Drawing.Size(100, 20);
            this.txtUrunAd.TabIndex = 0;
            this.txtUrunAd.TextChanged += new System.EventHandler(this.txtUrunAd_TextChanged);
            // 
            // txtBarkod
            // 
            this.txtBarkod.Location = new System.Drawing.Point(258, 13);
            this.txtBarkod.Name = "txtBarkod";
            this.txtBarkod.Size = new System.Drawing.Size(100, 20);
            this.txtBarkod.TabIndex = 1;
            this.txtBarkod.TextChanged += new System.EventHandler(this.txtUrunAd_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Ürün Adı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(208, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Barkod";
            // 
            // dgvUrun
            // 
            this.dgvUrun.AllowUserToAddRows = false;
            this.dgvUrun.AllowUserToDeleteRows = false;
            this.dgvUrun.AllowUserToResizeColumns = false;
            this.dgvUrun.AllowUserToResizeRows = false;
            this.dgvUrun.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUrun.Location = new System.Drawing.Point(12, 50);
            this.dgvUrun.MultiSelect = false;
            this.dgvUrun.Name = "dgvUrun";
            this.dgvUrun.ReadOnly = true;
            this.dgvUrun.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUrun.Size = new System.Drawing.Size(445, 338);
            this.dgvUrun.TabIndex = 4;
            this.dgvUrun.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUrun_CellClick);
            this.dgvUrun.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUrun_CellDoubleClick);
            // 
            // btnSec
            // 
            this.btnSec.Location = new System.Drawing.Point(382, 395);
            this.btnSec.Name = "btnSec";
            this.btnSec.Size = new System.Drawing.Size(75, 23);
            this.btnSec.TabIndex = 5;
            this.btnSec.Text = "Ürün Seç";
            this.btnSec.UseVisualStyleBackColor = true;
            this.btnSec.Click += new System.EventHandler(this.btnSec_Click);
            // 
            // btnAra
            // 
            this.btnAra.Location = new System.Drawing.Point(382, 11);
            this.btnAra.Name = "btnAra";
            this.btnAra.Size = new System.Drawing.Size(75, 23);
            this.btnAra.TabIndex = 6;
            this.btnAra.Text = "Ara";
            this.btnAra.UseVisualStyleBackColor = true;
            this.btnAra.Click += new System.EventHandler(this.txtUrunAd_TextChanged);
            // 
            // btnKapat
            // 
            this.btnKapat.BackColor = System.Drawing.Color.Black;
            this.btnKapat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKapat.ForeColor = System.Drawing.Color.White;
            this.btnKapat.Location = new System.Drawing.Point(474, 5);
            this.btnKapat.Name = "btnKapat";
            this.btnKapat.Size = new System.Drawing.Size(23, 26);
            this.btnKapat.TabIndex = 15;
            this.btnKapat.Text = "X";
            this.btnKapat.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnKapat.UseVisualStyleBackColor = false;
            this.btnKapat.Click += new System.EventHandler(this.btnKapat_Click);
            // 
            // FUrunAra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(499, 433);
            this.Controls.Add(this.btnKapat);
            this.Controls.Add(this.btnAra);
            this.Controls.Add(this.btnSec);
            this.Controls.Add(this.dgvUrun);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBarkod);
            this.Controls.Add(this.txtUrunAd);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FUrunAra";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FUrunAra";
            this.Load += new System.EventHandler(this.FUrunAra_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUrun)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtUrunAd;
        private System.Windows.Forms.TextBox txtBarkod;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvUrun;
        private System.Windows.Forms.Button btnSec;
        private System.Windows.Forms.Button btnAra;
        private System.Windows.Forms.Button btnKapat;
    }
}