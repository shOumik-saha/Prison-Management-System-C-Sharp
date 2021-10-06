
namespace PrisonManagementSystem
{
    partial class JailerRecords
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
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.cbGender = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtJailerId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Designation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.JailerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.JailerId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvJailerRecords = new System.Windows.Forms.DataGridView();
            this.cbStatus = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cbDesignation = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtJailerName = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvJailerRecords)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSearch
            // 
            this.btnSearch.AutoSize = true;
            this.btnSearch.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSearch.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSearch.Location = new System.Drawing.Point(102, 62);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(121, 35);
            this.btnSearch.TabIndex = 25;
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
            this.btnRefresh.Location = new System.Drawing.Point(512, 124);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(121, 35);
            this.btnRefresh.TabIndex = 23;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.btnSearch);
            this.panel2.Controls.Add(this.txtSearch);
            this.panel2.Controls.Add(this.btnRefresh);
            this.panel2.Location = new System.Drawing.Point(602, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(638, 160);
            this.panel2.TabIndex = 28;
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(299, 70);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(234, 22);
            this.txtSearch.TabIndex = 24;
            // 
            // cbGender
            // 
            this.cbGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbGender.FormattingEnabled = true;
            this.cbGender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.cbGender.Location = new System.Drawing.Point(307, 209);
            this.cbGender.Name = "cbGender";
            this.cbGender.Size = new System.Drawing.Size(234, 24);
            this.cbGender.TabIndex = 38;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(49, 205);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 27);
            this.label7.TabIndex = 37;
            this.label7.Text = "Gender";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(49, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 27);
            this.label3.TabIndex = 9;
            this.label3.Text = "Jailer Name";
            // 
            // txtJailerId
            // 
            this.txtJailerId.Location = new System.Drawing.Point(307, 108);
            this.txtJailerId.Name = "txtJailerId";
            this.txtJailerId.Size = new System.Drawing.Size(234, 22);
            this.txtJailerId.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(49, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 27);
            this.label1.TabIndex = 7;
            this.label1.Text = "Jailer Id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 16.2F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(198, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(182, 32);
            this.label2.TabIndex = 3;
            this.label2.Text = "Jailer Records";
            // 
            // panel3
            // 
            this.panel3.Location = new System.Drawing.Point(596, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(651, 217);
            this.panel3.TabIndex = 2;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Location = new System.Drawing.Point(604, 3);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(646, 169);
            this.flowLayoutPanel1.TabIndex = 1;
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
            // Designation
            // 
            this.Designation.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Designation.DataPropertyName = "Designation";
            this.Designation.HeaderText = "Designation";
            this.Designation.MinimumWidth = 6;
            this.Designation.Name = "Designation";
            this.Designation.ReadOnly = true;
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
            // JailerName
            // 
            this.JailerName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.JailerName.DataPropertyName = "JailerName";
            this.JailerName.HeaderText = "Jailer Name";
            this.JailerName.MinimumWidth = 6;
            this.JailerName.Name = "JailerName";
            this.JailerName.ReadOnly = true;
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
            this.dgvJailerRecords.Location = new System.Drawing.Point(602, 161);
            this.dgvJailerRecords.Name = "dgvJailerRecords";
            this.dgvJailerRecords.ReadOnly = true;
            this.dgvJailerRecords.RowHeadersWidth = 51;
            this.dgvJailerRecords.RowTemplate.Height = 24;
            this.dgvJailerRecords.Size = new System.Drawing.Size(638, 398);
            this.dgvJailerRecords.TabIndex = 27;
            this.dgvJailerRecords.DoubleClick += new System.EventHandler(this.dgvJailerRecords_DoubleClick);
            // 
            // cbStatus
            // 
            this.cbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbStatus.FormattingEnabled = true;
            this.cbStatus.Items.AddRange(new object[] {
            "Currently Here",
            "Currently Not Here"});
            this.cbStatus.Location = new System.Drawing.Point(307, 293);
            this.cbStatus.Name = "cbStatus";
            this.cbStatus.Size = new System.Drawing.Size(234, 24);
            this.cbStatus.TabIndex = 34;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(49, 293);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 27);
            this.label6.TabIndex = 33;
            this.label6.Text = "Status";
            // 
            // cbDesignation
            // 
            this.cbDesignation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDesignation.FormattingEnabled = true;
            this.cbDesignation.Items.AddRange(new object[] {
            "Inspector General",
            "Aditional Inspector General",
            "Dy.Inspactor General",
            "Superintendent",
            "Law Officer",
            "Resident Medical Officer-RMO"});
            this.cbDesignation.Location = new System.Drawing.Point(307, 250);
            this.cbDesignation.Name = "cbDesignation";
            this.cbDesignation.Size = new System.Drawing.Size(234, 24);
            this.cbDesignation.TabIndex = 30;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(49, 247);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 27);
            this.label4.TabIndex = 11;
            this.label4.Text = "Designation";
            // 
            // txtJailerName
            // 
            this.txtJailerName.Location = new System.Drawing.Point(307, 154);
            this.txtJailerName.Name = "txtJailerName";
            this.txtJailerName.Size = new System.Drawing.Size(234, 22);
            this.txtJailerName.TabIndex = 10;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnPrevious);
            this.panel1.Controls.Add(this.btnClear);
            this.panel1.Controls.Add(this.btnDelete);
            this.panel1.Controls.Add(this.btnUpdate);
            this.panel1.Controls.Add(this.cbGender);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.cbStatus);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.cbDesignation);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtJailerName);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtJailerId);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.flowLayoutPanel1);
            this.panel1.Location = new System.Drawing.Point(2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(598, 557);
            this.panel1.TabIndex = 26;
            // 
            // btnPrevious
            // 
            this.btnPrevious.Location = new System.Drawing.Point(54, 468);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(134, 42);
            this.btnPrevious.TabIndex = 51;
            this.btnPrevious.Text = "Previous";
            this.btnPrevious.UseVisualStyleBackColor = true;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.White;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnClear.Location = new System.Drawing.Point(432, 466);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(90, 42);
            this.btnClear.TabIndex = 50;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.AutoSize = true;
            this.btnDelete.BackColor = System.Drawing.Color.Red;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnDelete.Location = new System.Drawing.Point(54, 418);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(468, 42);
            this.btnDelete.TabIndex = 49;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.AutoSize = true;
            this.btnUpdate.BackColor = System.Drawing.Color.SteelBlue;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnUpdate.Location = new System.Drawing.Point(54, 370);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(468, 42);
            this.btnUpdate.TabIndex = 48;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // JailerRecords
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1263, 556);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.dgvJailerRecords);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.Name = "JailerRecords";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "JailerRecords";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvJailerRecords)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.ComboBox cbGender;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtJailerId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.DataGridViewTextBoxColumn Designation;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gender;
        private System.Windows.Forms.DataGridViewTextBoxColumn JailerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn JailerId;
        private System.Windows.Forms.DataGridView dgvJailerRecords;
        private System.Windows.Forms.ComboBox cbStatus;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbDesignation;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtJailerName;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnPrevious;
    }
}