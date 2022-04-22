
namespace POS.Forms
{
    partial class RecargasPOS
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RecargasPOS));
            this.kryptonHeaderGroup1 = new ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup();
            this.panel1 = new System.Windows.Forms.Panel();
            this.CheckAgregarSaldo = new ComponentFactory.Krypton.Toolkit.KryptonCheckBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtNumeroTel = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.RbTigo = new ComponentFactory.Krypton.Toolkit.KryptonRadioButton();
            this.RbClaro = new ComponentFactory.Krypton.Toolkit.KryptonRadioButton();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.listRecargas = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoriaIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sucursalIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.proveedorIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.empresaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codigoBarrasDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcionCortaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vigenciaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precioVentaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoriaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sucursalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.proveedorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deletedDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.listarRecargasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.toolRecargas = new System.Windows.Forms.ToolStrip();
            this.buscarprod = new System.Windows.Forms.ToolStripButton();
            this.txtBuscador = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnActualizar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.groupSaldo = new System.Windows.Forms.GroupBox();
            this.CheckSaldo150 = new System.Windows.Forms.CheckBox();
            this.CheckSaldo5 = new System.Windows.Forms.CheckBox();
            this.CheckSaldo20 = new System.Windows.Forms.CheckBox();
            this.CheckSaldo25 = new System.Windows.Forms.CheckBox();
            this.CheckSaldo50 = new System.Windows.Forms.CheckBox();
            this.CheckSaldo10 = new System.Windows.Forms.CheckBox();
            this.CheckSaldo100 = new System.Windows.Forms.CheckBox();
            this.CheckSaldo15 = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtMontoVariable = new System.Windows.Forms.TextBox();
            this.lbMonto = new System.Windows.Forms.Label();
            this.kryptonLabel1 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.BtnAceptar = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kryptonDataGridView2 = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonHeaderGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonHeaderGroup1.Panel)).BeginInit();
            this.kryptonHeaderGroup1.Panel.SuspendLayout();
            this.kryptonHeaderGroup1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listRecargas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listarRecargasBindingSource)).BeginInit();
            this.toolRecargas.SuspendLayout();
            this.groupSaldo.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonDataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // kryptonHeaderGroup1
            // 
            this.kryptonHeaderGroup1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonHeaderGroup1.Location = new System.Drawing.Point(0, 0);
            this.kryptonHeaderGroup1.Name = "kryptonHeaderGroup1";
            this.kryptonHeaderGroup1.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2007Blue;
            // 
            // kryptonHeaderGroup1.Panel
            // 
            this.kryptonHeaderGroup1.Panel.Controls.Add(this.panel1);
            this.kryptonHeaderGroup1.Panel.Controls.Add(this.kryptonDataGridView2);
            this.kryptonHeaderGroup1.Size = new System.Drawing.Size(785, 457);
            this.kryptonHeaderGroup1.TabIndex = 5;
            this.kryptonHeaderGroup1.ValuesPrimary.Heading = "Recargas";
            this.kryptonHeaderGroup1.ValuesPrimary.Image = null;
            this.kryptonHeaderGroup1.ValuesSecondary.Heading = "Sección para recargas de celulares";
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.AutoSize = true;
            this.panel1.Controls.Add(this.CheckAgregarSaldo);
            this.panel1.Controls.Add(this.groupBox3);
            this.panel1.Controls.Add(this.listRecargas);
            this.panel1.Controls.Add(this.toolRecargas);
            this.panel1.Controls.Add(this.groupSaldo);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.kryptonLabel1);
            this.panel1.Controls.Add(this.BtnAceptar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(783, 404);
            this.panel1.TabIndex = 28;
            // 
            // CheckAgregarSaldo
            // 
            this.CheckAgregarSaldo.Location = new System.Drawing.Point(671, 95);
            this.CheckAgregarSaldo.Name = "CheckAgregarSaldo";
            this.CheckAgregarSaldo.Size = new System.Drawing.Size(111, 20);
            this.CheckAgregarSaldo.TabIndex = 69;
            this.CheckAgregarSaldo.Values.Text = "Agregar a Saldo";
            this.CheckAgregarSaldo.CheckedChanged += new System.EventHandler(this.CheckAgregarSaldo_CheckedChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.White;
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.TxtNumeroTel);
            this.groupBox3.Controls.Add(this.pictureBox1);
            this.groupBox3.Controls.Add(this.RbTigo);
            this.groupBox3.Controls.Add(this.RbClaro);
            this.groupBox3.Controls.Add(this.pictureBox2);
            this.groupBox3.Location = new System.Drawing.Point(3, 8);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(210, 118);
            this.groupBox3.TabIndex = 24;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Compañia";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(4, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "No.";
            // 
            // TxtNumeroTel
            // 
            this.TxtNumeroTel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNumeroTel.Location = new System.Drawing.Point(34, 81);
            this.TxtNumeroTel.Name = "TxtNumeroTel";
            this.TxtNumeroTel.Size = new System.Drawing.Size(155, 29);
            this.TxtNumeroTel.TabIndex = 67;
            this.TxtNumeroTel.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.TxtNumeroTel.TextChanged += new System.EventHandler(this.TxtNumeroTel_TextChanged);
            this.TxtNumeroTel.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Numero_KeyPress);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::POS.Properties.Resources.tigo;
            this.pictureBox1.Location = new System.Drawing.Point(34, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(74, 63);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 65;
            this.pictureBox1.TabStop = false;
            // 
            // RbTigo
            // 
            this.RbTigo.Location = new System.Drawing.Point(19, 37);
            this.RbTigo.Name = "RbTigo";
            this.RbTigo.Size = new System.Drawing.Size(18, 12);
            this.RbTigo.TabIndex = 63;
            this.RbTigo.Values.Text = "";
            this.RbTigo.CheckedChanged += new System.EventHandler(this.RbTigo_CheckedChanged);
            // 
            // RbClaro
            // 
            this.RbClaro.Location = new System.Drawing.Point(110, 38);
            this.RbClaro.Name = "RbClaro";
            this.RbClaro.Size = new System.Drawing.Size(18, 12);
            this.RbClaro.TabIndex = 64;
            this.RbClaro.Values.Text = "";
            this.RbClaro.CheckedChanged += new System.EventHandler(this.RbClaro_CheckedChanged);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::POS.Properties.Resources.Claro;
            this.pictureBox2.Location = new System.Drawing.Point(131, 17);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(58, 53);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 66;
            this.pictureBox2.TabStop = false;
            // 
            // listRecargas
            // 
            this.listRecargas.AllowUserToAddRows = false;
            this.listRecargas.AllowUserToDeleteRows = false;
            this.listRecargas.AllowUserToResizeColumns = false;
            this.listRecargas.AllowUserToResizeRows = false;
            this.listRecargas.AutoGenerateColumns = false;
            this.listRecargas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.listRecargas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listRecargas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.categoriaIdDataGridViewTextBoxColumn,
            this.sucursalIdDataGridViewTextBoxColumn,
            this.proveedorIdDataGridViewTextBoxColumn,
            this.empresaDataGridViewTextBoxColumn,
            this.tipoDataGridViewTextBoxColumn,
            this.codigoBarrasDataGridViewTextBoxColumn,
            this.descripcionDataGridViewTextBoxColumn,
            this.descripcionCortaDataGridViewTextBoxColumn,
            this.vigenciaDataGridViewTextBoxColumn,
            this.precioVentaDataGridViewTextBoxColumn,
            this.categoriaDataGridViewTextBoxColumn,
            this.sucursalDataGridViewTextBoxColumn,
            this.proveedorDataGridViewTextBoxColumn,
            this.deletedDataGridViewCheckBoxColumn});
            this.listRecargas.DataSource = this.listarRecargasBindingSource;
            this.listRecargas.Location = new System.Drawing.Point(2, 157);
            this.listRecargas.MultiSelect = false;
            this.listRecargas.Name = "listRecargas";
            this.listRecargas.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2007Blue;
            this.listRecargas.ReadOnly = true;
            this.listRecargas.RowHeadersWidth = 51;
            this.listRecargas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.listRecargas.Size = new System.Drawing.Size(778, 243);
            this.listRecargas.TabIndex = 68;
            this.listRecargas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.listRecargas_CellClick);
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
            // categoriaIdDataGridViewTextBoxColumn
            // 
            this.categoriaIdDataGridViewTextBoxColumn.DataPropertyName = "CategoriaId";
            this.categoriaIdDataGridViewTextBoxColumn.HeaderText = "CategoriaId";
            this.categoriaIdDataGridViewTextBoxColumn.Name = "categoriaIdDataGridViewTextBoxColumn";
            this.categoriaIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.categoriaIdDataGridViewTextBoxColumn.Visible = false;
            this.categoriaIdDataGridViewTextBoxColumn.Width = 97;
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
            // proveedorIdDataGridViewTextBoxColumn
            // 
            this.proveedorIdDataGridViewTextBoxColumn.DataPropertyName = "ProveedorId";
            this.proveedorIdDataGridViewTextBoxColumn.HeaderText = "ProveedorId";
            this.proveedorIdDataGridViewTextBoxColumn.Name = "proveedorIdDataGridViewTextBoxColumn";
            this.proveedorIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.proveedorIdDataGridViewTextBoxColumn.Visible = false;
            // 
            // empresaDataGridViewTextBoxColumn
            // 
            this.empresaDataGridViewTextBoxColumn.DataPropertyName = "Empresa";
            this.empresaDataGridViewTextBoxColumn.HeaderText = "Empresa";
            this.empresaDataGridViewTextBoxColumn.Name = "empresaDataGridViewTextBoxColumn";
            this.empresaDataGridViewTextBoxColumn.ReadOnly = true;
            this.empresaDataGridViewTextBoxColumn.Width = 81;
            // 
            // tipoDataGridViewTextBoxColumn
            // 
            this.tipoDataGridViewTextBoxColumn.DataPropertyName = "Tipo";
            this.tipoDataGridViewTextBoxColumn.HeaderText = "Tipo";
            this.tipoDataGridViewTextBoxColumn.Name = "tipoDataGridViewTextBoxColumn";
            this.tipoDataGridViewTextBoxColumn.ReadOnly = true;
            this.tipoDataGridViewTextBoxColumn.Width = 59;
            // 
            // codigoBarrasDataGridViewTextBoxColumn
            // 
            this.codigoBarrasDataGridViewTextBoxColumn.DataPropertyName = "CodigoBarras";
            this.codigoBarrasDataGridViewTextBoxColumn.HeaderText = "CodigoBarras";
            this.codigoBarrasDataGridViewTextBoxColumn.Name = "codigoBarrasDataGridViewTextBoxColumn";
            this.codigoBarrasDataGridViewTextBoxColumn.ReadOnly = true;
            this.codigoBarrasDataGridViewTextBoxColumn.Width = 107;
            // 
            // descripcionDataGridViewTextBoxColumn
            // 
            this.descripcionDataGridViewTextBoxColumn.DataPropertyName = "Descripcion";
            this.descripcionDataGridViewTextBoxColumn.HeaderText = "Descripcion";
            this.descripcionDataGridViewTextBoxColumn.Name = "descripcionDataGridViewTextBoxColumn";
            this.descripcionDataGridViewTextBoxColumn.ReadOnly = true;
            this.descripcionDataGridViewTextBoxColumn.Width = 98;
            // 
            // descripcionCortaDataGridViewTextBoxColumn
            // 
            this.descripcionCortaDataGridViewTextBoxColumn.DataPropertyName = "DescripcionCorta";
            this.descripcionCortaDataGridViewTextBoxColumn.HeaderText = "DescripcionCorta";
            this.descripcionCortaDataGridViewTextBoxColumn.Name = "descripcionCortaDataGridViewTextBoxColumn";
            this.descripcionCortaDataGridViewTextBoxColumn.ReadOnly = true;
            this.descripcionCortaDataGridViewTextBoxColumn.Width = 127;
            // 
            // vigenciaDataGridViewTextBoxColumn
            // 
            this.vigenciaDataGridViewTextBoxColumn.DataPropertyName = "Vigencia";
            this.vigenciaDataGridViewTextBoxColumn.HeaderText = "Vigencia";
            this.vigenciaDataGridViewTextBoxColumn.Name = "vigenciaDataGridViewTextBoxColumn";
            this.vigenciaDataGridViewTextBoxColumn.ReadOnly = true;
            this.vigenciaDataGridViewTextBoxColumn.Width = 81;
            // 
            // precioVentaDataGridViewTextBoxColumn
            // 
            this.precioVentaDataGridViewTextBoxColumn.DataPropertyName = "PrecioVenta";
            this.precioVentaDataGridViewTextBoxColumn.HeaderText = "PrecioVenta";
            this.precioVentaDataGridViewTextBoxColumn.Name = "precioVentaDataGridViewTextBoxColumn";
            this.precioVentaDataGridViewTextBoxColumn.ReadOnly = true;
            this.precioVentaDataGridViewTextBoxColumn.Width = 98;
            // 
            // categoriaDataGridViewTextBoxColumn
            // 
            this.categoriaDataGridViewTextBoxColumn.DataPropertyName = "Categoria";
            this.categoriaDataGridViewTextBoxColumn.HeaderText = "Categoria";
            this.categoriaDataGridViewTextBoxColumn.Name = "categoriaDataGridViewTextBoxColumn";
            this.categoriaDataGridViewTextBoxColumn.ReadOnly = true;
            this.categoriaDataGridViewTextBoxColumn.Visible = false;
            this.categoriaDataGridViewTextBoxColumn.Width = 87;
            // 
            // sucursalDataGridViewTextBoxColumn
            // 
            this.sucursalDataGridViewTextBoxColumn.DataPropertyName = "Sucursal";
            this.sucursalDataGridViewTextBoxColumn.HeaderText = "Sucursal";
            this.sucursalDataGridViewTextBoxColumn.Name = "sucursalDataGridViewTextBoxColumn";
            this.sucursalDataGridViewTextBoxColumn.ReadOnly = true;
            this.sucursalDataGridViewTextBoxColumn.Width = 80;
            // 
            // proveedorDataGridViewTextBoxColumn
            // 
            this.proveedorDataGridViewTextBoxColumn.DataPropertyName = "Proveedor";
            this.proveedorDataGridViewTextBoxColumn.HeaderText = "Proveedor";
            this.proveedorDataGridViewTextBoxColumn.Name = "proveedorDataGridViewTextBoxColumn";
            this.proveedorDataGridViewTextBoxColumn.ReadOnly = true;
            this.proveedorDataGridViewTextBoxColumn.Width = 90;
            // 
            // deletedDataGridViewCheckBoxColumn
            // 
            this.deletedDataGridViewCheckBoxColumn.DataPropertyName = "Deleted";
            this.deletedDataGridViewCheckBoxColumn.HeaderText = "Deleted";
            this.deletedDataGridViewCheckBoxColumn.Name = "deletedDataGridViewCheckBoxColumn";
            this.deletedDataGridViewCheckBoxColumn.ReadOnly = true;
            this.deletedDataGridViewCheckBoxColumn.Visible = false;
            this.deletedDataGridViewCheckBoxColumn.Width = 57;
            // 
            // listarRecargasBindingSource
            // 
            this.listarRecargasBindingSource.DataSource = typeof(CapaDatos.ListasPersonalizadas.ListarRecargas);
            // 
            // toolRecargas
            // 
            this.toolRecargas.Dock = System.Windows.Forms.DockStyle.None;
            this.toolRecargas.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toolRecargas.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolRecargas.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.buscarprod,
            this.txtBuscador,
            this.toolStripSeparator2,
            this.btnActualizar,
            this.toolStripSeparator1});
            this.toolRecargas.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.toolRecargas.Location = new System.Drawing.Point(4, 129);
            this.toolRecargas.Name = "toolRecargas";
            this.toolRecargas.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolRecargas.Size = new System.Drawing.Size(776, 27);
            this.toolRecargas.TabIndex = 67;
            this.toolRecargas.Text = "ToolStrip";
            // 
            // buscarprod
            // 
            this.buscarprod.Image = ((System.Drawing.Image)(resources.GetObject("buscarprod.Image")));
            this.buscarprod.ImageTransparentColor = System.Drawing.Color.Black;
            this.buscarprod.Name = "buscarprod";
            this.buscarprod.Size = new System.Drawing.Size(66, 24);
            this.buscarprod.Text = "Buscar";
            // 
            // txtBuscador
            // 
            this.txtBuscador.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtBuscador.Name = "txtBuscador";
            this.txtBuscador.Size = new System.Drawing.Size(605, 27);
            this.txtBuscador.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtBuscador.TextChanged += new System.EventHandler(this.txtBuscador_TextChanged);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // btnActualizar
            // 
            this.btnActualizar.Image = global::POS.Properties.Resources.Refresh_16x;
            this.btnActualizar.ImageTransparentColor = System.Drawing.Color.Black;
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(79, 24);
            this.btnActualizar.Text = "Refrescar";
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // groupSaldo
            // 
            this.groupSaldo.BackColor = System.Drawing.Color.White;
            this.groupSaldo.Controls.Add(this.CheckSaldo150);
            this.groupSaldo.Controls.Add(this.CheckSaldo5);
            this.groupSaldo.Controls.Add(this.CheckSaldo20);
            this.groupSaldo.Controls.Add(this.CheckSaldo25);
            this.groupSaldo.Controls.Add(this.CheckSaldo50);
            this.groupSaldo.Controls.Add(this.CheckSaldo10);
            this.groupSaldo.Controls.Add(this.CheckSaldo100);
            this.groupSaldo.Controls.Add(this.CheckSaldo15);
            this.groupSaldo.Location = new System.Drawing.Point(223, 7);
            this.groupSaldo.Name = "groupSaldo";
            this.groupSaldo.Size = new System.Drawing.Size(255, 119);
            this.groupSaldo.TabIndex = 7;
            this.groupSaldo.TabStop = false;
            this.groupSaldo.Text = "Recargas de Saldo";
            // 
            // CheckSaldo150
            // 
            this.CheckSaldo150.AutoSize = true;
            this.CheckSaldo150.BackColor = System.Drawing.Color.White;
            this.CheckSaldo150.Font = new System.Drawing.Font("Arial", 10F);
            this.CheckSaldo150.Location = new System.Drawing.Point(187, 69);
            this.CheckSaldo150.Name = "CheckSaldo150";
            this.CheckSaldo150.Size = new System.Drawing.Size(62, 20);
            this.CheckSaldo150.TabIndex = 19;
            this.CheckSaldo150.Text = "Q150";
            this.CheckSaldo150.UseVisualStyleBackColor = false;
            this.CheckSaldo150.CheckedChanged += new System.EventHandler(this.CheckSaldo_CheckedChanged);
            // 
            // CheckSaldo5
            // 
            this.CheckSaldo5.AutoSize = true;
            this.CheckSaldo5.BackColor = System.Drawing.Color.White;
            this.CheckSaldo5.Font = new System.Drawing.Font("Arial", 10F);
            this.CheckSaldo5.Location = new System.Drawing.Point(10, 31);
            this.CheckSaldo5.Name = "CheckSaldo5";
            this.CheckSaldo5.Size = new System.Drawing.Size(46, 20);
            this.CheckSaldo5.TabIndex = 13;
            this.CheckSaldo5.Text = "Q5\r\n";
            this.CheckSaldo5.UseVisualStyleBackColor = false;
            this.CheckSaldo5.CheckedChanged += new System.EventHandler(this.CheckSaldo_CheckedChanged);
            // 
            // CheckSaldo20
            // 
            this.CheckSaldo20.AutoSize = true;
            this.CheckSaldo20.BackColor = System.Drawing.Color.White;
            this.CheckSaldo20.Font = new System.Drawing.Font("Arial", 10F);
            this.CheckSaldo20.Location = new System.Drawing.Point(187, 31);
            this.CheckSaldo20.Name = "CheckSaldo20";
            this.CheckSaldo20.Size = new System.Drawing.Size(54, 20);
            this.CheckSaldo20.TabIndex = 16;
            this.CheckSaldo20.Text = "Q20";
            this.CheckSaldo20.UseVisualStyleBackColor = false;
            this.CheckSaldo20.CheckedChanged += new System.EventHandler(this.CheckSaldo_CheckedChanged);
            // 
            // CheckSaldo25
            // 
            this.CheckSaldo25.AutoSize = true;
            this.CheckSaldo25.BackColor = System.Drawing.Color.White;
            this.CheckSaldo25.Font = new System.Drawing.Font("Arial", 10F);
            this.CheckSaldo25.Location = new System.Drawing.Point(10, 69);
            this.CheckSaldo25.Name = "CheckSaldo25";
            this.CheckSaldo25.Size = new System.Drawing.Size(54, 20);
            this.CheckSaldo25.TabIndex = 23;
            this.CheckSaldo25.Text = "Q25";
            this.CheckSaldo25.UseVisualStyleBackColor = false;
            this.CheckSaldo25.CheckedChanged += new System.EventHandler(this.CheckSaldo_CheckedChanged);
            // 
            // CheckSaldo50
            // 
            this.CheckSaldo50.AutoSize = true;
            this.CheckSaldo50.BackColor = System.Drawing.Color.White;
            this.CheckSaldo50.Font = new System.Drawing.Font("Arial", 10F);
            this.CheckSaldo50.Location = new System.Drawing.Point(69, 69);
            this.CheckSaldo50.Name = "CheckSaldo50";
            this.CheckSaldo50.Size = new System.Drawing.Size(54, 20);
            this.CheckSaldo50.TabIndex = 22;
            this.CheckSaldo50.Text = "Q50";
            this.CheckSaldo50.UseVisualStyleBackColor = false;
            this.CheckSaldo50.CheckedChanged += new System.EventHandler(this.CheckSaldo_CheckedChanged);
            // 
            // CheckSaldo10
            // 
            this.CheckSaldo10.AutoSize = true;
            this.CheckSaldo10.BackColor = System.Drawing.Color.White;
            this.CheckSaldo10.Font = new System.Drawing.Font("Arial", 10F);
            this.CheckSaldo10.Location = new System.Drawing.Point(69, 31);
            this.CheckSaldo10.Name = "CheckSaldo10";
            this.CheckSaldo10.Size = new System.Drawing.Size(54, 20);
            this.CheckSaldo10.TabIndex = 15;
            this.CheckSaldo10.Text = "Q10";
            this.CheckSaldo10.UseVisualStyleBackColor = false;
            this.CheckSaldo10.CheckedChanged += new System.EventHandler(this.CheckSaldo_CheckedChanged);
            // 
            // CheckSaldo100
            // 
            this.CheckSaldo100.AutoSize = true;
            this.CheckSaldo100.BackColor = System.Drawing.Color.White;
            this.CheckSaldo100.Font = new System.Drawing.Font("Arial", 10F);
            this.CheckSaldo100.Location = new System.Drawing.Point(127, 69);
            this.CheckSaldo100.Name = "CheckSaldo100";
            this.CheckSaldo100.Size = new System.Drawing.Size(62, 20);
            this.CheckSaldo100.TabIndex = 18;
            this.CheckSaldo100.Text = "Q100";
            this.CheckSaldo100.UseVisualStyleBackColor = false;
            this.CheckSaldo100.CheckedChanged += new System.EventHandler(this.CheckSaldo_CheckedChanged);
            // 
            // CheckSaldo15
            // 
            this.CheckSaldo15.AutoSize = true;
            this.CheckSaldo15.BackColor = System.Drawing.Color.White;
            this.CheckSaldo15.Font = new System.Drawing.Font("Arial", 10F);
            this.CheckSaldo15.Location = new System.Drawing.Point(127, 31);
            this.CheckSaldo15.Name = "CheckSaldo15";
            this.CheckSaldo15.Size = new System.Drawing.Size(54, 20);
            this.CheckSaldo15.TabIndex = 17;
            this.CheckSaldo15.Text = "Q15\r\n";
            this.CheckSaldo15.UseVisualStyleBackColor = false;
            this.CheckSaldo15.CheckedChanged += new System.EventHandler(this.CheckSaldo_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.White;
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.TxtMontoVariable);
            this.groupBox2.Controls.Add(this.lbMonto);
            this.groupBox2.Location = new System.Drawing.Point(490, 7);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(174, 119);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "MONTO";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Monto variable:";
            // 
            // TxtMontoVariable
            // 
            this.TxtMontoVariable.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtMontoVariable.Location = new System.Drawing.Point(9, 40);
            this.TxtMontoVariable.Name = "TxtMontoVariable";
            this.TxtMontoVariable.Size = new System.Drawing.Size(150, 29);
            this.TxtMontoVariable.TabIndex = 2;
            this.TxtMontoVariable.Text = "0";
            this.TxtMontoVariable.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.TxtMontoVariable.TextChanged += new System.EventHandler(this.TxtMontoVariable_TextChanged);
            this.TxtMontoVariable.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Numero_KeyPress);
            // 
            // lbMonto
            // 
            this.lbMonto.AutoSize = true;
            this.lbMonto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMonto.Location = new System.Drawing.Point(69, 78);
            this.lbMonto.Name = "lbMonto";
            this.lbMonto.Size = new System.Drawing.Size(37, 20);
            this.lbMonto.TabIndex = 0;
            this.lbMonto.Text = "Q 0";
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.Location = new System.Drawing.Point(-36, 31);
            this.kryptonLabel1.Margin = new System.Windows.Forms.Padding(2);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.Size = new System.Drawing.Size(6, 2);
            this.kryptonLabel1.TabIndex = 24;
            this.kryptonLabel1.Values.Text = "";
            // 
            // BtnAceptar
            // 
            this.BtnAceptar.Location = new System.Drawing.Point(679, 15);
            this.BtnAceptar.Name = "BtnAceptar";
            this.BtnAceptar.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2007Silver;
            this.BtnAceptar.Size = new System.Drawing.Size(83, 72);
            this.BtnAceptar.StateCommon.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.GlassCheckedStump;
            this.BtnAceptar.StateCommon.Back.Image = global::POS.Properties.Resources.dobla_a_la_derecha;
            this.BtnAceptar.StateCommon.Back.ImageAlign = ComponentFactory.Krypton.Toolkit.PaletteRectangleAlign.Local;
            this.BtnAceptar.StateCommon.Back.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Stretch;
            this.BtnAceptar.TabIndex = 7;
            this.BtnAceptar.Values.Image = global::POS.Properties.Resources.dobla_a_la_derecha;
            this.BtnAceptar.Values.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.BtnAceptar.Values.Text = "";
            this.BtnAceptar.Click += new System.EventHandler(this.BtnAceptar_Click);
            // 
            // kryptonDataGridView2
            // 
            this.kryptonDataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.kryptonDataGridView2.Location = new System.Drawing.Point(166, 412);
            this.kryptonDataGridView2.Name = "kryptonDataGridView2";
            this.kryptonDataGridView2.Size = new System.Drawing.Size(8, 8);
            this.kryptonDataGridView2.TabIndex = 12;
            // 
            // RecargasPOS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(785, 457);
            this.Controls.Add(this.kryptonHeaderGroup1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RecargasPOS";
            this.Text = "Red Owl Software";
            this.Load += new System.EventHandler(this.RecargasPOS_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonHeaderGroup1.Panel)).EndInit();
            this.kryptonHeaderGroup1.Panel.ResumeLayout(false);
            this.kryptonHeaderGroup1.Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonHeaderGroup1)).EndInit();
            this.kryptonHeaderGroup1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listRecargas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listarRecargasBindingSource)).EndInit();
            this.toolRecargas.ResumeLayout(false);
            this.toolRecargas.PerformLayout();
            this.groupSaldo.ResumeLayout(false);
            this.groupSaldo.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonDataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup kryptonHeaderGroup1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtMontoVariable;
        private System.Windows.Forms.Label lbMonto;
        private ComponentFactory.Krypton.Toolkit.KryptonButton BtnAceptar;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView kryptonDataGridView2;
        private System.Windows.Forms.CheckBox CheckSaldo5;
        private System.Windows.Forms.CheckBox CheckSaldo15;
        private System.Windows.Forms.CheckBox CheckSaldo20;
        private System.Windows.Forms.CheckBox CheckSaldo10;
        private System.Windows.Forms.CheckBox CheckSaldo25;
        private System.Windows.Forms.CheckBox CheckSaldo50;
        private System.Windows.Forms.CheckBox CheckSaldo150;
        private System.Windows.Forms.CheckBox CheckSaldo100;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private ComponentFactory.Krypton.Toolkit.KryptonRadioButton RbClaro;
        private ComponentFactory.Krypton.Toolkit.KryptonRadioButton RbTigo;
        private System.Windows.Forms.GroupBox groupSaldo;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView listRecargas;
        private System.Windows.Forms.ToolStrip toolRecargas;
        private System.Windows.Forms.ToolStripButton buscarprod;
        private System.Windows.Forms.ToolStripTextBox txtBuscador;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton btnActualizar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtNumeroTel;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoriaIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sucursalIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn proveedorIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn empresaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoBarrasDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcionCortaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vigenciaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn precioVentaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoriaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sucursalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn proveedorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn deletedDataGridViewCheckBoxColumn;
        private System.Windows.Forms.BindingSource listarRecargasBindingSource;
        private ComponentFactory.Krypton.Toolkit.KryptonCheckBox CheckAgregarSaldo;
    }
}