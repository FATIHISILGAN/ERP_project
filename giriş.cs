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
    public partial class giriş : Form
    {
        SqlConnection bağlantı = new SqlConnection("Data Source=DESKTOP-JUST06P\\MSSQLSERVER01;Initial Catalog=ERP_iki; Integrated Security=True;");
        public giriş()
        {
            InitializeComponent();
        }
        bool dragging;

        Point offset;
        public void giriş_kontrol_çalışan()
        {
            try
            {
                bağlantı.Open();
                string komut = "select *from çalışanlar where İD=@id AND p" + "w=@şifRe";

                SqlParameter sqlParameter = new SqlParameter("id", textBox1.Text.Trim());
                SqlParameter sqlparameter2 = new SqlParameter("şifre", textBox2.Text.Trim());
                SqlCommand sc = new SqlCommand(komut, bağlantı);
                sc.Parameters.Add(sqlParameter);
                sc.Parameters.Add(sqlparameter2);
                DataTable dt = new DataTable();

                SqlDataAdapter sda = new SqlDataAdapter(sc);

                sda.Fill(dt);


                if (dt.Rows.Count > 0)
                {
                    çalışan ç = new çalışan(textBox1.Text);

                    
                   
                    
                    ç.Show();
                    
                   
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("id veya şifre yanlış");
                }




                bağlantı.Close();


            }
            catch (Exception m)
            {
                MessageBox.Show("bir sorun oluştu");

                MessageBox.Show(m.Message);

            }
        }
        public void giriş_kontrol_yönetici()
        {
            try
            {
                bağlantı.Open();
                string komut = "select *from yönetici where yönetici_id=@id AND p" + "w=@şifRe";


                SqlParameter sqlParameter = new SqlParameter("id", textBox1.Text.Trim());
                SqlParameter sqlparameter2 = new SqlParameter("şifre", textBox2.Text.Trim());
                SqlCommand sc = new SqlCommand(komut, bağlantı);
                sc.Parameters.Add(sqlParameter);
                sc.Parameters.Add(sqlparameter2);
                DataTable dt = new DataTable();

                SqlDataAdapter sda = new SqlDataAdapter(sc);

                sda.Fill(dt);


                if (dt.Rows.Count > 0)
                {
                    yönetici yı = new yönetici();
                    
                    yı.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("id veya şifre yanlış");
                }




                bağlantı.Close();


            }
            catch (Exception m)
            {
                MessageBox.Show("bir sorun oluştu");

                MessageBox.Show(m.Message);

            }
        }
        private void gir_Click(object sender, EventArgs e)
        {
            if (Yönetici.Checked == true)
            {
                giriş_kontrol_yönetici();

            }
            else if (çalışan.Checked == true)
            {
                giriş_kontrol_çalışan();

            }
            //else is not possible

        }

        private void çıkış_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void çıkış_MouseMove(object sender, MouseEventArgs e)
        {
            çıkış.BackColor = Color.IndianRed;
        }

        private void çıkış_MouseLeave(object sender, EventArgs e)
        {
            çıkış.BackColor = Color.FromArgb(45, 45, 48);
        }

        private void giriş_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point currentScreenPos = PointToScreen(e.Location);
                Location = new
                Point(currentScreenPos.X - offset.X,
                currentScreenPos.Y - offset.Y);
            }
        }

        private void giriş_MouseDown(object sender, MouseEventArgs e)
        {

            dragging = true;
            offset = e.Location;
        }

        private void giriş_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;

        }

        private void giriş_Load(object sender, EventArgs e)
        {
            textBox2.UseSystemPasswordChar = true;
        }
    }
}
