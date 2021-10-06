
namespace PrisonManagementSystem
{
    partial class LawyerProfile
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
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLawyer)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.btnSearch);
            this.panel2.Controls.Add(this.txtSearch);
            this.panel2.Location = new System.Drawing.Point(0, -3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(638, 156);
            this.panel2.TabIndex = 32;
            // 
            // btnSearch
            // 
            this.btnSearch.AutoSize = true;
            this.btnSearch.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSearch.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSearch.Location = new System.Drawing.Point(96, 49);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(121, 35);
            this.btnSearch.TabIndex = 25;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(293, 57);
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
            this.dgvLawyer.Location = new System.Drawing.Point(0, 146);
            this.dgvLawyer.Name = "dgvLawyer";
            this.dgvLawyer.ReadOnly = true;
            this.dgvLawyer.RowHeadersWidth = 51;
            this.dgvLawyer.RowTemplate.Height = 24;
            this.dgvLawyer.Size = new System.Drawing.Size(638, 497);
            this.dgvLawyer.TabIndex = 33;
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
            // LawyerProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(636, 643);
            this.Controls.Add(this.dgvLawyer);
            this.Controls.Add(this.panel2);
            this.MaximizeBox = false;
            this.Name = "LawyerProfile";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LawyerProfile";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLawyer)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.DataGridView dgvLawyer;
        private System.Windows.Forms.DataGridViewTextBoxColumn LawyerId;
        private System.Windows.Forms.DataGridViewTextBoxColumn LawyerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn LawyerType;
        private System.Windows.Forms.DataGridViewTextBoxColumn LawyerRegistrationNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn LawyerStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn LawyerEmail;
    }
}