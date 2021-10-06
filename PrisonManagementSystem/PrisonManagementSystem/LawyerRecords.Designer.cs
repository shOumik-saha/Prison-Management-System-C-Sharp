
namespace PrisonManagementSystem
{
    partial class LawyerRecords
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
            this.txtLawyerEmail = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtLawyerRegistrationNumber = new System.Windows.Forms.TextBox();
            this.cbLawyerType = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cbLawyerStatus = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtLawyerName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtLawyerId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.dgvLawyer = new System.Windows.Forms.DataGridView();
            this.LawyerId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LawyerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LawyerType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LawyerRegistrationNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LawyerStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LawyerEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLawyer)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtLawyerEmail
            // 
            this.txtLawyerEmail.Location = new System.Drawing.Point(307, 325);
            this.txtLawyerEmail.Name = "txtLawyerEmail";
            this.txtLawyerEmail.Size = new System.Drawing.Size(234, 22);
            this.txtLawyerEmail.TabIndex = 41;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(49, 325);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 27);
            this.label5.TabIndex = 40;
            this.label5.Text = "Email";
            // 
            // txtLawyerRegistrationNumber
            // 
            this.txtLawyerRegistrationNumber.Location = new System.Drawing.Point(307, 239);
            this.txtLawyerRegistrationNumber.Name = "txtLawyerRegistrationNumber";
            this.txtLawyerRegistrationNumber.Size = new System.Drawing.Size(234, 22);
            this.txtLawyerRegistrationNumber.TabIndex = 39;
            // 
            // cbLawyerType
            // 
            this.cbLawyerType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbLawyerType.FormattingEnabled = true;
            this.cbLawyerType.Items.AddRange(new object[] {
            "Criminal Defence Lawyer",
            "Real Estate Lawyer",
            "Family Lawyer",
            "Tax Lawyer",
            "Business Lawyer",
            "Bankruptey Lawyer"});
            this.cbLawyerType.Location = new System.Drawing.Point(307, 196);
            this.cbLawyerType.Name = "cbLawyerType";
            this.cbLawyerType.Size = new System.Drawing.Size(234, 24);
            this.cbLawyerType.TabIndex = 38;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(49, 192);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 27);
            this.label7.TabIndex = 37;
            this.label7.Text = "Type";
            // 
            // cbLawyerStatus
            // 
            this.cbLawyerStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbLawyerStatus.FormattingEnabled = true;
            this.cbLawyerStatus.Items.AddRange(new object[] {
            "Currently Registered",
            "Currently Not Registered"});
            this.cbLawyerStatus.Location = new System.Drawing.Point(307, 279);
            this.cbLawyerStatus.Name = "cbLawyerStatus";
            this.cbLawyerStatus.Size = new System.Drawing.Size(234, 24);
            this.cbLawyerStatus.TabIndex = 34;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(49, 279);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 27);
            this.label6.TabIndex = 33;
            this.label6.Text = "Status";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(49, 234);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(212, 27);
            this.label4.TabIndex = 11;
            this.label4.Text = "Registration Number";
            // 
            // txtLawyerName
            // 
            this.txtLawyerName.Location = new System.Drawing.Point(307, 154);
            this.txtLawyerName.Name = "txtLawyerName";
            this.txtLawyerName.Size = new System.Drawing.Size(234, 22);
            this.txtLawyerName.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(49, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(149, 27);
            this.label3.TabIndex = 9;
            this.label3.Text = "Lawyer Name";
            // 
            // txtLawyerId
            // 
            this.txtLawyerId.Location = new System.Drawing.Point(307, 108);
            this.txtLawyerId.Name = "txtLawyerId";
            this.txtLawyerId.Size = new System.Drawing.Size(234, 22);
            this.txtLawyerId.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(49, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 27);
            this.label1.TabIndex = 7;
            this.label1.Text = "Lawyer Id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 16.2F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(198, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(200, 32);
            this.label2.TabIndex = 3;
            this.label2.Text = "Lawyer Records";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Location = new System.Drawing.Point(604, 3);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(646, 169);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // btnRefresh
            // 
            this.btnRefresh.AutoSize = true;
            this.btnRefresh.BackColor = System.Drawing.Color.LightSlateGray;
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnRefresh.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnRefresh.Location = new System.Drawing.Point(516, 141);
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
            this.panel2.Location = new System.Drawing.Point(601, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(638, 177);
            this.panel2.TabIndex = 31;
            // 
            // btnSearch
            // 
            this.btnSearch.AutoSize = true;
            this.btnSearch.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSearch.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSearch.Location = new System.Drawing.Point(96, 64);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(121, 35);
            this.btnSearch.TabIndex = 25;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(293, 72);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(234, 22);
            this.txtSearch.TabIndex = 24;
            // 
            // dgvLawyer
            // 
            this.dgvLawyer.AllowUserToAddRows = false;
            this.dgvLawyer.AllowUserToDeleteRows = false;
            this.dgvLawyer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLawyer.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.LawyerId,
            this.LawyerName,
            this.LawyerType,
            this.LawyerRegistrationNumber,
            this.LawyerStatus,
            this.LawyerEmail});
            this.dgvLawyer.Location = new System.Drawing.Point(601, 181);
            this.dgvLawyer.Name = "dgvLawyer";
            this.dgvLawyer.ReadOnly = true;
            this.dgvLawyer.RowHeadersWidth = 51;
            this.dgvLawyer.RowTemplate.Height = 24;
            this.dgvLawyer.Size = new System.Drawing.Size(638, 385);
            this.dgvLawyer.TabIndex = 32;
            this.dgvLawyer.DoubleClick += new System.EventHandler(this.dgvLawyer_DoubleClick);
            // 
            // LawyerId
            // 
            this.LawyerId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.LawyerId.DataPropertyName = "LawyerId";
            this.LawyerId.HeaderText = "Id";
            this.LawyerId.MinimumWidth = 6;
            this.LawyerId.Name = "LawyerId";
            this.LawyerId.ReadOnly = true;
            // 
            // LawyerName
            // 
            this.LawyerName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.LawyerName.DataPropertyName = "LawyerName";
            this.LawyerName.HeaderText = "Name";
            this.LawyerName.MinimumWidth = 6;
            this.LawyerName.Name = "LawyerName";
            this.LawyerName.ReadOnly = true;
            // 
            // LawyerType
            // 
            this.LawyerType.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.LawyerType.DataPropertyName = "LawyerType";
            this.LawyerType.HeaderText = "Type";
            this.LawyerType.MinimumWidth = 6;
            this.LawyerType.Name = "LawyerType";
            this.LawyerType.ReadOnly = true;
            // 
            // LawyerRegistrationNumber
            // 
            this.LawyerRegistrationNumber.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.LawyerRegistrationNumber.DataPropertyName = "LawyerRegistrationNumber";
            this.LawyerRegistrationNumber.HeaderText = "Registration Number";
            this.LawyerRegistrationNumber.MinimumWidth = 6;
            this.LawyerRegistrationNumber.Name = "LawyerRegistrationNumber";
            this.LawyerRegistrationNumber.ReadOnly = true;
            // 
            // LawyerStatus
            // 
            this.LawyerStatus.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.LawyerStatus.DataPropertyName = "LawyerStatus";
            this.LawyerStatus.HeaderText = "Status";
            this.LawyerStatus.MinimumWidth = 6;
            this.LawyerStatus.Name = "LawyerStatus";
            this.LawyerStatus.ReadOnly = true;
            // 
            // LawyerEmail
            // 
            this.LawyerEmail.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.LawyerEmail.DataPropertyName = "LawyerEmail";
            this.LawyerEmail.HeaderText = "Email";
            this.LawyerEmail.MinimumWidth = 6;
            this.LawyerEmail.Name = "LawyerEmail";
            this.LawyerEmail.ReadOnly = true;
            // 
            // panel3
            // 
            this.panel3.Location = new System.Drawing.Point(596, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(651, 217);
            this.panel3.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnPrevious);
            this.panel1.Controls.Add(this.btnClear);
            this.panel1.Controls.Add(this.btnDelete);
            this.panel1.Controls.Add(this.btnUpdate);
            this.panel1.Controls.Add(this.txtLawyerEmail);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txtLawyerRegistrationNumber);
            this.panel1.Controls.Add(this.cbLawyerType);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.cbLawyerStatus);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtLawyerName);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtLawyerId);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.flowLayoutPanel1);
            this.panel1.Location = new System.Drawing.Point(1, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(598, 564);
            this.panel1.TabIndex = 30;
            // 
            // btnPrevious
            // 
            this.btnPrevious.Location = new System.Drawing.Point(348, 461);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(127, 42);
            this.btnPrevious.TabIndex = 46;
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
            this.btnClear.Location = new System.Drawing.Point(94, 461);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(127, 42);
            this.btnClear.TabIndex = 47;
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
            this.btnDelete.Location = new System.Drawing.Point(348, 397);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(127, 42);
            this.btnDelete.TabIndex = 46;
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
            this.btnUpdate.Location = new System.Drawing.Point(94, 397);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(127, 42);
            this.btnUpdate.TabIndex = 45;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // LawyerRecords
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1238, 569);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.dgvLawyer);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.Name = "LawyerRecords";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LawyerRecords";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLawyer)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtLawyerEmail;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtLawyerRegistrationNumber;
        private System.Windows.Forms.ComboBox cbLawyerType;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbLawyerStatus;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtLawyerName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtLawyerId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.DataGridView dgvLawyer;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.DataGridViewTextBoxColumn LawyerId;
        private System.Windows.Forms.DataGridViewTextBoxColumn LawyerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn LawyerType;
        private System.Windows.Forms.DataGridViewTextBoxColumn LawyerRegistrationNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn LawyerStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn LawyerEmail;
        private System.Windows.Forms.Button btnPrevious;
    }
}