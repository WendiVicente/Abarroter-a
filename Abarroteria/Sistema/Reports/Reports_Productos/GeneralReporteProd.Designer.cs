namespace Sistema.Reports.Reports_Productos
{
    partial class GeneralReporteProd
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
            this.kryptonPanel1 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.rvProductosGenerales = new Microsoft.Reporting.WinForms.ReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).BeginInit();
            this.kryptonPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // kryptonPanel1
            // 
            this.kryptonPanel1.Controls.Add(this.rvProductosGenerales);
            this.kryptonPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanel1.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel1.Name = "kryptonPanel1";
            this.kryptonPanel1.Size = new System.Drawing.Size(800, 450);
            this.kryptonPanel1.TabIndex = 0;
            // 
            // rvProductosGenerales
            // 
            this.rvProductosGenerales.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rvProductosGenerales.DocumentMapWidth = 81;
            this.rvProductosGenerales.LocalReport.ReportEmbeddedResource = "Sistema.Reports.Reports_Productos.GeneralReporte.rdlc";
            this.rvProductosGenerales.Location = new System.Drawing.Point(0, 0);
            this.rvProductosGenerales.Name = "rvProductosGenerales";
            this.rvProductosGenerales.ServerReport.BearerToken = null;
            this.rvProductosGenerales.Size = new System.Drawing.Size(800, 450);
            this.rvProductosGenerales.TabIndex = 0;
            // 
            // GeneralReporteProd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.kryptonPanel1);
            this.Name = "GeneralReporteProd";
            this.Text = "GeneralReporte";
            this.Load += new System.EventHandler(this.GeneralReporte_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).EndInit();
            this.kryptonPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel1;
        private Microsoft.Reporting.WinForms.ReportViewer rvProductosGenerales;
    }
}