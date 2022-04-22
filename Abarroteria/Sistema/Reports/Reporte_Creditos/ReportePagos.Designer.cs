
namespace Sistema.Reports.Reporte_Creditos
{
    partial class ReportePagos
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnGeneraReporte = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lbCuentaPorCobrar = new System.Windows.Forms.Label();
            this.kryptonLabel24 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.cbCliente = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.rvPagos = new Microsoft.Reporting.WinForms.ReportViewer();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbCliente)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.rvPagos, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 24.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 75.33334F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 450);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(794, 104);
            this.panel1.TabIndex = 0;
            // 
            // btnGeneraReporte
            // 
            this.btnGeneraReporte.Location = new System.Drawing.Point(316, 46);
            this.btnGeneraReporte.Name = "btnGeneraReporte";
            this.btnGeneraReporte.Size = new System.Drawing.Size(141, 39);
            this.btnGeneraReporte.TabIndex = 5;
            this.btnGeneraReporte.Values.Text = "Generar Reporte";
            this.btnGeneraReporte.Click += new System.EventHandler(this.btnGeneraReporte_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnGeneraReporte);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.lbCuentaPorCobrar);
            this.groupBox2.Controls.Add(this.kryptonLabel24);
            this.groupBox2.Controls.Add(this.cbCliente);
            this.groupBox2.Location = new System.Drawing.Point(3, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(473, 98);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "CUENTAS";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label4.Location = new System.Drawing.Point(15, 58);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 16);
            this.label4.TabIndex = 68;
            this.label4.Text = "No. de Cuenta:";
            // 
            // lbCuentaPorCobrar
            // 
            this.lbCuentaPorCobrar.AutoSize = true;
            this.lbCuentaPorCobrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCuentaPorCobrar.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbCuentaPorCobrar.Location = new System.Drawing.Point(161, 59);
            this.lbCuentaPorCobrar.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbCuentaPorCobrar.Name = "lbCuentaPorCobrar";
            this.lbCuentaPorCobrar.Size = new System.Drawing.Size(73, 16);
            this.lbCuentaPorCobrar.TabIndex = 67;
            this.lbCuentaPorCobrar.Text = "CC-00000";
            // 
            // kryptonLabel24
            // 
            this.kryptonLabel24.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.BoldControl;
            this.kryptonLabel24.Location = new System.Drawing.Point(10, 19);
            this.kryptonLabel24.Name = "kryptonLabel24";
            this.kryptonLabel24.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2007Blue;
            this.kryptonLabel24.Size = new System.Drawing.Size(51, 20);
            this.kryptonLabel24.TabIndex = 55;
            this.kryptonLabel24.Values.Text = "Cliente";
            // 
            // cbCliente
            // 
            this.cbCliente.DropDownWidth = 250;
            this.cbCliente.Location = new System.Drawing.Point(86, 19);
            this.cbCliente.Name = "cbCliente";
            this.cbCliente.Size = new System.Drawing.Size(197, 21);
            this.cbCliente.TabIndex = 54;
            this.cbCliente.SelectedIndexChanged += new System.EventHandler(this.cbCliente_SelectedIndexChanged);
            // 
            // rvPagos
            // 
            this.rvPagos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rvPagos.LocalReport.ReportEmbeddedResource = "Sistema.Reports.Reporte_Creditos.ReportePagos.rdlc";
            this.rvPagos.Location = new System.Drawing.Point(3, 113);
            this.rvPagos.Name = "rvPagos";
            this.rvPagos.ServerReport.BearerToken = null;
            this.rvPagos.Size = new System.Drawing.Size(794, 334);
            this.rvPagos.TabIndex = 1;
            // 
            // ReportePagos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "ReportePagos";
            this.Text = "Reporte Pagos";
            this.Load += new System.EventHandler(this.ReportePagos_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbCliente)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnGeneraReporte;
        private System.Windows.Forms.GroupBox groupBox2;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel24;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox cbCliente;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbCuentaPorCobrar;
        private Microsoft.Reporting.WinForms.ReportViewer rvPagos;
    }
}