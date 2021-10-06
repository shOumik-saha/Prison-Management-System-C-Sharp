
namespace PrisonManagementSystem
{
    partial class JailerProfile
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(JailerProfile));
            this.dgvJailerRecords = new System.Windows.Forms.DataGridView();
            this.JailerId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.JailerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Designation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvJailerRecords)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvJailerRecords
            // 
            this.dgvJailerRecords.AllowUserToAddRows = false;
            this.dgvJailerRecords.AllowUserToDeleteRows = false;
            this.dgvJailerRecords.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvJailerRecords.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.JailerId,
            this.JailerName,
            this.Gender,
            this.Designation,
            this.Status});
            this.dgvJailerRecords.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvJailerRecords.Location = new System.Drawing.Point(0, 145);
            this.dgvJailerRecords.Name = "dgvJailerRecords";
            this.dgvJailerRecords.ReadOnly = true;
            this.dgvJailerRecords.RowHeadersWidth = 51;
            this.dgvJailerRecords.RowTemplate.Height = 24;
            this.dgvJailerRecords.Size = new System.Drawing.Size(868, 397);
            this.dgvJailerRecords.TabIndex = 28;
            // 
            // JailerId
            // 
            this.JailerId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.JailerId.DataPropertyName = "JailerId";
            this.JailerId.HeaderText = "Jailer Id";
            this.JailerId.MinimumWidth = 6;
            this.JailerId.Name = "JailerId";
            this.JailerId.ReadOnly = true;
            // 
            // JailerName
            // 
            this.JailerName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.JailerName.DataPropertyName = "JailerName";
            this.JailerName.HeaderText = "Jailer Name";
            this.JailerName.MinimumWidth = 6;
            this.JailerName.Name = "JailerName";
            this.JailerName.ReadOnly = true;
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
            // Designation
            // 
            this.Designation.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Designation.DataPropertyName = "Designation";
            this.Designation.HeaderText = "Designation";
            this.Designation.MinimumWidth = 6;
            this.Designation.Name = "Designation";
            this.Designation.ReadOnly = true;
            // 
            // Status
            // 
            this.Status.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Status.DataPropertyName = "Status";
            this.Status.HeaderText = "Status";
            this.Status.MinimumWidth = 6;
            this.Status.Name = "Status";
            this.Status.ReadOnly = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnSearch);
            this.panel1.Controls.Add(this.txtSearch);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(868, 147);
            this.panel1.TabIndex = 29;
            // 
            // btnSearch
            // 
            this.btnSearch.AutoSize = true;
            this.btnSearch.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSearch.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSearch.Location = new System.Drawing.Point(231, 56);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(155, 36);
            this.btnSearch.TabIndex = 32;
            this.btnSearch.Text = "Search By Id";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(410, 56);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(234, 34);
            this.txtSearch.TabIndex = 31;
            // 
            // JailerProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(868, 542);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgvJailerRecords);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "JailerProfile";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "JailerProfile";
            ((System.ComponentModel.ISupportInitialize)(this.dgvJailerRecords)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvJailerRecords;
        private System.Windows.Forms.DataGridViewTextBoxColumn JailerId;
        private System.Windows.Forms.DataGridViewTextBoxColumn JailerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gender;
        private System.Windows.Forms.DataGridViewTextBoxColumn Designation;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearch;
    }
}