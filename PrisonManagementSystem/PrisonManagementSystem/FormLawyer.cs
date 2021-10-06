using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace PrisonManagementSystem
{
    public partial class FormLawyer : Form
    {
        private DataAccess Da { get; set; }
        public FormLawyer()
        {
            InitializeComponent();
            this.Da = new DataAccess();
        }
        private void Populateidview(string sql = " select * from Prisoner_Records;")
        {
            try
            {
                DataSet ds = this.Da.ExecuteQuery(sql);
                this.dgvRecords.AutoGenerateColumns = false;
                this.dgvRecords.DataSource = ds.Tables[0];
            }
            catch (Exception exc)
            {
                MessageBox.Show("Error:" + exc.Message);
            }

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string sql = "select * from Prisoner_Records where PrisonerId = '" + this.txtSearch.Text + "'; ";
            this.Populateidview(sql);
        }

        private void myProfileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LawyerProfile lp = new LawyerProfile();
            lp.Visible = true;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }

       

        private void searchPrisonerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormLawyer fl = new FormLawyer();
            fl.Visible = true;
        }

        private void myProfileToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            LawyerProfile lp = new LawyerProfile();
            lp.Visible = true;
        }

        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        private void prisonerRecordsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormLawyer fl = new FormLawyer();
            fl.Visible = true;
        }
    }
}
