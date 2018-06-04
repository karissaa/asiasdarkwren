using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using MahApps.Metro.Controls;

namespace AsiasDarkWren
{
    public partial class Resepsionis : Form
    {
        public Resepsionis()
        {
            InitializeComponent();
            sldPanel.Height = btnDashboard.Height;
            dashboardMain1.BringToFront();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            clock.Text = DateTime.Now.ToString("HH:mm:ss");
            tanggal.Text = DateTime.Now.ToString("ddd, dd MMM yyyy");
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            sldPanel.Height = btnDashboard.Height;
            sldPanel.Top = btnDashboard.Top;
            dashboardMain1.BringToFront();
        }

        private void btnReservasi_Click(object sender, EventArgs e)
        {
            sldPanel.Height = btnReservasi.Height;
            sldPanel.Top = btnReservasi.Top;
            reservasi1.BringToFront();
        }

        private void btnKeluar_Click(object sender, EventArgs e)
        {
            Hide();
            login nw = new login();
            nw.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
