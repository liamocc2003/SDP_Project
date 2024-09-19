﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;

namespace GymSYS
{
    public partial class frmCancelClass : Form
    {
        public frmCancelClass()
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

        private void yearlyRevenueAnalysisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmYearlyRevenueAnalysis yearlyRevenueAnalysis = new frmYearlyRevenueAnalysis();
            yearlyRevenueAnalysis.Show();
        }

        private void yearlyClassAnalysisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmYearlyClassAnalysis yearlyClassAnalysis = new frmYearlyClassAnalysis();
            yearlyClassAnalysis.Show();
        }

        private void btnCancelClass_Click(object sender, EventArgs e)
        {
            //valiadte ClassId
            if (cboClassId.Text.Equals(""))
            {
                MessageBox.Show("Class ID must be selected ", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cboClassId.Focus();
                return;
            }
            //end of validation

            //load bookingIds into comboBox
            DataSet dsB = Booking.getBookingsForClassId();

            for (int i = 0; i < dsB.Tables[0].Rows.Count; i++)
            {
                cboClassId.Items.Add(dsB.Tables[0].Rows[i][0]);
            }

            //create Booking Object
            Booking cancelBooking = new Booking();

            //remove all bookings with classId
            for (int i = cboBookings.Items.Count; i > 0; i--)
            {
                int bookingId = Convert.ToInt32(cboBookings.SelectedIndex.ToString());
                cancelBooking.setBookingId(bookingId);
                cancelBooking.cancelBooking();
            }

            //connect to database
            OracleConnection conn = new OracleConnection(DBConnect.oracledb);

            //create Session object
            Session cancelClass = new Session();

            //sql query
            String sqlQuery = "SELECT * FROM SESSIONS WHERE Class_Id = " + Convert.ToInt32(cboClassId.Text);

            //execute query
            OracleCommand cmd = new OracleCommand(sqlQuery, conn);
            conn.Open();
            OracleDataReader dr = cmd.ExecuteReader();
            if (!dr.Read())
            {
                MessageBox.Show("There are no classes found with that Class ID");
                return;
            }
            else
            {
                cancelClass.setClassId(Convert.ToInt32(cboClassId.Text));
            }

            //remove the data
            if (cboBookings.Items.Count > 0)
            {
                MessageBox.Show("Could not cancel Class as members have booked it", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                cancelClass.cancelClass();

                //Display Confirmation Message
                MessageBox.Show("Class has cancelled successfully", "Success",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            //Reset UI
            cboClassId.SelectedIndex = -1;

            //close connection
            conn.Close();
        }

        private void frmCancelClass_Load(object sender, EventArgs e)
        {
            DataSet dsC = Session.getClassIds();

            for (int i = 0; i < dsC.Tables[0].Rows.Count; i++)
            {
                cboClassId.Items.Add(dsC.Tables[0].Rows[i][0]);
            }
        }
    }
}
