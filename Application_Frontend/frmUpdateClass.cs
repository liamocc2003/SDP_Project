﻿using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using GymSYS.Business_Logic;
using GymSYS.Database;
using Oracle.ManagedDataAccess.Client;

namespace GymSYS.Application_Frontend
{
    public partial class frmUpdateClass : Form
    {
        public frmUpdateClass()
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

        private void btnSearch_Click(object sender, EventArgs e)
        {
            //valiadte ClassId
            if (cboClassId.Text.Equals(""))
            {
                MessageBox.Show("Class ID must be selected ", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cboClassId.Focus();
                return;
            }
            //end of validation

            //conect to database
            OracleConnection conn = new OracleConnection(DBConnect.oracledb);

            //define sql query
            String sqlQuery = "SELECT * " +
                "FROM SESSIONS WHERE Class_Id = " + Convert.ToInt32(cboClassId.Text);

            //execute query
            OracleCommand cmd = new OracleCommand(sqlQuery, conn);
            conn.Open();
            OracleDataReader dr = cmd.ExecuteReader();
            if (!dr.Read())
            {
                MessageBox.Show("There are no classes found with that Class ID");
            }
            else
            {
                txtClassName.Text = dr.GetString(1);
                txtClassTeacher.Text = dr.GetString(2);
                txtClassSize.Text = Convert.ToString(dr.GetString(3));
                if (dr.GetDateTime(5) >= DateTime.Today)
                {
                    dtpClassDate.Value = dr.GetDateTime(5);
                }
                else
                {
                    dtpClassDate.Value = DateTime.Today;
                }
                txtClassDuration.Text = Convert.ToString(dr.GetInt32(6));
                txtClassFee.Text = dr.GetString(7);
            }

            conn.Close();
        }

        private void btnUpdateClass_Click(object sender, EventArgs e)
        {
            //Validate all data
            //valiadte ClassId
            if (cboClassId.Text.Equals(""))
            {
                MessageBox.Show("Class ID must be selected", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cboClassId.Focus();
                return;
            }
            //Validate ClassName
            if (txtClassName.Text.Equals(""))
            {
                MessageBox.Show("Class Name must be entered", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtClassName.Focus();
                return;
            }
            for (int i = 0; i < txtClassName.TextLength; i++)
            {
                if (txtClassName.Text.Any(char.IsDigit) == true)
                {
                    MessageBox.Show("Class Name contains a digit", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtClassName.Focus();
                    return;
                }
            }

            //Validate ClassTeacher
            if (txtClassTeacher.Text.Equals(""))
            {
                MessageBox.Show("Class Teacher must be entered", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtClassTeacher.Focus();
                return;
            }
            for (int i = 0; i < txtClassTeacher.TextLength; i++)
            {
                if (txtClassTeacher.Text.Any(char.IsDigit) == true)
                {
                    MessageBox.Show("Class Teacher contains a digit", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtClassTeacher.Focus();
                    return;
                }
            }

            //Validate Class Size
            if (txtClassSize.Text.Equals(""))
            {
                MessageBox.Show("Class Size must be entered", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtClassSize.Focus();
                return;
            }
            for (int i = 0; i < txtClassSize.TextLength; i++)
            {
                if (txtClassSize.Text.Any(char.IsLetter) == true)
                {
                    MessageBox.Show("Class Size contains a letter", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtClassSize.Focus();
                    return;
                }
            }

            //Validate Class Duration
            if (txtClassDuration.Text.Equals(""))
            {
                MessageBox.Show("Class Duration must be entered", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtClassDuration.Focus();
                return;
            }
            for (int i = 0; i < txtClassDuration.TextLength; i++)
            {
                if (txtClassDuration.Text.Any(char.IsLetter) == true)
                {
                    MessageBox.Show("Class Duration contains a letter", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtClassDuration.Focus();
                    return;
                }
            }

            //Validate Class Fee
            if (txtClassFee.Text.Equals(""))
            {
                MessageBox.Show("Class Fee must be entered", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtClassFee.Focus();
                return;
            }
            int count = 0;
            for (int i = 0; i < txtClassFee.TextLength; i++)
            {
                if (txtClassFee.Text.Any(char.IsLetter) == true)
                {
                    MessageBox.Show("Class Fee must be numerical", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtClassFee.Focus();
                    return;
                }

                if (txtClassFee.Text.Any(char.IsPunctuation) == true)
                {
                    count++;
                }
                if (count > 1)
                {
                    MessageBox.Show("Class Fee cannot have more than 1 punctuation", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtClassFee.Focus();
                    return;
                }
            }
            //End of Validation

            //Create Class Object
            Session updateClass = new Session();

            //change the data
            updateClass.setClassId(Convert.ToInt32(cboClassId.Text));
            updateClass.setClassName(txtClassName.Text);
            updateClass.setClassTeacher(txtClassTeacher.Text);
            updateClass.setClassSize(Convert.ToInt32(txtClassSize.Text));
            updateClass.setClassDate(dtpClassDate.Value.ToString("dd-MMM-yyyy"));
            updateClass.setClassDuration(Convert.ToInt32(txtClassDuration.Text));
            updateClass.setClassFee(Convert.ToInt32(txtClassFee.Text));

            //update the data
            updateClass.updateClass();

            //Display Confirmation Message
            MessageBox.Show("Class has been updated successfully", "Success",
                MessageBoxButtons.OK, MessageBoxIcon.Information);

            //Reset UI
            cboClassId.SelectedIndex = -1;
            txtClassName.Clear();
            txtClassTeacher.Clear();
            txtClassSize.Clear();
            dtpClassDate.Text = string.Empty;
            txtClassDuration.Clear();
            txtClassFee.Clear();
        }

        private void frmUpdateClass_Load(object sender, EventArgs e)
        {
            //load classIds into combobox
            DataSet dsC = Session.getClassIds();

            for (int i = 0; i < dsC.Tables[0].Rows.Count; i++)
            {
                cboClassId.Items.Add(dsC.Tables[0].Rows[i][0]);
            }

            //set classDate to a minuimum of today
            dtpClassDate.MinDate = DateTime.Today;
        }
    }
}
