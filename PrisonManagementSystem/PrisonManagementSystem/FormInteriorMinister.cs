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
    public partial class FormInteriorMinister : Form
    {
        public FormInteriorMinister()
        {
            InitializeComponent();
        }

        private void btnPrisonerRecords_Click(object sender, EventArgs e)
        {
            FormJailer fj = new FormJailer();
            fj.Visible = true;
        }

        private void btnLawyerRecords_Click(object sender, EventArgs e)
        {
            LawyerRecords lr = new LawyerRecords();
            lr.Visible = true;
        }

        private void btnJailerRecords_Click(object sender, EventArgs e)
        {
            JailerRecords jr = new JailerRecords();
            jr.Visible = true;
        }

        private void updatePrisonerRecordsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormExistedRecords fer = new FormExistedRecords();
            fer.Visible = true;
        }

        private void updateLawyerRecordsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LawyerRecords lr = new LawyerRecords();
            lr.Visible = true;
        }

        private void updateJailerRecordsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            JailerRecords jr = new JailerRecords();
            jr.Visible = true;
        }

        private void prisonerRecordsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            JailerRecords jr = new JailerRecords();
            jr.Visible = true;
        }

        private void lawyerRecordsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LawyerProfile lp = new LawyerProfile();
            lp.Visible = true;
        }

        private void jailerRecordsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            JailerProfile jf = new JailerProfile();
            jf.Visible = true;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        private void prisonerRecordsToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FormExistedRecords fer = new FormExistedRecords();
            fer.Visible = true;
        }

        private void lawyerRecordsToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            LawyerRecords lr = new LawyerRecords();
            lr.Visible = true;
        }

        private void jailerRecordsToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            JailerRecords jr = new JailerRecords();
            jr.Visible = true;
        }

        private void prisonerRecordsToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            PrisonerRecords pr = new PrisonerRecords();
            pr.Visible = true;
        }

        private void lawyerRecordsToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            LawyerProfile lp = new LawyerProfile();
            lp.Visible = true;
        }

        private void jailerRecordsToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            JailerProfile jf = new JailerProfile();
            jf.Visible = true;
        }

        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        private void myPrifileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InteriorMinisterProfile imp = new InteriorMinisterProfile();
           imp.Visible = true;
        }

        private void myProfileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InteriorMinisterProfile imp = new InteriorMinisterProfile();
            imp.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormVisitor fv = new FormVisitor();
            fv.Visible = true;

        }

        private void visitorRecordsToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            VisitorsProfile vf = new VisitorsProfile();
            vf.Visible = true;

        }

        private void updateVisitorRecordsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormVisitor fv = new FormVisitor();
            fv.Visible = true;
        }

        private void visitorRecordsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VisitorsProfile vf = new VisitorsProfile();
            vf.Visible = true;
        }

        private void visitorRecordsToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            FormVisitor fv = new FormVisitor();
            fv.Visible = true;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            JailerRecords jr = new JailerRecords();
            jr.Visible = true;
        }

        

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            FormJailer fj = new FormJailer();
            fj.Visible = true;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            FormVisitor fv = new FormVisitor();
            fv.Visible = true;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            LawyerRecords lr = new LawyerRecords();
            lr.Visible = true;
        }

        private void btnJailerRecords_MouseHover(object sender, EventArgs e)
        {
            this.btnJailerRecords.BackColor = Color.DarkGreen;
        }

        private void btnJailerRecords_MouseLeave(object sender, EventArgs e)
        {
            this.btnJailerRecords.BackColor = Color.DarkBlue;
        }

        private void btnLawyerRecords_MouseHover(object sender, EventArgs e)
        {
            this.btnLawyerRecords.BackColor = Color.Yellow;
        }

        private void btnLawyerRecords_MouseLeave(object sender, EventArgs e)
        {
            this.btnLawyerRecords.BackColor = Color.White;
        }

        private void btnPrisonerRecords_MouseHover(object sender, EventArgs e)
        {
            this.btnPrisonerRecords.BackColor = Color.LemonChiffon;
        }

        private void btnPrisonerRecords_MouseLeave(object sender, EventArgs e)
        {
            this.btnPrisonerRecords.BackColor = Color.Orange;
        }
    }
}
