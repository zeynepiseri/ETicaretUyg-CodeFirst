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
    public partial class FrmSiparisEkle : Form
    {
        private DbETicaretEntities db;
        private bool formDragging;
        private int mouseX;
        private int mouseY;

        public FrmSiparisEkle()
        {
            InitializeComponent();
            db = new DbETicaretEntities();
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

        private void BtnMusteriListele_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = (from x in db.Siparislers
                                        select new
                                        {
                                            x.SiparisId,
                                            x.Musterilers.MusteriId,
                                            x.SiparisTarih,
                                            x.SiparisToplamFiyat
                                        }).ToList();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            TxtSiparisId.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            TxtSiparisTarih.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            TxtToplamFiyat.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            TxtMusteriId.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
        }

        private void BtnSiparisiEkle_Click(object sender, EventArgs e)
        {
            Siparislers sip = new Siparislers();
            sip.SiparisTarih = Convert.ToDateTime(TxtSiparisTarih.Text);
            sip.SiparisToplamFiyat = Convert.ToInt16(TxtToplamFiyat.Text);
            db.Siparislers.Add(sip);
            db.SaveChanges();
            MessageBox.Show("Sipariş Sisteme Kaydedildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void BtnSiparisSil_Click(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(TxtSiparisId.Text);
            var si = db.Siparislers.Find(x);  // Urun değişkenine Tbl_Urun tablosundaki x'in karşılığı olan id değerinin olduğu satırı bul.
            db.Siparislers.Remove(si);        //Tbl_kategori içerisinde ktgr den gelen değeri kaldır
            db.SaveChanges();
            MessageBox.Show("Sipariş Silindi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void BtnSiparisGuncelle_Click(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(TxtSiparisId.Text);
            var sip = db.Siparislers.Find(x);
            sip.SiparisTarih = Convert.ToDateTime(TxtSiparisTarih.Text);
            sip.SiparisToplamFiyat = Convert.ToInt16(TxtToplamFiyat.Text);
            db.SaveChanges();
            MessageBox.Show("Sipariş Güncellendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void FrmSiparisEkle_MouseDown(object sender, MouseEventArgs e)
        {
            formDragging = true;
            mouseX = e.X;
            mouseY = e.Y;
        }

        private void FrmSiparisEkle_MouseMove(object sender, MouseEventArgs e)
        {
            if (formDragging)
            {
                int newX = this.Left + (e.X - mouseX);
                int newY = this.Top + (e.Y - mouseY);
                this.Location = new Point(newX, newY);
            }
        }

        private void FrmSiparisEkle_MouseUp(object sender, MouseEventArgs e)
        {
            formDragging = false;
        }
    }
}