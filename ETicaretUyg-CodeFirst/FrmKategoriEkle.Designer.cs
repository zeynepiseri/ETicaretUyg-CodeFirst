namespace ETicaretUyg_CodeFirst
{
    partial class FrmKategoriEkle
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
            this.TxtAd = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panelTitleBar = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnMinimize = new FontAwesome.Sharp.IconButton();
            this.BtnClose = new FontAwesome.Sharp.IconButton();
            this.BtnMaximize = new FontAwesome.Sharp.IconButton();
            this.TxtId = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.BtnKategoriGuncelle = new System.Windows.Forms.Button();
            this.BtnKategoriSil = new System.Windows.Forms.Button();
            this.BtnKategoriiEkle = new System.Windows.Forms.Button();
            this.BtnKategoriListele = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panelTitleBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // TxtAd
            // 
            this.TxtAd.Location = new System.Drawing.Point(190, 249);
            this.TxtAd.Name = "TxtAd";
            this.TxtAd.Size = new System.Drawing.Size(189, 28);
            this.TxtAd.TabIndex = 73;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Georgia", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(57, 252);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 21);
            this.label4.TabIndex = 74;
            this.label4.Text = "Kategori Ad:";
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
            this.panelTitleBar.Size = new System.Drawing.Size(745, 60);
            this.panelTitleBar.TabIndex = 64;
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
            this.BtnMinimize.Location = new System.Drawing.Point(617, 0);
            this.BtnMinimize.Name = "BtnMinimize";
            this.BtnMinimize.Size = new System.Drawing.Size(42, 25);
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
            this.BtnClose.Location = new System.Drawing.Point(701, 0);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(42, 25);
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
            this.BtnMaximize.Location = new System.Drawing.Point(659, 0);
            this.BtnMaximize.Name = "BtnMaximize";
            this.BtnMaximize.Size = new System.Drawing.Size(42, 25);
            this.BtnMaximize.TabIndex = 2;
            this.BtnMaximize.UseVisualStyleBackColor = false;
            this.BtnMaximize.Click += new System.EventHandler(this.BtnMaximize_Click);
            // 
            // TxtId
            // 
            this.TxtId.Location = new System.Drawing.Point(190, 215);
            this.TxtId.Name = "TxtId";
            this.TxtId.Size = new System.Drawing.Size(189, 28);
            this.TxtId.TabIndex = 61;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Georgia", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(64, 218);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(121, 21);
            this.label7.TabIndex = 72;
            this.label7.Text = "Kategori Id:";
            // 
            // BtnKategoriGuncelle
            // 
            this.BtnKategoriGuncelle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(95)))), ((int)(((byte)(225)))));
            this.BtnKategoriGuncelle.Location = new System.Drawing.Point(487, 293);
            this.BtnKategoriGuncelle.Name = "BtnKategoriGuncelle";
            this.BtnKategoriGuncelle.Size = new System.Drawing.Size(220, 39);
            this.BtnKategoriGuncelle.TabIndex = 71;
            this.BtnKategoriGuncelle.Text = "Kategori Güncelle";
            this.BtnKategoriGuncelle.UseVisualStyleBackColor = false;
            this.BtnKategoriGuncelle.Click += new System.EventHandler(this.BtnKategoriGuncelle_Click_1);
            // 
            // BtnKategoriSil
            // 
            this.BtnKategoriSil.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(95)))), ((int)(((byte)(225)))));
            this.BtnKategoriSil.Location = new System.Drawing.Point(487, 246);
            this.BtnKategoriSil.Name = "BtnKategoriSil";
            this.BtnKategoriSil.Size = new System.Drawing.Size(220, 39);
            this.BtnKategoriSil.TabIndex = 70;
            this.BtnKategoriSil.Text = "Kategori Sil";
            this.BtnKategoriSil.UseVisualStyleBackColor = false;
            this.BtnKategoriSil.Click += new System.EventHandler(this.BtnKategoriSil_Click);
            // 
            // BtnKategoriiEkle
            // 
            this.BtnKategoriiEkle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(95)))), ((int)(((byte)(225)))));
            this.BtnKategoriiEkle.Location = new System.Drawing.Point(487, 200);
            this.BtnKategoriiEkle.Name = "BtnKategoriiEkle";
            this.BtnKategoriiEkle.Size = new System.Drawing.Size(220, 39);
            this.BtnKategoriiEkle.TabIndex = 69;
            this.BtnKategoriiEkle.Text = "Kategori Ekle";
            this.BtnKategoriiEkle.UseVisualStyleBackColor = false;
            this.BtnKategoriiEkle.Click += new System.EventHandler(this.BtnKategoriiEkle_Click);
            // 
            // BtnKategoriListele
            // 
            this.BtnKategoriListele.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(95)))), ((int)(((byte)(225)))));
            this.BtnKategoriListele.Location = new System.Drawing.Point(487, 154);
            this.BtnKategoriListele.Name = "BtnKategoriListele";
            this.BtnKategoriListele.Size = new System.Drawing.Size(220, 40);
            this.BtnKategoriListele.TabIndex = 68;
            this.BtnKategoriListele.Text = "Kategori Listele";
            this.BtnKategoriListele.UseVisualStyleBackColor = false;
            this.BtnKategoriListele.Click += new System.EventHandler(this.BtnKategoriListele_Click_1);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 429);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(745, 220);
            this.dataGridView1.TabIndex = 67;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick_1);
            // 
            // FrmKategoriEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(242)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(745, 646);
            this.Controls.Add(this.TxtAd);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panelTitleBar);
            this.Controls.Add(this.TxtId);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.BtnKategoriGuncelle);
            this.Controls.Add(this.BtnKategoriSil);
            this.Controls.Add(this.BtnKategoriiEkle);
            this.Controls.Add(this.BtnKategoriListele);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Georgia", 10.8F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmKategoriEkle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmKategoriiEkle";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FrmKategoriEkle_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.FrmKategoriEkle_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.FrmKategoriEkle_MouseUp);
            this.panelTitleBar.ResumeLayout(false);
            this.panelTitleBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtAd;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panelTitleBar;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconButton BtnMinimize;
        private FontAwesome.Sharp.IconButton BtnClose;
        private FontAwesome.Sharp.IconButton BtnMaximize;
        private System.Windows.Forms.TextBox TxtId;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button BtnKategoriGuncelle;
        private System.Windows.Forms.Button BtnKategoriSil;
        private System.Windows.Forms.Button BtnKategoriiEkle;
        private System.Windows.Forms.Button BtnKategoriListele;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}