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
    public partial class VisitorsProfile : Form
    {
        private DataAccess Da { get; set; }
        public VisitorsProfile()
        {
            InitializeComponent();
            this.Da = new DataAccess();
        }

        private void PopulateGridView(string sql = " select * from Visitor_Records;")
        {
            try
            {
                DataSet ds = this.Da.ExecuteQuery(sql);
                this.dgvVisitors.AutoGenerateColumns = false;
                this.dgvVisitors.DataSource = ds.Tables[0];

            }
            catch (Exception exc)
            {
                MessageBox.Show("Error: " + exc.Message);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string sql = "select * from Visitor_Records where VisitorNID = '" + this.txtSearch.Text + "'; ";
            this.PopulateGridView(sql);
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            this.PopulateGridView();
        }
    }
}
