
namespace Sistema.Reports.Reports_Clientes
{
    partial class VentasCliente
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chktodasf = new ComponentFactory.Krypton.Toolkit.KryptonCheckBox();
            this.dtpFechaFinal = new ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker();
            this.dtpFechaInicio = new ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker();
            this.kryptonLabel2 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel1 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnGeneraReporte = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kryptonLabel24 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.cbCliente = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.rvVentas = new Microsoft.Reporting.WinForms.ReportViewer();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbCliente)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.rvVentas, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.77778F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 74.22222F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 450);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(794, 110);
            this.panel1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chktodasf);
            this.groupBox1.Controls.Add(this.dtpFechaFinal);
            this.groupBox1.Controls.Add(this.dtpFechaInicio);
            this.groupBox1.Controls.Add(this.kryptonLabel2);
            this.groupBox1.Controls.Add(this.kryptonLabel1);
            this.groupBox1.Location = new System.Drawing.Point(3, 8);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(380, 96);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "FECHAS";
            // 
            // chktodasf
            // 
            this.chktodasf.Location = new System.Drawing.Point(119, 67);
            this.chktodasf.Name = "chktodasf";
            this.chktodasf.Size = new System.Drawing.Size(107, 20);
            this.chktodasf.TabIndex = 6;
            this.chktodasf.Values.Text = "Todas la fechas";
            // 
            // dtpFechaFinal
            // 
            this.dtpFechaFinal.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.dtpFechaFinal.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaFinal.Location = new System.Drawing.Point(119, 40);
            this.dtpFechaFinal.Name = "dtpFechaFinal";
            this.dtpFechaFinal.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Global;
            this.dtpFechaFinal.Size = new System.Drawing.Size(188, 21);
            this.dtpFechaFinal.TabIndex = 3;
            // 
            // dtpFechaInicio
            // 
            this.dtpFechaInicio.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.dtpFechaInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaInicio.Location = new System.Drawing.Point(119, 15);
            this.dtpFechaInicio.MinDate = new System.DateTime(2020, 1, 1, 0, 0, 0, 0);
            this.dtpFechaInicio.Name = "dtpFechaInicio";
            this.dtpFechaInicio.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Global;
            this.dtpFechaInicio.Size = new System.Drawing.Size(188, 21);
            this.dtpFechaInicio.TabIndex = 2;
            this.dtpFechaInicio.ValueNullable = new System.DateTime(2021, 8, 4, 14, 45, 49, 0);
            // 
            // kryptonLabel2
            // 
            this.kryptonLabel2.Location = new System.Drawing.Point(20, 40);
            this.kryptonLabel2.Name = "kryptonLabel2";
            this.kryptonLabel2.Size = new System.Drawing.Size(73, 20);
            this.kryptonLabel2.TabIndex = 1;
            this.kryptonLabel2.Values.Text = "Fecha Final:";
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.Location = new System.Drawing.Point(20, 19);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.Size = new System.Drawing.Size(79, 20);
            this.kryptonLabel1.TabIndex = 0;
            this.kryptonLabel1.Values.Text = "Fecha Inicial:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnGeneraReporte);
            this.groupBox2.Controls.Add(this.kryptonLabel24);
            this.groupBox2.Controls.Add(this.cbCliente);
            this.groupBox2.Location = new System.Drawing.Point(389, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(324, 98);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "CLIENTES";
            // 
            // btnGeneraReporte
            // 
            this.btnGeneraReporte.Location = new System.Drawing.Point(142, 53);
            this.btnGeneraReporte.Name = "btnGeneraReporte";
            this.btnGeneraReporte.Size = new System.Drawing.Size(141, 39);
            this.btnGeneraReporte.TabIndex = 5;
            this.btnGeneraReporte.Values.Text = "Generar Reporte";
            this.btnGeneraReporte.Click += new System.EventHandler(this.btnGeneraReporte_Click);
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
            // rvVentas
            // 
            this.rvVentas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rvVentas.LocalReport.ReportEmbeddedResource = "Sistema.Reports.Reporte_Creditos.ReportePagos.rdlc";
            this.rvVentas.Location = new System.Drawing.Point(3, 119);
            this.rvVentas.Name = "rvVentas";
            this.rvVentas.ServerReport.BearerToken = null;
            this.rvVentas.Size = new System.Drawing.Size(794, 328);
            this.rvVentas.TabIndex = 1;
            // 
            // VentasCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "VentasCliente";
            this.Text = "Reporte Pagos";
            this.Load += new System.EventHandler(this.ReportePagos_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
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
        private Microsoft.Reporting.WinForms.ReportViewer rvVentas;
        private System.Windows.Forms.GroupBox groupBox1;
        private ComponentFactory.Krypton.Toolkit.KryptonCheckBox chktodasf;
        private ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker dtpFechaFinal;
        private ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker dtpFechaInicio;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel2;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel1;
    }
}