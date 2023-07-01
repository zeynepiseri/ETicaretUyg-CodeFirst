namespace ETicaretUyg_CodeFirst
{
    partial class FrmUrunEkle
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
            this.panelTitleBar = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnMinimize = new FontAwesome.Sharp.IconButton();
            this.BtnClose = new FontAwesome.Sharp.IconButton();
            this.BtnMaximize = new FontAwesome.Sharp.IconButton();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtAd = new System.Windows.Forms.TextBox();
            this.TxtMarka = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtStok = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtFiyat = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtKategori = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.BtnUrunGuncelle = new System.Windows.Forms.Button();
            this.BtnUrunSil = new System.Windows.Forms.Button();
            this.BtnUrunEkle = new System.Windows.Forms.Button();
            this.BtnUrunListele = new System.Windows.Forms.Button();
            this.TxtId = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.panelTitleBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
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
            this.panelTitleBar.Size = new System.Drawing.Size(793, 60);
            this.panelTitleBar.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(16, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(301, 21);
            this.label1.TabIndex = 5;
            this.label1.Text = "ÜRÜN EKLE - SİL - GÜNCELLE";
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
            this.BtnMinimize.Location = new System.Drawing.Point(667, 0);
            this.BtnMinimize.Name = "BtnMinimize";
            this.BtnMinimize.Size = new System.Drawing.Size(40, 25);
            this.BtnMinimize.TabIndex = 4;
            this.BtnMinimize.UseVisualStyleBackColor = false;
            this.BtnMinimize.Click += new System.EventHandler(this.BtnMinimize_Click);
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
            this.BtnClose.Location = new System.Drawing.Point(751, 0);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(40, 25);
            this.BtnClose.TabIndex = 3;
            this.BtnClose.UseVisualStyleBackColor = false;
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
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
            this.BtnMaximize.Location = new System.Drawing.Point(709, 0);
            this.BtnMaximize.Name = "BtnMaximize";
            this.BtnMaximize.Size = new System.Drawing.Size(40, 25);
            this.BtnMaximize.TabIndex = 2;
            this.BtnMaximize.UseVisualStyleBackColor = false;
            this.BtnMaximize.Click += new System.EventHandler(this.BtnMaximize_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Georgia", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(132, 166);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 21);
            this.label2.TabIndex = 6;
            this.label2.Text = "Ürün Ad:";
            // 
            // TxtAd
            // 
            this.TxtAd.Location = new System.Drawing.Point(236, 163);
            this.TxtAd.Name = "TxtAd";
            this.TxtAd.Size = new System.Drawing.Size(187, 28);
            this.TxtAd.TabIndex = 2;
            // 
            // TxtMarka
            // 
            this.TxtMarka.Location = new System.Drawing.Point(236, 197);
            this.TxtMarka.Name = "TxtMarka";
            this.TxtMarka.Size = new System.Drawing.Size(187, 28);
            this.TxtMarka.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Georgia", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(98, 200);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 21);
            this.label3.TabIndex = 8;
            this.label3.Text = "Ürün Marka:";
            // 
            // TxtStok
            // 
            this.TxtStok.Location = new System.Drawing.Point(236, 231);
            this.TxtStok.Name = "TxtStok";
            this.TxtStok.Size = new System.Drawing.Size(187, 28);
            this.TxtStok.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Georgia", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(117, 234);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 21);
            this.label4.TabIndex = 10;
            this.label4.Text = "Ürün Stok:";
            // 
            // TxtFiyat
            // 
            this.TxtFiyat.Location = new System.Drawing.Point(236, 265);
            this.TxtFiyat.Name = "TxtFiyat";
            this.TxtFiyat.Size = new System.Drawing.Size(187, 28);
            this.TxtFiyat.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Georgia", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(111, 268);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(118, 21);
            this.label5.TabIndex = 12;
            this.label5.Text = "Ürün Fiyat:";
            // 
            // TxtKategori
            // 
            this.TxtKategori.Location = new System.Drawing.Point(236, 299);
            this.TxtKategori.Name = "TxtKategori";
            this.TxtKategori.Size = new System.Drawing.Size(187, 28);
            this.TxtKategori.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Georgia", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(78, 302);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(151, 21);
            this.label6.TabIndex = 14;
            this.label6.Text = "Ürün Kategori:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(2, 366);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(788, 220);
            this.dataGridView1.TabIndex = 16;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // BtnUrunGuncelle
            // 
            this.BtnUrunGuncelle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(191)))), ((int)(((byte)(159)))));
            this.BtnUrunGuncelle.Location = new System.Drawing.Point(532, 284);
            this.BtnUrunGuncelle.Name = "BtnUrunGuncelle";
            this.BtnUrunGuncelle.Size = new System.Drawing.Size(218, 39);
            this.BtnUrunGuncelle.TabIndex = 20;
            this.BtnUrunGuncelle.Text = "Ürün Güncelle";
            this.BtnUrunGuncelle.UseVisualStyleBackColor = false;
            this.BtnUrunGuncelle.Click += new System.EventHandler(this.BtnUrunGuncelle_Click);
            // 
            // BtnUrunSil
            // 
            this.BtnUrunSil.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(191)))), ((int)(((byte)(159)))));
            this.BtnUrunSil.Location = new System.Drawing.Point(532, 237);
            this.BtnUrunSil.Name = "BtnUrunSil";
            this.BtnUrunSil.Size = new System.Drawing.Size(218, 39);
            this.BtnUrunSil.TabIndex = 19;
            this.BtnUrunSil.Text = "Ürün Sil";
            this.BtnUrunSil.UseVisualStyleBackColor = false;
            this.BtnUrunSil.Click += new System.EventHandler(this.BtnUrunSil_Click);
            // 
            // BtnUrunEkle
            // 
            this.BtnUrunEkle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(191)))), ((int)(((byte)(159)))));
            this.BtnUrunEkle.Location = new System.Drawing.Point(532, 191);
            this.BtnUrunEkle.Name = "BtnUrunEkle";
            this.BtnUrunEkle.Size = new System.Drawing.Size(218, 39);
            this.BtnUrunEkle.TabIndex = 18;
            this.BtnUrunEkle.Text = "Ürün Ekle";
            this.BtnUrunEkle.UseVisualStyleBackColor = false;
            this.BtnUrunEkle.Click += new System.EventHandler(this.BtnUrunEkle_Click);
            // 
            // BtnUrunListele
            // 
            this.BtnUrunListele.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(191)))), ((int)(((byte)(159)))));
            this.BtnUrunListele.Location = new System.Drawing.Point(532, 145);
            this.BtnUrunListele.Name = "BtnUrunListele";
            this.BtnUrunListele.Size = new System.Drawing.Size(218, 40);
            this.BtnUrunListele.TabIndex = 17;
            this.BtnUrunListele.Text = "Ürün Listele";
            this.BtnUrunListele.UseVisualStyleBackColor = false;
            this.BtnUrunListele.Click += new System.EventHandler(this.BtnUrunListele_Click);
            // 
            // TxtId
            // 
            this.TxtId.Location = new System.Drawing.Point(236, 128);
            this.TxtId.Name = "TxtId";
            this.TxtId.Size = new System.Drawing.Size(187, 28);
            this.TxtId.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Georgia", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(132, 131);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(92, 21);
            this.label7.TabIndex = 22;
            this.label7.Text = "Ürün Id:";
            // 
            // FrmUrunEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(242)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(793, 583);
            this.Controls.Add(this.TxtId);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.BtnUrunGuncelle);
            this.Controls.Add(this.BtnUrunSil);
            this.Controls.Add(this.BtnUrunEkle);
            this.Controls.Add(this.BtnUrunListele);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.TxtKategori);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.TxtFiyat);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TxtStok);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TxtMarka);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TxtAd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panelTitleBar);
            this.Font = new System.Drawing.Font("Georgia", 10.8F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmUrunEkle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmUrunEkle";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FrmUrunEkle_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.FrmUrunEkle_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.FrmUrunEkle_MouseUp);
            this.panelTitleBar.ResumeLayout(false);
            this.panelTitleBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelTitleBar;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconButton BtnMinimize;
        private FontAwesome.Sharp.IconButton BtnClose;
        private FontAwesome.Sharp.IconButton BtnMaximize;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtAd;
        private System.Windows.Forms.TextBox TxtMarka;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtStok;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtFiyat;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TxtKategori;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button BtnUrunGuncelle;
        private System.Windows.Forms.Button BtnUrunSil;
        private System.Windows.Forms.Button BtnUrunEkle;
        private System.Windows.Forms.Button BtnUrunListele;
        private System.Windows.Forms.TextBox TxtId;
        private System.Windows.Forms.Label label7;
    }
}