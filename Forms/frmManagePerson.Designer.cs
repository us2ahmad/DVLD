namespace DVLD_PresentationLayer.Forms
{
    partial class frmManagePerson
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmManagePerson));
            this.dgvPerson = new System.Windows.Forms.DataGridView();
            this.cmsPersonGrid = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiShowDetails = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiAddNewPerson = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiEditPerson = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiDeletePerson = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiSendEmailToPerson = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiPhoneCallPerson = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.lblRecord = new System.Windows.Forms.Label();
            this.lblRecCount = new System.Windows.Forms.Label();
            this.cbFilterBy = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbFilterBy = new System.Windows.Forms.TextBox();
            this.rbMale = new System.Windows.Forms.RadioButton();
            this.rbFeMale = new System.Windows.Forms.RadioButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPerson)).BeginInit();
            this.cmsPersonGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPerson
            // 
            this.dgvPerson.AllowUserToAddRows = false;
            this.dgvPerson.AllowUserToDeleteRows = false;
            this.dgvPerson.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvPerson.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPerson.ContextMenuStrip = this.cmsPersonGrid;
            this.dgvPerson.Location = new System.Drawing.Point(14, 295);
            this.dgvPerson.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvPerson.Name = "dgvPerson";
            this.dgvPerson.ReadOnly = true;
            this.dgvPerson.RowHeadersWidth = 51;
            this.dgvPerson.Size = new System.Drawing.Size(1407, 446);
            this.dgvPerson.TabIndex = 0;
            // 
            // cmsPersonGrid
            // 
            this.cmsPersonGrid.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cmsPersonGrid.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiShowDetails,
            this.toolStripSeparator1,
            this.tsmiAddNewPerson,
            this.tsmiEditPerson,
            this.tsmiDeletePerson,
            this.toolStripSeparator2,
            this.tsmiSendEmailToPerson,
            this.tsmiPhoneCallPerson});
            this.cmsPersonGrid.Name = "cmsPersonGrid";
            this.cmsPersonGrid.Size = new System.Drawing.Size(192, 172);
            // 
            // tsmiShowDetails
            // 
            this.tsmiShowDetails.Image = global::DVLD_PresentationLayer.Properties.Resources.PersonDetails_32;
            this.tsmiShowDetails.Name = "tsmiShowDetails";
            this.tsmiShowDetails.Size = new System.Drawing.Size(191, 26);
            this.tsmiShowDetails.Text = "Show Details";
            this.tsmiShowDetails.Click += new System.EventHandler(this.tsmiShowDetails_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(188, 6);
            // 
            // tsmiAddNewPerson
            // 
            this.tsmiAddNewPerson.Image = global::DVLD_PresentationLayer.Properties.Resources.Add_Person_40;
            this.tsmiAddNewPerson.Name = "tsmiAddNewPerson";
            this.tsmiAddNewPerson.Size = new System.Drawing.Size(191, 26);
            this.tsmiAddNewPerson.Text = "Add New Person";
            this.tsmiAddNewPerson.Click += new System.EventHandler(this.tsmiAddNewPerson_Click);
            // 
            // tsmiEditPerson
            // 
            this.tsmiEditPerson.Image = ((System.Drawing.Image)(resources.GetObject("tsmiEditPerson.Image")));
            this.tsmiEditPerson.Name = "tsmiEditPerson";
            this.tsmiEditPerson.Size = new System.Drawing.Size(191, 26);
            this.tsmiEditPerson.Text = "Edit";
            this.tsmiEditPerson.Click += new System.EventHandler(this.tsmiEditPerson_Click);
            // 
            // tsmiDeletePerson
            // 
            this.tsmiDeletePerson.Image = ((System.Drawing.Image)(resources.GetObject("tsmiDeletePerson.Image")));
            this.tsmiDeletePerson.Name = "tsmiDeletePerson";
            this.tsmiDeletePerson.Size = new System.Drawing.Size(191, 26);
            this.tsmiDeletePerson.Text = "Delete";
            this.tsmiDeletePerson.Click += new System.EventHandler(this.tsmiDeletePerson_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(188, 6);
            // 
            // tsmiSendEmailToPerson
            // 
            this.tsmiSendEmailToPerson.Image = ((System.Drawing.Image)(resources.GetObject("tsmiSendEmailToPerson.Image")));
            this.tsmiSendEmailToPerson.Name = "tsmiSendEmailToPerson";
            this.tsmiSendEmailToPerson.Size = new System.Drawing.Size(191, 26);
            this.tsmiSendEmailToPerson.Text = "Send Email";
            this.tsmiSendEmailToPerson.Click += new System.EventHandler(this.tsmiSendEmailToPerson_Click);
            // 
            // tsmiPhoneCallPerson
            // 
            this.tsmiPhoneCallPerson.Image = ((System.Drawing.Image)(resources.GetObject("tsmiPhoneCallPerson.Image")));
            this.tsmiPhoneCallPerson.Name = "tsmiPhoneCallPerson";
            this.tsmiPhoneCallPerson.Size = new System.Drawing.Size(191, 26);
            this.tsmiPhoneCallPerson.Text = "Phone Call";
            this.tsmiPhoneCallPerson.Click += new System.EventHandler(this.tsmiPhoneCallPerson_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 26F);
            this.label1.Location = new System.Drawing.Point(570, 198);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(317, 53);
            this.label1.TabIndex = 1;
            this.label1.Text = "Manage Person";
            // 
            // lblRecord
            // 
            this.lblRecord.AutoSize = true;
            this.lblRecord.Font = new System.Drawing.Font("Tahoma", 12F);
            this.lblRecord.Location = new System.Drawing.Point(14, 751);
            this.lblRecord.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRecord.Name = "lblRecord";
            this.lblRecord.Size = new System.Drawing.Size(99, 24);
            this.lblRecord.TabIndex = 3;
            this.lblRecord.Text = "Records : ";
            // 
            // lblRecCount
            // 
            this.lblRecCount.AutoSize = true;
            this.lblRecCount.Font = new System.Drawing.Font("Tahoma", 12F);
            this.lblRecCount.Location = new System.Drawing.Point(115, 751);
            this.lblRecCount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRecCount.Name = "lblRecCount";
            this.lblRecCount.Size = new System.Drawing.Size(28, 24);
            this.lblRecCount.TabIndex = 4;
            this.lblRecCount.Text = "??";
            // 
            // cbFilterBy
            // 
            this.cbFilterBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFilterBy.FormattingEnabled = true;
            this.cbFilterBy.Items.AddRange(new object[] {
            "None",
            "NationalNo",
            "FirstName",
            "SecondName",
            "ThirdName",
            "LastName",
            "Gendor",
            "Address",
            "Phone",
            "Email",
            "CountryName"});
            this.cbFilterBy.Location = new System.Drawing.Point(115, 260);
            this.cbFilterBy.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbFilterBy.Name = "cbFilterBy";
            this.cbFilterBy.Size = new System.Drawing.Size(173, 24);
            this.cbFilterBy.TabIndex = 5;
            this.cbFilterBy.SelectedIndexChanged += new System.EventHandler(this.cbFilterBy_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label2.Location = new System.Drawing.Point(14, 260);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "Filter By : ";
            // 
            // tbFilterBy
            // 
            this.tbFilterBy.Location = new System.Drawing.Point(308, 260);
            this.tbFilterBy.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbFilterBy.Name = "tbFilterBy";
            this.tbFilterBy.Size = new System.Drawing.Size(148, 24);
            this.tbFilterBy.TabIndex = 6;
            this.tbFilterBy.TextChanged += new System.EventHandler(this.tbFilterBy_TextChanged);
            // 
            // rbMale
            // 
            this.rbMale.AutoSize = true;
            this.rbMale.Checked = true;
            this.rbMale.Location = new System.Drawing.Point(308, 260);
            this.rbMale.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rbMale.Name = "rbMale";
            this.rbMale.Size = new System.Drawing.Size(55, 21);
            this.rbMale.TabIndex = 7;
            this.rbMale.TabStop = true;
            this.rbMale.Text = "Male";
            this.rbMale.UseVisualStyleBackColor = true;
            this.rbMale.Visible = false;
            this.rbMale.CheckedChanged += new System.EventHandler(this.rbMale_CheckedChanged);
            // 
            // rbFeMale
            // 
            this.rbFeMale.AutoSize = true;
            this.rbFeMale.Location = new System.Drawing.Point(370, 260);
            this.rbFeMale.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rbFeMale.Name = "rbFeMale";
            this.rbFeMale.Size = new System.Drawing.Size(69, 21);
            this.rbFeMale.TabIndex = 7;
            this.rbFeMale.Text = "FeMale";
            this.rbFeMale.UseVisualStyleBackColor = true;
            this.rbFeMale.Visible = false;
            this.rbFeMale.CheckedChanged += new System.EventHandler(this.rbFeMale_CheckedChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DVLD_PresentationLayer.Properties.Resources.People_400;
            this.pictureBox1.Location = new System.Drawing.Point(553, 25);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(330, 170);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // frmManagePerson
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1435, 822);
            this.Controls.Add(this.rbFeMale);
            this.Controls.Add(this.rbMale);
            this.Controls.Add(this.tbFilterBy);
            this.Controls.Add(this.cbFilterBy);
            this.Controls.Add(this.lblRecCount);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblRecord);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvPerson);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmManagePerson";
            this.ShowIcon = false;
            this.Text = "frmManagePerson";
            this.Load += new System.EventHandler(this.frmManagePerson_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPerson)).EndInit();
            this.cmsPersonGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPerson;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblRecord;
        private System.Windows.Forms.Label lblRecCount;
        private System.Windows.Forms.ComboBox cbFilterBy;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbFilterBy;
        private System.Windows.Forms.RadioButton rbMale;
        private System.Windows.Forms.RadioButton rbFeMale;
        private System.Windows.Forms.ContextMenuStrip cmsPersonGrid;
        private System.Windows.Forms.ToolStripMenuItem tsmiShowDetails;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem tsmiAddNewPerson;
        private System.Windows.Forms.ToolStripMenuItem tsmiEditPerson;
        private System.Windows.Forms.ToolStripMenuItem tsmiDeletePerson;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem tsmiSendEmailToPerson;
        private System.Windows.Forms.ToolStripMenuItem tsmiPhoneCallPerson;
    }
}