namespace ETicaretUyg_CodeFirst
{
    partial class FrmSiparisEkle
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
            this.TxtSiparisId = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.BtnSiparisGuncelle = new System.Windows.Forms.Button();
            this.BtnSiparisSil = new System.Windows.Forms.Button();
            this.BtnSiparisiEkle = new System.Windows.Forms.Button();
            this.BtnSiparisListele = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnMinimize = new FontAwesome.Sharp.IconButton();
            this.BtnClose = new FontAwesome.Sharp.IconButton();
            this.BtnMaximize = new FontAwesome.Sharp.IconButton();
            this.TxtToplamFiyat = new System.Windows.Forms.TextBox();
            this.TxtSiparisTarih = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panelTitleBar = new System.Windows.Forms.Panel();
            this.TxtMusteriId = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panelTitleBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // TxtSiparisId
            // 
            this.TxtSiparisId.Location = new System.Drawing.Point(266, 199);
            this.TxtSiparisId.Name = "TxtSiparisId";
            this.TxtSiparisId.Size = new System.Drawing.Size(189, 28);
            this.TxtSiparisId.TabIndex = 41;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Georgia", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(140, 202);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(107, 21);
            this.label7.TabIndex = 58;
            this.label7.Text = "Sipariş Id:";
            // 
            // BtnSiparisGuncelle
            // 
            this.BtnSiparisGuncelle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(197)))), ((int)(((byte)(55)))));
            this.BtnSiparisGuncelle.Location = new System.Drawing.Point(550, 316);
            this.BtnSiparisGuncelle.Name = "BtnSiparisGuncelle";
            this.BtnSiparisGuncelle.Size = new System.Drawing.Size(220, 39);
            this.BtnSiparisGuncelle.TabIndex = 57;
            this.BtnSiparisGuncelle.Text = "Sipariş Güncelle";
            this.BtnSiparisGuncelle.UseVisualStyleBackColor = false;
            this.BtnSiparisGuncelle.Click += new System.EventHandler(this.BtnSiparisGuncelle_Click);
            // 
            // BtnSiparisSil
            // 
            this.BtnSiparisSil.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(197)))), ((int)(((byte)(55)))));
            this.BtnSiparisSil.Location = new System.Drawing.Point(550, 269);
            this.BtnSiparisSil.Name = "BtnSiparisSil";
            this.BtnSiparisSil.Size = new System.Drawing.Size(220, 39);
            this.BtnSiparisSil.TabIndex = 56;
            this.BtnSiparisSil.Text = "Sipariş Sil";
            this.BtnSiparisSil.UseVisualStyleBackColor = false;
            this.BtnSiparisSil.Click += new System.EventHandler(this.BtnSiparisSil_Click);
            // 
            // BtnSiparisiEkle
            // 
            this.BtnSiparisiEkle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(197)))), ((int)(((byte)(55)))));
            this.BtnSiparisiEkle.Location = new System.Drawing.Point(550, 223);
            this.BtnSiparisiEkle.Name = "BtnSiparisiEkle";
            this.BtnSiparisiEkle.Size = new System.Drawing.Size(220, 39);
            this.BtnSiparisiEkle.TabIndex = 55;
            this.BtnSiparisiEkle.Text = "Sipariş Ekle";
            this.BtnSiparisiEkle.UseVisualStyleBackColor = false;
            this.BtnSiparisiEkle.Click += new System.EventHandler(this.BtnSiparisiEkle_Click);
            // 
            // BtnSiparisListele
            // 
            this.BtnSiparisListele.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(197)))), ((int)(((byte)(55)))));
            this.BtnSiparisListele.Location = new System.Drawing.Point(550, 177);
            this.BtnSiparisListele.Name = "BtnSiparisListele";
            this.BtnSiparisListele.Size = new System.Drawing.Size(220, 40);
            this.BtnSiparisListele.TabIndex = 54;
            this.BtnSiparisListele.Text = "Sipariş Listele";
            this.BtnSiparisListele.UseVisualStyleBackColor = false;
            this.BtnSiparisListele.Click += new System.EventHandler(this.BtnMusteriListele_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 432);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(829, 220);
            this.dataGridView1.TabIndex = 53;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(16, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(362, 21);
            this.label1.TabIndex = 5;
            this.label1.Text = "SİPARİŞLER EKLE - SİL - GÜNCELLE";
            // 
            // BtnMinimize
            // 
            this.BtnMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnMinimize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(111)))), ((int)(((byte)(3)))));
            this.BtnMinimize.FlatAppearance.BorderSize = 0;
            this.BtnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnMinimize.ForeColor = System.Drawing.SystemColors.ControlText;
            this.BtnMinimize.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize;
            this.BtnMinimize.IconColor = System.Drawing.Color.White;
            this.BtnMinimize.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnMinimize.IconSize = 20;
            this.BtnMinimize.Location = new System.Drawing.Point(701, 0);
            this.BtnMinimize.Name = "BtnMinimize";
            this.BtnMinimize.Size = new System.Drawing.Size(42, 25);
            this.BtnMinimize.TabIndex = 4;
            this.BtnMinimize.UseVisualStyleBackColor = false;
            this.BtnMinimize.Click += new System.EventHandler(this.BtnMinimize_Click_1);
            // 
            // BtnClose
            // 
            this.BtnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(111)))), ((int)(((byte)(3)))));
            this.BtnClose.FlatAppearance.BorderSize = 0;
            this.BtnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnClose.ForeColor = System.Drawing.SystemColors.ControlText;
            this.BtnClose.IconChar = FontAwesome.Sharp.IconChar.TimesRectangle;
            this.BtnClose.IconColor = System.Drawing.Color.White;
            this.BtnClose.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnClose.IconSize = 30;
            this.BtnClose.Location = new System.Drawing.Point(785, 0);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(42, 25);
            this.BtnClose.TabIndex = 3;
            this.BtnClose.UseVisualStyleBackColor = false;
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click_1);
            // 
            // BtnMaximize
            // 
            this.BtnMaximize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnMaximize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(111)))), ((int)(((byte)(3)))));
            this.BtnMaximize.FlatAppearance.BorderSize = 0;
            this.BtnMaximize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnMaximize.ForeColor = System.Drawing.SystemColors.ControlText;
            this.BtnMaximize.IconChar = FontAwesome.Sharp.IconChar.WindowRestore;
            this.BtnMaximize.IconColor = System.Drawing.Color.White;
            this.BtnMaximize.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnMaximize.IconSize = 25;
            this.BtnMaximize.Location = new System.Drawing.Point(743, 0);
            this.BtnMaximize.Name = "BtnMaximize";
            this.BtnMaximize.Size = new System.Drawing.Size(42, 25);
            this.BtnMaximize.TabIndex = 2;
            this.BtnMaximize.UseVisualStyleBackColor = false;
            this.BtnMaximize.Click += new System.EventHandler(this.BtnMaximize_Click_1);
            // 
            // TxtToplamFiyat
            // 
            this.TxtToplamFiyat.Location = new System.Drawing.Point(266, 301);
            this.TxtToplamFiyat.Name = "TxtToplamFiyat";
            this.TxtToplamFiyat.Size = new System.Drawing.Size(189, 28);
            this.TxtToplamFiyat.TabIndex = 43;
            // 
            // TxtSiparisTarih
            // 
            this.TxtSiparisTarih.Location = new System.Drawing.Point(266, 267);
            this.TxtSiparisTarih.Name = "TxtSiparisTarih";
            this.TxtSiparisTarih.Size = new System.Drawing.Size(189, 28);
            this.TxtSiparisTarih.TabIndex = 42;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Georgia", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(109, 270);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 21);
            this.label2.TabIndex = 48;
            this.label2.Text = "Sipariş Tarih:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Georgia", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(39, 304);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(208, 21);
            this.label3.TabIndex = 49;
            this.label3.Text = "Sipariş Toplam Fiyat:";
            // 
            // panelTitleBar
            // 
            this.panelTitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(95)))), ((int)(((byte)(225)))));
            this.panelTitleBar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelTitleBar.Controls.Add(this.label1);
            this.panelTitleBar.Controls.Add(this.BtnMinimize);
            this.panelTitleBar.Controls.Add(this.BtnClose);
            this.panelTitleBar.Controls.Add(this.BtnMaximize);
            this.panelTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitleBar.Location = new System.Drawing.Point(0, 0);
            this.panelTitleBar.Name = "panelTitleBar";
            this.panelTitleBar.Size = new System.Drawing.Size(829, 60);
            this.panelTitleBar.TabIndex = 46;
            // 
            // TxtMusteriId
            // 
            this.TxtMusteriId.Location = new System.Drawing.Point(266, 233);
            this.TxtMusteriId.Name = "TxtMusteriId";
            this.TxtMusteriId.Size = new System.Drawing.Size(189, 28);
            this.TxtMusteriId.TabIndex = 59;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Georgia", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(133, 236);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 21);
            this.label4.TabIndex = 60;
            this.label4.Text = "Müşteri Id:";
            // 
            // FrmSiparisEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(242)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(829, 653);
            this.Controls.Add(this.TxtMusteriId);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TxtSiparisId);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.BtnSiparisGuncelle);
            this.Controls.Add(this.BtnSiparisSil);
            this.Controls.Add(this.BtnSiparisiEkle);
            this.Controls.Add(this.BtnSiparisListele);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.TxtToplamFiyat);
            this.Controls.Add(this.TxtSiparisTarih);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panelTitleBar);
            this.Font = new System.Drawing.Font("Georgia", 10.8F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmSiparisEkle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmSiparisler";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FrmSiparisEkle_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.FrmSiparisEkle_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.FrmSiparisEkle_MouseUp);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panelTitleBar.ResumeLayout(false);
            this.panelTitleBar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtSiparisId;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button BtnSiparisGuncelle;
        private System.Windows.Forms.Button BtnSiparisSil;
        private System.Windows.Forms.Button BtnSiparisiEkle;
        private System.Windows.Forms.Button BtnSiparisListele;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconButton BtnMinimize;
        private FontAwesome.Sharp.IconButton BtnClose;
        private FontAwesome.Sharp.IconButton BtnMaximize;
        private System.Windows.Forms.TextBox TxtToplamFiyat;
        private System.Windows.Forms.TextBox TxtSiparisTarih;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panelTitleBar;
        private System.Windows.Forms.TextBox TxtMusteriId;
        private System.Windows.Forms.Label label4;
    }
}