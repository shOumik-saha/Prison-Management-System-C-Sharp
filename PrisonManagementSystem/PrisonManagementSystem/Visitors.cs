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
    public partial class Visitors : Form
    {
        private DataAccess Da { get; set; }
        public Visitors()
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
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (String.IsNullOrEmpty(this.txtVisitorName.Text) || String.IsNullOrEmpty(this.txtVisitorNID.Text) ||
                String.IsNullOrEmpty(this.txtVisitorNationality.Text) || String.IsNullOrEmpty(this.txtVisitFor.Text) ||
                String.IsNullOrEmpty(this.cbGender.Text) || String.IsNullOrEmpty(this.rtxtVisitorAddress.Text) ||
                String.IsNullOrEmpty(this.dtpVisitDate.Text) || String.IsNullOrEmpty(this.txtEntryTime.Text) ||
                String.IsNullOrEmpty(this.txtExitTime.Text))
                {
                    MessageBox.Show("To add Visitor Records please fill all the information.");
                    return;
                }

                var sql = "select * from Visitor_Records where VisitorNID = '" + this.txtVisitorNID.Text + "';";
                var ds = this.Da.ExecuteQuery(sql);

                if (ds.Tables[0].Rows.Count == 1)
                {
                    string query = "update Visitor_Records set VisitorName = '" + this.txtVisitorName.Text + "', VisitorNID = '" +
                                 this.txtVisitorNID.Text + "', VisitorNationality = '" + this.txtVisitorNationality.Text + "'," +
                                  "VisitorFor = '" + this.txtVisitFor.Text + "' , Gender = '" + this.cbGender.Text + "'," +
                                  "  VisitorAddress = '" + this.rtxtVisitorAddress.Text + "'," +
                                  " VisitorEntryDate = '" + this.dtpVisitDate.Text + "'," +
                                  " VisitorEntryTime = '" + this.txtEntryTime.Text + "'," +
                                  " VisitorExitTime = '" + this.txtExitTime.Text + "'where VisitorNID = '" +
                                  this.txtVisitorNID.Text + "';";

                    int count = this.Da.ExecuteDML(query);

                    if (count == 1)
                    {
                        MessageBox.Show("Data Inserted.");
                    }
                    else
                    {
                        MessageBox.Show("Data Insertion Failed.");
                    }

                }

                else
                {
                    string query = "insert into Visitor_Records values ('" + this.txtVisitorName.Text + "','" + this.txtVisitorNID.Text + "','" +
                         this.txtVisitorNationality.Text + "','" + this.txtVisitFor.Text + "','" + this.cbGender.Text + "','" +
                          this.rtxtVisitorAddress.Text + "' ,'" + this.dtpVisitDate.Text + " ','" + this.txtEntryTime.Text + "','" + this.txtEntryTime.Text + "');";

                    int count = this.Da.ExecuteDML(query);

                    if (count == 1)
                    {
                        MessageBox.Show("Data Inserted.");
                    }
                    else
                    {
                        MessageBox.Show("Data Insertion Failed.");
                    }

                }

                this.PopulateGridView();

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

        private void btnClear_Click(object sender, EventArgs e)
        {
            this.ClearContent();
        }

        private void dgvVisitors_DoubleClick(object sender, EventArgs e)
        {
            this.txtVisitorName.Text = this.dgvVisitors.CurrentRow.Cells["VisitorName"].Value.ToString();
            this.txtVisitorNID.Text = this.dgvVisitors.CurrentRow.Cells["VisitorNID"].Value.ToString();
            this.txtVisitorNationality.Text = this.dgvVisitors.CurrentRow.Cells["VisitorNationality"].Value.ToString();
            this.txtVisitFor.Text = this.dgvVisitors.CurrentRow.Cells["VisitorFor"].Value.ToString();
            this.cbGender.Text = this.dgvVisitors.CurrentRow.Cells["Gender"].Value.ToString();
            this.rtxtVisitorAddress.Text = this.dgvVisitors.CurrentRow.Cells["VisitorAddress"].Value.ToString();
            this.dtpVisitDate.Text = this.dgvVisitors.CurrentRow.Cells["VisitorEntryDate"].Value.ToString();
            this.txtEntryTime.Text = this.dgvVisitors.CurrentRow.Cells["VisitorEntryTime"].Value.ToString();
            this.txtExitTime.Text = this.dgvVisitors.CurrentRow.Cells["VisitorExitTime"].Value.ToString();
            this.txtVisitorNID.ReadOnly = true;
        }

        private void ClearContent()
        {
            this.txtVisitorName.Text = "";
            this.txtVisitorNID.Text = "";
            this.txtVisitorNationality.Text = "";
            this.txtVisitFor.Text = "";
            this.cbGender.SelectedIndex = -1;
            this.rtxtVisitorAddress.Text = "";
            this.dtpVisitDate.Text = "";
            this.txtEntryTime.Text = "";
            this.txtExitTime.Text = "";
            this.txtVisitorNID.ReadOnly = true;

        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }
    }
}
