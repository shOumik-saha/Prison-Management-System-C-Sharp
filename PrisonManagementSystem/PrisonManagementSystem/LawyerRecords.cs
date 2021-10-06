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
    public partial class LawyerRecords : Form
    {
        private DataAccess Da { get; set; }
        public LawyerRecords()
        {
            InitializeComponent();
            this.Da = new DataAccess();
        }

        private void PopulateGridView(string sql = " select * from Lawyer_Records;")
        {
            try
            {
                DataSet ds = this.Da.ExecuteQuery(sql);
                this.dgvLawyer.AutoGenerateColumns = false;
                this.dgvLawyer.DataSource = ds.Tables[0];

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
            string sql = "select * from Lawyer_Records where LawyerId = '" + this.txtSearch.Text + "'; ";
            this.PopulateGridView(sql);
        }

  
        private void ClearContent()
        {
            this.txtLawyerId.Text = "";
            this.txtLawyerName.Text = "";
            this.cbLawyerType.SelectedIndex = -1;
            this.txtLawyerRegistrationNumber.Text = "";
            this.cbLawyerStatus.SelectedIndex = -1;
            this.txtLawyerEmail.Text = "";
            this.LawyerId.ReadOnly = true;

        }

       

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                var Id = this.dgvLawyer.CurrentRow.Cells["LawyerId"].Value.ToString();
                var Name = this.dgvLawyer.CurrentRow.Cells["LawyerName"].Value.ToString();

                string sql = "delete from Lawyer_Records where LawyerId = '" + Id + "';";
                int count = this.Da.ExecuteDML(sql);

                if (count == 1)
                {
                    MessageBox.Show("Lawyer Records " + Name + " has been deleted.");
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

       
        
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (String.IsNullOrEmpty(this.txtLawyerId.Text) || String.IsNullOrEmpty(this.txtLawyerName.Text) ||
                    String.IsNullOrEmpty(this.cbLawyerType.Text) || String.IsNullOrEmpty(this.txtLawyerRegistrationNumber.Text) ||
                    String.IsNullOrEmpty(this.cbLawyerStatus.Text) || String.IsNullOrEmpty(this.txtLawyerEmail.Text))
                {
                    MessageBox.Show("To add Lawyer Records please fill all the information.");
                    return;
                }


                var sql = "select * from Lawyer_Records where LawyerId = '" + this.txtLawyerId.Text + "';";
                var ds = this.Da.ExecuteQuery(sql);

                if (ds.Tables[0].Rows.Count == 1)
                {

                    string query = "update Lawyer_Records set LawyerName = '" + this.txtLawyerName.Text + "', LawyerType = '" +
                                  this.cbLawyerType.Text + "', LawyerRegistrationNumber = '" + this.txtLawyerRegistrationNumber.Text + "'," +
                                   "LawyerStatus = '" + this.cbLawyerStatus.Text + "' , LawyerEmail = '" + this.txtLawyerEmail.Text + "' where LawyerId = '" +
                                   this.txtLawyerId.Text + "';";

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
                    string query = "insert into Lawyer_Records values ('" + this.txtLawyerId.Text + "','" + this.txtLawyerName.Text + "','" +
                             this.cbLawyerType.Text + "','" + this.txtLawyerRegistrationNumber.Text + "','" + this.cbLawyerStatus.Text + "' ,'" + this.txtLawyerEmail.Text + "');";

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

        private void dgvLawyer_DoubleClick(object sender, EventArgs e)
        {
            this.txtLawyerId.Text = this.dgvLawyer.CurrentRow.Cells["LawyerId"].Value.ToString();
            this.txtLawyerName.Text = this.dgvLawyer.CurrentRow.Cells["LawyerName"].Value.ToString();
            this.cbLawyerType.Text = this.dgvLawyer.CurrentRow.Cells["LawyerType"].Value.ToString();
            this.txtLawyerRegistrationNumber.Text = this.dgvLawyer.CurrentRow.Cells["LawyerRegistrationNumber"].Value.ToString();
            this.cbLawyerStatus.Text = this.dgvLawyer.CurrentRow.Cells["LawyerStatus"].Value.ToString();
            this.txtLawyerEmail.Text = this.dgvLawyer.CurrentRow.Cells["LawyerEmail"].Value.ToString();
            this.txtLawyerId.ReadOnly = true;
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }
    }
}
