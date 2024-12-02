﻿using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using GymSYS.Business_Logic;
using GymSYS.Database;
using Oracle.ManagedDataAccess.Client;

namespace GymSYS.Application_Frontend
{
    public partial class frmTopUpMemberWallet : Form
    {
        public frmTopUpMemberWallet()
        {
            InitializeComponent();
        }

        private void btnAddMoney_Click(object sender, EventArgs e)
        {
            //Validate data
            //Validate MemberId
            if (cboMemberId.Text.Equals(""))
            {
                MessageBox.Show("Member ID must be entered", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cboMemberId.Focus();
                return;
            }

            //Validate CurrentAmount
            if (txtCurrentAmount.Text.Equals(""))
            {
                MessageBox.Show("You must search if the Member ID exists", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCurrentAmount.Focus();
                return;
            }
            //Validate Amount
            int count = 0;
            if (txtAmount.Text.Equals(""))
            {
                MessageBox.Show("Amount must be entered", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtAmount.Focus();
                return;
            }
            for(int i=0; i<txtAmount.TextLength; i++)
            {
                if(txtAmount.Text.Any(char.IsLetter) == true)
                {
                    MessageBox.Show("Amount must be numerical", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtAmount.Focus();
                    return;
                }
                if(txtAmount.Text.Any(char.IsPunctuation) == true)
                {
                    count++;
                }
                if(count > 1)
                {
                    MessageBox.Show("Amount cannot have more than 1 punctuation", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtAmount.Focus();
                    return;
                }
            }
            //End of Validation

            //create Member Object
            Member topUpMemberWallet = new Member();

            //change data
            topUpMemberWallet.setMemberId(Convert.ToInt32(cboMemberId.Text));
            topUpMemberWallet.setForename(txtForename.Text);
            topUpMemberWallet.setSurname(txtSurname.Text);
            topUpMemberWallet.setDateOfBirth(dtpDOB.Value.ToString("dd-MMM-yyyy"));
            topUpMemberWallet.setEircode(txtEircode.Text);
            topUpMemberWallet.setEmail(txtEmail.Text);
            topUpMemberWallet.setPaymentType(cboPaymentType.Text);
            topUpMemberWallet.setMemberWallet(Convert.ToInt32(txtCurrentAmount.Text) + Convert.ToInt32(txtAmount.Text));

            //update the data
            topUpMemberWallet.updateMember();

            //Display Confirmation Message
            MessageBox.Show("Member has updated wallet successfully", "Success",
                MessageBoxButtons.OK, MessageBoxIcon.Information);

            //Reset UI
            cboMemberId.SelectedIndex=-1;
            txtAmount.Clear();
            txtCurrentAmount.Clear();
            dtpDOB.Text = string.Empty;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            //Validate data
            //Validate MemberId
            if (cboMemberId.Text.Equals(""))
            {
                MessageBox.Show("Member ID must be entered", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cboMemberId.Focus();
                return;
            }
            //end of validation

            //connect to database
            OracleConnection conn = new OracleConnection(DBConnect.oracledb);

            //sql query
            String sqlQuery = "SELECT * FROM Members WHERE Member_Id = " + Convert.ToInt32(cboMemberId.Text);

            //execute query
            OracleCommand cmd = new OracleCommand(sqlQuery, conn);
            conn.Open();
            OracleDataReader dr = cmd.ExecuteReader();
            if (!dr.Read())
            {
                MessageBox.Show("There are no members found with that Member ID");
            }
            else
            {
                txtForename.Text = dr.GetString(1);
                txtSurname.Text = dr.GetString(2);
                dtpDOB.Value = dr.GetDateTime(3);
                txtEircode.Text = dr.GetString(4);
                txtEmail.Text = dr.GetString(5);
                cboPaymentType.Text = dr.GetString(6);
                txtCurrentAmount.Text = Convert.ToString(dr.GetInt32(7));
            }

            conn.Close();
        }

        private void frmTopUpMemberWallet_Load(object sender, EventArgs e)
        {
            //load memberIds into combobox
            DataSet dsM = Member.getMemberIds();

            for (int i = 0; i < dsM.Tables[0].Rows.Count; i++)
            {
                cboMemberId.Items.Add(dsM.Tables[0].Rows[i][0]);
            }
        }
    }
}
