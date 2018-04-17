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
    public partial class frm_Home : Form
    {
        public frm_Home()
        {
            InitializeComponent();
        }

        private void btn_PouleOverview_Click(object sender, EventArgs e)
        {
            frm_PouleOverview PouleOverview = new frm_PouleOverview();
            this.Hide();
            PouleOverview.Show();
        }

        private void btn_Settings_Click(object sender, EventArgs e)
        {
            frm_Login Login = new frm_Login();
            this.Hide();
            Login.Show();
        }

        private void btn_NewResult_Click(object sender, EventArgs e)
        {
            frm_InvoerResultaten InvoerResultaten = new frm_InvoerResultaten();
            this.Hide();
            InvoerResultaten.Show();
        }

        private void btn_AddTeam_Click(object sender, EventArgs e)
        {
            frm_TeamInvoer TeamInvoer = new frm_TeamInvoer();
            this.Hide();
            TeamInvoer.Show();
        }
    }
}
