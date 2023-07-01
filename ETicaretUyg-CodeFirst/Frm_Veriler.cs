using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ETicaretUyg_CodeFirst.Entity;

namespace ETicaretUyg_CodeFirst
{
    public partial class Frm_Veriler : Form
    {
        private bool formDragging;
        private int mouseX;
        private int mouseY;
        public Frm_Veriler()
        {
            InitializeComponent();
        }

        DbETicaretEntities db = new DbETicaretEntities();
        private bool isDragging = false;
        private Point lastLocation;



        private void BtnMinimize_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void BtnMaximize_Click_1(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
                this.WindowState = FormWindowState.Maximized;
            else
                this.WindowState = FormWindowState.Normal;
        }

        private void Frm_Veriler_MouseMove(object sender, MouseEventArgs e)
        {
            if (formDragging)
            {
                int newX = this.Left + (e.X - mouseX);
                int newY = this.Top + (e.Y - mouseY);
                this.Location = new Point(newX, newY);
            }
        }

        private void Frm_Veriler_MouseUp(object sender, MouseEventArgs e)
        {
            formDragging = false;
        }

        private void Frm_Veriler_MouseDown(object sender, MouseEventArgs e)
        {
            formDragging = true;
            mouseX = e.X;
            mouseY = e.Y;
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }



        private void ıconButton2_MouseClick(object sender, MouseEventArgs e)
        {
            FrmAnaForm fr= new FrmAnaForm();
            fr.Show();
            this.Hide();
        }

        private void BtnUrunListele_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = (from x in db.Urunlers
                                        select new
                                        {
                                            x.UrunId,
                                            x.UrunAd,
                                            x.UrunMarka,
                                            x.UrunStok,
                                            x.UrunFiyat,
                                            x.UrunKategori
                                        }).ToList();
        }

        private void BtnMusteriListele_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = (from x in db.Musterilers
                                        select new
                                        {
                                            x.MusteriId,
                                            x.MusteriAd,
                                            x.MusteriSoyad,
                                            x.MusteriEmail,
                                            x.MusteriTelefon,
                                            x.MusteriSifre
                                        }).ToList();
        }

        private void BtnSiparisListele_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = (from x in db.Siparislers
                                        select new
                                        {
                                            x.SiparisId,
                                            x.SiparisTarih,
                                            x.SiparisToplamFiyat,
                                            x.Musterilers.MusteriId
                                        }).ToList();
        }

        private void BtnKategoriListele_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = (from x in db.Kategorilers
                                        select new
                                        {
                                            x.KategoriId,
                                            x.KategoriAd
                                        }).ToList();
        }

        private void BtnUrunEkle_Click_1(object sender, EventArgs e)
        {
            FrmUrunEkle fr = new FrmUrunEkle();
            fr.Show();
        }

        private void BtnMusteriEkle_Click(object sender, EventArgs e)
        {
            FrmMusteriEkle fr = new FrmMusteriEkle();
            fr.Show();
        }

        private void Frm_Veriler_Load(object sender, EventArgs e)
        {
            dataGridView1.CellFormatting += dataGridView1_CellFormatting;
        }

        private void BtnSiparisEkle_Click(object sender, EventArgs e)
        {
            FrmSiparisEkle fr = new FrmSiparisEkle();
            fr.Show();
        }

        private void BtnKategoriEkle_Click(object sender, EventArgs e)
        {
            FrmKategoriEkle fr = new FrmKategoriEkle(); 
            fr.Show();
        }

        private void IconBtnAra_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex % 2 == 0) // Çift satır indeksi
            {
                e.CellStyle.BackColor = Color.FromArgb(236, 242, 255); // Çift satırların arka plan rengini belirleyin
                e.CellStyle.ForeColor = Color.Black; // Çift satırların metin rengini belirleyin
            }
            else // Tek satır indeksi
            {
                e.CellStyle.BackColor = Color.White; // Tek satırların arka plan rengini belirleyin
                e.CellStyle.ForeColor = Color.Black; // Tek satırların metin rengini belirleyin
            }
        }

        private void ıconButton3_Click(object sender, EventArgs e)
        {
            FrmGrafikler fr= new FrmGrafikler();
            fr.Show();
            this.Hide();
        }
    }
}
