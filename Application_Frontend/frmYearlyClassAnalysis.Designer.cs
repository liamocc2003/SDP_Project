
using GymSYS.Database;
using Oracle.ManagedDataAccess.Client;
using System.Windows.Forms;

namespace GymSYS.Application_Frontend
{
    partial class frmYearlyClassAnalysis
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

            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.chartClassAnalysis = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTotalClasses = new System.Windows.Forms.TextBox();

            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartClassAnalysis)).BeginInit();
            this.SuspendLayout();
            // 
            // chartClassAnalysis
            // 
            chartArea1.Name = "ChartArea1";
            this.chartClassAnalysis.ChartAreas.Add(chartArea1);
            legend1.ItemColumnSpacing = 10;
            legend1.Name = "Legend1";
            this.chartClassAnalysis.Legends.Add(legend1);
            this.chartClassAnalysis.Location = new System.Drawing.Point(12, 63);
            this.chartClassAnalysis.Name = "chartClassAnalysis";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.MarkerSize = 2;
            series1.MarkerStep = 5;
            series1.Name = "Class";
            this.chartClassAnalysis.Series.Add(series1);
            this.chartClassAnalysis.Size = new System.Drawing.Size(776, 300);
            this.chartClassAnalysis.TabIndex = 2;
            this.chartClassAnalysis.Text = "chart1";
            title1.Name = "Title1";
            title1.Text = "Class Analysis";
            this.chartClassAnalysis.Titles.Add(title1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(316, 409);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Total Classes:";
            // 
            // txtTotalClasses
            // 
            this.txtTotalClasses.Location = new System.Drawing.Point(430, 409);
            this.txtTotalClasses.Name = "txtTotalClasses";
            this.txtTotalClasses.ReadOnly = true;
            this.txtTotalClasses.Size = new System.Drawing.Size(100, 20);
            this.txtTotalClasses.TabIndex = 4;
            // 
            // frmYearlyClassAnalysis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtTotalClasses);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chartClassAnalysis);
            this.Controls.Add(this.menuStrip1);
            this.Name = "frmYearlyClassAnalysis";
            this.Text = "Yearly Class Analysis";
            this.Load += new System.EventHandler(this.frmYearlyClassAnalysis_Load);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartClassAnalysis)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartClassAnalysis;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTotalClasses;
    }
}