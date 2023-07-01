namespace ETicaretUyg_CodeFirst
{
    partial class FrmMusteriEkle
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
            this.TxtId = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.BtnMusteriGuncelle = new System.Windows.Forms.Button();
            this.BtnMusteriSil = new System.Windows.Forms.Button();
            this.BtnMusteriEkle = new System.Windows.Forms.Button();
            this.BtnMusteriListele = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.TxtSifre = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.TxtTelefon = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtEmail = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtSoyad = new System.Windows.Forms.TextBox();
            this.TxtAd = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnMinimize = new FontAwesome.Sharp.IconButton();
            this.BtnClose = new FontAwesome.Sharp.IconButton();
            this.BtnMaximize = new FontAwesome.Sharp.IconButton();
            this.label3 = new System.Windows.Forms.Label();
            this.panelTitleBar = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panelTitleBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // TxtId
            // 
            this.TxtId.Location = new System.Drawing.Point(224, 115);
            this.TxtId.Name = "TxtId";
            this.TxtId.Size = new System.Drawing.Size(189, 28);
            this.TxtId.TabIndex = 23;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Georgia", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(109, 118);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(114, 21);
            this.label7.TabIndex = 40;
            this.label7.Text = "Müşteri Id:";
            // 
            // BtnMusteriGuncelle
            // 
            this.BtnMusteriGuncelle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(67)))), ((int)(((byte)(81)))));
            this.BtnMusteriGuncelle.Location = new System.Drawing.Point(550, 266);
            this.BtnMusteriGuncelle.Name = "BtnMusteriGuncelle";
            this.BtnMusteriGuncelle.Size = new System.Drawing.Size(220, 39);
            this.BtnMusteriGuncelle.TabIndex = 39;
            this.BtnMusteriGuncelle.Text = "Müşteri Güncelle";
            this.BtnMusteriGuncelle.UseVisualStyleBackColor = false;
            this.BtnMusteriGuncelle.Click += new System.EventHandler(this.BtnMusteriGuncelle_Click);
            // 
            // BtnMusteriSil
            // 
            this.BtnMusteriSil.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(67)))), ((int)(((byte)(81)))));
            this.BtnMusteriSil.Location = new System.Drawing.Point(550, 219);
            this.BtnMusteriSil.Name = "BtnMusteriSil";
            this.BtnMusteriSil.Size = new System.Drawing.Size(220, 39);
            this.BtnMusteriSil.TabIndex = 38;
            this.BtnMusteriSil.Text = "Müşteri Sil";
            this.BtnMusteriSil.UseVisualStyleBackColor = false;
            this.BtnMusteriSil.Click += new System.EventHandler(this.BtnMusteriSil_Click);
            // 
            // BtnMusteriEkle
            // 
            this.BtnMusteriEkle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(67)))), ((int)(((byte)(81)))));
            this.BtnMusteriEkle.Location = new System.Drawing.Point(550, 173);
            this.BtnMusteriEkle.Name = "BtnMusteriEkle";
            this.BtnMusteriEkle.Size = new System.Drawing.Size(220, 39);
            this.BtnMusteriEkle.TabIndex = 37;
            this.BtnMusteriEkle.Text = "Müşteri Ekle";
            this.BtnMusteriEkle.UseVisualStyleBackColor = false;
            this.BtnMusteriEkle.Click += new System.EventHandler(this.BtnMusteriEkle_Click);
            // 
            // BtnMusteriListele
            // 
            this.BtnMusteriListele.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(67)))), ((int)(((byte)(81)))));
            this.BtnMusteriListele.Location = new System.Drawing.Point(550, 127);
            this.BtnMusteriListele.Name = "BtnMusteriListele";
            this.BtnMusteriListele.Size = new System.Drawing.Size(220, 40);
            this.BtnMusteriListele.TabIndex = 36;
            this.BtnMusteriListele.Text = "Müşteri Listele";
            this.BtnMusteriListele.UseVisualStyleBackColor = false;
            this.BtnMusteriListele.Click += new System.EventHandler(this.BtnMüşteriListele_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 382);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(829, 220);
            this.dataGridView1.TabIndex = 35;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick_1);
            // 
            // TxtSifre
            // 
            this.TxtSifre.Location = new System.Drawing.Point(224, 286);
            this.TxtSifre.Name = "TxtSifre";
            this.TxtSifre.Size = new System.Drawing.Size(189, 28);
            this.TxtSifre.TabIndex = 29;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Georgia", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(85, 289);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(138, 21);
            this.label6.TabIndex = 34;
            this.label6.Text = "Müşteri Şifre:";
            // 
            // TxtTelefon
            // 
            this.TxtTelefon.Location = new System.Drawing.Point(224, 252);
            this.TxtTelefon.Name = "TxtTelefon";
            this.TxtTelefon.Size = new System.Drawing.Size(189, 28);
            this.TxtTelefon.TabIndex = 27;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Georgia", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(60, 255);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(163, 21);
            this.label5.TabIndex = 33;
            this.label5.Text = "Müşteri Telefon:";
            // 
            // TxtEmail
            // 
            this.TxtEmail.Location = new System.Drawing.Point(224, 218);
            this.TxtEmail.Name = "TxtEmail";
            this.TxtEmail.Size = new System.Drawing.Size(189, 28);
            this.TxtEmail.TabIndex = 26;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Georgia", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(75, 221);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(148, 21);
            this.label4.TabIndex = 32;
            this.label4.Text = "Müşteri Email:";
            // 
            // TxtSoyad
            // 
            this.TxtSoyad.Location = new System.Drawing.Point(224, 184);
            this.TxtSoyad.Name = "TxtSoyad";
            this.TxtSoyad.Size = new System.Drawing.Size(189, 28);
            this.TxtSoyad.TabIndex = 25;
            // 
            // TxtAd
            // 
            this.TxtAd.Location = new System.Drawing.Point(224, 150);
            this.TxtAd.Name = "TxtAd";
            this.TxtAd.Size = new System.Drawing.Size(189, 28);
            this.TxtAd.TabIndex = 24;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Georgia", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(103, 153);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 21);
            this.label2.TabIndex = 30;
            this.label2.Text = "Müşteri Ad:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(16, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(334, 21);
            this.label1.TabIndex = 5;
            this.label1.Text = "MÜŞTERİ EKLE - SİL - GÜNCELLE";
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Georgia", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(73, 187);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(150, 21);
            this.label3.TabIndex = 31;
            this.label3.Text = "Müşteri Soyad:";
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
            this.panelTitleBar.TabIndex = 28;
            // 
            // FrmMusteriEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(242)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(829, 603);
            this.Controls.Add(this.TxtId);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.BtnMusteriGuncelle);
            this.Controls.Add(this.BtnMusteriSil);
            this.Controls.Add(this.BtnMusteriEkle);
            this.Controls.Add(this.BtnMusteriListele);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.TxtSifre);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.TxtTelefon);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TxtEmail);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TxtSoyad);
            this.Controls.Add(this.TxtAd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panelTitleBar);
            this.Font = new System.Drawing.Font("Georgia", 10.8F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmMusteriEkle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmMusteriEkle";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FrmMusteriEkle_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.FrmMusteriEkle_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.FrmMusteriEkle_MouseUp);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panelTitleBar.ResumeLayout(false);
            this.panelTitleBar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtId;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button BtnMusteriGuncelle;
        private System.Windows.Forms.Button BtnMusteriSil;
        private System.Windows.Forms.Button BtnMusteriEkle;
        private System.Windows.Forms.Button BtnMusteriListele;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox TxtSifre;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TxtTelefon;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TxtEmail;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtSoyad;
        private System.Windows.Forms.TextBox TxtAd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconButton BtnMinimize;
        private FontAwesome.Sharp.IconButton BtnClose;
        private FontAwesome.Sharp.IconButton BtnMaximize;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panelTitleBar;
    }
}