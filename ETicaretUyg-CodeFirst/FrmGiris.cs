using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Input;
using ETicaretUyg_CodeFirst.Entity;

namespace ETicaretUyg_CodeFirst
{
    public partial class FrmGiris : Form
    {
        private DbETicaretEntities db;
        private bool isDragging;
        private int mouseX;
        private int mouseY;

        public FrmGiris()
        {
            InitializeComponent();
            db = new DbETicaretEntities();
        }

        private void BtnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void BtnMaximize_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
                this.WindowState = FormWindowState.Maximized;
            else
                this.WindowState = FormWindowState.Normal;
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnGiris_Click(object sender, EventArgs e)
        {
            string username = TxtAd.Text.Trim();
            string password = TxtSifre.Text.Trim();

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Kullanıcı adı ve şifre gereklidir.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int parsedPassword;
            bool isPasswordValid = int.TryParse(password, out parsedPassword);

            if (!isPasswordValid)
            {
                MessageBox.Show("Geçersiz şifre formatı.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var query = from x in db.Admins
                        where x.AdminAd == username && x.AdminSifre == parsedPassword
                        select x;

            if (query.Any())
            {
                FrmAnaForm frm = new FrmAnaForm();
                frm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Kullanıcı Adı veya Şifre Yanlış!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void FrmGiris_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            isDragging = true;
            mouseX = e.X;
            mouseY = e.Y;
        }

        private void FrmGiris_MouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            isDragging = false;
        }

        private void FrmGiris_MouseMove(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            if (isDragging)
            {
                int newX = this.Left + (e.X - mouseX);
                int newY = this.Top + (e.Y - mouseY);
                this.Location = new Point(newX, newY);
            }
        }
    }
}

