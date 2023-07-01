using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ETicaretUyg_CodeFirst.Entity;


namespace ETicaretUyg_CodeFirst
{
    public partial class FrmGrafikler : Form
    {
        private DbETicaretEntities db;
        private bool formDragging;
        private int mouseX;
        private int mouseY;

        public FrmGrafikler()
        {
            InitializeComponent();
        }

        private void panelDesktop_MouseDown(object sender, MouseEventArgs e)
        {
            formDragging = true;
            mouseX = e.X;
            mouseY = e.Y;
        }

        private void panelDesktop_MouseMove(object sender, MouseEventArgs e)
        {
            if (formDragging)
            {
                int newX = Left + (e.X - mouseX);
                int newY = Top + (e.Y - mouseY);
                Location = new Point(newX, newY);
            }
        }

        private void panelDesktop_MouseUp(object sender, MouseEventArgs e)
        {
            formDragging = false;
        }

        private void FrmGrafikler_Load(object sender, EventArgs e)
        {
            var urunler = db.Siparislers.Select(u => new { MusteriAd = u.MusteriId, SatisMiktari = u.SiparisToplamFiyat }).ToList();

            // Chart kontrolüne verileri ekleme işlemleri burada yapılır
            // Örneğin:
            foreach (var urun in urunler)
            {
                chart1.Series["Satış Miktarları"].Points.AddXY(urun.MusteriAd, urun.SatisMiktari);
            }



        }

        private void ıconButton4_Click(object sender, EventArgs e)
        {
            Frm_Veriler fr = new Frm_Veriler();
            fr.Show();
            this.Hide();
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
    }
}
