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
    public partial class FrmUrunEkle : Form
    {
        private DbETicaretEntities db;
        private bool formDragging;
        private int mouseX;
        private int mouseY;

        public FrmUrunEkle()
        {
            InitializeComponent();
            db = new DbETicaretEntities();
        }
        //ETicaretUyg_CodeFirst db=new ETicaretUyg_CodeFirst();
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

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            TxtId.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            TxtAd.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            TxtMarka.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            TxtStok.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            TxtFiyat.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            TxtKategori.Text = dataGridView1.Rows[secilen].Cells[5].Value.ToString();
        }

        private void BtnUrunEkle_Click(object sender, EventArgs e)
        {
            Urunlers tbu = new Urunlers();
            tbu.UrunAd = TxtAd.Text;
            tbu.UrunMarka = TxtMarka.Text;
            tbu.UrunStok = Convert.ToInt16(TxtStok.Text);
            tbu.UrunKategori=TxtKategori.Text;
            tbu.UrunFiyat=Convert.ToInt16(TxtFiyat.Text);
            db.Urunlers.Add(tbu);
            db.SaveChanges();
            MessageBox.Show("Ürün Sisteme Kaydedildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void BtnUrunSil_Click(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(TxtId.Text);
            var urun = db.Urunlers.Find(x);  // Urun değişkenine Tbl_Urun tablosundaki x'in karşılığı olan id değerinin olduğu satırı bul.
            db.Urunlers.Remove(urun);        //Tbl_kategori içerisinde ktgr den gelen değeri kaldır
            db.SaveChanges();
            MessageBox.Show("Ürün Silindi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void BtnUrunGuncelle_Click(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(TxtId.Text);
            var urun = db.Urunlers.Find(x);
            urun.UrunAd = TxtAd.Text;
            urun.UrunMarka = TxtMarka.Text;
            urun.UrunStok = short.Parse(TxtStok.Text);
            urun.UrunFiyat = decimal.Parse(TxtFiyat.Text);
            urun.UrunKategori = TxtKategori.Text;
            db.SaveChanges();
            MessageBox.Show("Ürün Güncellendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void FrmUrunEkle_MouseDown(object sender, MouseEventArgs e)
        {
            formDragging = true;
            mouseX = e.X;
            mouseY = e.Y;
        }

        private void FrmUrunEkle_MouseMove(object sender, MouseEventArgs e)
        {
            if (formDragging)
            {
                int newX = this.Left + (e.X - mouseX);
                int newY = this.Top + (e.Y - mouseY);
                this.Location = new Point(newX, newY);
            }
        }

        private void FrmUrunEkle_MouseUp(object sender, MouseEventArgs e)
        {
            formDragging = false;
        }
    }
}