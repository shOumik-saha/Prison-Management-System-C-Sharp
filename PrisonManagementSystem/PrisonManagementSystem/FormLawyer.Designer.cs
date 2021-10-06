
namespace PrisonManagementSystem
{
    partial class FormLawyer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLawyer));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.dgvRecords = new System.Windows.Forms.DataGridView();
            this.PrisonerId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrisonerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrisonerFathersName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateOfBirth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrisonerAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Crime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Work = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EntranceDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ReleaseDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchPrisonerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.myProfileToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.myProfileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.prisonerRecordsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecords)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.PowderBlue;
            this.panel1.Controls.Add(this.btnSearch);
            this.panel1.Controls.Add(this.txtSearch);
            this.panel1.Location = new System.Drawing.Point(0, 31);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1275, 202);
            this.panel1.TabIndex = 22;
            // 
            // btnSearch
            // 
            this.btnSearch.AutoSize = true;
            this.btnSearch.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSearch.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSearch.Location = new System.Drawing.Point(421, 81);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(204, 33);
            this.btnSearch.TabIndex = 18;
            this.btnSearch.Text = "Search By Prisoner Id";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(666, 84);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(234, 30);
            this.txtSearch.TabIndex = 5;
            // 
            // dgvRecords
            // 
            this.dgvRecords.AllowUserToAddRows = false;
            this.dgvRecords.AllowUserToDeleteRows = false;
            this.dgvRecords.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRecords.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PrisonerId,
            this.PrisonerName,
            this.PrisonerFathersName,
            this.DateOfBirth,
            this.Gender,
            this.PrisonerAddress,
            this.Crime,
            this.Work,
            this.EntranceDate,
            this.ReleaseDate});
            this.dgvRecords.Location = new System.Drawing.Point(-2, 231);
            this.dgvRecords.Name = "dgvRecords";
            this.dgvRecords.ReadOnly = true;
            this.dgvRecords.RowHeadersWidth = 51;
            this.dgvRecords.RowTemplate.Height = 24;
            this.dgvRecords.Size = new System.Drawing.Size(1277, 228);
            this.dgvRecords.TabIndex = 23;
            // 
            // PrisonerId
            // 
            this.PrisonerId.DataPropertyName = "PrisonerId";
            this.PrisonerId.HeaderText = "Prisoner Id";
            this.PrisonerId.MinimumWidth = 6;
            this.PrisonerId.Name = "PrisonerId";
            this.PrisonerId.ReadOnly = true;
            this.PrisonerId.Width = 125;
            // 
            // PrisonerName
            // 
            this.PrisonerName.DataPropertyName = "PrisonerName";
            this.PrisonerName.HeaderText = "Prisoner Name";
            this.PrisonerName.MinimumWidth = 6;
            this.PrisonerName.Name = "PrisonerName";
            this.PrisonerName.ReadOnly = true;
            this.PrisonerName.Width = 125;
            // 
            // PrisonerFathersName
            // 
            this.PrisonerFathersName.DataPropertyName = "PrisonerFathersName";
            this.PrisonerFathersName.HeaderText = "Prisoner Father\'s Name";
            this.PrisonerFathersName.MinimumWidth = 6;
            this.PrisonerFathersName.Name = "PrisonerFathersName";
            this.PrisonerFathersName.ReadOnly = true;
            this.PrisonerFathersName.Width = 125;
            // 
            // DateOfBirth
            // 
            this.DateOfBirth.DataPropertyName = "DateOfBirth";
            this.DateOfBirth.HeaderText = "Date Of Birth";
            this.DateOfBirth.MinimumWidth = 6;
            this.DateOfBirth.Name = "DateOfBirth";
            this.DateOfBirth.ReadOnly = true;
            this.DateOfBirth.Width = 125;
            // 
            // Gender
            // 
            this.Gender.DataPropertyName = "Gender";
            this.Gender.HeaderText = "Gender";
            this.Gender.MinimumWidth = 6;
            this.Gender.Name = "Gender";
            this.Gender.ReadOnly = true;
            this.Gender.Width = 125;
            // 
            // PrisonerAddress
            // 
            this.PrisonerAddress.DataPropertyName = "PrisonerAddress";
            this.PrisonerAddress.HeaderText = "Prisoner Address";
            this.PrisonerAddress.MinimumWidth = 6;
            this.PrisonerAddress.Name = "PrisonerAddress";
            this.PrisonerAddress.ReadOnly = true;
            this.PrisonerAddress.Width = 125;
            // 
            // Crime
            // 
            this.Crime.DataPropertyName = "Crime";
            this.Crime.HeaderText = "Crime";
            this.Crime.MinimumWidth = 6;
            this.Crime.Name = "Crime";
            this.Crime.ReadOnly = true;
            this.Crime.Width = 125;
            // 
            // Work
            // 
            this.Work.DataPropertyName = "Work";
            this.Work.HeaderText = "Work";
            this.Work.MinimumWidth = 6;
            this.Work.Name = "Work";
            this.Work.ReadOnly = true;
            this.Work.Width = 125;
            // 
            // EntranceDate
            // 
            this.EntranceDate.DataPropertyName = "EntranceDate";
            this.EntranceDate.HeaderText = "Entrance Date";
            this.EntranceDate.MinimumWidth = 6;
            this.EntranceDate.Name = "EntranceDate";
            this.EntranceDate.ReadOnly = true;
            this.EntranceDate.Width = 125;
            // 
            // ReleaseDate
            // 
            this.ReleaseDate.DataPropertyName = "ReleaseDate";
            this.ReleaseDate.HeaderText = "Release Date";
            this.ReleaseDate.MinimumWidth = 6;
            this.ReleaseDate.Name = "ReleaseDate";
            this.ReleaseDate.ReadOnly = true;
            this.ReleaseDate.Width = 125;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.viewToolStripMenuItem,
            this.exitToolStripMenuItem,
            this.myProfileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1276, 28);
            this.menuStrip1.TabIndex = 24;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.searchPrisonerToolStripMenuItem,
            this.myProfileToolStripMenuItem1,
            this.exitToolStripMenuItem1});
            this.fileToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("fileToolStripMenuItem.Image")));
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(66, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // searchPrisonerToolStripMenuItem
            // 
            this.searchPrisonerToolStripMenuItem.Name = "searchPrisonerToolStripMenuItem";
            this.searchPrisonerToolStripMenuItem.Size = new System.Drawing.Size(193, 26);
            this.searchPrisonerToolStripMenuItem.Text = "Search Prisoner";
            this.searchPrisonerToolStripMenuItem.Click += new System.EventHandler(this.searchPrisonerToolStripMenuItem_Click);
            // 
            // myProfileToolStripMenuItem1
            // 
            this.myProfileToolStripMenuItem1.Name = "myProfileToolStripMenuItem1";
            this.myProfileToolStripMenuItem1.Size = new System.Drawing.Size(193, 26);
            this.myProfileToolStripMenuItem1.Text = "My Profile";
            this.myProfileToolStripMenuItem1.Click += new System.EventHandler(this.myProfileToolStripMenuItem1_Click);
            // 
            // exitToolStripMenuItem1
            // 
            this.exitToolStripMenuItem1.Name = "exitToolStripMenuItem1";
            this.exitToolStripMenuItem1.Size = new System.Drawing.Size(193, 26);
            this.exitToolStripMenuItem1.Text = "Exit";
            this.exitToolStripMenuItem1.Click += new System.EventHandler(this.exitToolStripMenuItem1_Click);
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.prisonerRecordsToolStripMenuItem});
            this.viewToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("viewToolStripMenuItem.Image")));
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(75, 24);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("exitToolStripMenuItem.Image")));
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(67, 24);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // myProfileToolStripMenuItem
            // 
            this.myProfileToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("myProfileToolStripMenuItem.Image")));
            this.myProfileToolStripMenuItem.Name = "myProfileToolStripMenuItem";
            this.myProfileToolStripMenuItem.Size = new System.Drawing.Size(110, 24);
            this.myProfileToolStripMenuItem.Text = "My Profile";
            this.myProfileToolStripMenuItem.Click += new System.EventHandler(this.myProfileToolStripMenuItem_Click);
            // 
            // prisonerRecordsToolStripMenuItem
            // 
            this.prisonerRecordsToolStripMenuItem.Name = "prisonerRecordsToolStripMenuItem";
            this.prisonerRecordsToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.prisonerRecordsToolStripMenuItem.Text = "Prisoner Records";
            this.prisonerRecordsToolStripMenuItem.Click += new System.EventHandler(this.prisonerRecordsToolStripMenuItem_Click);
            // 
            // FormLawyer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1276, 457);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgvRecords);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "FormLawyer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormLawyer";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecords)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.DataGridView dgvRecords;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrisonerId;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrisonerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrisonerFathersName;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateOfBirth;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gender;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrisonerAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn Crime;
        private System.Windows.Forms.DataGridViewTextBoxColumn Work;
        private System.Windows.Forms.DataGridViewTextBoxColumn EntranceDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReleaseDate;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem myProfileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchPrisonerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem myProfileToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem prisonerRecordsToolStripMenuItem;
    }
}