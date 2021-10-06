using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrisonManagementSystem
{
    public partial class PrisonerRecords : Form
    {
        private DataAccess Da { get; set; }
        public PrisonerRecords()
        {
            InitializeComponent();
            this.Da = new DataAccess();
        }
        private void PopulateGridView(string sql = " select * from Prisoner_Records;")
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

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            this.PopulateGridView();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string sql = "select * from Prisoner_Records where PrisonerId = '" + this.txtSearch.Text + "'; ";
            this.PopulateGridView(sql);
        }
    }
}
