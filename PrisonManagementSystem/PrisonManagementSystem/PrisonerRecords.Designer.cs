
namespace PrisonManagementSystem
{
    partial class PrisonerRecords
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
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
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
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecords)).BeginInit();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel3.Controls.Add(this.txtSearch);
            this.panel3.Controls.Add(this.btnSearch);
            this.panel3.Controls.Add(this.btnRefresh);
            this.panel3.Location = new System.Drawing.Point(2, 1);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(750, 163);
            this.panel3.TabIndex = 11;
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(335, 66);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(225, 34);
            this.txtSearch.TabIndex = 21;
            // 
            // btnSearch
            // 
            this.btnSearch.AutoSize = true;
            this.btnSearch.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSearch.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSearch.Location = new System.Drawing.Point(167, 66);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(121, 36);
            this.btnSearch.TabIndex = 20;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.AutoSize = true;
            this.btnRefresh.BackColor = System.Drawing.Color.LightSlateGray;
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnRefresh.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnRefresh.Location = new System.Drawing.Point(629, 128);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(121, 35);
            this.btnRefresh.TabIndex = 19;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
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
            this.dgvRecords.Location = new System.Drawing.Point(2, 160);
            this.dgvRecords.Name = "dgvRecords";
            this.dgvRecords.ReadOnly = true;
            this.dgvRecords.RowHeadersWidth = 51;
            this.dgvRecords.RowTemplate.Height = 24;
            this.dgvRecords.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRecords.Size = new System.Drawing.Size(750, 457);
            this.dgvRecords.TabIndex = 12;
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
            // PrisonerRecords
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(753, 614);
            this.Controls.Add(this.dgvRecords);
            this.Controls.Add(this.panel3);
            this.Name = "PrisonerRecords";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PrisonerRecords";
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecords)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnRefresh;
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
    }
}