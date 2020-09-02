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
    public partial class çalışan : Form
    {
        SqlConnection bağlantı = new SqlConnection("Data Source=DESKTOP-JUST06P\\MSSQLSERVER01;Initial Catalog=ERP_iki; Integrated Security=True;");
        string b = "";
        public çalışan(string a)
        {
            b = a;
            InitializeComponent();
        }
        bool dragging;

        Point offset;
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

        private void çalışan_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point currentScreenPos = PointToScreen(e.Location);
                Location = new
                Point(currentScreenPos.X - offset.X,
                currentScreenPos.Y - offset.Y);
            }
        }

        private void çalışan_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;

        }

        private void çalışan_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            offset = e.Location;
        }

        private void çalışan_Load(object sender, EventArgs e)
        {
            richTextBox1.Enabled = false;
            id_text.Text =b;

            bağlantı.Open();
            SqlCommand sc = new SqlCommand("Select *from çalışanlar where İD like '%"+id_text.Text+"%'",bağlantı);
            SqlDataReader sdr = sc.ExecuteReader();

            while (sdr.Read())
            {
                richTextBox1.Text = sdr["son_verilen_görev"].ToString();
            }

           
            
            bağlantı.Close();


            
        }
    }
}
