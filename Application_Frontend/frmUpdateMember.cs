using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using GymSYS.Business_Logic;
using GymSYS.Database;
using Oracle.ManagedDataAccess.Client;

namespace GymSYS.Application_Frontend
{
    public partial class frmUpdateMember : Form
    {
        public frmUpdateMember()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            //Validation
            if (cboMemberId.Text.Equals(""))
            {
                MessageBox.Show("Member ID must be selected", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cboMemberId.Focus();
                return;
            }
            //end of validation

            //conect to database
            OracleConnection conn = new OracleConnection(DBConnect.oracledb);

            //define sql query
            String sqlQuery = "SELECT * " +
                "FROM Members WHERE Member_Id = " + Convert.ToInt32(cboMemberId.Text);

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
                txtWallet.Text = Convert.ToString(dr.GetInt32(7));
                txtPoints.Text = Convert.ToString(dr.GetInt32(8));
            }

            conn.Close();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            //Validate memberId
            if (cboMemberId.Text.Equals(""))
            {
                MessageBox.Show("Member ID must be selected", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cboMemberId.Focus();
                return;
            }

            //Create Member Object
            Member updateMember = new Member();

            //Validate data
            updateMember.validateMember(txtForename, txtSurname, txtEircode, txtEmail, cboPaymentType);

            //change the data
            updateMember.setMemberId(Convert.ToInt32(cboMemberId.Text));
            updateMember.setForename(txtForename.Text);
            updateMember.setSurname(txtSurname.Text);
            updateMember.setDateOfBirth(dtpDOB.Value.ToString("dd-MMM-yyyy"));
            updateMember.setEircode(txtEircode.Text);
            updateMember.setEmail(txtEmail.Text);
            updateMember.setPaymentType(cboPaymentType.Text);
            updateMember.setMemberWallet(Convert.ToInt32(txtWallet.Text));
            updateMember.setMemberPoints(Convert.ToInt32(txtPoints.Text));

            //update the data
            updateMember.updateMember();

            //Display Confirmation Message
            MessageBox.Show("Member has been updated successfully", "Success",
                MessageBoxButtons.OK, MessageBoxIcon.Information);

            //Reset UI
            cboMemberId.SelectedIndex = -1;
            txtForename.Clear();
            txtSurname.Clear();
            dtpDOB.Text = string.Empty;
            txtEircode.Clear();
            txtEmail.Clear();
            cboPaymentType.SelectedIndex = -1;
            cboMemberId.Focus();
        }

        private void frmUpdateMember_Load(object sender, EventArgs e)
        {
            //load memberIds in combobox
            DataSet dsM = Member.getMemberIds();

            for (int i = 0; i < dsM.Tables[0].Rows.Count; i++)
            {
                cboMemberId.Items.Add(dsM.Tables[0].Rows[i][0]);
            }
        }
    }
}
