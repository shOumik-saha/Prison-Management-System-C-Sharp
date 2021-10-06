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
    public partial class FormJailer : Form
    {
        
        public FormJailer()
        {
            InitializeComponent();
           
        }

        private void btnRecords_Click(object sender, EventArgs e)
        {
            FormRecords fr = new FormRecords();
            fr.Visible = true;
        }

        private void btnExistedRecords_Click(object sender, EventArgs e)
        {
            FormExistedRecords fer = new FormExistedRecords();
            fer.Visible = true;
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormRecords fr = new FormRecords();
            fr.Visible = true;
        }

       

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        private void newToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FormRecords fr = new FormRecords();
            fr.Visible = true;
        }

        private void existedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormExistedRecords fer = new FormExistedRecords();
            fer.Visible = true;
        }

        private void myProfileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            JailerProfile jf = new JailerProfile();
            jf.Visible = true;
        }

        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormExistedRecords fer = new FormExistedRecords();
            fer.Visible = true;
        }

        private void prisonerRecordsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PrisonerRecords pr = new PrisonerRecords();
            pr.Visible = true;
        }

        private void newToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            FormRecords fr = new FormRecords();
            fr.Visible = true;
        }

        private void updateToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FormExistedRecords fer = new FormExistedRecords();
            fer.Visible = true;
        }


        private void newToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            FormRecords fr = new FormRecords();
            fr.Visible = true;
        }

        private void existedToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FormExistedRecords fer = new FormExistedRecords();
            fer.Visible = true;
        }

        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            JailerProfile jf = new JailerProfile();
            jf.Visible = true;
        }

        private void exitToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        private void prisonerRecordsToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            PrisonerRecords pr = new PrisonerRecords();
            pr.Visible = true;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            FormRecords fr = new FormRecords();
            fr.Visible = true;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            FormExistedRecords fer = new FormExistedRecords();
            fer.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
           Visitors v = new Visitors();
            v.Visible = true;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Visitors v = new Visitors();
            v.Visible = true;
        }
    }
}
