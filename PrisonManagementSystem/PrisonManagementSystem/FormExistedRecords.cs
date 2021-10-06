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
    
    public partial class FormExistedRecords : Form
    {
        private DataAccess Da { get; set; }
        public FormExistedRecords()
        {
            InitializeComponent();
            this.Da = new DataAccess();
           
        }

        private void PopulateGridView(string sql = " select * from Prisoner_Records;")
        {
            try
            {
                DataSet ds = this.Da.ExecuteQuery(sql);

                this.dgvERecords.AutoGenerateColumns = false;
                this.dgvERecords.DataSource = ds.Tables[0];

            }
            catch (Exception exc)
            {
                MessageBox.Show("Error: " + exc.Message);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string sql = "select * from Prisoner_Records where PrisonerId = '" + this.txtSearch.Text + "'; ";
            this.PopulateGridView(sql);
        }

        

        

        private void dgvERecords_DoubleClick(object sender, EventArgs e)
        {
            this.txtPrisonerId.Text = this.dgvERecords.CurrentRow.Cells["PrisonerId"].Value.ToString();
            this.txtPrisonerName.Text = this.dgvERecords.CurrentRow.Cells["PrisonerName"].Value.ToString();
            this.txtPrisonerFName.Text = this.dgvERecords.CurrentRow.Cells["PrisonerFathersName"].Value.ToString();
            this.dtpDOB.Text = this.dgvERecords.CurrentRow.Cells["DateOfBirth"].Value.ToString();
            this.cbGender.Text = this.dgvERecords.CurrentRow.Cells["Gender"].Value.ToString();
            this.rtxtPrisonerAddress.Text = this.dgvERecords.CurrentRow.Cells["PrisonerAddress"].Value.ToString();
            this.txtCrime.Text = this.dgvERecords.CurrentRow.Cells["Crime"].Value.ToString();
            this.txtWork.Text = this.dgvERecords.CurrentRow.Cells["Work"].Value.ToString();
            this.dtpEntranceDate.Text = this.dgvERecords.CurrentRow.Cells["EntranceDate"].Value.ToString();
            this.dtpReleaseDate.Text = this.dgvERecords.CurrentRow.Cells["ReleaseDate"].Value.ToString();
            this.txtPrisonerId.ReadOnly = true;
        }

       

        private void ClearContent()
        {
            this.txtPrisonerId.Text = "";
            this.txtPrisonerName.Text = "";
            this.txtPrisonerFName.Text = "";
            this.dtpDOB.Text = "";
            this.cbGender.SelectedIndex = -1;
            this.rtxtPrisonerAddress.Text = "";
            this.txtCrime.Text = "";
            this.txtWork.Text = "";
            this.dtpEntranceDate.Text = "";
            this.dtpReleaseDate.Text = "";
            this.txtPrisonerId.ReadOnly = true;




        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (String.IsNullOrEmpty(this.txtPrisonerId.Text) || String.IsNullOrEmpty(this.txtPrisonerName.Text) ||
                    String.IsNullOrEmpty(this.txtPrisonerFName.Text) || String.IsNullOrEmpty(this.dtpDOB.Text) ||
                    String.IsNullOrEmpty(this.cbGender.Text) || String.IsNullOrEmpty(this.rtxtPrisonerAddress.Text) ||
                    String.IsNullOrEmpty(this.txtCrime.Text) || String.IsNullOrEmpty(this.txtWork.Text) ||
                    String.IsNullOrEmpty(this.dtpEntranceDate.Text) || String.IsNullOrEmpty(this.dtpReleaseDate.Text))
                {
                    MessageBox.Show("To add Prisoner Records please fill all the information.");
                    return;
                }


                var sql = "select * from Prisoner_Records where PrisonerId = '" + this.txtPrisonerId.Text + "';";
                var ds = this.Da.ExecuteQuery(sql);

                if (ds.Tables[0].Rows.Count == 1)
                {

                    string query = "update Prisoner_Records set PrisonerName = '" + this.txtPrisonerName.Text + "', PrisonerFathersName = '" +
                                  this.txtPrisonerFName.Text + "', DateOfBirth = '" + this.dtpDOB.Text + "', Gender = '" +
                                   this.cbGender.Text + "', PrisonerAddress = '" + this.rtxtPrisonerAddress.Text + "'," +
                                   "Crime = '" + this.txtCrime.Text + "',Work = '" + this.txtWork.Text + "',EntranceDate = '" + this.dtpEntranceDate.Text + "'," +
                                   " ReleaseDate = '" + this.dtpReleaseDate.Text + "' where PrisonerId = '" +
                                   this.txtPrisonerId.Text + "';";

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
                    string query = "insert into Prisoner_Records values ('" + this.txtPrisonerId.Text + "','" + this.txtPrisonerName.Text + "','" +
                             this.txtPrisonerFName.Text + "','" + this.dtpDOB.Text + "','" + this.cbGender.Text + "','" +
                              this.rtxtPrisonerAddress.Text + "' ,'" + this.txtCrime.Text + " ','" + this.txtWork.Text + "', " +
                              "'" + this.dtpEntranceDate.Text + "', '" + this.dtpReleaseDate.Text + "');";

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

        private void btnReportRecords_Click(object sender, EventArgs e)
        {
            this.PopulateGridView();
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
