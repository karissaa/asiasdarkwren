using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AsiasDarkWren
{
    public partial class CariPasien : UserControl
    {
        public CariPasien()
        {
            InitializeComponent();
            flagger();
        }

        private void flagger()
        {
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (Convert.ToBoolean(row.Cells[1].Value))
                {
                    btnLanjut.Enabled = true;
                }
            }
        }

        private void btnLanjut_Click(object sender, EventArgs e)
        {
            SendToBack();
        }
    }
}
