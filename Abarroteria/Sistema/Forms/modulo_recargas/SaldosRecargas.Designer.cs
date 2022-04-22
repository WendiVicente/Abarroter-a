
namespace Sistema.Forms.modulo_recargas
{
    partial class SaldosRecargas
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SaldosRecargas));
            this.kryptonHeaderGroup1 = new ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.DgvHistorialSaldos = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sucursalIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sucursalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.empresaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.saldoInicialDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.saldoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.saldoActualDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaTransferenciaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.listarHistorialRecargasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.BtnEliminar = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.dtpFecha = new ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker();
            this.kryptonLabel4 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.lbSaldoActualClaro = new System.Windows.Forms.Label();
            this.kryptonLabel3 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.RbClaro = new ComponentFactory.Krypton.Toolkit.KryptonRadioButton();
            this.RbTigo = new ComponentFactory.Krypton.Toolkit.KryptonRadioButton();
            this.TxtNuevoSaldo = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.kryptonLabel2 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.BtnGuardar = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.lbSaldoActualTigo = new System.Windows.Forms.Label();
            this.kryptonLabel1 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonHeaderGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonHeaderGroup1.Panel)).BeginInit();
            this.kryptonHeaderGroup1.Panel.SuspendLayout();
            this.kryptonHeaderGroup1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvHistorialSaldos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listarHistorialRecargasBindingSource)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // kryptonHeaderGroup1
            // 
            this.kryptonHeaderGroup1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonHeaderGroup1.Location = new System.Drawing.Point(0, 0);
            this.kryptonHeaderGroup1.Name = "kryptonHeaderGroup1";
            // 
            // kryptonHeaderGroup1.Panel
            // 
            this.kryptonHeaderGroup1.Panel.Controls.Add(this.panel1);
            this.kryptonHeaderGroup1.Size = new System.Drawing.Size(675, 405);
            this.kryptonHeaderGroup1.TabIndex = 0;
            this.kryptonHeaderGroup1.ValuesPrimary.Heading = "Recargas";
            this.kryptonHeaderGroup1.ValuesSecondary.Heading = "Formulario para modificar el saldo para recargas";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(673, 352);
            this.panel1.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.DgvHistorialSaldos, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.12303F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 66.87697F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(673, 352);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // DgvHistorialSaldos
            // 
            this.DgvHistorialSaldos.AllowUserToAddRows = false;
            this.DgvHistorialSaldos.AllowUserToResizeColumns = false;
            this.DgvHistorialSaldos.AllowUserToResizeRows = false;
            this.DgvHistorialSaldos.AutoGenerateColumns = false;
            this.DgvHistorialSaldos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.DgvHistorialSaldos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvHistorialSaldos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.sucursalIdDataGridViewTextBoxColumn,
            this.sucursalDataGridViewTextBoxColumn,
            this.empresaDataGridViewTextBoxColumn,
            this.saldoInicialDataGridViewTextBoxColumn,
            this.saldoDataGridViewTextBoxColumn,
            this.saldoActualDataGridViewTextBoxColumn,
            this.fechaTransferenciaDataGridViewTextBoxColumn});
            this.DgvHistorialSaldos.DataSource = this.listarHistorialRecargasBindingSource;
            this.DgvHistorialSaldos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DgvHistorialSaldos.Location = new System.Drawing.Point(2, 118);
            this.DgvHistorialSaldos.Margin = new System.Windows.Forms.Padding(2);
            this.DgvHistorialSaldos.MultiSelect = false;
            this.DgvHistorialSaldos.Name = "DgvHistorialSaldos";
            this.DgvHistorialSaldos.ReadOnly = true;
            this.DgvHistorialSaldos.RowHeadersWidth = 51;
            this.DgvHistorialSaldos.RowTemplate.Height = 24;
            this.DgvHistorialSaldos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvHistorialSaldos.Size = new System.Drawing.Size(669, 232);
            this.DgvHistorialSaldos.TabIndex = 5;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Visible = false;
            this.idDataGridViewTextBoxColumn.Width = 46;
            // 
            // sucursalIdDataGridViewTextBoxColumn
            // 
            this.sucursalIdDataGridViewTextBoxColumn.DataPropertyName = "SucursalId";
            this.sucursalIdDataGridViewTextBoxColumn.HeaderText = "SucursalId";
            this.sucursalIdDataGridViewTextBoxColumn.Name = "sucursalIdDataGridViewTextBoxColumn";
            this.sucursalIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.sucursalIdDataGridViewTextBoxColumn.Visible = false;
            this.sucursalIdDataGridViewTextBoxColumn.Width = 90;
            // 
            // sucursalDataGridViewTextBoxColumn
            // 
            this.sucursalDataGridViewTextBoxColumn.DataPropertyName = "Sucursal";
            this.sucursalDataGridViewTextBoxColumn.HeaderText = "Sucursal";
            this.sucursalDataGridViewTextBoxColumn.Name = "sucursalDataGridViewTextBoxColumn";
            this.sucursalDataGridViewTextBoxColumn.ReadOnly = true;
            this.sucursalDataGridViewTextBoxColumn.Width = 80;
            // 
            // empresaDataGridViewTextBoxColumn
            // 
            this.empresaDataGridViewTextBoxColumn.DataPropertyName = "Empresa";
            this.empresaDataGridViewTextBoxColumn.HeaderText = "Empresa";
            this.empresaDataGridViewTextBoxColumn.Name = "empresaDataGridViewTextBoxColumn";
            this.empresaDataGridViewTextBoxColumn.ReadOnly = true;
            this.empresaDataGridViewTextBoxColumn.Width = 81;
            // 
            // saldoInicialDataGridViewTextBoxColumn
            // 
            this.saldoInicialDataGridViewTextBoxColumn.DataPropertyName = "SaldoInicial";
            this.saldoInicialDataGridViewTextBoxColumn.HeaderText = "SaldoInicial";
            this.saldoInicialDataGridViewTextBoxColumn.Name = "saldoInicialDataGridViewTextBoxColumn";
            this.saldoInicialDataGridViewTextBoxColumn.ReadOnly = true;
            this.saldoInicialDataGridViewTextBoxColumn.Width = 96;
            // 
            // saldoDataGridViewTextBoxColumn
            // 
            this.saldoDataGridViewTextBoxColumn.DataPropertyName = "Saldo";
            this.saldoDataGridViewTextBoxColumn.HeaderText = "Saldo";
            this.saldoDataGridViewTextBoxColumn.Name = "saldoDataGridViewTextBoxColumn";
            this.saldoDataGridViewTextBoxColumn.ReadOnly = true;
            this.saldoDataGridViewTextBoxColumn.Width = 65;
            // 
            // saldoActualDataGridViewTextBoxColumn
            // 
            this.saldoActualDataGridViewTextBoxColumn.DataPropertyName = "SaldoActual";
            this.saldoActualDataGridViewTextBoxColumn.HeaderText = "SaldoActual";
            this.saldoActualDataGridViewTextBoxColumn.Name = "saldoActualDataGridViewTextBoxColumn";
            this.saldoActualDataGridViewTextBoxColumn.ReadOnly = true;
            this.saldoActualDataGridViewTextBoxColumn.Width = 99;
            // 
            // fechaTransferenciaDataGridViewTextBoxColumn
            // 
            this.fechaTransferenciaDataGridViewTextBoxColumn.DataPropertyName = "FechaTransferencia";
            this.fechaTransferenciaDataGridViewTextBoxColumn.HeaderText = "FechaTransferencia";
            this.fechaTransferenciaDataGridViewTextBoxColumn.Name = "fechaTransferenciaDataGridViewTextBoxColumn";
            this.fechaTransferenciaDataGridViewTextBoxColumn.ReadOnly = true;
            this.fechaTransferenciaDataGridViewTextBoxColumn.Width = 136;
            // 
            // listarHistorialRecargasBindingSource
            // 
            this.listarHistorialRecargasBindingSource.DataSource = typeof(CapaDatos.ListasPersonalizadas.ListarHistorialRecargas);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.BtnEliminar);
            this.panel2.Controls.Add(this.dtpFecha);
            this.panel2.Controls.Add(this.kryptonLabel4);
            this.panel2.Controls.Add(this.lbSaldoActualClaro);
            this.panel2.Controls.Add(this.kryptonLabel3);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.RbClaro);
            this.panel2.Controls.Add(this.RbTigo);
            this.panel2.Controls.Add(this.TxtNuevoSaldo);
            this.panel2.Controls.Add(this.kryptonLabel2);
            this.panel2.Controls.Add(this.BtnGuardar);
            this.panel2.Controls.Add(this.lbSaldoActualTigo);
            this.panel2.Controls.Add(this.kryptonLabel1);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(667, 110);
            this.panel2.TabIndex = 4;
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.Location = new System.Drawing.Point(616, 61);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(41, 30);
            this.BtnEliminar.StateCommon.Back.Image = global::Sistema.Properties.Resources.DeleteAllRows_16x;
            this.BtnEliminar.StateCommon.Back.ImageAlign = ComponentFactory.Krypton.Toolkit.PaletteRectangleAlign.Local;
            this.BtnEliminar.StateCommon.Back.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.CenterMiddle;
            this.BtnEliminar.TabIndex = 80;
            this.BtnEliminar.Values.Text = "";
            this.BtnEliminar.Click += new System.EventHandler(this.BtnEliminar_Click);
            // 
            // dtpFecha
            // 
            this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecha.Location = new System.Drawing.Point(360, 35);
            this.dtpFecha.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(145, 21);
            this.dtpFecha.TabIndex = 79;
            this.dtpFecha.ValueNullable = new System.DateTime(2021, 10, 5, 14, 44, 52, 0);
            // 
            // kryptonLabel4
            // 
            this.kryptonLabel4.Location = new System.Drawing.Point(256, 39);
            this.kryptonLabel4.Name = "kryptonLabel4";
            this.kryptonLabel4.Size = new System.Drawing.Size(45, 20);
            this.kryptonLabel4.TabIndex = 78;
            this.kryptonLabel4.Values.Text = "Fecha: ";
            // 
            // lbSaldoActualClaro
            // 
            this.lbSaldoActualClaro.AutoSize = true;
            this.lbSaldoActualClaro.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSaldoActualClaro.Location = new System.Drawing.Point(456, 8);
            this.lbSaldoActualClaro.Name = "lbSaldoActualClaro";
            this.lbSaldoActualClaro.Size = new System.Drawing.Size(40, 18);
            this.lbSaldoActualClaro.TabIndex = 77;
            this.lbSaldoActualClaro.Text = "0.00";
            // 
            // kryptonLabel3
            // 
            this.kryptonLabel3.Location = new System.Drawing.Point(275, 6);
            this.kryptonLabel3.Name = "kryptonLabel3";
            this.kryptonLabel3.Size = new System.Drawing.Size(113, 20);
            this.kryptonLabel3.TabIndex = 75;
            this.kryptonLabel3.Values.Text = "Saldo Actual Claro:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(389, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(21, 18);
            this.label3.TabIndex = 76;
            this.label3.Text = "Q";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Sistema.Properties.Resources.Claro;
            this.pictureBox2.Location = new System.Drawing.Point(151, 33);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(58, 53);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 74;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Sistema.Properties.Resources.tigo;
            this.pictureBox1.Location = new System.Drawing.Point(54, 28);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(74, 63);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 73;
            this.pictureBox1.TabStop = false;
            // 
            // RbClaro
            // 
            this.RbClaro.Location = new System.Drawing.Point(130, 54);
            this.RbClaro.Name = "RbClaro";
            this.RbClaro.Size = new System.Drawing.Size(18, 12);
            this.RbClaro.TabIndex = 72;
            this.RbClaro.Values.Text = "";
            this.RbClaro.CheckedChanged += new System.EventHandler(this.RbClaro_CheckedChanged);
            // 
            // RbTigo
            // 
            this.RbTigo.Location = new System.Drawing.Point(39, 54);
            this.RbTigo.Name = "RbTigo";
            this.RbTigo.Size = new System.Drawing.Size(18, 12);
            this.RbTigo.TabIndex = 71;
            this.RbTigo.Values.Text = "";
            this.RbTigo.CheckedChanged += new System.EventHandler(this.RbTigo_CheckedChanged);
            // 
            // TxtNuevoSaldo
            // 
            this.TxtNuevoSaldo.Location = new System.Drawing.Point(360, 64);
            this.TxtNuevoSaldo.Name = "TxtNuevoSaldo";
            this.TxtNuevoSaldo.Size = new System.Drawing.Size(145, 23);
            this.TxtNuevoSaldo.TabIndex = 5;
            this.TxtNuevoSaldo.Text = "0.00";
            this.TxtNuevoSaldo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.TxtNuevoSaldo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtNuevoSaldo_KeyPress);
            // 
            // kryptonLabel2
            // 
            this.kryptonLabel2.Location = new System.Drawing.Point(256, 65);
            this.kryptonLabel2.Name = "kryptonLabel2";
            this.kryptonLabel2.Size = new System.Drawing.Size(91, 20);
            this.kryptonLabel2.TabIndex = 4;
            this.kryptonLabel2.Values.Text = "Agregar Saldo:";
            // 
            // BtnGuardar
            // 
            this.BtnGuardar.Location = new System.Drawing.Point(517, 61);
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.Size = new System.Drawing.Size(90, 30);
            this.BtnGuardar.TabIndex = 3;
            this.BtnGuardar.Values.Text = "Guardar";
            this.BtnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click);
            // 
            // lbSaldoActualTigo
            // 
            this.lbSaldoActualTigo.AutoSize = true;
            this.lbSaldoActualTigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSaldoActualTigo.Location = new System.Drawing.Point(189, 8);
            this.lbSaldoActualTigo.Name = "lbSaldoActualTigo";
            this.lbSaldoActualTigo.Size = new System.Drawing.Size(40, 18);
            this.lbSaldoActualTigo.TabIndex = 2;
            this.lbSaldoActualTigo.Text = "0.00";
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.Location = new System.Drawing.Point(8, 6);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.Size = new System.Drawing.Size(108, 20);
            this.kryptonLabel1.TabIndex = 0;
            this.kryptonLabel1.Values.Text = "Saldo Actual Tigo:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(122, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Q";
            // 
            // SaldosRecargas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(675, 405);
            this.Controls.Add(this.kryptonHeaderGroup1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SaldosRecargas";
            this.Text = "Red Owl Software";
            this.Load += new System.EventHandler(this.SaldoRecarga_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonHeaderGroup1.Panel)).EndInit();
            this.kryptonHeaderGroup1.Panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonHeaderGroup1)).EndInit();
            this.kryptonHeaderGroup1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DgvHistorialSaldos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listarHistorialRecargasBindingSource)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup kryptonHeaderGroup1;
        private System.Windows.Forms.Panel panel1;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private System.Windows.Forms.Label lbSaldoActualTigo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel2;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox TxtNuevoSaldo;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel2;
        private ComponentFactory.Krypton.Toolkit.KryptonButton BtnGuardar;
        private System.Windows.Forms.Label lbSaldoActualClaro;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private ComponentFactory.Krypton.Toolkit.KryptonRadioButton RbClaro;
        private ComponentFactory.Krypton.Toolkit.KryptonRadioButton RbTigo;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel4;
        private ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker dtpFecha;
        private System.Windows.Forms.BindingSource listarHistorialRecargasBindingSource;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView DgvHistorialSaldos;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sucursalIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sucursalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn empresaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn saldoInicialDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn saldoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn saldoActualDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaTransferenciaDataGridViewTextBoxColumn;
        private ComponentFactory.Krypton.Toolkit.KryptonButton BtnEliminar;
    }
}