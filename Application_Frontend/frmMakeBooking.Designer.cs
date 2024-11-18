
using GymSYS.Database;
using Oracle.ManagedDataAccess.Client;
using System.Windows.Forms;

namespace GymSYS.Application_Frontend
{
    partial class frmMakeBooking
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

            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBookClass = new System.Windows.Forms.Button();
            this.txtBookingId = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cboClassId = new System.Windows.Forms.ComboBox();
            this.cboMemberId = new System.Windows.Forms.ComboBox();
            this.rdbMemberWallet = new System.Windows.Forms.RadioButton();
            this.rdbMemberPoints = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.txtForename = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtClassName = new System.Windows.Forms.TextBox();

            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label7.Location = new System.Drawing.Point(44, 161);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(92, 20);
            this.label7.TabIndex = 19;
            this.label7.Text = "Member ID:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(394, 162);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 20);
            this.label1.TabIndex = 21;
            this.label1.Text = "Class ID:";
            // 
            // btnBookClass
            // 
            this.btnBookClass.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBookClass.Location = new System.Drawing.Point(678, 398);
            this.btnBookClass.Name = "btnBookClass";
            this.btnBookClass.Size = new System.Drawing.Size(110, 40);
            this.btnBookClass.TabIndex = 23;
            this.btnBookClass.Text = "Book";
            this.btnBookClass.UseVisualStyleBackColor = true;
            this.btnBookClass.Click += new System.EventHandler(this.btnBookClass_Click);
            // 
            // txtBookingId
            // 
            this.txtBookingId.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtBookingId.Location = new System.Drawing.Point(167, 69);
            this.txtBookingId.Name = "txtBookingId";
            this.txtBookingId.ReadOnly = true;
            this.txtBookingId.Size = new System.Drawing.Size(150, 23);
            this.txtBookingId.TabIndex = 25;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(44, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 20);
            this.label2.TabIndex = 24;
            this.label2.Text = "Booking ID:";
            // 
            // cboClassId
            // 
            this.cboClassId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboClassId.FormattingEnabled = true;
            this.cboClassId.Location = new System.Drawing.Point(517, 161);
            this.cboClassId.Name = "cboClassId";
            this.cboClassId.Size = new System.Drawing.Size(150, 21);
            this.cboClassId.TabIndex = 26;
            this.cboClassId.SelectedIndexChanged += new System.EventHandler(this.cboClassId_SelectedIndexChanged);
            // 
            // cboMemberId
            // 
            this.cboMemberId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMemberId.FormattingEnabled = true;
            this.cboMemberId.Location = new System.Drawing.Point(167, 160);
            this.cboMemberId.Name = "cboMemberId";
            this.cboMemberId.Size = new System.Drawing.Size(150, 21);
            this.cboMemberId.TabIndex = 27;
            this.cboMemberId.SelectedIndexChanged += new System.EventHandler(this.cboMemberId_SelectedIndexChanged);
            // 
            // rdbMemberWallet
            // 
            this.rdbMemberWallet.AutoSize = true;
            this.rdbMemberWallet.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.rdbMemberWallet.Location = new System.Drawing.Point(48, 301);
            this.rdbMemberWallet.Name = "rdbMemberWallet";
            this.rdbMemberWallet.Size = new System.Drawing.Size(120, 21);
            this.rdbMemberWallet.TabIndex = 28;
            this.rdbMemberWallet.TabStop = true;
            this.rdbMemberWallet.Text = "Member Wallet";
            this.rdbMemberWallet.UseVisualStyleBackColor = true;
            // 
            // rdbMemberPoints
            // 
            this.rdbMemberPoints.AutoSize = true;
            this.rdbMemberPoints.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.rdbMemberPoints.Location = new System.Drawing.Point(48, 324);
            this.rdbMemberPoints.Name = "rdbMemberPoints";
            this.rdbMemberPoints.Size = new System.Drawing.Size(120, 21);
            this.rdbMemberPoints.TabIndex = 29;
            this.rdbMemberPoints.TabStop = true;
            this.rdbMemberPoints.Text = "Member Points";
            this.rdbMemberPoints.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(44, 278);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(184, 20);
            this.label3.TabIndex = 30;
            this.label3.Text = "Select a payment option:";
            // 
            // txtForename
            // 
            this.txtForename.Location = new System.Drawing.Point(198, 210);
            this.txtForename.Name = "txtForename";
            this.txtForename.ReadOnly = true;
            this.txtForename.Size = new System.Drawing.Size(119, 20);
            this.txtForename.TabIndex = 31;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label4.Location = new System.Drawing.Point(44, 210);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(148, 20);
            this.label4.TabIndex = 32;
            this.label4.Text = "Member Forename:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label5.Location = new System.Drawing.Point(394, 208);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 20);
            this.label5.TabIndex = 34;
            this.label5.Text = "Class Name:";
            // 
            // txtClassName
            // 
            this.txtClassName.Location = new System.Drawing.Point(517, 208);
            this.txtClassName.Name = "txtClassName";
            this.txtClassName.ReadOnly = true;
            this.txtClassName.Size = new System.Drawing.Size(150, 20);
            this.txtClassName.TabIndex = 33;
            // 
            // frmMakeBooking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtClassName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtForename);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.rdbMemberPoints);
            this.Controls.Add(this.rdbMemberWallet);
            this.Controls.Add(this.cboMemberId);
            this.Controls.Add(this.cboClassId);
            this.Controls.Add(this.txtBookingId);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnBookClass);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.menuStrip1);
            this.Name = "frmMakeBooking";
            this.Text = "Make Booking";
            this.Load += new System.EventHandler(this.frmMakeBooking_Load);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBookClass;
        private System.Windows.Forms.TextBox txtBookingId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboClassId;
        private System.Windows.Forms.ComboBox cboMemberId;
        private System.Windows.Forms.RadioButton rdbMemberWallet;
        private System.Windows.Forms.RadioButton rdbMemberPoints;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtForename;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtClassName;
    }
}