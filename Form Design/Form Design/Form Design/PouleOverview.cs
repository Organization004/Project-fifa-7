using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Form_Design
{
    public partial class frm_PouleOverview : Form
    {
        public frm_PouleOverview()
        {
            InitializeComponent();
        }

        private void btn_POBack_Click(object sender, EventArgs e)
        {
            frm_Home Home = new frm_Home();
            this.Hide();
            Home.Show();
        }
    }
}
