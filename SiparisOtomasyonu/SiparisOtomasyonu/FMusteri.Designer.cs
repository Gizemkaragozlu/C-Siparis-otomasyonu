namespace SiparisOtomasyonu
{
    partial class FMusteri
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
            this.components = new System.ComponentModel.Container();
            this.btnKapat = new System.Windows.Forms.Button();
            this.dgvMusteriAdres = new System.Windows.Forms.DataGridView();
            this.cms_MusteriAdres = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.adresSilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adresGüncelleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txtAdres = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtAdresBaslik = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnAdresEkle = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTel = new System.Windows.Forms.MaskedTextBox();
            this.txtEPosta = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMusteriAd = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnMusteriBul = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.btnYeni = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMusteriAdres)).BeginInit();
            this.cms_MusteriAdres.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnKapat
            // 
            this.btnKapat.BackColor = System.Drawing.Color.Black;
            this.btnKapat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKapat.ForeColor = System.Drawing.Color.White;
            this.btnKapat.Location = new System.Drawing.Point(749, 3);
            this.btnKapat.Name = "btnKapat";
            this.btnKapat.Size = new System.Drawing.Size(23, 26);
            this.btnKapat.TabIndex = 16;
            this.btnKapat.Text = "X";
            this.btnKapat.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnKapat.UseVisualStyleBackColor = false;
            this.btnKapat.Click += new System.EventHandler(this.btnKapat_Click);
            // 
            // dgvMusteriAdres
            // 
            this.dgvMusteriAdres.AllowUserToAddRows = false;
            this.dgvMusteriAdres.AllowUserToDeleteRows = false;
            this.dgvMusteriAdres.AllowUserToResizeColumns = false;
            this.dgvMusteriAdres.AllowUserToResizeRows = false;
            this.dgvMusteriAdres.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMusteriAdres.ContextMenuStrip = this.cms_MusteriAdres;
            this.dgvMusteriAdres.Location = new System.Drawing.Point(380, 35);
            this.dgvMusteriAdres.Name = "dgvMusteriAdres";
            this.dgvMusteriAdres.ReadOnly = true;
            this.dgvMusteriAdres.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMusteriAdres.Size = new System.Drawing.Size(392, 322);
            this.dgvMusteriAdres.TabIndex = 50;
            this.dgvMusteriAdres.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMusteriAdres_CellDoubleClick);
            this.dgvMusteriAdres.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dgvMusteriAdres_MouseClick);
            // 
            // cms_MusteriAdres
            // 
            this.cms_MusteriAdres.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adresSilToolStripMenuItem,
            this.adresGüncelleToolStripMenuItem});
            this.cms_MusteriAdres.Name = "cms_MusteriAdres";
            this.cms_MusteriAdres.Size = new System.Drawing.Size(154, 48);
            // 
            // adresSilToolStripMenuItem
            // 
            this.adresSilToolStripMenuItem.Name = "adresSilToolStripMenuItem";
            this.adresSilToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.adresSilToolStripMenuItem.Text = "Adres Sil";
            this.adresSilToolStripMenuItem.Click += new System.EventHandler(this.adresSilToolStripMenuItem_Click);
            // 
            // adresGüncelleToolStripMenuItem
            // 
            this.adresGüncelleToolStripMenuItem.Name = "adresGüncelleToolStripMenuItem";
            this.adresGüncelleToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.adresGüncelleToolStripMenuItem.Text = "Adres Güncelle";
            this.adresGüncelleToolStripMenuItem.Click += new System.EventHandler(this.adresGüncelleToolStripMenuItem_Click);
            // 
            // txtAdres
            // 
            this.txtAdres.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtAdres.Location = new System.Drawing.Point(107, 230);
            this.txtAdres.Multiline = true;
            this.txtAdres.Name = "txtAdres";
            this.txtAdres.Size = new System.Drawing.Size(245, 49);
            this.txtAdres.TabIndex = 49;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Maroon;
            this.label5.Location = new System.Drawing.Point(56, 236);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 48;
            this.label5.Text = "Adres";
            // 
            // txtAdresBaslik
            // 
            this.txtAdresBaslik.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtAdresBaslik.Location = new System.Drawing.Point(107, 184);
            this.txtAdresBaslik.Name = "txtAdresBaslik";
            this.txtAdresBaslik.Size = new System.Drawing.Size(126, 30);
            this.txtAdresBaslik.TabIndex = 47;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Maroon;
            this.label4.Location = new System.Drawing.Point(23, 190);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 13);
            this.label4.TabIndex = 46;
            this.label4.Text = "Adres Başlığı";
            // 
            // btnAdresEkle
            // 
            this.btnAdresEkle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnAdresEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAdresEkle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdresEkle.Location = new System.Drawing.Point(286, 124);
            this.btnAdresEkle.Name = "btnAdresEkle";
            this.btnAdresEkle.Size = new System.Drawing.Size(66, 51);
            this.btnAdresEkle.TabIndex = 45;
            this.btnAdresEkle.Text = "Yenii Adres Ekle";
            this.btnAdresEkle.UseVisualStyleBackColor = false;
            this.btnAdresEkle.Click += new System.EventHandler(this.btnAdresEkle_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(49, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 44;
            this.label3.Text = "EPosta";
            // 
            // txtTel
            // 
            this.txtTel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtTel.Location = new System.Drawing.Point(107, 88);
            this.txtTel.Mask = "9990000000";
            this.txtTel.Name = "txtTel";
            this.txtTel.Size = new System.Drawing.Size(126, 30);
            this.txtTel.TabIndex = 43;
            // 
            // txtEPosta
            // 
            this.txtEPosta.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtEPosta.Location = new System.Drawing.Point(107, 137);
            this.txtEPosta.Name = "txtEPosta";
            this.txtEPosta.Size = new System.Drawing.Size(126, 30);
            this.txtEPosta.TabIndex = 38;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Maroon;
            this.label2.Location = new System.Drawing.Point(47, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 37;
            this.label2.Text = "Telefon";
            // 
            // txtMusteriAd
            // 
            this.txtMusteriAd.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtMusteriAd.Location = new System.Drawing.Point(107, 42);
            this.txtMusteriAd.Name = "txtMusteriAd";
            this.txtMusteriAd.Size = new System.Drawing.Size(126, 30);
            this.txtMusteriAd.TabIndex = 36;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(17, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 35;
            this.label1.Text = "Müşterinin Adı";
            // 
            // btnMusteriBul
            // 
            this.btnMusteriBul.Image = global::SiparisOtomasyonu.Properties.Resources._510861_find_magnifying_glass_search_zoom_icon;
            this.btnMusteriBul.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMusteriBul.Location = new System.Drawing.Point(286, 42);
            this.btnMusteriBul.Name = "btnMusteriBul";
            this.btnMusteriBul.Size = new System.Drawing.Size(66, 49);
            this.btnMusteriBul.TabIndex = 42;
            this.btnMusteriBul.Text = "Bul";
            this.btnMusteriBul.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnMusteriBul.UseVisualStyleBackColor = true;
            this.btnMusteriBul.Click += new System.EventHandler(this.btnMusteriBul_Click);
            // 
            // btnSil
            // 
            this.btnSil.Image = global::SiparisOtomasyonu.Properties.Resources._2290850_clean_delete_garbage_recycle_bin_trash_icon;
            this.btnSil.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSil.Location = new System.Drawing.Point(297, 307);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(55, 51);
            this.btnSil.TabIndex = 41;
            this.btnSil.Text = "Sil";
            this.btnSil.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSil.UseVisualStyleBackColor = true;
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Image = global::SiparisOtomasyonu.Properties.Resources._64935_update_icon;
            this.btnGuncelle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuncelle.Location = new System.Drawing.Point(196, 307);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(89, 51);
            this.btnGuncelle.TabIndex = 40;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // btnKaydet
            // 
            this.btnKaydet.Image = global::SiparisOtomasyonu.Properties.Resources._2305609_disk_diskette_floppy_guardar_save_icon;
            this.btnKaydet.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnKaydet.Location = new System.Drawing.Point(100, 307);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(90, 51);
            this.btnKaydet.TabIndex = 39;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // btnYeni
            // 
            this.btnYeni.Image = global::SiparisOtomasyonu.Properties.Resources._2931173_document_empty_file_new_sheet_icon;
            this.btnYeni.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnYeni.Location = new System.Drawing.Point(26, 307);
            this.btnYeni.Name = "btnYeni";
            this.btnYeni.Size = new System.Drawing.Size(68, 51);
            this.btnYeni.TabIndex = 34;
            this.btnYeni.Text = "Yeni";
            this.btnYeni.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnYeni.UseVisualStyleBackColor = true;
            // 
            // FMusteri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(789, 368);
            this.Controls.Add(this.dgvMusteriAdres);
            this.Controls.Add(this.txtAdres);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtAdresBaslik);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnAdresEkle);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtTel);
            this.Controls.Add(this.btnMusteriBul);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.txtEPosta);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtMusteriAd);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnYeni);
            this.Controls.Add(this.btnKapat);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FMusteri";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FMusteri";
            ((System.ComponentModel.ISupportInitialize)(this.dgvMusteriAdres)).EndInit();
            this.cms_MusteriAdres.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnKapat;
        private System.Windows.Forms.DataGridView dgvMusteriAdres;
        private System.Windows.Forms.TextBox txtAdres;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtAdresBaslik;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnAdresEkle;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox txtTel;
        private System.Windows.Forms.Button btnMusteriBul;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.MaskedTextBox txtEPosta;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMusteriAd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnYeni;
        private System.Windows.Forms.ContextMenuStrip cms_MusteriAdres;
        private System.Windows.Forms.ToolStripMenuItem adresSilToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adresGüncelleToolStripMenuItem;
    }
}