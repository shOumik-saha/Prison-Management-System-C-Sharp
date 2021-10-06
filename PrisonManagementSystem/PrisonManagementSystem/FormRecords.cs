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
    public partial class FormRecords : Form
    {
        private DataAccess Da { get; set; }
        public FormRecords()
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

        private void btnAdd_Click(object sender, EventArgs e)
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



                string query = "insert into Prisoner_Records values ('" + this.txtPrisonerId.Text + "','" + this.txtPrisonerName.Text + "','" +
                             this.txtPrisonerFName.Text + "','" + this.dtpDOB.Text + "','" + this.cbGender.Text + "','" +
                              this.rtxtPrisonerAddress.Text + "' ,'" + this.txtCrime.Text + " ','" + this.txtWork.Text + "', '" + this.dtpEntranceDate.Text + "', '" + this.dtpReleaseDate.Text + "');";

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


            catch (Exception exc)
            {
                MessageBox.Show("Error: " + exc.Message);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                var id = this.dgvRecords.CurrentRow.Cells["PrisonerId"].Value.ToString();
                var name = this.dgvRecords.CurrentRow.Cells["PrisonerName"].Value.ToString();

                string sql = "delete from Prisoner_Records where PrisonerId = '" + id + "';";
                int count = this.Da.ExecuteDML(sql);

                if (count == 1)
                {
                    MessageBox.Show("Prisoner Records " + name + " has been deleted.");
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

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            this.Visible = false;
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

        private void btnClear_Click(object sender, EventArgs e)
        {
            this.ClearContent();
        }
    }
}
