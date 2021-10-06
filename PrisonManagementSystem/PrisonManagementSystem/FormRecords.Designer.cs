
namespace PrisonManagementSystem
{
    partial class FormRecords
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
            this.EntranceDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Crime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cbGender = new System.Windows.Forms.ComboBox();
            this.txtWork = new System.Windows.Forms.TextBox();
            this.dtpDOB = new System.Windows.Forms.DateTimePicker();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.dtpReleaseDate = new System.Windows.Forms.DateTimePicker();
            this.PrisonerAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtpEntranceDate = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.txtPrisonerFName = new System.Windows.Forms.TextBox();
            this.Work = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateOfBirth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label8 = new System.Windows.Forms.Label();
            this.PrisonerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label7 = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.txtCrime = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.PrisonerFathersName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ReleaseDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rtxtPrisonerAddress = new System.Windows.Forms.RichTextBox();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPrisonerName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPrisonerId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.PrisonerId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvRecords = new System.Windows.Forms.DataGridView();
            this.btnClear = new System.Windows.Forms.Button();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecords)).BeginInit();
            this.SuspendLayout();
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
            // Crime
            // 
            this.Crime.DataPropertyName = "Crime";
            this.Crime.HeaderText = "Crime";
            this.Crime.MinimumWidth = 6;
            this.Crime.Name = "Crime";
            this.Crime.ReadOnly = true;
            this.Crime.Width = 125;
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
            // txtWork
            // 
            this.txtWork.Location = new System.Drawing.Point(282, 437);
            this.txtWork.Name = "txtWork";
            this.txtWork.Size = new System.Drawing.Size(234, 22);
            this.txtWork.TabIndex = 28;
            // 
            // dtpDOB
            // 
            this.dtpDOB.CustomFormat = "yyyy-MM-dd";
            this.dtpDOB.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDOB.Location = new System.Drawing.Point(284, 180);
            this.dtpDOB.Name = "dtpDOB";
            this.dtpDOB.Size = new System.Drawing.Size(234, 22);
            this.dtpDOB.TabIndex = 27;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(26, 178);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(144, 27);
            this.label11.TabIndex = 26;
            this.label11.Text = "Date Of Birth";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(24, 433);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(65, 27);
            this.label10.TabIndex = 24;
            this.label10.Text = "Work";
            // 
            // dtpReleaseDate
            // 
            this.dtpReleaseDate.CustomFormat = "yyyy-MM-dd";
            this.dtpReleaseDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpReleaseDate.Location = new System.Drawing.Point(282, 519);
            this.dtpReleaseDate.Name = "dtpReleaseDate";
            this.dtpReleaseDate.Size = new System.Drawing.Size(234, 22);
            this.dtpReleaseDate.TabIndex = 23;
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
            // Gender
            // 
            this.Gender.DataPropertyName = "Gender";
            this.Gender.HeaderText = "Gender";
            this.Gender.MinimumWidth = 6;
            this.Gender.Name = "Gender";
            this.Gender.ReadOnly = true;
            this.Gender.Width = 125;
            // 
            // dtpEntranceDate
            // 
            this.dtpEntranceDate.CustomFormat = "yyyy-MM-dd";
            this.dtpEntranceDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpEntranceDate.Location = new System.Drawing.Point(282, 491);
            this.dtpEntranceDate.Name = "dtpEntranceDate";
            this.dtpEntranceDate.Size = new System.Drawing.Size(234, 22);
            this.dtpEntranceDate.TabIndex = 22;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(29, 519);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(139, 27);
            this.label9.TabIndex = 21;
            this.label9.Text = "Release Date";
            // 
            // txtPrisonerFName
            // 
            this.txtPrisonerFName.Location = new System.Drawing.Point(284, 141);
            this.txtPrisonerFName.Name = "txtPrisonerFName";
            this.txtPrisonerFName.Size = new System.Drawing.Size(234, 22);
            this.txtPrisonerFName.TabIndex = 18;
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
            // DateOfBirth
            // 
            this.DateOfBirth.DataPropertyName = "DateOfBirth";
            this.DateOfBirth.HeaderText = "Date Of Birth";
            this.DateOfBirth.MinimumWidth = 6;
            this.DateOfBirth.Name = "DateOfBirth";
            this.DateOfBirth.ReadOnly = true;
            this.DateOfBirth.Width = 125;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(26, 472);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(151, 27);
            this.label8.TabIndex = 19;
            this.label8.Text = "Entrance Date";
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
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(26, 137);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(236, 27);
            this.label7.TabIndex = 17;
            this.label7.Text = "Prisoner Father\'s Name";
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Red;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnDelete.Location = new System.Drawing.Point(52, 617);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(435, 42);
            this.btnDelete.TabIndex = 16;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // txtCrime
            // 
            this.txtCrime.Location = new System.Drawing.Point(282, 402);
            this.txtCrime.Name = "txtCrime";
            this.txtCrime.Size = new System.Drawing.Size(234, 22);
            this.txtCrime.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(24, 397);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 27);
            this.label6.TabIndex = 13;
            this.label6.Text = "Crime";
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
            // ReleaseDate
            // 
            this.ReleaseDate.DataPropertyName = "ReleaseDate";
            this.ReleaseDate.HeaderText = "Release Date";
            this.ReleaseDate.MinimumWidth = 6;
            this.ReleaseDate.Name = "ReleaseDate";
            this.ReleaseDate.ReadOnly = true;
            this.ReleaseDate.Width = 125;
            // 
            // rtxtPrisonerAddress
            // 
            this.rtxtPrisonerAddress.Location = new System.Drawing.Point(282, 265);
            this.rtxtPrisonerAddress.Name = "rtxtPrisonerAddress";
            this.rtxtPrisonerAddress.Size = new System.Drawing.Size(236, 122);
            this.rtxtPrisonerAddress.TabIndex = 12;
            this.rtxtPrisonerAddress.Text = "";
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
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(24, 265);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(175, 27);
            this.label5.TabIndex = 11;
            this.label5.Text = "Prisoner Address";
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
            // txtPrisonerName
            // 
            this.txtPrisonerName.Location = new System.Drawing.Point(284, 101);
            this.txtPrisonerName.Name = "txtPrisonerName";
            this.txtPrisonerName.Size = new System.Drawing.Size(234, 22);
            this.txtPrisonerName.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(26, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(155, 27);
            this.label3.TabIndex = 5;
            this.label3.Text = "Prisoner Name";
            // 
            // txtPrisonerId
            // 
            this.txtPrisonerId.Location = new System.Drawing.Point(284, 63);
            this.txtPrisonerId.Name = "txtPrisonerId";
            this.txtPrisonerId.Size = new System.Drawing.Size(234, 22);
            this.txtPrisonerId.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 27);
            this.label1.TabIndex = 3;
            this.label1.Text = "Prisoner Id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 16.2F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(188, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 32);
            this.label2.TabIndex = 2;
            this.label2.Text = "Records";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel3.Controls.Add(this.txtSearch);
            this.panel3.Controls.Add(this.btnSearch);
            this.panel3.Controls.Add(this.btnRefresh);
            this.panel3.Location = new System.Drawing.Point(538, 6);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(750, 163);
            this.panel3.TabIndex = 10;
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
            // panel1
            // 
            this.panel1.Controls.Add(this.btnClear);
            this.panel1.Controls.Add(this.btnPrevious);
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Controls.Add(this.cbGender);
            this.panel1.Controls.Add(this.txtWork);
            this.panel1.Controls.Add(this.dtpDOB);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.dtpReleaseDate);
            this.panel1.Controls.Add(this.dtpEntranceDate);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.txtPrisonerFName);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.btnDelete);
            this.panel1.Controls.Add(this.txtCrime);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.rtxtPrisonerAddress);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtPrisonerName);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtPrisonerId);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(-6, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(538, 713);
            this.panel1.TabIndex = 8;
            // 
            // btnPrevious
            // 
            this.btnPrevious.Location = new System.Drawing.Point(52, 664);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(134, 37);
            this.btnPrevious.TabIndex = 31;
            this.btnPrevious.Text = "Previous";
            this.btnPrevious.UseVisualStyleBackColor = true;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.SteelBlue;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAdd.Location = new System.Drawing.Point(52, 566);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(435, 42);
            this.btnAdd.TabIndex = 30;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
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
            this.dgvRecords.Location = new System.Drawing.Point(538, 166);
            this.dgvRecords.Name = "dgvRecords";
            this.dgvRecords.ReadOnly = true;
            this.dgvRecords.RowHeadersWidth = 51;
            this.dgvRecords.RowTemplate.Height = 24;
            this.dgvRecords.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRecords.Size = new System.Drawing.Size(750, 553);
            this.dgvRecords.TabIndex = 9;
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.LightGray;
            this.btnClear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnClear.Location = new System.Drawing.Point(346, 662);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(141, 39);
            this.btnClear.TabIndex = 45;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // FormRecords
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1283, 719);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgvRecords);
            this.MaximizeBox = false;
            this.Name = "FormRecords";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormRecords";
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecords)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridViewTextBoxColumn EntranceDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Crime;
        private System.Windows.Forms.ComboBox cbGender;
        private System.Windows.Forms.TextBox txtWork;
        private System.Windows.Forms.DateTimePicker dtpDOB;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker dtpReleaseDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrisonerAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gender;
        private System.Windows.Forms.DateTimePicker dtpEntranceDate;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtPrisonerFName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Work;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateOfBirth;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrisonerName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.TextBox txtCrime;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrisonerFathersName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReleaseDate;
        private System.Windows.Forms.RichTextBox rtxtPrisonerAddress;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPrisonerName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPrisonerId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrisonerId;
        private System.Windows.Forms.DataGridView dgvRecords;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.Button btnClear;
    }
}