namespace PresupuestoDeCuentas2.UI.Reportes
{
    partial class ReporteViewer
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
            this.PresupuestoCrystalReview = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // PresupuestoCrystalReview
            // 
            this.PresupuestoCrystalReview.ActiveViewIndex = -1;
            this.PresupuestoCrystalReview.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PresupuestoCrystalReview.Cursor = System.Windows.Forms.Cursors.Default;
            this.PresupuestoCrystalReview.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PresupuestoCrystalReview.Location = new System.Drawing.Point(0, 0);
            this.PresupuestoCrystalReview.Name = "PresupuestoCrystalReview";
            this.PresupuestoCrystalReview.Size = new System.Drawing.Size(824, 516);
            this.PresupuestoCrystalReview.TabIndex = 0;
            this.PresupuestoCrystalReview.Load += new System.EventHandler(this.crystalReportViewer1_Load);
            // 
            // ReporteViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(824, 516);
            this.Controls.Add(this.PresupuestoCrystalReview);
            this.Name = "ReporteViewer";
            this.Text = "ReporteViewer";
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer PresupuestoCrystalReview;
    }
}