
using System.Windows.Forms;

namespace GymSYS.Application_Frontend
{
    partial class frmCancelBooking
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

            this.btnCancelClass = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.cboBookingId = new System.Windows.Forms.ComboBox();
            this.cboMemberId = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtClassId = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtForename = new System.Windows.Forms.TextBox();

            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCancelClass
            // 
            this.btnCancelClass.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelClass.Location = new System.Drawing.Point(345, 263);
            this.btnCancelClass.Name = "btnCancelClass";
            this.btnCancelClass.Size = new System.Drawing.Size(110, 40);
            this.btnCancelClass.TabIndex = 29;
            this.btnCancelClass.Text = "Cancel";
            this.btnCancelClass.UseVisualStyleBackColor = true;
            this.btnCancelClass.Click += new System.EventHandler(this.btnCancelClass_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label7.Location = new System.Drawing.Point(296, 209);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(92, 20);
            this.label7.TabIndex = 25;
            this.label7.Text = "Booking ID:";
            this.label7.Visible = false;
            // 
            // cboBookingId
            // 
            this.cboBookingId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboBookingId.FormattingEnabled = true;
            this.cboBookingId.Location = new System.Drawing.Point(394, 208);
            this.cboBookingId.Name = "cboBookingId";
            this.cboBookingId.Size = new System.Drawing.Size(117, 21);
            this.cboBookingId.TabIndex = 30;
            this.cboBookingId.Visible = false;
            // 
            // cboMemberId
            // 
            this.cboMemberId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMemberId.FormattingEnabled = true;
            this.cboMemberId.Location = new System.Drawing.Point(342, 108);
            this.cboMemberId.Name = "cboMemberId";
            this.cboMemberId.Size = new System.Drawing.Size(117, 21);
            this.cboMemberId.TabIndex = 32;
            this.cboMemberId.SelectedIndexChanged += new System.EventHandler(this.cboMemberId_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(244, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 20);
            this.label1.TabIndex = 31;
            this.label1.Text = "Member ID:";
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(481, 108);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 33;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtClassId
            // 
            this.txtClassId.Location = new System.Drawing.Point(688, 418);
            this.txtClassId.Name = "txtClassId";
            this.txtClassId.Size = new System.Drawing.Size(100, 20);
            this.txtClassId.TabIndex = 34;
            this.txtClassId.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(296, 156);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 20);
            this.label2.TabIndex = 35;
            this.label2.Text = "Forename:";
            this.label2.Visible = false;
            // 
            // txtForename
            // 
            this.txtForename.Enabled = false;
            this.txtForename.Location = new System.Drawing.Point(394, 156);
            this.txtForename.Name = "txtForename";
            this.txtForename.Size = new System.Drawing.Size(117, 20);
            this.txtForename.TabIndex = 36;
            this.txtForename.Visible = false;
            // 
            // frmCancelBooking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtForename);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtClassId);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.cboMemberId);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboBookingId);
            this.Controls.Add(this.btnCancelClass);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.menuStrip1);
            this.Name = "frmCancelBooking";
            this.Text = "Cancel Booking";
            this.Load += new System.EventHandler(this.frmCancelBooking_Load);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancelClass;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ComboBox cboBookingId;
        private System.Windows.Forms.ComboBox cboMemberId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtClassId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtForename;
    }
}