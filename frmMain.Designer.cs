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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tsmiApplications = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiDrivers = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiUsers = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiAccountSettings = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_LogOut = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(30, 30);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiApplications,
            this.toolStripMenuItem2,
            this.tsmiDrivers,
            this.tsmiUsers,
            this.tsmiAccountSettings});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.menuStrip1.Size = new System.Drawing.Size(1822, 38);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tsmiApplications
            // 
            this.tsmiApplications.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.tsmiApplications.Image = ((System.Drawing.Image)(resources.GetObject("tsmiApplications.Image")));
            this.tsmiApplications.Name = "tsmiApplications";
            this.tsmiApplications.Size = new System.Drawing.Size(172, 34);
            this.tsmiApplications.Text = "Applications";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.toolStripMenuItem2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItem2.Image")));
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(121, 34);
            this.toolStripMenuItem2.Text = "People";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // tsmiDrivers
            // 
            this.tsmiDrivers.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.tsmiDrivers.Image = ((System.Drawing.Image)(resources.GetObject("tsmiDrivers.Image")));
            this.tsmiDrivers.Name = "tsmiDrivers";
            this.tsmiDrivers.Size = new System.Drawing.Size(123, 34);
            this.tsmiDrivers.Text = "Drivers";
            // 
            // tsmiUsers
            // 
            this.tsmiUsers.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.tsmiUsers.Image = ((System.Drawing.Image)(resources.GetObject("tsmiUsers.Image")));
            this.tsmiUsers.Name = "tsmiUsers";
            this.tsmiUsers.Size = new System.Drawing.Size(108, 34);
            this.tsmiUsers.Text = "Users";
            // 
            // tsmiAccountSettings
            // 
            this.tsmiAccountSettings.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.tsmiAccountSettings.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmi_LogOut});
            this.tsmiAccountSettings.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.tsmiAccountSettings.Image = ((System.Drawing.Image)(resources.GetObject("tsmiAccountSettings.Image")));
            this.tsmiAccountSettings.Name = "tsmiAccountSettings";
            this.tsmiAccountSettings.Size = new System.Drawing.Size(216, 34);
            this.tsmiAccountSettings.Text = "Account Settings";
            this.tsmiAccountSettings.ToolTipText = "Account Settings";
            // 
            // tsmi_LogOut
            // 
            this.tsmi_LogOut.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.tsmi_LogOut.Image = ((System.Drawing.Image)(resources.GetObject("tsmi_LogOut.Image")));
            this.tsmi_LogOut.Name = "tsmi_LogOut";
            this.tsmi_LogOut.Size = new System.Drawing.Size(147, 30);
            this.tsmi_LogOut.Text = "LogOut";
            this.tsmi_LogOut.Click += new System.EventHandler(this.tsmi_LogOut_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1822, 737);
            this.Controls.Add(this.menuStrip1);
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
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem tsmiDrivers;
        private System.Windows.Forms.ToolStripMenuItem tsmiUsers;
        private System.Windows.Forms.ToolStripMenuItem tsmiAccountSettings;
        private System.Windows.Forms.ToolStripMenuItem tsmi_LogOut;
    }
}