namespace SiparisOtomasyonu
{
    partial class FSiparisDetay
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
            this.lblSeciliMasa = new System.Windows.Forms.Label();
            this.dgvUrun = new System.Windows.Forms.DataGridView();
            this.dgvSiparisDetay = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUrun)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSiparisDetay)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSeciliMasa
            // 
            this.lblSeciliMasa.AutoSize = true;
            this.lblSeciliMasa.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSeciliMasa.Location = new System.Drawing.Point(28, 36);
            this.lblSeciliMasa.Name = "lblSeciliMasa";
            this.lblSeciliMasa.Size = new System.Drawing.Size(70, 25);
            this.lblSeciliMasa.TabIndex = 0;
            this.lblSeciliMasa.Text = "label1";
            // 
            // dgvUrun
            // 
            this.dgvUrun.AllowUserToAddRows = false;
            this.dgvUrun.AllowUserToDeleteRows = false;
            this.dgvUrun.AllowUserToResizeColumns = false;
            this.dgvUrun.AllowUserToResizeRows = false;
            this.dgvUrun.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUrun.Location = new System.Drawing.Point(12, 99);
            this.dgvUrun.Name = "dgvUrun";
            this.dgvUrun.ReadOnly = true;
            this.dgvUrun.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUrun.Size = new System.Drawing.Size(181, 339);
            this.dgvUrun.TabIndex = 51;
            this.dgvUrun.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUrun_CellDoubleClick);
            // 
            // dgvSiparisDetay
            // 
            this.dgvSiparisDetay.AllowUserToAddRows = false;
            this.dgvSiparisDetay.AllowUserToDeleteRows = false;
            this.dgvSiparisDetay.AllowUserToResizeColumns = false;
            this.dgvSiparisDetay.AllowUserToResizeRows = false;
            this.dgvSiparisDetay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSiparisDetay.Location = new System.Drawing.Point(239, 36);
            this.dgvSiparisDetay.Name = "dgvSiparisDetay";
            this.dgvSiparisDetay.ReadOnly = true;
            this.dgvSiparisDetay.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSiparisDetay.Size = new System.Drawing.Size(406, 322);
            this.dgvSiparisDetay.TabIndex = 52;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.button1.Location = new System.Drawing.Point(266, 375);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(71, 63);
            this.button1.TabIndex = 53;
            this.button1.Text = "Ürün Çıkart";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Lime;
            this.button2.Location = new System.Drawing.Point(357, 375);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(71, 63);
            this.button2.TabIndex = 54;
            this.button2.Text = "Masa Değiştir";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.button3.Location = new System.Drawing.Point(454, 375);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(71, 63);
            this.button3.TabIndex = 55;
            this.button3.Text = "Masa Kapat";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Aqua;
            this.button4.Location = new System.Drawing.Point(546, 375);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(71, 63);
            this.button4.TabIndex = 56;
            this.button4.Text = "Fiş Yazdır";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // FSiparisDetay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(663, 450);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgvSiparisDetay);
            this.Controls.Add(this.dgvUrun);
            this.Controls.Add(this.lblSeciliMasa);
            this.Name = "FSiparisDetay";
            this.Text = "FSiparisDetay";
            this.Load += new System.EventHandler(this.FSiparisDetay_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUrun)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSiparisDetay)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSeciliMasa;
        private System.Windows.Forms.DataGridView dgvUrun;
        private System.Windows.Forms.DataGridView dgvSiparisDetay;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
    }
}