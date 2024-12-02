using System;
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
            Member validateMember = new Member();
            validateMember.validateMember(txtForename, txtSurname, txtEircode, txtEmail, cboPaymentType);

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
