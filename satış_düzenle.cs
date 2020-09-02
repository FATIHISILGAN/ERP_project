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
    public partial class satış_düzenle : Form
    {
        SqlConnection bağlantı = new SqlConnection("Data Source=DESKTOP-JUST06P\\MSSQLSERVER01;Initial Catalog=ERP_iki; Integrated Security=True;");
        public satış_düzenle()
        {
            InitializeComponent();
        }
        bool dragging;

        Point offset;
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

      

        private void satış_düzenle_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            offset = e.Location;
        }

        private void satış_düzenle_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point currentScreenPos = PointToScreen(e.Location);
                Location = new
                Point(currentScreenPos.X - offset.X,
                currentScreenPos.Y - offset.Y);
            }
        }

        private void satış_düzenle_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }

        private void kaydet_btn_Click(object sender, EventArgs e)
        {
            bağlantı.Open();

            SqlCommand komut = new SqlCommand("insert into satış(ürün_id,ürün_ad,satış_adet,satış_tarihi)values(@id,@üad,@adet,@tarih)", bağlantı);

            komut.Parameters.AddWithValue("@id",ürün_id.Text);
            komut.Parameters.AddWithValue("@üad", ürün_ad.Text);
            komut.Parameters.AddWithValue("@adet", satış_adet.Text);
            komut.Parameters.AddWithValue("@tarih", satış_tarihi.Text);



            komut.ExecuteNonQuery();

            bağlantı.Close();

            MessageBox.Show("başarı ile eklendi yenile düğmesine basmayı unutmayınız");
        }

        private void Güncelle_btn_Click(object sender, EventArgs e)
        {
          
            bağlantı.Open();
            SqlCommand komut = new SqlCommand("update satış set ürün_ad= '" + ürün_ad.Text + "',satış_adet='" + satış_adet.Text + "',satış_tarihi='" + satış_tarihi.Value.Date.ToString() + "' where ürün_id= '" + ürün_id.Text + " '", bağlantı);
            komut.ExecuteNonQuery();
            MessageBox.Show("başarı ile güncellendi yenile düğmesine basmayı unutmayınız");

           
        }
        private void Sil_Click(object sender, EventArgs e)
        {
            bağlantı.Open();
            SqlCommand komut = new SqlCommand("delete from satış where ürün_id=@id", bağlantı);
            komut.Parameters.AddWithValue("@id", silincek_text.Text);
            komut.ExecuteNonQuery();
            bağlantı.Close();

            MessageBox.Show("başarı ile silindi yenile düğmesine basmayı unutmayınız");

        }
    }
}
