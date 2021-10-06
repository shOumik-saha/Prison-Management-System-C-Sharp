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
    public partial class InteriorMinisterProfile : Form
    {
        private DataAccess Da { get; set; }
        public InteriorMinisterProfile()
        {
            InitializeComponent();
            this.Da = new DataAccess();
        }

        private void PopulateGridView(string sql = " select * from Interior_Minister;")
        {
            try
            {
                DataSet ds = this.Da.ExecuteQuery(sql);
                this.dgvMinister.AutoGenerateColumns = false;
                this.dgvMinister.DataSource = ds.Tables[0];

            }
            catch (Exception exc)
            {
                MessageBox.Show("Error: " + exc.Message);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string sql = "select * from Interior_Minister where MinisterId = '" + this.txtSearch.Text + "'; ";
            this.PopulateGridView(sql);
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            this.PopulateGridView();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                var id = this.dgvMinister.CurrentRow.Cells["MinisterId"].Value.ToString();
                var name = this.dgvMinister.CurrentRow.Cells["MinisterName"].Value.ToString();

                string sql = "delete from Interior_Minister where MinisterId = '" + id + "';";
                int count = this.Da.ExecuteDML(sql);

                if (count == 1)
                {
                    MessageBox.Show("Interior Minister Records " + name + " has been deleted.");
                }
                else
                {
                    MessageBox.Show("Data Deletion Failed.");
                }


            }
            catch (Exception exc)
            {
                MessageBox.Show("Error: " + exc.Message);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
           this.ClearContent();
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (String.IsNullOrEmpty(this.txtMId.Text) || String.IsNullOrEmpty(this.txtMName.Text) ||
                    String.IsNullOrEmpty(this.cbMStatus.Text) || String.IsNullOrEmpty(this.txtMNumber.Text))
                {
                    MessageBox.Show("To add Interior Minister Records please fill all the information.");
                    return;
                }


                var sql = "select * from Interior_Minister where MinisterId = '" + this.txtMId.Text + "';";
                var ds = this.Da.ExecuteQuery(sql);

                if (ds.Tables[0].Rows.Count == 1)
                {

                    string query = "update Interior_Minister set MinisterName = '" + this.txtMName.Text + "', MinisterStatus = '" +
                                  this.cbMStatus.Text + "',MobileNumber = '" + this.txtMNumber.Text + "' where MinisterId = '" +
                                   this.txtMId.Text + "';";

                    int count = this.Da.ExecuteDML(query);

                    if (count == 1)
                    {
                        MessageBox.Show("Data Updated Successfully.");
                    }
                    else
                    {
                        MessageBox.Show("Data Upgradation Failed.");
                    }
                }

                else
                {
                    string query = "insert into Interior_Minister values ('" + this.txtMId.Text + "','" + this.txtMName.Text + "', " +
                              "'" + this.cbMStatus.Text + "', '" + this.txtMNumber.Text + "');";

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

        private void ClearContent()
        {
            this.txtMId.Text = "";
            this.txtMName.Text = "";
            this.cbMStatus.Text = "";
            this.txtMNumber.Text = "";

        }

        private void dgvMinister_DoubleClick(object sender, EventArgs e)
        {
            this.txtMId.Text = this.dgvMinister.CurrentRow.Cells["MinisterId"].Value.ToString();
            this.txtMName.Text = this.dgvMinister.CurrentRow.Cells["MinisterName"].Value.ToString();
            this.cbMStatus.Text = this.dgvMinister.CurrentRow.Cells["MinisterStatus"].Value.ToString();
            this.txtMNumber.Text = this.dgvMinister.CurrentRow.Cells["MobileNumber"].Value.ToString();
            this.txtMId.ReadOnly = true;
        }
    }
}
