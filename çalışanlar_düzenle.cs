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
    public partial class çalışanlar_düzenle : Form
    {
        SqlConnection bağlantı = new SqlConnection("Data Source=DESKTOP-JUST06P\\MSSQLSERVER01;Initial Catalog=ERP_iki; Integrated Security=True;");
        public çalışanlar_düzenle()
        {
            InitializeComponent();
        }
        bool dragging;

        Point offset;
        private void kaydet_btn_Click(object sender, EventArgs e)
        {
            bağlantı.Open();

            SqlCommand komut = new SqlCommand("insert into çalışanlar(İD,pw,[ad soyad],maaş,meslek,son_verilen_görev)values(@id,@pw,@adsoyad,@maaş,@meslek,@svg)", bağlantı);

            komut.Parameters.AddWithValue("@id",Id_text.Text);
            komut.Parameters.AddWithValue("@pw", şifre_text.Text);
            komut.Parameters.AddWithValue("@adsoyad", adsoyad_text.Text);
            komut.Parameters.AddWithValue("@maaş", maaş_text.Text);
            komut.Parameters.AddWithValue("@meslek", meslek_text.Text);
          
            komut.Parameters.AddWithValue("@svg", svg_text.Text);
          
            komut.ExecuteNonQuery();

            bağlantı.Close();

            MessageBox.Show("başarı ile eklendi yenile düğmesine basmayı unutmayınız");

           
        }

        private void Güncelle_btn_Click(object sender, EventArgs e)
        {
            bağlantı.Open();
            SqlCommand komut = new SqlCommand("update çalışanlar set pw= '" + şifre_text.Text + "',[ad soyad]='" + adsoyad_text.Text + "',maaş='" + maaş_text.Text + "',meslek='" + meslek_text.Text + "' ,son_verilen_görev='" + svg_text.Text + "' where İD='" + Id_text.Text + "'", bağlantı);
            komut.ExecuteNonQuery();
            MessageBox.Show("başarı ile güncellendi yenile düğmesine basmayı unutmayınız");

           
        }

        private void Sil_Click(object sender, EventArgs e)
        {
            bağlantı.Open();
            SqlCommand komut = new SqlCommand("delete from çalışanlar where İD=@id", bağlantı);
            komut.Parameters.AddWithValue("@id",silincek_text.Text);
            komut.ExecuteNonQuery();
            bağlantı.Close();

            MessageBox.Show("başarı ile silindi yenile düğmesine basmayı unutmayınız");

        }

        private void çalışanlar_düzenle_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point currentScreenPos = PointToScreen(e.Location);
                Location = new
                Point(currentScreenPos.X - offset.X,
                currentScreenPos.Y - offset.Y);
            }
        }

        private void çalışanlar_düzenle_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            offset = e.Location;
        }

        private void çalışanlar_düzenle_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;

        }

        private void çıkış_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void çıkış_MouseMove(object sender, MouseEventArgs e)
        {
            çıkış.BackColor = Color.IndianRed;
        }

        private void çıkış_MouseLeave(object sender, EventArgs e)
        {
            çıkış.BackColor = Color.FromArgb(45, 45, 48);

        }
    }
}
