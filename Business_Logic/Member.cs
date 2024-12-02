using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using GymSYS.Database;
using Oracle.ManagedDataAccess.Client;

namespace GymSYS.Business_Logic
{
    class Member
    {
        private int memberId;
        private String forename;
        private String surname;
        private String dateOfBirth;
        private String eircode;
        private String email;
        private String paymentType;
        private int memberWallet;
        private int memberPoints;

        //define sqlFunctions
        private sqlConnection sqlConnection = new sqlConnection();

        public Member()
        {
            this.memberId = 10000;
            this.forename = "";
            this.surname = "";
            this.dateOfBirth = Convert.ToString(DateTime.Today);
            this.eircode = "";
            this.email = "";
            this.paymentType = "";
            this.memberWallet = 0;
            this.memberPoints = 0;
    }

        public Member(int memberId, String forename, String surname, String dateOfBirth, String eircode, String email, String paymentType, int memberWallet, int memberPoints)
        {
            this.memberId = memberId;
            this.forename = forename;
            this.surname = surname;
            this.dateOfBirth = dateOfBirth;
            this.eircode = eircode;
            this.email = email;
            this.paymentType = paymentType;
            this.memberWallet = memberWallet;
            this.memberPoints = memberPoints;
        }

        public int getMemberId()
        {
            return this.memberId;
        }
        public String getForename()
        {
            return this.forename;
        }
        public String getSurname()
        {
            return this.surname;
        }
        public String getDateOfBirth()
        {
            return this.dateOfBirth;
        }
        public String getEircode()
        {
            return this.eircode;
        }
        public String getEmail()
        {
            return this.email;
        }
        public String getPaymentType()
        {
            return this.paymentType;
        }
        public int getMemberWallet()
        {
            return this.memberWallet;
        }
        public int getMemberPoints()
        {
            return this.memberPoints;
        }

        public void setMemberId(int MemberId)
        {
            memberId=MemberId;
        }
        public void setForename(String Forename)
        {
            forename=Forename;
        }
        public void setSurname(String Surname)
        {
            surname=Surname;
        }
        public void setDateOfBirth(String DateOfBirth)
        {
            dateOfBirth=DateOfBirth;
        }
        public void setEircode(String Eircode)
        {
            eircode=Eircode;
        }
        public void setEmail(String Email)
        {
            email=Email;
        }
        public void setPaymentType(String PaymentType)
        {
            paymentType=PaymentType;
        }
        public void setMemberWallet(int MemberWallet)
        {
            memberWallet = MemberWallet;
        }
        public void setMemberPoints(int MemberPoints)
        {
            memberPoints = MemberPoints;
        }

        public void validateMember(TextBox txtForename, TextBox txtSurname, TextBox txtEircode, TextBox txtEmail, ComboBox cboPaymentType)
        {
            //Validate all data
            //Validate forename
            if (txtForename.Text.Equals(""))
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
        }

        public void addMember()
        {
            //define sql query
            String sqlQuery = "INSERT INTO MEMBERS VALUES (" +
                this.memberId + ",'" +
                this.forename + "','" +
                this.surname + "','" +
                this.dateOfBirth + "','" +
                this.eircode + "','" +
                this.email + "','" +
                this.paymentType + "'," +
                this.memberWallet + "," +
                this.memberPoints + ")";

            //execute query
            OracleConnection conn = new OracleConnection(DBConnect.oracledb);
            conn.Open();

            OracleCommand cmd = new OracleCommand(sqlQuery, conn);

            cmd.ExecuteNonQuery();

            //close database
            sqlConnection.close_db(conn);
        }

        public void updateMember()
        {
            //conect to database
            OracleConnection conn = new OracleConnection(DBConnect.oracledb);

            //define sql query
            String sqlQuery = "UPDATE Members SET " +
                "Member_Id = " + this.memberId + "," +
                "Forename = '" + this.forename + "'," +
                "Surname = '" + this.surname + "'," +
                "Date_Of_Birth = '" + this.dateOfBirth + "'," +
                "Eircode = '" + this.eircode + "'," +
                "Email = '" + this.email + "'," +
                "Payment_Type = '" + this.paymentType + "'," +
                "Member_Wallet = " + this.memberWallet + "," +
                "Member_Points = " + this.memberPoints +
                "WHERE Member_Id = " + this.memberId;

            //execute query
            OracleCommand cmd = new OracleCommand(sqlQuery, conn);
            conn.Open();

            cmd.ExecuteNonQuery();

            //close database
            conn.Close();
        }

        public static int getNextMemberId()
        {
            //define sql query
            String sqlQuery="SELECT MAX(Member_Id) FROM Members";

            //execute query
            OracleConnection conn = new OracleConnection(DBConnect.oracledb);
            conn.Open();

            OracleCommand cmd = new OracleCommand(sqlQuery, conn);

            OracleDataReader dr = cmd.ExecuteReader();

            //is dr null
            int nextId;
            dr.Read();

            if (dr.IsDBNull(0))
            {
                nextId = 10000;
            }
            else
            {
                nextId = dr.GetInt32(0) + 1;
            }

            conn.Close();

            return nextId;
        }

        public static DataSet getMemberIds()
        {
            //open a db connection
            OracleConnection conn = new OracleConnection(DBConnect.oracledb);

            //define sql query to execute
            String sqlQuery = "SELECT Member_Id FROM Members ORDER BY Member_Id ASC";

            //execute sql query
            OracleCommand cmd = new OracleCommand(sqlQuery, conn);

            OracleDataAdapter da = new OracleDataAdapter(cmd);

            DataSet ds = new DataSet();
            da.Fill(ds, "membIds");

            //close db connection
            conn.Close();

            return ds;
        }

        public static DataSet getMemberDetails()
        {
            //open a db connection
            OracleConnection conn = new OracleConnection(DBConnect.oracledb);

            //define sql query to execute
            String sqlQuery = "SELECT Member_Id,Member_Wallet FROM Members ORDER BY Member_Id ASC";

            //execute sql query
            OracleCommand cmd = new OracleCommand(sqlQuery, conn);

            OracleDataAdapter da = new OracleDataAdapter(cmd);

            DataSet ds = new DataSet();
            da.Fill(ds, "membAll");

            //close db connection
            conn.Close();

            return ds;
        }

        public static int getWalletTotal()
        {
            //open a db connection
            OracleConnection conn = new OracleConnection(DBConnect.oracledb);

            //define sql query to execute
            String sqlQuery = "SELECT SUM(Member_Wallet) FROM Members";

            //execute sql query
            OracleCommand cmd = new OracleCommand(sqlQuery, conn);
            conn.Open();

            OracleDataReader dr = cmd.ExecuteReader();

            //is dr null
            int walletTotal;
            dr.Read();

            if (dr.IsDBNull(0))
            {
                walletTotal = 0;
            }
            else
            {
                walletTotal = dr.GetInt32(0);
            }

            //close db connection
            conn.Close();

            return walletTotal;
        }

        public void bookedClass()
        {
            //conect to database
            OracleConnection conn = new OracleConnection(DBConnect.oracledb);

            //define sql query
            String sqlQuery = "UPDATE Members SET " +
                "Member_Wallet = " + this.memberWallet + "," +
                "Member_Points = " + this.memberPoints +
                "WHERE Member_Id = " + this.memberId;

            //execute query
            OracleCommand cmd = new OracleCommand(sqlQuery, conn);
            conn.Open();

            cmd.ExecuteNonQuery();

            //close database
            conn.Close();
        }
    }
}
