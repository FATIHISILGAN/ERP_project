using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace exERP_Full
{
    public partial class yönetici : Form
    {

        SqlConnection bağlantı = new SqlConnection("Data Source=DESKTOP-JUST06P\\MSSQLSERVER01;Initial Catalog=ERP_iki; Integrated Security=True;");
        public yönetici()
        {
            InitializeComponent();
        }
        bool çalışanbl, stokbl, satışbl;

        bool dragging;

        Point offset;

        public void görüntüle(string veri)
        {
            SqlDataAdapter DA = new SqlDataAdapter(veri, bağlantı);
            DataSet DS = new DataSet();
            DA.Fill(DS);

            db_görüntüleyici.DataSource = DS.Tables[0];


        }
        private void label5_Click(object sender, EventArgs e)//hakkında click
        {
            hakkında h = new hakkında();
            h.Show();

        }

        private void yönetici_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point currentScreenPos = PointToScreen(e.Location);
                Location = new
                Point(currentScreenPos.X - offset.X,
                currentScreenPos.Y - offset.Y);
            }
        }

        private void yönetici_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }

        private void yönetici_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            offset = e.Location;
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point currentScreenPos = PointToScreen(e.Location);
                Location = new
                Point(currentScreenPos.X - offset.X,
                currentScreenPos.Y - offset.Y);
            }
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            offset = e.Location;
        }

        private void panel2_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point currentScreenPos = PointToScreen(e.Location);
                Location = new
                Point(currentScreenPos.X - offset.X,
                currentScreenPos.Y - offset.Y);
            }
        }

        private void panel2_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            offset = e.Location;
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point currentScreenPos = PointToScreen(e.Location);
                Location = new
                Point(currentScreenPos.X - offset.X,
                currentScreenPos.Y - offset.Y);
            }
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            offset = e.Location;
        }

        private void anasayfa_pnl_MouseLeave(object sender, EventArgs e)
        {
            anasayfa_pnl.BackColor = Color.FromArgb(45, 45, 51);

        }

        private void anasayfa_pnl_MouseMove(object sender, MouseEventArgs e)
        {
            anasayfa_pnl.BackColor = Color.FromArgb(60, 60, 40);
        }

        private void anasayfa_pic_MouseMove(object sender, MouseEventArgs e)
        {
            anasayfa_pnl.BackColor = Color.FromArgb(60, 60, 40);

        }

        private void anasayfa_pic_MouseLeave(object sender, EventArgs e)
        {
            anasayfa_pnl.BackColor = Color.FromArgb(45, 45, 51);

        }

        private void anasayfa_lbl_MouseMove(object sender, MouseEventArgs e)
        {
            anasayfa_pnl.BackColor = Color.FromArgb(60, 60, 40);

        }

        private void anasayfa_lbl_MouseLeave(object sender, EventArgs e)
        {
            anasayfa_pnl.BackColor = Color.FromArgb(45, 45, 51);

        }

        private void çalışanlar_pic_MouseMove(object sender, MouseEventArgs e)
        {
            çalışanlar_pnl.BackColor = Color.FromArgb(60, 60, 40);

        }

        private void çalışanlar_pic_MouseLeave(object sender, EventArgs e)
        {
            çalışanlar_pnl.BackColor = Color.FromArgb(45, 45, 51);

        }

        private void çalışanlar_lbl_MouseMove(object sender, MouseEventArgs e)
        {
            çalışanlar_pnl.BackColor = Color.FromArgb(60, 60, 40);

        }

        private void çalışanlar_lbl_MouseLeave(object sender, EventArgs e)
        {
            çalışanlar_pnl.BackColor = Color.FromArgb(45, 45, 51);

        }

        private void çalışanlar_pnl_MouseMove(object sender, MouseEventArgs e)
        {
            çalışanlar_pnl.BackColor = Color.FromArgb(60, 60, 40);

        }

        private void çalışanlar_pnl_MouseLeave(object sender, EventArgs e)
        {
            çalışanlar_pnl.BackColor = Color.FromArgb(45, 45, 51);

        }

        private void stok_pnl_MouseMove(object sender, MouseEventArgs e)
        {
           stok_pnl.BackColor = Color.FromArgb(60, 60, 40);

        }

        private void stok_pnl_MouseLeave(object sender, EventArgs e)
        {
            stok_pnl.BackColor = Color.FromArgb(45, 45, 51);

        }

        private void stok_pic_MouseMove(object sender, MouseEventArgs e)
        {
            stok_pnl.BackColor = Color.FromArgb(60, 60, 40);

        }

        private void stok_pic_MouseLeave(object sender, EventArgs e)
        {
            stok_pnl.BackColor = Color.FromArgb(45, 45, 51);

        }

        private void stok_lbl_MouseMove(object sender, MouseEventArgs e)
        {
            stok_pnl.BackColor = Color.FromArgb(60, 60, 40);

        }

        private void stok_lbl_MouseLeave(object sender, EventArgs e)
        {
            stok_pnl.BackColor = Color.FromArgb(45, 45, 51);

        }

        private void satış_pnl_MouseMove(object sender, MouseEventArgs e)
        {
            satış_pnl.BackColor = Color.FromArgb(60, 60, 40);

        }

        private void satış_pnl_MouseLeave(object sender, EventArgs e)
        {

            satış_pnl.BackColor = Color.FromArgb(45, 45, 51);
        }

        private void satış_pic_MouseMove(object sender, MouseEventArgs e)
        {
            satış_pnl.BackColor = Color.FromArgb(60, 60, 40);

        }

        private void satış_pic_MouseLeave(object sender, EventArgs e)
        {
            satış_pnl.BackColor = Color.FromArgb(45, 45, 51);

        }

        private void satış_lbl_MouseMove(object sender, MouseEventArgs e)
        {
            satış_pnl.BackColor = Color.FromArgb(60, 60, 40);

        }

        private void anasayfa_pic_Click(object sender, EventArgs e)
        {
            db_görüntüleyici.Visible = false;
            satışbl = false;
            çalışanbl = false;
            stokbl = false;

            satış.Visible = true;
            en_çok_satılan.Visible = true;

            çalışan_maaş.Visible = true;
            düzenle_btn.Visible = false;
            btn_yenile.Visible = false;
        }

        private void anasayfa_lbl_Click(object sender, EventArgs e)
        {
            db_görüntüleyici.Visible = false;
            satışbl = false;
            çalışanbl = false;
            stokbl = false;

            satış.Visible = true;
            en_çok_satılan.Visible = true;

            çalışan_maaş.Visible = true;
            düzenle_btn.Visible = false;
            btn_yenile.Visible = false;
        }

        private void anasayfa_pnl_MouseClick(object sender, MouseEventArgs e)
        {
            db_görüntüleyici.Visible = false;
            satışbl = false;
            çalışanbl = false;
            stokbl = false;

            satış.Visible = true;
            en_çok_satılan.Visible = true;

            çalışan_maaş.Visible = true;
            düzenle_btn.Visible = false;
            btn_yenile.Visible = false;
        }

        private void çalışanlar_pic_Click(object sender, EventArgs e)
        {
            db_görüntüleyici.Visible = true;
            satışbl = false;
            çalışanbl = true;
            stokbl = false;

            satış.Visible = false;
            en_çok_satılan.Visible =false;

            çalışan_maaş.Visible =false;
            düzenle_btn.Visible = true;
          btn_yenile.Visible = true;

            görüntüle("select *from çalışanlar");

        }

        private void çalışanlar_lbl_Click(object sender, EventArgs e)
        {
            db_görüntüleyici.Visible = true;
            satışbl = false;
            çalışanbl = true;
            stokbl = false;

            satış.Visible = false;
            en_çok_satılan.Visible = false;

            çalışan_maaş.Visible = false;

            düzenle_btn.Visible = true;
            btn_yenile.Visible = true;
            görüntüle("select *from çalışanlar");
        }

        private void çalışanlar_pnl_MouseClick(object sender, MouseEventArgs e)
        {
            db_görüntüleyici.Visible = true;
            satışbl = false;
            çalışanbl = true;
            stokbl = false;

            satış.Visible = false;
            en_çok_satılan.Visible = false;

            çalışan_maaş.Visible = false;
            düzenle_btn.Visible = true;
            btn_yenile.Visible = true;
            görüntüle("select *from çalışanlar");

        }

        private void stok_lbl_Click(object sender, EventArgs e)
        {
            db_görüntüleyici.Visible = true;
            satışbl = false;
            çalışanbl = false;
            stokbl = true;

            satış.Visible = false;
            en_çok_satılan.Visible = false;

            çalışan_maaş.Visible = false;
            düzenle_btn.Visible = true;
            btn_yenile.Visible = true;
            görüntüle("select *from Stok");


        }

        private void stok_pic_Click(object sender, EventArgs e)
        {
            db_görüntüleyici.Visible = true;
            satışbl = false;
            çalışanbl = false;
            stokbl = true;

            satış.Visible = false;
            en_çok_satılan.Visible = false;

            çalışan_maaş.Visible = false;
            düzenle_btn.Visible = true;
            btn_yenile.Visible = true;
            görüntüle("select *from Stok");

        }

        private void stok_pnl_MouseClick(object sender, MouseEventArgs e)
        {
            db_görüntüleyici.Visible = true;
            satışbl = false;
            çalışanbl = false;
            stokbl = true;

            satış.Visible = false;
            en_çok_satılan.Visible = false;

            çalışan_maaş.Visible = false;
            düzenle_btn.Visible = true;
            btn_yenile.Visible = true;
            görüntüle("select *from Stok");

        }

        private void satış_pic_Click(object sender, EventArgs e)
        {
            db_görüntüleyici.Visible = true;
            satışbl = true;
            çalışanbl = false;
            stokbl = false;

            satış.Visible = false;
            en_çok_satılan.Visible = false;

            çalışan_maaş.Visible = false;
            düzenle_btn.Visible = true;
            btn_yenile.Visible = true;
            görüntüle("select *from satış");

        }

        private void satış_lbl_Click(object sender, EventArgs e)
        {
            db_görüntüleyici.Visible = true;
            satışbl = true;
            çalışanbl = false;
            stokbl = false;

            satış.Visible = false;
            en_çok_satılan.Visible = false;

            çalışan_maaş.Visible = false;
            düzenle_btn.Visible = true;
            btn_yenile.Visible = true;
            görüntüle("select *from satış");

        }

        private void satış_pnl_MouseClick(object sender, MouseEventArgs e)
        {
            db_görüntüleyici.Visible = true;
            satışbl = true;
            çalışanbl = false;
            stokbl = false;

            satış.Visible = false;
            en_çok_satılan.Visible = false;

            çalışan_maaş.Visible = false;
            düzenle_btn.Visible = true;
            btn_yenile.Visible = true;
            görüntüle("select *from satış");

        }

        private void düzenle_btn_Click(object sender, EventArgs e)
        {
            if (çalışanbl == true)
            {
                çalışanlar_düzenle çalışanlar_Düzenle = new çalışanlar_düzenle();
                çalışanlar_Düzenle.Show();
            }
            else if (stokbl == true)
            {
                stok_düzenle sd = new stok_düzenle();

                sd.Show();


            }
            else if (satışbl == true)
            {
                satış_düzenle sd = new satış_düzenle();
                sd.Show();
            }
                
        }

        private void btn_yenile_Click(object sender, EventArgs e)
        {
            if (çalışanbl == true)
            {
                görüntüle("select *from çalışanlar");
            }
            else if (stokbl == true)
            {
                görüntüle("select *from stok");

            }
            else if (satışbl == true)
            {
                görüntüle("select *from Satış");

            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_MouseMove(object sender, MouseEventArgs e)
        {
            label1.BackColor = Color.IndianRed;

        }

        private void label1_MouseLeave(object sender, EventArgs e)
        {
          label1.BackColor = Color.FromArgb(45, 45, 48);

        }

        private void label5_MouseMove(object sender, MouseEventArgs e)
        {
            label5.BackColor = Color.IndianRed;
        }

        private void label5_MouseLeave(object sender, EventArgs e)
        {
            label5.BackColor = Color.FromArgb(45, 45, 48);

        }

        private void grafikleri_yenile_Click(object sender, EventArgs e)
        {
            yönetici y = new yönetici();

            y.Show();
            this.Hide();

        }

        private void grafikleri_yenile_MouseMove(object sender, MouseEventArgs e)
        {
            grafikleri_yenile.BackColor = Color.IndianRed;
        }

        private void grafikleri_yenile_MouseLeave(object sender, EventArgs e)
        {
            grafikleri_yenile.BackColor = Color.FromArgb(45, 45, 48);
        }

        private void satış_lbl_MouseLeave(object sender, EventArgs e)
        {
            satış_pnl.BackColor = Color.FromArgb(45, 45, 51);

        }

        private void yönetici_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'eRP_ikiDataSet2.çalışanlar' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.çalışanlarTableAdapter.Fill(this.eRP_ikiDataSet2.çalışanlar);
            // TODO: Bu kod satırı 'eRP_ikiDataSet1.Stok' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.stokTableAdapter.Fill(this.eRP_ikiDataSet1.Stok);
            // TODO: Bu kod satırı 'eRP_ikiDataSet.satış' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.satışTableAdapter.Fill(this.eRP_ikiDataSet.satış);
            düzenle_btn.Visible = false;
            btn_yenile.Visible = false;

            db_görüntüleyici.Visible = false;
        }
    }
}
