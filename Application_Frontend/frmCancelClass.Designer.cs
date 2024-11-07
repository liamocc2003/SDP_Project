
using System.Windows.Forms;

namespace GymSYS.Application_Frontend
{
    partial class frmCancelClass
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
            this.btnCancelClass = new System.Windows.Forms.Button();
            this.cboClassId = new System.Windows.Forms.ComboBox();
            this.cboBookings = new System.Windows.Forms.ComboBox();

            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(296, 151);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 20);
            this.label1.TabIndex = 19;
            this.label1.Text = "Class ID:";
            // 
            // btnCancelClass
            // 
            this.btnCancelClass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelClass.Location = new System.Drawing.Point(345, 250);
            this.btnCancelClass.Name = "btnCancelClass";
            this.btnCancelClass.Size = new System.Drawing.Size(110, 40);
            this.btnCancelClass.TabIndex = 27;
            this.btnCancelClass.Text = "Cancel";
            this.btnCancelClass.UseVisualStyleBackColor = true;
            this.btnCancelClass.Click += new System.EventHandler(this.btnCancelClass_Click);
            // 
            // cboClassId
            // 
            this.cboClassId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboClassId.FormattingEnabled = true;
            this.cboClassId.Location = new System.Drawing.Point(375, 150);
            this.cboClassId.Name = "cboClassId";
            this.cboClassId.Size = new System.Drawing.Size(129, 21);
            this.cboClassId.TabIndex = 28;
            // 
            // cboBookings
            // 
            this.cboBookings.FormattingEnabled = true;
            this.cboBookings.Location = new System.Drawing.Point(756, 417);
            this.cboBookings.Name = "cboBookings";
            this.cboBookings.Size = new System.Drawing.Size(32, 21);
            this.cboBookings.TabIndex = 29;
            this.cboBookings.Visible = false;
            // 
            // frmCancelClass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cboBookings);
            this.Controls.Add(this.cboClassId);
            this.Controls.Add(this.btnCancelClass);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "frmCancelClass";
            this.Text = "Cancel Class";
            this.Load += new System.EventHandler(this.frmCancelClass_Load);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCancelClass;
        private System.Windows.Forms.ComboBox cboClassId;
        private System.Windows.Forms.ComboBox cboBookings;
    }
}