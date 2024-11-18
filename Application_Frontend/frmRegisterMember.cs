﻿using System;
using System.Linq;
using System.Windows.Forms;
using GymSYS.Business_Logic;

namespace GymSYS.Application_Frontend
{
    public partial class frmRegisterMember : Form
    {
        public frmRegisterMember()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            //Validate all data
            //Validate forename
            if(txtForename.Text.Equals(""))
            {
                MessageBox.Show("Forename must be entered", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtForename.Focus();
                return;
            }
            for (int i = 0; i < txtForename.TextLength; i++)
            {
                if (txtForename.Text.Any(char.IsDigit) == true)
                {
                    MessageBox.Show("Forename contains a digit", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtForename.Focus();
                    return;
                }
            }

            //Validate surname
            if (txtSurname.Text.Equals(""))
            {
                MessageBox.Show("Surname must be entered", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSurname.Focus();
                return;
            }
            for (int i = 0; i < txtSurname.TextLength; i++)
            {
                if (txtSurname.Text.Any(char.IsDigit) == true)
                {
                    MessageBox.Show("Surname contains a digit", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtSurname.Focus();
                    return;
                }
            }

            //Validate Eircode
            if (txtEircode.Text.Equals(""))
            {
                MessageBox.Show("Eircode must be entered", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtEircode.Focus();
                return;
            }
            else if (txtEircode.Text.Length != 7)
            {
                MessageBox.Show("Eircode must be 7 characters long", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtEircode.Focus();
                return;
            }
            if (Char.IsDigit(txtEircode.Text[0]) || Char.IsLetter(txtEircode.Text[1]) ||
                    Char.IsLetter(txtEircode.Text[2]) || Char.IsDigit(txtEircode.Text[3]) ||
                    Char.IsLetter(txtEircode.Text[6]))
            {
                MessageBox.Show("Eircode is invalid", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtEircode.Focus();
                return;
            }

            //Validate Email
            if (txtEmail.Text.Equals(""))
            {
                MessageBox.Show("Email must be entered", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtEmail.Focus();
                return;
            }
            else if (txtEmail.Text.Contains('@') == false && (txtEmail.Text.EndsWith(".com") == false ||
                     txtEmail.Text.EndsWith(".ie") == false))
            {
                MessageBox.Show("Email is not valid", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtEmail.Focus();
                return;
            }

            //Validate paymentType
            if (cboPaymentType.Text.Equals(""))
            {
                MessageBox.Show("Payment Type must be selected", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cboPaymentType.Focus();
                return;
            }
            //End of Validation

            //Create Member instance with values from form
            Member registerMember = new Member(Convert.ToInt32(txtMemberId.Text), txtForename.Text, txtSurname.Text,
                dtpDOB.Value.ToString("dd-MMM-yyyy"), txtEircode.Text, txtEmail.Text, cboPaymentType.Text, 0, 0);

            //invoke method to add data to Members Table
            registerMember.addMember();

            //Confirmation Message
            MessageBox.Show("Member has been added successfully", "Success", 
                MessageBoxButtons.OK, MessageBoxIcon.Information);

            //reset UI
            txtMemberId.Text = Member.getNextMemberId().ToString("00000");
            txtForename.Clear();
            txtSurname.Clear();
            dtpDOB.Text = Convert.ToString(DateTime.Today.AddYears(-16));
            txtEircode.Clear();
            txtEmail.Clear();
            cboPaymentType.SelectedIndex = -1;
            txtForename.Focus();
        }

        private void frmRegisterMember_Load(object sender, EventArgs e)
        {
            //set max date to 16 years ago
            dtpDOB.MaxDate = DateTime.Today.AddYears(-16);

            //get next MemberId
            txtMemberId.Text = Member.getNextMemberId().ToString("00000");
        }
    }
}
