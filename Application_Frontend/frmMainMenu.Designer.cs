
using System.Windows.Forms;
using static GymSYS.Application_Frontend.toolStripMenu;

namespace GymSYS.Application_Frontend
{
    partial class frmMainMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMainMenu));
            Form form = this;
            toolStripMenu menuStrip = new toolStripMenu(menuStrip1, this);

            this.label1 = new System.Windows.Forms.Label();
            this.pboLogo = new System.Windows.Forms.PictureBox();

            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pboLogo)).BeginInit();
            this.SuspendLayout();
            //
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(350, 330);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 36);
            this.label1.TabIndex = 2;
            this.label1.Text = "GYMSYS";
            // 
            // pboLogo
            // 
            this.pboLogo.BackColor = System.Drawing.Color.Transparent;
            this.pboLogo.Image = global::GymSYS.Properties.Resources.GymSysLogo;
            this.pboLogo.Location = new System.Drawing.Point(325, 75);
            this.pboLogo.Name = "pboLogo";
            this.pboLogo.Size = new System.Drawing.Size(200, 200);
            this.pboLogo.TabIndex = 1;
            this.pboLogo.TabStop = false;
            // 
            // frmMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 461);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pboLogo);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMainMenu";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main Menu";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pboLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.PictureBox pboLogo;
        private System.Windows.Forms.Label label1;
    }
}