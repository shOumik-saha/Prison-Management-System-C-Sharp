
namespace PrisonManagementSystem
{
    partial class FormVisitor
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtVisitFor = new System.Windows.Forms.TextBox();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnReportRecords = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.cbGender = new System.Windows.Forms.ComboBox();
            this.txtEntryTime = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.dtpVisitDate = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.txtVisitorNationality = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtExitTime = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.rtxtVisitorAddress = new System.Windows.Forms.RichTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtVisitorNID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtVisitorName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
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
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVisitors)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtVisitFor);
            this.panel1.Controls.Add(this.btnPrevious);
            this.panel1.Controls.Add(this.btnClear);
            this.panel1.Controls.Add(this.btnReportRecords);
            this.panel1.Controls.Add(this.btnUpdate);
            this.panel1.Controls.Add(this.cbGender);
            this.panel1.Controls.Add(this.txtEntryTime);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.dtpVisitDate);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.txtVisitorNationality);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.txtExitTime);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.rtxtVisitorAddress);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtVisitorNID);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtVisitorName);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(0, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(567, 728);
            this.panel1.TabIndex = 25;
            // 
            // txtVisitFor
            // 
            this.txtVisitFor.Location = new System.Drawing.Point(284, 183);
            this.txtVisitFor.Name = "txtVisitFor";
            this.txtVisitFor.Size = new System.Drawing.Size(234, 22);
            this.txtVisitFor.TabIndex = 46;
            // 
            // btnPrevious
            // 
            this.btnPrevious.Location = new System.Drawing.Point(48, 663);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(134, 42);
            this.btnPrevious.TabIndex = 45;
            this.btnPrevious.Text = "Previous";
            this.btnPrevious.UseVisualStyleBackColor = true;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.LightGray;
            this.btnClear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnClear.Location = new System.Drawing.Point(375, 663);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(141, 42);
            this.btnClear.TabIndex = 44;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnReportRecords
            // 
            this.btnReportRecords.AutoSize = true;
            this.btnReportRecords.BackColor = System.Drawing.Color.Red;
            this.btnReportRecords.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReportRecords.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReportRecords.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnReportRecords.Location = new System.Drawing.Point(48, 615);
            this.btnReportRecords.Name = "btnReportRecords";
            this.btnReportRecords.Size = new System.Drawing.Size(468, 42);
            this.btnReportRecords.TabIndex = 16;
            this.btnReportRecords.Text = "Delete";
            this.btnReportRecords.UseVisualStyleBackColor = false;
            this.btnReportRecords.Click += new System.EventHandler(this.btnReportRecords_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.AutoSize = true;
            this.btnUpdate.BackColor = System.Drawing.Color.SteelBlue;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnUpdate.Location = new System.Drawing.Point(48, 567);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(468, 42);
            this.btnUpdate.TabIndex = 15;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // cbGender
            // 
            this.cbGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbGender.FormattingEnabled = true;
            this.cbGender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.cbGender.Location = new System.Drawing.Point(284, 222);
            this.cbGender.Name = "cbGender";
            this.cbGender.Size = new System.Drawing.Size(234, 24);
            this.cbGender.TabIndex = 29;
            // 
            // txtEntryTime
            // 
            this.txtEntryTime.Location = new System.Drawing.Point(282, 437);
            this.txtEntryTime.Name = "txtEntryTime";
            this.txtEntryTime.Size = new System.Drawing.Size(234, 22);
            this.txtEntryTime.TabIndex = 28;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(26, 178);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(150, 27);
            this.label11.TabIndex = 26;
            this.label11.Text = "Visitor For(Id)";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(24, 433);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(184, 27);
            this.label10.TabIndex = 24;
            this.label10.Text = "Vsitor Entry Time";
            // 
            // dtpVisitDate
            // 
            this.dtpVisitDate.CustomFormat = "yyyy-MM-dd";
            this.dtpVisitDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpVisitDate.Location = new System.Drawing.Point(282, 399);
            this.dtpVisitDate.Name = "dtpVisitDate";
            this.dtpVisitDate.Size = new System.Drawing.Size(234, 22);
            this.dtpVisitDate.TabIndex = 22;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(26, 472);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(175, 27);
            this.label8.TabIndex = 19;
            this.label8.Text = "Visitor Exit Time";
            // 
            // txtVisitorNationality
            // 
            this.txtVisitorNationality.Location = new System.Drawing.Point(284, 141);
            this.txtVisitorNationality.Name = "txtVisitorNationality";
            this.txtVisitorNationality.Size = new System.Drawing.Size(234, 22);
            this.txtVisitorNationality.TabIndex = 18;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(26, 137);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(188, 27);
            this.label7.TabIndex = 17;
            this.label7.Text = "Visitor Nationality";
            // 
            // txtExitTime
            // 
            this.txtExitTime.Location = new System.Drawing.Point(282, 477);
            this.txtExitTime.Name = "txtExitTime";
            this.txtExitTime.Size = new System.Drawing.Size(234, 22);
            this.txtExitTime.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(24, 397);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(176, 27);
            this.label6.TabIndex = 13;
            this.label6.Text = "Visitor Visit Date";
            // 
            // rtxtVisitorAddress
            // 
            this.rtxtVisitorAddress.Location = new System.Drawing.Point(282, 265);
            this.rtxtVisitorAddress.Name = "rtxtVisitorAddress";
            this.rtxtVisitorAddress.Size = new System.Drawing.Size(236, 122);
            this.rtxtVisitorAddress.TabIndex = 12;
            this.rtxtVisitorAddress.Text = "";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(24, 265);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(158, 27);
            this.label5.TabIndex = 11;
            this.label5.Text = "Visitor Address";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(26, 219);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 27);
            this.label4.TabIndex = 7;
            this.label4.Text = "Gender";
            // 
            // txtVisitorNID
            // 
            this.txtVisitorNID.Location = new System.Drawing.Point(284, 101);
            this.txtVisitorNID.Name = "txtVisitorNID";
            this.txtVisitorNID.Size = new System.Drawing.Size(234, 22);
            this.txtVisitorNID.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(26, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 27);
            this.label3.TabIndex = 5;
            this.label3.Text = "Visitor NID";
            // 
            // txtVisitorName
            // 
            this.txtVisitorName.Location = new System.Drawing.Point(284, 63);
            this.txtVisitorName.Name = "txtVisitorName";
            this.txtVisitorName.Size = new System.Drawing.Size(234, 22);
            this.txtVisitorName.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 27);
            this.label1.TabIndex = 3;
            this.label1.Text = "Visitor Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 16.2F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(188, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(190, 32);
            this.label2.TabIndex = 2;
            this.label2.Text = "Visitor Records";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel3.Controls.Add(this.btnRefresh);
            this.panel3.Controls.Add(this.txtSearch);
            this.panel3.Controls.Add(this.btnSearch);
            this.panel3.Location = new System.Drawing.Point(568, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(629, 202);
            this.panel3.TabIndex = 26;
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
            this.dgvVisitors.Location = new System.Drawing.Point(568, 197);
            this.dgvVisitors.Name = "dgvVisitors";
            this.dgvVisitors.ReadOnly = true;
            this.dgvVisitors.RowHeadersWidth = 51;
            this.dgvVisitors.RowTemplate.Height = 24;
            this.dgvVisitors.Size = new System.Drawing.Size(629, 533);
            this.dgvVisitors.TabIndex = 27;
            this.dgvVisitors.DoubleClick += new System.EventHandler(this.dgvVisitors_DoubleClick);
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
            this.VisitorNID.DataPropertyName = "VisitorNID";
            this.VisitorNID.HeaderText = "NID";
            this.VisitorNID.MinimumWidth = 6;
            this.VisitorNID.Name = "VisitorNID";
            this.VisitorNID.ReadOnly = true;
            this.VisitorNID.Width = 64;
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
            // FormVisitor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1197, 731);
            this.Controls.Add(this.dgvVisitors);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.Name = "FormVisitor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormVisitor";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVisitors)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnReportRecords;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.ComboBox cbGender;
        private System.Windows.Forms.TextBox txtEntryTime;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker dtpVisitDate;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtVisitorNationality;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtExitTime;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RichTextBox rtxtVisitorAddress;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtVisitorNID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtVisitorName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DataGridView dgvVisitors;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.TextBox txtVisitFor;
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