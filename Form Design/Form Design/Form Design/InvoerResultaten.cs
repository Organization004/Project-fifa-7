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
    public partial class frm_InvoerResultaten : Form
    {
        DataTable dt = new DataTable();

        public frm_InvoerResultaten()
        {
            InitializeComponent();
        }

        // Team 1 Speler Toevoegen

        private void btn_AddPlayerTeam1_Click(object sender, EventArgs e)
        {
            // als alle labels niet gelijk zijn aan de geselecteerde speler en het doel label is leeg (""), print dan de speler + aantal goals.

            if (lbl_T1P2.Text != cbox_PlayerTeam1.Text && lbl_T1P3.Text != cbox_PlayerTeam1.Text && lbl_T1P4.Text != cbox_PlayerTeam1.Text && lbl_T1P5.Text != cbox_PlayerTeam1.Text && lbl_T1P1.Text == "")
            {
                lbl_T1P1.Text = cbox_PlayerTeam1.Text;
                lbl_T1P1Goals.Text = Convert.ToString(num_Team1.Value);
            }

            if (lbl_T1P1.Text != cbox_PlayerTeam1.Text && lbl_T1P3.Text != cbox_PlayerTeam1.Text && lbl_T1P4.Text != cbox_PlayerTeam1.Text && lbl_T1P5.Text != cbox_PlayerTeam1.Text && lbl_T1P2.Text == "")
            {
                lbl_T1P2.Text = cbox_PlayerTeam1.Text;
                lbl_T1P2Goals.Text = Convert.ToString(num_Team1.Value);
            }

            if (lbl_T1P1.Text != cbox_PlayerTeam1.Text && lbl_T1P2.Text != cbox_PlayerTeam1.Text && lbl_T1P4.Text != cbox_PlayerTeam1.Text && lbl_T1P5.Text != cbox_PlayerTeam1.Text && lbl_T1P3.Text == "")
            {
                lbl_T1P3.Text = cbox_PlayerTeam1.Text;
                lbl_T1P3Goals.Text = Convert.ToString(num_Team1.Value);
            }

            if (lbl_T1P1.Text != cbox_PlayerTeam1.Text && lbl_T1P2.Text != cbox_PlayerTeam1.Text && lbl_T1P3.Text != cbox_PlayerTeam1.Text && lbl_T1P5.Text != cbox_PlayerTeam1.Text && lbl_T1P4.Text == "")
            {
                lbl_T1P4.Text = cbox_PlayerTeam1.Text;
                lbl_T1P4Goals.Text = Convert.ToString(num_Team1.Value);
            }

            if (lbl_T1P1.Text != cbox_PlayerTeam1.Text && lbl_T1P2.Text != cbox_PlayerTeam1.Text && lbl_T1P3.Text != cbox_PlayerTeam1.Text && lbl_T1P4.Text != cbox_PlayerTeam1.Text && lbl_T1P5.Text == "")
            {
                lbl_T1P5.Text = cbox_PlayerTeam1.Text;
                lbl_T1P5Goals.Text = Convert.ToString(num_Team1.Value);
            }
        }

        // Team 1 Spelers Remove Buttons
        // Als de button word geklikt, verander labels in (""). <- [niks dus]

        private void btn_Remove001_Click(object sender, EventArgs e)
        {
            lbl_T1P1.Text = "";
            lbl_T1P1Goals.Text = "";
        }

        private void btn_Remove002_Click(object sender, EventArgs e)
        {
            lbl_T1P2.Text = "";
            lbl_T1P2Goals.Text = "";
        }

        private void btn_Remove003_Click(object sender, EventArgs e)
        {
            lbl_T1P3.Text = "";
            lbl_T1P3Goals.Text = "";
        }

        private void btn_Remove004_Click(object sender, EventArgs e)
        {
            lbl_T1P4.Text = "";
            lbl_T1P4Goals.Text = "";
        }

        private void btn_Remove005_Click(object sender, EventArgs e)
        {
            lbl_T1P5.Text = "";
            lbl_T1P5Goals.Text = "";
        }

        // Team 2 Speler Toevoegen

        private void btn_AddPlayerTeam2_Click(object sender, EventArgs e)
        {
            if (lbl_T2P2.Text != cbox_PlayerTeam2.Text && lbl_T2P3.Text != cbox_PlayerTeam2.Text && lbl_T2P4.Text != cbox_PlayerTeam2.Text && lbl_T2P5.Text != cbox_PlayerTeam2.Text && lbl_T2P1.Text == "")
            {
                lbl_T2P1.Text = cbox_PlayerTeam2.Text;
                lbl_T2P1Goals.Text = Convert.ToString(num_Team2.Value);
            }

            if (lbl_T2P1.Text != cbox_PlayerTeam2.Text && lbl_T2P3.Text != cbox_PlayerTeam2.Text && lbl_T2P4.Text != cbox_PlayerTeam2.Text && lbl_T2P5.Text != cbox_PlayerTeam2.Text && lbl_T2P2.Text == "")
            {
                lbl_T2P2.Text = cbox_PlayerTeam2.Text;
                lbl_T2P2Goals.Text = Convert.ToString(num_Team2.Value);
            }

            if (lbl_T2P1.Text != cbox_PlayerTeam2.Text && lbl_T2P2.Text != cbox_PlayerTeam2.Text && lbl_T2P4.Text != cbox_PlayerTeam2.Text && lbl_T2P5.Text != cbox_PlayerTeam2.Text && lbl_T2P3.Text == "")
            {
                lbl_T2P3.Text = cbox_PlayerTeam2.Text;
                lbl_T2P3Goals.Text = Convert.ToString(num_Team2.Value);
            }

            if (lbl_T2P1.Text != cbox_PlayerTeam2.Text && lbl_T2P2.Text != cbox_PlayerTeam2.Text && lbl_T2P3.Text != cbox_PlayerTeam2.Text && lbl_T2P5.Text != cbox_PlayerTeam2.Text && lbl_T2P4.Text == "")
            {
                lbl_T2P4.Text = cbox_PlayerTeam2.Text;
                lbl_T2P4Goals.Text = Convert.ToString(num_Team2.Value);
            }

            if (lbl_T2P1.Text != cbox_PlayerTeam2.Text && lbl_T2P2.Text != cbox_PlayerTeam2.Text && lbl_T2P3.Text != cbox_PlayerTeam2.Text && lbl_T2P4.Text != cbox_PlayerTeam2.Text && lbl_T2P5.Text == "")
            {
                lbl_T2P5.Text = cbox_PlayerTeam2.Text;
                lbl_T2P5Goals.Text = Convert.ToString(num_Team2.Value);
            }
        }

        // Team 2 Spelers Remove Buttons

        private void btn_Remove006_Click(object sender, EventArgs e)
        {
            lbl_T2P1.Text = "";
            lbl_T2P1Goals.Text = "";
        }

        private void btn_Remove007_Click(object sender, EventArgs e)
        {
            lbl_T2P2.Text = "";
            lbl_T2P2Goals.Text = "";
        }

        private void btn_Remove008_Click(object sender, EventArgs e)
        {
            lbl_T2P3.Text = "";
            lbl_T2P3Goals.Text = "";
        }

        private void btn_Remove009_Click(object sender, EventArgs e)
        {
            lbl_T2P4.Text = "";
            lbl_T2P4Goals.Text = "";
        }

        private void btn_Remove010_Click(object sender, EventArgs e)
        {
            lbl_T2P5.Text = "";
            lbl_T2P5Goals.Text = "";
        }

        // Submit Teams

            // FIX THIS!! zorg ervoor dat hij niet op alle labels print.

        string[] GameResults = new string[]
        {
           
        }
        
        private void btn_Submit_Click(object sender, EventArgs e)
        {
            if (lbl_GRTeams001.Text == "Result 1")
            {
                lbl_GRTeams001.Text = cbox_InvoerTeam1.Text + " - " + cbox_TeamInvoer2.Text;
                lbl_GRScore001.Text = txt_ScoreTeam1.Text + " - " + txt_ScoreTeam2.Text;
            }

            if (lbl_GRTeams001.Text != "Result 2")
            {
                lbl_GRTeams002.Text = cbox_InvoerTeam1.Text + " - " + cbox_TeamInvoer2.Text;
                lbl_GRScore002.Text = txt_ScoreTeam1.Text + " - " + txt_ScoreTeam2.Text;
            }

            if (lbl_GRTeams002.Text != "Result 3")
            {
                lbl_GRTeams003.Text = cbox_InvoerTeam1.Text + " - " + cbox_TeamInvoer2.Text;
                lbl_GRScore003.Text = txt_ScoreTeam1.Text + " - " + txt_ScoreTeam2.Text;
            }

            if (lbl_GRTeams003.Text != "Result 4")
            {
                lbl_GRTeams004.Text = cbox_InvoerTeam1.Text + " - " + cbox_TeamInvoer2;
                lbl_GRScore004.Text = txt_ScoreTeam1.Text + " - " + txt_ScoreTeam2;
            }

            if (lbl_GRScore004.Text != "Result 5")
            {
                lbl_GRTeams005.Text = cbox_InvoerTeam1.Text + " - " + cbox_TeamInvoer2;
                lbl_GRScore005.Text = txt_ScoreTeam1.Text + " - " + txt_ScoreTeam2;
            }
            
        }

        // Remove Results Buttons

        private void btn_RemoveRes001_Click(object sender, EventArgs e)
        {
            lbl_GRTeams001.Text = "Result 1";
            lbl_GRScore001.Text = "";

            lbl_GRTeams001.Text = lbl_GRTeams002.Text;
            lbl_GRScore001.Text = lbl_GRScore002.Text;

            lbl_GRTeams002.Text = lbl_GRTeams003.Text;
            lbl_GRScore002.Text = lbl_GRScore003.Text;

            lbl_GRTeams003.Text = lbl_GRTeams004.Text;
            lbl_GRScore003.Text = lbl_GRScore004.Text;

            lbl_GRTeams004.Text = lbl_GRTeams005.Text;
            lbl_GRScore004.Text = lbl_GRScore005.Text;
        }

        private void btn_RemoveRes002_Click(object sender, EventArgs e)
        {
            lbl_GRTeams002.Text = "";
            lbl_GRScore002.Text = "";

            lbl_GRTeams002.Text = lbl_GRTeams003.Text;
            lbl_GRScore002.Text = lbl_GRScore003.Text;

            lbl_GRTeams003.Text = lbl_GRTeams004.Text;
            lbl_GRScore003.Text = lbl_GRScore004.Text;

            lbl_GRTeams004.Text = lbl_GRTeams005.Text;
            lbl_GRScore004.Text = lbl_GRScore005.Text;
        }

        private void btn_RemoveRes003_Click(object sender, EventArgs e)
        {
            lbl_GRTeams003.Text = "";
            lbl_GRScore003.Text = "";

            lbl_GRTeams003.Text = lbl_GRTeams004.Text;
            lbl_GRScore003.Text = lbl_GRScore004.Text;

            lbl_GRTeams004.Text = lbl_GRTeams005.Text;
            lbl_GRScore004.Text = lbl_GRScore005.Text;
        }

        private void btn_RemoveRes004_Click(object sender, EventArgs e)
        {
            lbl_GRTeams004.Text = "";
            lbl_GRScore004.Text = "";

            lbl_GRTeams004.Text = lbl_GRTeams005.Text;
            lbl_GRScore004.Text = lbl_GRScore005.Text;
        }

        private void btn_RemoveRes005_Click(object sender, EventArgs e)
        {
            lbl_GRTeams005.Text = "";
            lbl_GRScore005.Text = "";
        }
    }
}
