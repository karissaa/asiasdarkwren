using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MahApps.Metro.Controls;
using System.Configuration;

namespace AsiasDarkWren
{
   

    public partial class login : Form
    {
        string connection = ConfigurationManager.ConnectionStrings["cs"].ConnectionString;

        public login()
        {
            InitializeComponent();
        }


        private int noGambar = 1;

        private void GambarSelanjutnya()
        {
            if(noGambar == 9)
            {
                noGambar = 1;
            }
            slidePic.ImageLocation = string.Format(@"Hospital\{0}.jpg", noGambar);
            noGambar++;
        }    

        private void timer_Tick(object sender, EventArgs e)
        {
            GambarSelanjutnya();
        }

        private void away_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void mainkeys(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Escape)
            {
                Application.Exit();
            }
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            Hide();
            //Account acc = new Account();
            Resepsionis nw = new Resepsionis();
            nw.Show();
        }
    }
    public class Account
    {
        private string id;
        private string Nama;
        public Account(string id, string nama)
        {
            this.id = id;
            this.Nama = nama;
        }
        public string getID()
        {
            return this.id;
        }
        public string getNama()
        {
            return this.Nama;
        }
        public void setID(string id)
        {
            this.id = id;
        }
        public void setNama(string nama)
        {
            this.Nama = nama;
        }
    }
}
