namespace DVLD_PresentationLayer.Forms
{
    partial class frmMain
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tsmiApplications = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_People = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiDrivers = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiUsers = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_AccountSettings = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_CurrentUserInfo = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_ChangePassword = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_SignOut = new System.Windows.Forms.ToolStripMenuItem();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(30, 30);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiApplications,
            this.tsmi_People,
            this.tsmiDrivers,
            this.tsmiUsers,
            this.tsmi_AccountSettings});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.menuStrip1.Size = new System.Drawing.Size(1822, 72);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tsmiApplications
            // 
            this.tsmiApplications.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.tsmiApplications.Image = global::DVLD_PresentationLayer.Properties.Resources.Applications_64;
            this.tsmiApplications.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsmiApplications.Name = "tsmiApplications";
            this.tsmiApplications.Size = new System.Drawing.Size(182, 68);
            this.tsmiApplications.Text = "Applications";
            // 
            // tsmi_People
            // 
            this.tsmi_People.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.tsmi_People.Image = global::DVLD_PresentationLayer.Properties.Resources.People_64;
            this.tsmi_People.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsmi_People.Name = "tsmi_People";
            this.tsmi_People.Size = new System.Drawing.Size(139, 68);
            this.tsmi_People.Text = "People";
            this.tsmi_People.Click += new System.EventHandler(this.tsmi_People_Click);
            // 
            // tsmiDrivers
            // 
            this.tsmiDrivers.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.tsmiDrivers.Image = global::DVLD_PresentationLayer.Properties.Resources.Drivers_64;
            this.tsmiDrivers.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsmiDrivers.Name = "tsmiDrivers";
            this.tsmiDrivers.Size = new System.Drawing.Size(140, 68);
            this.tsmiDrivers.Text = "Drivers";
            // 
            // tsmiUsers
            // 
            this.tsmiUsers.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.tsmiUsers.Image = global::DVLD_PresentationLayer.Properties.Resources.Users_2_64;
            this.tsmiUsers.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsmiUsers.Name = "tsmiUsers";
            this.tsmiUsers.Size = new System.Drawing.Size(127, 68);
            this.tsmiUsers.Text = "Users";
            // 
            // tsmi_AccountSettings
            // 
            this.tsmi_AccountSettings.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.tsmi_AccountSettings.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmi_CurrentUserInfo,
            this.tsmi_ChangePassword,
            this.tsmi_SignOut});
            this.tsmi_AccountSettings.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.tsmi_AccountSettings.Image = global::DVLD_PresentationLayer.Properties.Resources.account_settings_64;
            this.tsmi_AccountSettings.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsmi_AccountSettings.Name = "tsmi_AccountSettings";
            this.tsmi_AccountSettings.Size = new System.Drawing.Size(215, 68);
            this.tsmi_AccountSettings.Text = "Account Settings";
            this.tsmi_AccountSettings.ToolTipText = "Account Settings";
            // 
            // tsmi_CurrentUserInfo
            // 
            this.tsmi_CurrentUserInfo.Image = global::DVLD_PresentationLayer.Properties.Resources.PersonDetails_32;
            this.tsmi_CurrentUserInfo.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsmi_CurrentUserInfo.Name = "tsmi_CurrentUserInfo";
            this.tsmi_CurrentUserInfo.Size = new System.Drawing.Size(230, 38);
            this.tsmi_CurrentUserInfo.Text = "&Current User Info";
            // 
            // tsmi_ChangePassword
            // 
            this.tsmi_ChangePassword.Image = global::DVLD_PresentationLayer.Properties.Resources.Password_32;
            this.tsmi_ChangePassword.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsmi_ChangePassword.Name = "tsmi_ChangePassword";
            this.tsmi_ChangePassword.Size = new System.Drawing.Size(230, 38);
            this.tsmi_ChangePassword.Text = "Change Password";
            // 
            // tsmi_SignOut
            // 
            this.tsmi_SignOut.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.tsmi_SignOut.Image = global::DVLD_PresentationLayer.Properties.Resources.sign_out_32__2;
            this.tsmi_SignOut.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsmi_SignOut.Name = "tsmi_SignOut";
            this.tsmi_SignOut.Size = new System.Drawing.Size(230, 38);
            this.tsmi_SignOut.Text = "Sign &Out";
            this.tsmi_SignOut.Click += new System.EventHandler(this.tsmi_SignOut_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1822, 737);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.ShowIcon = false;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsmiApplications;
        private System.Windows.Forms.ToolStripMenuItem tsmi_People;
        private System.Windows.Forms.ToolStripMenuItem tsmiDrivers;
        private System.Windows.Forms.ToolStripMenuItem tsmiUsers;
        private System.Windows.Forms.ToolStripMenuItem tsmi_AccountSettings;
        private System.Windows.Forms.ToolStripMenuItem tsmi_SignOut;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ToolStripMenuItem tsmi_CurrentUserInfo;
        private System.Windows.Forms.ToolStripMenuItem tsmi_ChangePassword;
    }
}