
using System.Windows.Forms;

namespace GymSYS.Application_Frontend
{
    partial class frmTopUpMemberWallet
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            Form form = this;
            toolStripMenu menuStrip = new toolStripMenu(menuStrip1, this);

            this.label1 = new System.Windows.Forms.Label();
            this.btnAddMoney = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.txtCurrentAmount = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpDOB = new System.Windows.Forms.DateTimePicker();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.txtForename = new System.Windows.Forms.TextBox();
            this.cboPaymentType = new System.Windows.Forms.ComboBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtEircode = new System.Windows.Forms.TextBox();
            this.cboMemberId = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();

            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(40, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 20);
            this.label1.TabIndex = 18;
            this.label1.Text = "Member Id:";
            // 
            // btnAddMoney
            // 
            this.btnAddMoney.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddMoney.Location = new System.Drawing.Point(678, 398);
            this.btnAddMoney.Name = "btnAddMoney";
            this.btnAddMoney.Size = new System.Drawing.Size(110, 40);
            this.btnAddMoney.TabIndex = 20;
            this.btnAddMoney.Text = "Add Money";
            this.btnAddMoney.UseVisualStyleBackColor = true;
            this.btnAddMoney.Click += new System.EventHandler(this.btnAddMoney_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(40, 261);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 20);
            this.label2.TabIndex = 22;
            this.label2.Text = "Amount:           €";
            // 
            // txtAmount
            // 
            this.txtAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAmount.Location = new System.Drawing.Point(162, 259);
            this.txtAmount.MaxLength = 2;
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(133, 22);
            this.txtAmount.TabIndex = 23;
            // 
            // txtCurrentAmount
            // 
            this.txtCurrentAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCurrentAmount.Location = new System.Drawing.Point(194, 203);
            this.txtCurrentAmount.Name = "txtCurrentAmount";
            this.txtCurrentAmount.ReadOnly = true;
            this.txtCurrentAmount.Size = new System.Drawing.Size(101, 22);
            this.txtCurrentAmount.TabIndex = 25;
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(334, 65);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 22);
            this.btnSearch.TabIndex = 26;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(40, 205);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(148, 20);
            this.label3.TabIndex = 27;
            this.label3.Text = "Current amount is €";
            // 
            // dtpDOB
            // 
            this.dtpDOB.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDOB.Location = new System.Drawing.Point(638, 85);
            this.dtpDOB.Name = "dtpDOB";
            this.dtpDOB.Size = new System.Drawing.Size(150, 20);
            this.dtpDOB.TabIndex = 39;
            this.dtpDOB.Visible = false;
            // 
            // txtSurname
            // 
            this.txtSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtSurname.Location = new System.Drawing.Point(638, 56);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(150, 23);
            this.txtSurname.TabIndex = 41;
            this.txtSurname.Visible = false;
            // 
            // txtForename
            // 
            this.txtForename.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtForename.Location = new System.Drawing.Point(194, 111);
            this.txtForename.Name = "txtForename";
            this.txtForename.ReadOnly = true;
            this.txtForename.Size = new System.Drawing.Size(101, 23);
            this.txtForename.TabIndex = 40;
            // 
            // cboPaymentType
            // 
            this.cboPaymentType.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cboPaymentType.FormattingEnabled = true;
            this.cboPaymentType.Items.AddRange(new object[] {
            "Cash",
            "Credit Card",
            "Revolut"});
            this.cboPaymentType.Location = new System.Drawing.Point(638, 169);
            this.cboPaymentType.Name = "cboPaymentType";
            this.cboPaymentType.Size = new System.Drawing.Size(150, 24);
            this.cboPaymentType.TabIndex = 44;
            this.cboPaymentType.Visible = false;
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtEmail.Location = new System.Drawing.Point(638, 140);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(150, 23);
            this.txtEmail.TabIndex = 43;
            this.txtEmail.Visible = false;
            // 
            // txtEircode
            // 
            this.txtEircode.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtEircode.Location = new System.Drawing.Point(638, 111);
            this.txtEircode.Name = "txtEircode";
            this.txtEircode.Size = new System.Drawing.Size(150, 23);
            this.txtEircode.TabIndex = 42;
            this.txtEircode.Visible = false;
            // 
            // cboMemberId
            // 
            this.cboMemberId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMemberId.FormattingEnabled = true;
            this.cboMemberId.Location = new System.Drawing.Point(162, 67);
            this.cboMemberId.Name = "cboMemberId";
            this.cboMemberId.Size = new System.Drawing.Size(133, 21);
            this.cboMemberId.TabIndex = 45;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(40, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(152, 20);
            this.label4.TabIndex = 47;
            this.label4.Text = "Member Forename: ";
            // 
            // frmTopUpMemberWallet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cboMemberId);
            this.Controls.Add(this.cboPaymentType);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtEircode);
            this.Controls.Add(this.txtSurname);
            this.Controls.Add(this.txtForename);
            this.Controls.Add(this.dtpDOB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtCurrentAmount);
            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnAddMoney);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "frmTopUpMemberWallet";
            this.Text = "Top-Up Member Wallet";
            this.Load += new System.EventHandler(this.frmTopUpMemberWallet_Load);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAddMoney;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.TextBox txtCurrentAmount;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpDOB;
        private System.Windows.Forms.TextBox txtSurname;
        private System.Windows.Forms.TextBox txtForename;
        private System.Windows.Forms.ComboBox cboPaymentType;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtEircode;
        private System.Windows.Forms.ComboBox cboMemberId;
        private System.Windows.Forms.Label label4;
    }
}