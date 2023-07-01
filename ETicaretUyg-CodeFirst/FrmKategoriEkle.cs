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
    public partial class FrmKategoriEkle : Form
    {
        private DbETicaretEntities db;
        private bool isDragging;
        private int mouseX;
        private int mouseY;
        public FrmKategoriEkle()
        {
            InitializeComponent();
            db = new DbETicaretEntities();
        }


        private void dataGridView1_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            TxtId.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            TxtAd.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
        }

        private void BtnKategoriListele_Click_1(object sender, EventArgs e)
        {
            dataGridView1.DataSource = (from x in db.Kategorilers
                                        select new
                                        {
                                            x.KategoriId,
                                            x.KategoriAd
                                        }).ToList();
        }

        private void BtnKategoriiEkle_Click(object sender, EventArgs e)
        {
            Kategorilers ktg = new Kategorilers();
            ktg.KategoriAd = TxtAd.Text;
            db.Kategorilers.Add(ktg);
            db.SaveChanges();
            MessageBox.Show("Kategori Sisteme Kaydedildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void BtnKategoriSil_Click(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(TxtId.Text);
            var si = db.Siparislers.Find(x);  // Urun değişkenine Tbl_Urun tablosundaki x'in karşılığı olan id değerinin olduğu satırı bul.
            db.Siparislers.Remove(si);        //Tbl_kategori içerisinde ktgr den gelen değeri kaldır
            db.SaveChanges();
            MessageBox.Show("Kategori Silindi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void BtnKategoriGuncelle_Click_1(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(TxtId.Text);
            var sip = db.Kategorilers.Find(x);
            sip.KategoriAd = TxtAd.Text;
            db.SaveChanges();
            MessageBox.Show("Kategori Güncellendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            this.Close();
        }

        private void FrmKategoriEkle_MouseDown(object sender, MouseEventArgs e)
        {
            isDragging = true;
            mouseX = e.X;
            mouseY = e.Y;
        }

        private void FrmKategoriEkle_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDragging)
            {
                int newX = this.Left + (e.X - mouseX);
                int newY = this.Top + (e.Y - mouseY);
                this.Location = new Point(newX, newY);
            }
        }

        private void FrmKategoriEkle_MouseUp(object sender, MouseEventArgs e)
        {
            isDragging = false;
        }
    }
}