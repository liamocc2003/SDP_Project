
using System.Windows.Forms;

namespace GymSYS.Application_Frontend
{
    partial class frmUpdateClass
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtClassName = new System.Windows.Forms.TextBox();
            this.txtClassTeacher = new System.Windows.Forms.TextBox();
            this.txtClassFee = new System.Windows.Forms.TextBox();
            this.btnUpdateClass = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.dtpClassDate = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.txtClassDuration = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtClassSize = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cboClassId = new System.Windows.Forms.ComboBox();

            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(40, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 20);
            this.label1.TabIndex = 18;
            this.label1.Text = "Class Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(40, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 20);
            this.label2.TabIndex = 20;
            this.label2.Text = "Class Teacher:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(40, 367);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 20);
            this.label3.TabIndex = 22;
            this.label3.Text = "Class Fee:";
            // 
            // txtClassName
            // 
            this.txtClassName.Location = new System.Drawing.Point(172, 66);
            this.txtClassName.Name = "txtClassName";
            this.txtClassName.Size = new System.Drawing.Size(163, 20);
            this.txtClassName.TabIndex = 23;
            // 
            // txtClassTeacher
            // 
            this.txtClassTeacher.Location = new System.Drawing.Point(172, 127);
            this.txtClassTeacher.Name = "txtClassTeacher";
            this.txtClassTeacher.Size = new System.Drawing.Size(163, 20);
            this.txtClassTeacher.TabIndex = 24;
            // 
            // txtClassFee
            // 
            this.txtClassFee.Location = new System.Drawing.Point(172, 367);
            this.txtClassFee.Name = "txtClassFee";
            this.txtClassFee.Size = new System.Drawing.Size(163, 20);
            this.txtClassFee.TabIndex = 25;
            // 
            // btnUpdateClass
            // 
            this.btnUpdateClass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateClass.Location = new System.Drawing.Point(678, 398);
            this.btnUpdateClass.Name = "btnUpdateClass";
            this.btnUpdateClass.Size = new System.Drawing.Size(110, 40);
            this.btnUpdateClass.TabIndex = 26;
            this.btnUpdateClass.Text = "Update";
            this.btnUpdateClass.UseVisualStyleBackColor = true;
            this.btnUpdateClass.Click += new System.EventHandler(this.btnUpdateClass_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(535, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 20);
            this.label4.TabIndex = 27;
            this.label4.Text = "Class ID:";
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(677, 113);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(82, 34);
            this.btnSearch.TabIndex = 29;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // dtpClassDate
            // 
            this.dtpClassDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpClassDate.Location = new System.Drawing.Point(171, 243);
            this.dtpClassDate.Name = "dtpClassDate";
            this.dtpClassDate.Size = new System.Drawing.Size(150, 20);
            this.dtpClassDate.TabIndex = 37;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label7.Location = new System.Drawing.Point(40, 243);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(109, 20);
            this.label7.TabIndex = 36;
            this.label7.Text = "Date of Class:";
            // 
            // txtClassDuration
            // 
            this.txtClassDuration.Location = new System.Drawing.Point(171, 305);
            this.txtClassDuration.Name = "txtClassDuration";
            this.txtClassDuration.Size = new System.Drawing.Size(163, 20);
            this.txtClassDuration.TabIndex = 35;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(40, 305);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(117, 20);
            this.label5.TabIndex = 34;
            this.label5.Text = "Class Duration:";
            // 
            // txtClassSize
            // 
            this.txtClassSize.Location = new System.Drawing.Point(171, 186);
            this.txtClassSize.Name = "txtClassSize";
            this.txtClassSize.Size = new System.Drawing.Size(163, 20);
            this.txtClassSize.TabIndex = 33;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(40, 186);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 20);
            this.label6.TabIndex = 32;
            this.label6.Text = "Class Size:";
            // 
            // cboClassId
            // 
            this.cboClassId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboClassId.FormattingEnabled = true;
            this.cboClassId.Location = new System.Drawing.Point(614, 65);
            this.cboClassId.Name = "cboClassId";
            this.cboClassId.Size = new System.Drawing.Size(145, 21);
            this.cboClassId.TabIndex = 38;
            // 
            // frmUpdateClass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cboClassId);
            this.Controls.Add(this.dtpClassDate);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtClassDuration);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtClassSize);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnUpdateClass);
            this.Controls.Add(this.txtClassFee);
            this.Controls.Add(this.txtClassTeacher);
            this.Controls.Add(this.txtClassName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "frmUpdateClass";
            this.Text = "Update Class";
            this.Load += new System.EventHandler(this.frmUpdateClass_Load);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtClassName;
        private System.Windows.Forms.TextBox txtClassTeacher;
        private System.Windows.Forms.TextBox txtClassFee;
        private System.Windows.Forms.Button btnUpdateClass;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DateTimePicker dtpClassDate;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtClassDuration;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtClassSize;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cboClassId;
    }
}