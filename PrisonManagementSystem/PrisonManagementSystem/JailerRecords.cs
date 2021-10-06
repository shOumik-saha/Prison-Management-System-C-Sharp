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
    public partial class JailerRecords : Form
    {
        private DataAccess Da { get; set; }
        public JailerRecords()
        {
            InitializeComponent();
            this.Da = new DataAccess();
        }

        private void PopulateGridView(string sql = " select * from Jailer_Records;")
        {
            try
            {
                DataSet ds = this.Da.ExecuteQuery(sql);

                this.dgvJailerRecords.AutoGenerateColumns = false;
                this.dgvJailerRecords.DataSource = ds.Tables[0];

            }
            catch (Exception exc)
            {
                MessageBox.Show("Error: " + exc.Message);
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            this.PopulateGridView();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string sql = "select * from Jailer_Records where JailerId = '" + this.txtSearch.Text + "'; ";
            this.PopulateGridView(sql);
        }

       

       

        private void dgvJailerRecords_DoubleClick(object sender, EventArgs e)
        {
            this.txtJailerId.Text = this.dgvJailerRecords.CurrentRow.Cells["JailerId"].Value.ToString();
            this.txtJailerName.Text = this.dgvJailerRecords.CurrentRow.Cells["JailerName"].Value.ToString();
            this.cbGender.Text = this.dgvJailerRecords.CurrentRow.Cells["Gender"].Value.ToString();
            this.cbDesignation.Text = this.dgvJailerRecords.CurrentRow.Cells["Designation"].Value.ToString();
            this.cbStatus.Text = this.dgvJailerRecords.CurrentRow.Cells["Status"].Value.ToString();
            this.txtJailerId.ReadOnly = true;
        }

        private void ClearContent()
        {
            this.txtJailerId.Text = "";
            this.txtJailerName.Text = "";
            this.cbGender.SelectedIndex = -1;
            this.cbDesignation.SelectedIndex = -1;
            this.cbStatus.SelectedIndex = -1;
            this.txtJailerId.ReadOnly = true;


        }

        
        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                var Id = this.dgvJailerRecords.CurrentRow.Cells["JailerId"].Value.ToString();
                var Name = this.dgvJailerRecords.CurrentRow.Cells["JailerName"].Value.ToString();

                string sql = "delete from Jailer_Records where JailerId = '" + Id + "';";
                int count = this.Da.ExecuteDML(sql);

                if (count == 1)
                {
                    MessageBox.Show("Jailer Records " + Name + " has been deleted.");
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

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (String.IsNullOrEmpty(this.txtJailerId.Text) || String.IsNullOrEmpty(this.txtJailerName.Text) ||
                    String.IsNullOrEmpty(this.cbGender.Text) || String.IsNullOrEmpty(this.cbDesignation.Text) ||
                    String.IsNullOrEmpty(this.cbStatus.Text))
                {
                    MessageBox.Show("To add Jailer Records please fill all the information.");
                    return;
                }


                var sql = "select * from Jailer_Records where JailerId = '" + this.txtJailerId.Text + "';";
                var ds = this.Da.ExecuteQuery(sql);

                if (ds.Tables[0].Rows.Count == 1)
                {

                    string query = "update Jailer_Records set JailerName = '" + this.txtJailerName.Text + "', Gender = '" +
                                  this.cbGender.Text + "', Designation = '" + this.cbDesignation.Text + "'," +
                                   "Status = '" + this.cbStatus.Text + "' where JailerId = '" +
                                   this.txtJailerId.Text + "';";

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
                    string query = "insert into Jailer_Records values ('" + this.txtJailerId.Text + "','" + this.txtJailerName.Text + "','" +
                             this.cbGender.Text + "','" + this.cbDesignation.Text + "','" + this.cbStatus.Text + "');";

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

        private void btnClear_Click(object sender, EventArgs e)
        {
            this.ClearContent();
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }
    }
}
