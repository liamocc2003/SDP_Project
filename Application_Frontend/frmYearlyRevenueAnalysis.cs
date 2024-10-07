using System;
using System.Data;
using System.Windows.Forms;
using GymSYS.Business_Logic;

namespace GymSYS.Application_Frontend
{
    public partial class frmYearlyRevenueAnalysis : Form
    {
        public frmYearlyRevenueAnalysis()
        {
            InitializeComponent();
        }

        private void backToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            frmMainMenu mainMenu = new frmMainMenu();
            mainMenu.Show();
        }

        private void mnuRegisterMember_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmRegisterMember registerMember = new frmRegisterMember();
            registerMember.Show();
        }

        private void mnuUpdateMember_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmUpdateMember updateMember = new frmUpdateMember();
            updateMember.Show();
        }

        private void mnuTopUpMemberWallet_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmTopUpMemberWallet topUpMember = new frmTopUpMemberWallet();
            topUpMember.Show();
        }

        private void scheduleClassToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmScheduleClass scheduleClass = new frmScheduleClass();
            scheduleClass.Show();
        }

        private void updateClassToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmUpdateClass updateClass = new frmUpdateClass();
            updateClass.Show();
        }

        private void cancelClassToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmCancelClass cancelClass = new frmCancelClass();
            cancelClass.Show();
        }

        private void makeBookingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmMakeBooking makeBooking = new frmMakeBooking();
            makeBooking.Show();
        }

        private void cancelBookingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmCancelBooking cancelBooking = new frmCancelBooking();
            cancelBooking.Show();
        }

        private void yearlyClassAnalysisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmYearlyClassAnalysis yearlyClassAnalysis = new frmYearlyClassAnalysis();
            yearlyClassAnalysis.Show();
        }

        private void frmYearlyRevenueAnalysis_Load(object sender, EventArgs e)
        {
            //load member details into member grid
            DataSet dsM = Member.getMemberDetails();

            for (int i = 0; i < dsM.Tables[0].Rows.Count; i++)
            {
                dgvMemberAnalysis.Rows.Add(dsM.Tables[0].Rows[i][0],
                    dsM.Tables[0].Rows[i][1]);
            }

            //load booking details into booking chart
            DataSet dsC = Session.getClassDetails();

            for (int i = 0; i < dsC.Tables[0].Rows.Count; i++)
            {
                dgvClassAnalysis.Rows.Add(dsC.Tables[0].Rows[i][0],
                    dsC.Tables[0].Rows[i][1], dsC.Tables[0].Rows[i][2]);
            }

            //load total in member wallet box
            txtWalletTotal.Text = Convert.ToString(Member.getWalletTotal());

            //load total in class fees box
            txtFeeTotal.Text = Convert.ToString(Session.getFeeTotal());

            //put complete total in text box
            txtCompleteTotal.Text = Convert.ToString(Member.getWalletTotal() + Session.getFeeTotal());
        }
    }
}
