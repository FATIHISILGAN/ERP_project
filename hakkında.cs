using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace exERP_Full
{
    public partial class hakkında : Form
    {
        public hakkında()
        {
            InitializeComponent();
        }
        bool dragging;

        Point offset;
        private void çıkış_MouseClick(object sender, MouseEventArgs e)
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

        private void SİTE_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://isilgannotes.wordpress.com/");
        }

        private void hakkında_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point currentScreenPos = PointToScreen(e.Location);
                Location = new
                Point(currentScreenPos.X - offset.X,
                currentScreenPos.Y - offset.Y);
            }
        }

        private void hakkında_MouseDown(object sender, MouseEventArgs e)
        {

            dragging = true;
            offset = e.Location;
        }

        private void hakkında_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;

        }
    }
}
