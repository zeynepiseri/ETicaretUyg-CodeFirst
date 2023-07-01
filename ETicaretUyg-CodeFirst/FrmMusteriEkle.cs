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
    public partial class FrmMusteriEkle : Form
    {
        private DbETicaretEntities db;
        private bool formDragging;
        private int mouseX;
        private int mouseY;

        public FrmMusteriEkle()
        {
            InitializeComponent();
            db = new DbETicaretEntities();
        }


        private void BtnMüşteriListele_Click(object sender, EventArgs e)
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

        private void dataGridView1_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            TxtId.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            TxtAd.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            TxtSoyad.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            TxtEmail.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            TxtTelefon.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            TxtSifre.Text = dataGridView1.Rows[secilen].Cells[5].Value.ToString();
        }

        private void BtnMusteriSil_Click(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(TxtId.Text);
            var urun = db.Musterilers.Find(x);  // Urun değişkenine Tbl_Urun tablosundaki x'in karşılığı olan id değerinin olduğu satırı bul.
            db.Musterilers.Remove(urun);        //Tbl_kategori içerisinde ktgr den gelen değeri kaldır
            db.SaveChanges();
            MessageBox.Show("Ürün Silindi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void BtnMusteriGuncelle_Click(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(TxtId.Text);
            var mus = db.Musterilers.Find(x);
            mus.MusteriAd = TxtAd.Text;
            mus.MusteriSoyad = TxtSoyad.Text;
            mus.MusteriEmail = TxtEmail.Text;
            mus.MusteriTelefon = TxtTelefon.Text;
            mus.MusteriSifre = Convert.ToInt16(TxtSifre.Text);
            db.SaveChanges();
            MessageBox.Show("Ürün Güncellendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void BtnMusteriEkle_Click(object sender, EventArgs e)
        {
            Musterilers mus = new Musterilers();
            mus.MusteriAd = TxtAd.Text;
            mus.MusteriSoyad = TxtSoyad.Text;
            mus.MusteriEmail = TxtEmail.Text;
            mus.MusteriTelefon =TxtTelefon.Text;
            mus.MusteriSifre = Convert.ToInt16(TxtSifre.Text);
            mus.MusteriAd = TxtAd.Text;
            db.Musterilers.Add(mus);
            db.SaveChanges();
            MessageBox.Show("Müşteri Sisteme Kaydedildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

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

        private void BtnClose_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmMusteriEkle_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            formDragging = true;
            mouseX = e.X;
            mouseY = e.Y;
        }

        private void FrmMusteriEkle_MouseMove(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            if (formDragging)
            {
                int newX = this.Left + (e.X - mouseX);
                int newY = this.Top + (e.Y - mouseY);
                this.Location = new Point(newX, newY);
            }
        }

        private void FrmMusteriEkle_MouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            formDragging = false;
        }
    }
}