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
    public partial class LawyerProfile : Form
    {
        private DataAccess Da { get; set; }
        public LawyerProfile()
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

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string sql = "select * from Lawyer_Records where LawyerId = '" + this.txtSearch.Text + "'; ";
            this.PopulateGridView(sql);
        }

       
    }
}
