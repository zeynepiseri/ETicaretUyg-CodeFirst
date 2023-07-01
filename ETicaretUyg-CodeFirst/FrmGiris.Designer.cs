namespace ETicaretUyg_CodeFirst
{
    partial class FrmGiris
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmGiris));
            this.panelTitleBar = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnMinimize = new FontAwesome.Sharp.IconButton();
            this.BtnClose = new FontAwesome.Sharp.IconButton();
            this.BtnMaximize = new FontAwesome.Sharp.IconButton();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtAd = new System.Windows.Forms.TextBox();
            this.TxtSifre = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.BtnGiris = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelTitleBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTitleBar
            // 
            this.panelTitleBar.BackColor = System.Drawing.Color.White;
            this.panelTitleBar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelTitleBar.Controls.Add(this.pictureBox1);
            this.panelTitleBar.Controls.Add(this.label1);
            this.panelTitleBar.Controls.Add(this.BtnMinimize);
            this.panelTitleBar.Controls.Add(this.BtnClose);
            this.panelTitleBar.Controls.Add(this.BtnMaximize);
            this.panelTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitleBar.Location = new System.Drawing.Point(0, 0);
            this.panelTitleBar.Name = "panelTitleBar";
            this.panelTitleBar.Size = new System.Drawing.Size(734, 63);
            this.panelTitleBar.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(302, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 21);
            this.label1.TabIndex = 5;
            this.label1.Text = "DASHBOARD";
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
            this.BtnMinimize.Location = new System.Drawing.Point(606, 0);
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
            this.BtnClose.Location = new System.Drawing.Point(690, 0);
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
            this.BtnMaximize.Location = new System.Drawing.Point(648, 0);
            this.BtnMaximize.Name = "BtnMaximize";
            this.BtnMaximize.Size = new System.Drawing.Size(42, 25);
            this.BtnMaximize.TabIndex = 2;
            this.BtnMaximize.UseVisualStyleBackColor = false;
            this.BtnMaximize.Click += new System.EventHandler(this.BtnMaximize_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Georgia", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(239, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 21);
            this.label2.TabIndex = 3;
            this.label2.Text = "Ad:";
            // 
            // TxtAd
            // 
            this.TxtAd.Location = new System.Drawing.Point(289, 120);
            this.TxtAd.Name = "TxtAd";
            this.TxtAd.Size = new System.Drawing.Size(202, 28);
            this.TxtAd.TabIndex = 4;
            this.TxtAd.Text = "Aylin Koca";
            // 
            // TxtSifre
            // 
            this.TxtSifre.Location = new System.Drawing.Point(289, 154);
            this.TxtSifre.Name = "TxtSifre";
            this.TxtSifre.Size = new System.Drawing.Size(202, 28);
            this.TxtSifre.TabIndex = 6;
            this.TxtSifre.Text = "1222";
            this.TxtSifre.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Georgia", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(224, 157);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 21);
            this.label3.TabIndex = 5;
            this.label3.Text = "Şifre:";
            // 
            // BtnGiris
            // 
            this.BtnGiris.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(95)))), ((int)(((byte)(225)))));
            this.BtnGiris.Location = new System.Drawing.Point(307, 206);
            this.BtnGiris.Name = "BtnGiris";
            this.BtnGiris.Size = new System.Drawing.Size(157, 40);
            this.BtnGiris.TabIndex = 7;
            this.BtnGiris.Text = "Giriş Yap";
            this.BtnGiris.UseVisualStyleBackColor = false;
            this.BtnGiris.Click += new System.EventHandler(this.BtnGiris_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(11, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(138, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // FrmGiris
            // 
            this.AcceptButton = this.BtnGiris;
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(242)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(734, 296);
            this.Controls.Add(this.BtnGiris);
            this.Controls.Add(this.TxtSifre);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TxtAd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panelTitleBar);
            this.Font = new System.Drawing.Font("Georgia", 10.8F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmGiris";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmGiriis";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FrmGiris_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.FrmGiris_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.FrmGiris_MouseUp);
            this.panelTitleBar.ResumeLayout(false);
            this.panelTitleBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private System.Windows.Forms.TextBox TxtSifre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BtnGiris;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}