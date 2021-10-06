
namespace PrisonManagementSystem
{
    partial class VisitorsProfile
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
            this.btnRefresh = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.dgvVisitors = new System.Windows.Forms.DataGridView();
            this.VisitorName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VisitorNID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VisitorNationality = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VisitorFor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VisitorAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VisitorEntryDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VisitorEntryTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VisitorExitTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVisitors)).BeginInit();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel3.Controls.Add(this.btnRefresh);
            this.panel3.Controls.Add(this.txtSearch);
            this.panel3.Controls.Add(this.btnSearch);
            this.panel3.Location = new System.Drawing.Point(0, -2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(629, 202);
            this.panel3.TabIndex = 30;
            // 
            // btnRefresh
            // 
            this.btnRefresh.AutoSize = true;
            this.btnRefresh.BackColor = System.Drawing.Color.LightSlateGray;
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnRefresh.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnRefresh.Location = new System.Drawing.Point(508, 164);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(121, 35);
            this.btnRefresh.TabIndex = 20;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(325, 84);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(225, 22);
            this.txtSearch.TabIndex = 19;
            // 
            // btnSearch
            // 
            this.btnSearch.AutoSize = true;
            this.btnSearch.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSearch.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSearch.Location = new System.Drawing.Point(117, 76);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(121, 35);
            this.btnSearch.TabIndex = 18;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // dgvVisitors
            // 
            this.dgvVisitors.AllowUserToAddRows = false;
            this.dgvVisitors.AllowUserToDeleteRows = false;
            this.dgvVisitors.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVisitors.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.VisitorName,
            this.VisitorNID,
            this.VisitorNationality,
            this.VisitorFor,
            this.Gender,
            this.VisitorAddress,
            this.VisitorEntryDate,
            this.VisitorEntryTime,
            this.VisitorExitTime});
            this.dgvVisitors.Location = new System.Drawing.Point(0, 196);
            this.dgvVisitors.Name = "dgvVisitors";
            this.dgvVisitors.ReadOnly = true;
            this.dgvVisitors.RowHeadersWidth = 51;
            this.dgvVisitors.RowTemplate.Height = 24;
            this.dgvVisitors.Size = new System.Drawing.Size(629, 519);
            this.dgvVisitors.TabIndex = 31;
            // 
            // VisitorName
            // 
            this.VisitorName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.VisitorName.DataPropertyName = "VisitorName";
            this.VisitorName.HeaderText = "Name";
            this.VisitorName.MinimumWidth = 6;
            this.VisitorName.Name = "VisitorName";
            this.VisitorName.ReadOnly = true;
            // 
            // VisitorNID
            // 
            this.VisitorNID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.VisitorNID.DataPropertyName = "VisitorNID";
            this.VisitorNID.HeaderText = "NID";
            this.VisitorNID.MinimumWidth = 6;
            this.VisitorNID.Name = "VisitorNID";
            this.VisitorNID.ReadOnly = true;
            // 
            // VisitorNationality
            // 
            this.VisitorNationality.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.VisitorNationality.DataPropertyName = "VisitorNationality";
            this.VisitorNationality.HeaderText = "Nationality";
            this.VisitorNationality.MinimumWidth = 6;
            this.VisitorNationality.Name = "VisitorNationality";
            this.VisitorNationality.ReadOnly = true;
            // 
            // VisitorFor
            // 
            this.VisitorFor.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.VisitorFor.DataPropertyName = "VisitorFor";
            this.VisitorFor.HeaderText = "Visitor For (Id)";
            this.VisitorFor.MinimumWidth = 6;
            this.VisitorFor.Name = "VisitorFor";
            this.VisitorFor.ReadOnly = true;
            // 
            // Gender
            // 
            this.Gender.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Gender.DataPropertyName = "Gender";
            this.Gender.HeaderText = "Gender";
            this.Gender.MinimumWidth = 6;
            this.Gender.Name = "Gender";
            this.Gender.ReadOnly = true;
            // 
            // VisitorAddress
            // 
            this.VisitorAddress.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.VisitorAddress.DataPropertyName = "VisitorAddress";
            this.VisitorAddress.HeaderText = "Address";
            this.VisitorAddress.MinimumWidth = 6;
            this.VisitorAddress.Name = "VisitorAddress";
            this.VisitorAddress.ReadOnly = true;
            // 
            // VisitorEntryDate
            // 
            this.VisitorEntryDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.VisitorEntryDate.DataPropertyName = "VisitorEntryDate";
            this.VisitorEntryDate.HeaderText = "Entry Date";
            this.VisitorEntryDate.MinimumWidth = 6;
            this.VisitorEntryDate.Name = "VisitorEntryDate";
            this.VisitorEntryDate.ReadOnly = true;
            // 
            // VisitorEntryTime
            // 
            this.VisitorEntryTime.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.VisitorEntryTime.DataPropertyName = "VisitorEntryTime";
            this.VisitorEntryTime.HeaderText = "Entry time";
            this.VisitorEntryTime.MinimumWidth = 6;
            this.VisitorEntryTime.Name = "VisitorEntryTime";
            this.VisitorEntryTime.ReadOnly = true;
            // 
            // VisitorExitTime
            // 
            this.VisitorExitTime.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.VisitorExitTime.DataPropertyName = "VisitorExitTime";
            this.VisitorExitTime.HeaderText = "Exit Time";
            this.VisitorExitTime.MinimumWidth = 6;
            this.VisitorExitTime.Name = "VisitorExitTime";
            this.VisitorExitTime.ReadOnly = true;
            // 
            // VisitorsProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(630, 712);
            this.Controls.Add(this.dgvVisitors);
            this.Controls.Add(this.panel3);
            this.MaximizeBox = false;
            this.Name = "VisitorsProfile";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VisitorsProfile";
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVisitors)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DataGridView dgvVisitors;
        private System.Windows.Forms.DataGridViewTextBoxColumn VisitorName;
        private System.Windows.Forms.DataGridViewTextBoxColumn VisitorNID;
        private System.Windows.Forms.DataGridViewTextBoxColumn VisitorNationality;
        private System.Windows.Forms.DataGridViewTextBoxColumn VisitorFor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gender;
        private System.Windows.Forms.DataGridViewTextBoxColumn VisitorAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn VisitorEntryDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn VisitorEntryTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn VisitorExitTime;
    }
}