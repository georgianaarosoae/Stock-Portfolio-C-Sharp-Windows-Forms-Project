namespace PortofoliuDeActiuni
{
    partial class FormPieChart
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
            this.pieChart2 = new LiveCharts.WinForms.PieChart();
            this.SuspendLayout();
            // 
            // pieChart2
            // 
            this.pieChart2.Location = new System.Drawing.Point(168, 64);
            this.pieChart2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pieChart2.Name = "pieChart2";
            this.pieChart2.Size = new System.Drawing.Size(454, 281);
            this.pieChart2.TabIndex = 0;
            this.pieChart2.Text = "pieChart1";
            this.pieChart2.ChildChanged += new System.EventHandler<System.Windows.Forms.Integration.ChildChangedEventArgs>(this.pieChart2_ChildChanged);
            // 
            // FormGraphic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pieChart2);
            this.Name = "FormGraphic";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Grafic_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private LiveCharts.WinForms.PieChart pieChart2;
    }
}