using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ETicaretUyg_CodeFirst.Entity;

namespace ETicaretUyg_CodeFirst
{
    public partial class FrmAnaForm : Form
    {
        // Fields
        private int borderSize = 2;
        private bool isMenuCollapsed = false;
        private DbETicaretEntities db;
        private bool formDragging;
        private int mouseX;
        private int mouseY;


        public FrmAnaForm()
        {
            InitializeComponent();
            db = new DbETicaretEntities();
            CollapseMenu();
            this.Padding = new Padding(borderSize);  // border size
            this.BackColor = Color.FromArgb(82, 95, 225); // border color
        }

        private void CollapseMenu()
        {
            isMenuCollapsed = !isMenuCollapsed;
            PanelMenu.Width = isMenuCollapsed ? 100 : 230;
            pictureBox1.Visible = !isMenuCollapsed;
            BtnMenu.Dock = isMenuCollapsed ? DockStyle.Top : DockStyle.None;

            foreach (Button menuButton in PanelMenu.Controls.OfType<Button>())
            {
                if (isMenuCollapsed)
                {
                    menuButton.Text = "";
                    menuButton.ImageAlign = ContentAlignment.MiddleCenter;
                    menuButton.Padding = new Padding(0);
                }
                else
                {
                    menuButton.Text = "   " + menuButton.Tag.ToString();
                    menuButton.ImageAlign = ContentAlignment.MiddleLeft;
                    menuButton.Padding = new Padding(10, 0, 0, 0);
                }
            }
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void panelTitleBar_MouseDown_1(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        protected override void WndProc(ref Message m)
        {
            const int WM_NCCALCSIZE = 0x0083;
            const int WM_SYSCOMMAND = 0x0112;
            const int SC_MINIMIZE = 0xF020;
            const int SC_RESTORE = 0xF120;
            const int WM_NCHITTEST = 0x0084;
            const int resizeAreaSize = 10;

            // Resize/WM_NCHITTEST values
            const int HTCLIENT = 1;
            const int HTLEFT = 10;
            const int HTRIGHT = 11;
            const int HTTOP = 12;
            const int HTTOPLEFT = 13;
            const int HTTOPRIGHT = 14;
            const int HTBOTTOM = 15;
            const int HTBOTTOMLEFT = 16;
            const int HTBOTTOMRIGHT = 17;

            if (m.Msg == WM_NCCALCSIZE && m.WParam.ToInt32() == 1)
            {
                return;
            }
            else if (m.Msg == WM_NCHITTEST)
            {
                base.WndProc(ref m);
                if (this.WindowState == FormWindowState.Normal)
                {
                    if ((int)m.Result == HTCLIENT)
                    {
                        Point screenPoint = new Point(m.LParam.ToInt32());
                        Point clientPoint = this.PointToClient(screenPoint);

                        if (clientPoint.Y <= resizeAreaSize)
                        {
                            if (clientPoint.X <= resizeAreaSize)
                                m.Result = (IntPtr)HTTOPLEFT;
                            else if (clientPoint.X < (this.Size.Width - resizeAreaSize))
                                m.Result = (IntPtr)HTTOP;
                            else
                                m.Result = (IntPtr)HTTOPRIGHT;
                        }
                        else if (clientPoint.Y <= (this.Size.Height - resizeAreaSize))
                        {
                            if (clientPoint.X <= resizeAreaSize)
                                m.Result = (IntPtr)HTLEFT;
                            else if (clientPoint.X > (this.Size.Width - resizeAreaSize))
                                m.Result = (IntPtr)HTRIGHT;
                        }
                        else
                        {
                            if (clientPoint.X <= resizeAreaSize)
                                m.Result = (IntPtr)HTBOTTOMLEFT;
                            else if (clientPoint.X < (this.Size.Width - resizeAreaSize))
                                m.Result = (IntPtr)HTBOTTOM;
                            else
                                m.Result = (IntPtr)HTBOTTOMRIGHT;
                        }
                    }
                }
                return;
            }
            else if (m.Msg == WM_SYSCOMMAND && (int)m.WParam == SC_MINIMIZE)
            {
                // Minimize form
                // Add your custom code here
                return;
            }
            else if (m.Msg == WM_SYSCOMMAND && (int)m.WParam == SC_RESTORE)
            {
                // Restore form
                // Add your custom code here
                return;
            }

            base.WndProc(ref m);
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            AdjustForm();
        }

        private void AdjustForm()
        {
            switch (this.WindowState)
            {
                case FormWindowState.Maximized: //Maximized form (After)
                    this.Padding = new Padding(8, 8, 8, 0);
                    break;
                case FormWindowState.Normal: //Restored form (After)
                    if (this.Padding.Top != borderSize)
                        this.Padding = new Padding(borderSize);
                    break;
            }
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

        private void BtnMenu_Click(object sender, EventArgs e)
        {
            CollapseMenu();
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            formDragging = true;
            mouseX = e.X;
            mouseY = e.Y;
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (formDragging)
            {
                int newX = this.Left + (e.X - mouseX);
                int newY = this.Top + (e.Y - mouseY);
                this.Location = new Point(newX, newY);
            }
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            formDragging = false;
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            Context cont = new Context();
            if (!cont.Database.Exists())
            {
                cont.Database.Create();
            }

            LblToplamKategori.Text = cont.Urunlers.Count().ToString();
            LblSiparisToplam.Text = cont.Siparislers.Count().ToString();
            LblKasaTutarAy.Text = cont.Siparislers.Sum(x => x.SiparisToplamFiyat).ToString() + " TL";
            LblToplamStok.Text = cont.Urunlers.Sum(x => x.UrunStok).ToString();
            LblYuksekFiyatUrun.Text = (from x in cont.Urunlers orderby x.UrunFiyat descending select x.UrunAd).FirstOrDefault()?.ToString();
            LblDusukFiyatUrun.Text = (from x in cont.Urunlers orderby x.UrunFiyat ascending select x.UrunAd).FirstOrDefault()?.ToString();
            //LblFazlaUrunluMarka.Text = cont.Urunlers.FirstOrDefault()?.ToString();
            //LblFazlaUrunluMarka.Text = db.Urunlers().FirstOrDefault();
            //LblFazlaUrunluMarka.Text = db.Urunlers().FirstOrDefault(Urunlers).Marka;


        }

        private void ıconButton4_MouseClick(object sender, MouseEventArgs e)
        {
            Frm_Veriler fr = new Frm_Veriler();
            fr.Show();
            this.Hide();
        }

        private void ıconButton3_Click(object sender, EventArgs e)
        {
            FrmGrafikler fr= new FrmGrafikler();
            fr.Show();
            this.Hide();
        }
    }
}

