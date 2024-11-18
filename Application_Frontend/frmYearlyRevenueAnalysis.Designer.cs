
using GymSYS.Database;
using Oracle.ManagedDataAccess.Client;
using System.Windows.Forms;

namespace GymSYS.Application_Frontend
{
    partial class frmYearlyRevenueAnalysis
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

            this.dgvMemberAnalysis = new System.Windows.Forms.DataGridView();
            this.MemberIdColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MemberWalletColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvClassAnalysis = new System.Windows.Forms.DataGridView();
            this.ClassIdsColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClassRegColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClassFeesColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtWalletTotal = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtFeeTotal = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCompleteTotal = new System.Windows.Forms.TextBox();

            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMemberAnalysis)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClassAnalysis)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvMemberAnalysis
            // 
            this.dgvMemberAnalysis.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMemberAnalysis.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MemberIdColumn,
            this.MemberWalletColumn});
            this.dgvMemberAnalysis.Location = new System.Drawing.Point(39, 89);
            this.dgvMemberAnalysis.Name = "dgvMemberAnalysis";
            this.dgvMemberAnalysis.Size = new System.Drawing.Size(244, 217);
            this.dgvMemberAnalysis.TabIndex = 30;
            // 
            // MemberIdColumn
            // 
            this.MemberIdColumn.HeaderText = "Member Ids";
            this.MemberIdColumn.Name = "MemberIdColumn";
            this.MemberIdColumn.ReadOnly = true;
            // 
            // MemberWalletColumn
            // 
            this.MemberWalletColumn.HeaderText = "Member Wallets";
            this.MemberWalletColumn.Name = "MemberWalletColumn";
            this.MemberWalletColumn.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(35, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 20);
            this.label1.TabIndex = 31;
            this.label1.Text = "Member Analysis:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(405, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 20);
            this.label2.TabIndex = 32;
            this.label2.Text = "Class Analysis:";
            // 
            // dgvClassAnalysis
            // 
            this.dgvClassAnalysis.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClassAnalysis.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ClassIdsColumn,
            this.ClassRegColumn,
            this.ClassFeesColumn});
            this.dgvClassAnalysis.Location = new System.Drawing.Point(409, 89);
            this.dgvClassAnalysis.Name = "dgvClassAnalysis";
            this.dgvClassAnalysis.Size = new System.Drawing.Size(345, 217);
            this.dgvClassAnalysis.TabIndex = 33;
            // 
            // ClassIdsColumn
            // 
            this.ClassIdsColumn.HeaderText = "Class Ids";
            this.ClassIdsColumn.Name = "ClassIdsColumn";
            this.ClassIdsColumn.ReadOnly = true;
            // 
            // ClassRegColumn
            // 
            this.ClassRegColumn.HeaderText = "Class Registered";
            this.ClassRegColumn.Name = "ClassRegColumn";
            this.ClassRegColumn.ReadOnly = true;
            // 
            // ClassFeesColumn
            // 
            this.ClassFeesColumn.HeaderText = "Class Fees";
            this.ClassFeesColumn.Name = "ClassFeesColumn";
            this.ClassFeesColumn.ReadOnly = true;
            // 
            // txtWalletTotal
            // 
            this.txtWalletTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWalletTotal.Location = new System.Drawing.Point(223, 337);
            this.txtWalletTotal.Name = "txtWalletTotal";
            this.txtWalletTotal.ReadOnly = true;
            this.txtWalletTotal.Size = new System.Drawing.Size(91, 22);
            this.txtWalletTotal.TabIndex = 34;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(35, 339);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(182, 20);
            this.label3.TabIndex = 35;
            this.label3.Text = "Total in Member Wallets:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(405, 339);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(200, 20);
            this.label4.TabIndex = 36;
            this.label4.Text = "Total Members Registered:";
            // 
            // txtFeeTotal
            // 
            this.txtFeeTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFeeTotal.Location = new System.Drawing.Point(611, 337);
            this.txtFeeTotal.Name = "txtFeeTotal";
            this.txtFeeTotal.ReadOnly = true;
            this.txtFeeTotal.Size = new System.Drawing.Size(91, 22);
            this.txtFeeTotal.TabIndex = 37;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(219, 408);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 20);
            this.label5.TabIndex = 38;
            this.label5.Text = "Complete Total:";
            // 
            // txtCompleteTotal
            // 
            this.txtCompleteTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCompleteTotal.Location = new System.Drawing.Point(345, 406);
            this.txtCompleteTotal.Name = "txtCompleteTotal";
            this.txtCompleteTotal.ReadOnly = true;
            this.txtCompleteTotal.Size = new System.Drawing.Size(91, 22);
            this.txtCompleteTotal.TabIndex = 39;
            // 
            // frmYearlyRevenueAnalysis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtCompleteTotal);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtFeeTotal);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtWalletTotal);
            this.Controls.Add(this.dgvClassAnalysis);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvMemberAnalysis);
            this.Controls.Add(this.menuStrip1);
            this.Name = "frmYearlyRevenueAnalysis";
            this.Text = "Yearly Revenue Analysis";
            this.Load += new System.EventHandler(this.frmYearlyRevenueAnalysis_Load);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMemberAnalysis)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClassAnalysis)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.DataGridView dgvMemberAnalysis;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn MemberIdColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn MemberWalletColumn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvClassAnalysis;
        private System.Windows.Forms.TextBox txtWalletTotal;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtFeeTotal;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCompleteTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClassIdsColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClassRegColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClassFeesColumn;
    }
}