namespace Form_Design
{
    partial class frm_Home
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Home));
            this.btn_Account = new System.Windows.Forms.Button();
            this.btn_Highscores = new System.Windows.Forms.Button();
            this.btn_PouleOverview = new System.Windows.Forms.Button();
            this.btn_GameResult = new System.Windows.Forms.Button();
            this.btn_NewResult = new System.Windows.Forms.Button();
            this.btn_AddTeam = new System.Windows.Forms.Button();
            this.btn_Settings = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_Account
            // 
            this.btn_Account.Location = new System.Drawing.Point(876, 12);
            this.btn_Account.Name = "btn_Account";
            this.btn_Account.Size = new System.Drawing.Size(96, 36);
            this.btn_Account.TabIndex = 0;
            this.btn_Account.Text = "Account";
            this.btn_Account.UseVisualStyleBackColor = true;
            // 
            // btn_Highscores
            // 
            this.btn_Highscores.BackColor = System.Drawing.SystemColors.GrayText;
            this.btn_Highscores.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Highscores.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_Highscores.Location = new System.Drawing.Point(350, 113);
            this.btn_Highscores.Name = "btn_Highscores";
            this.btn_Highscores.Size = new System.Drawing.Size(300, 50);
            this.btn_Highscores.TabIndex = 1;
            this.btn_Highscores.Text = "Highscores";
            this.btn_Highscores.UseVisualStyleBackColor = false;
            // 
            // btn_PouleOverview
            // 
            this.btn_PouleOverview.BackColor = System.Drawing.SystemColors.GrayText;
            this.btn_PouleOverview.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_PouleOverview.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_PouleOverview.Location = new System.Drawing.Point(349, 182);
            this.btn_PouleOverview.Name = "btn_PouleOverview";
            this.btn_PouleOverview.Size = new System.Drawing.Size(300, 50);
            this.btn_PouleOverview.TabIndex = 2;
            this.btn_PouleOverview.Text = "Poule Overview";
            this.btn_PouleOverview.UseVisualStyleBackColor = false;
            this.btn_PouleOverview.Click += new System.EventHandler(this.btn_PouleOverview_Click);
            // 
            // btn_GameResult
            // 
            this.btn_GameResult.BackColor = System.Drawing.SystemColors.GrayText;
            this.btn_GameResult.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_GameResult.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_GameResult.Location = new System.Drawing.Point(349, 251);
            this.btn_GameResult.Name = "btn_GameResult";
            this.btn_GameResult.Size = new System.Drawing.Size(300, 50);
            this.btn_GameResult.TabIndex = 3;
            this.btn_GameResult.Text = "Game Results";
            this.btn_GameResult.UseVisualStyleBackColor = false;
            // 
            // btn_NewResult
            // 
            this.btn_NewResult.BackColor = System.Drawing.SystemColors.GrayText;
            this.btn_NewResult.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_NewResult.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_NewResult.Location = new System.Drawing.Point(349, 320);
            this.btn_NewResult.Name = "btn_NewResult";
            this.btn_NewResult.Size = new System.Drawing.Size(300, 50);
            this.btn_NewResult.TabIndex = 4;
            this.btn_NewResult.Text = "New Game Result";
            this.btn_NewResult.UseVisualStyleBackColor = false;
            this.btn_NewResult.Click += new System.EventHandler(this.btn_NewResult_Click);
            // 
            // btn_AddTeam
            // 
            this.btn_AddTeam.BackColor = System.Drawing.SystemColors.GrayText;
            this.btn_AddTeam.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AddTeam.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_AddTeam.Location = new System.Drawing.Point(349, 389);
            this.btn_AddTeam.Name = "btn_AddTeam";
            this.btn_AddTeam.Size = new System.Drawing.Size(300, 50);
            this.btn_AddTeam.TabIndex = 5;
            this.btn_AddTeam.Text = "Add Team";
            this.btn_AddTeam.UseVisualStyleBackColor = false;
            this.btn_AddTeam.Click += new System.EventHandler(this.btn_AddTeam_Click);
            // 
            // btn_Settings
            // 
            this.btn_Settings.Location = new System.Drawing.Point(876, 513);
            this.btn_Settings.Name = "btn_Settings";
            this.btn_Settings.Size = new System.Drawing.Size(96, 36);
            this.btn_Settings.TabIndex = 6;
            this.btn_Settings.Text = "Logout";
            this.btn_Settings.UseVisualStyleBackColor = true;
            this.btn_Settings.Click += new System.EventHandler(this.btn_Settings_Click);
            // 
            // frm_Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.btn_Settings);
            this.Controls.Add(this.btn_AddTeam);
            this.Controls.Add(this.btn_NewResult);
            this.Controls.Add(this.btn_GameResult);
            this.Controls.Add(this.btn_PouleOverview);
            this.Controls.Add(this.btn_Highscores);
            this.Controls.Add(this.btn_Account);
            this.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frm_Home";
            this.Text = "Home";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Account;
        private System.Windows.Forms.Button btn_Highscores;
        private System.Windows.Forms.Button btn_PouleOverview;
        private System.Windows.Forms.Button btn_GameResult;
        private System.Windows.Forms.Button btn_NewResult;
        private System.Windows.Forms.Button btn_AddTeam;
        private System.Windows.Forms.Button btn_Settings;
    }
}