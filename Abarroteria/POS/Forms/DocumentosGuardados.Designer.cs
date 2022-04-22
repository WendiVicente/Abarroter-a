namespace POS.Forms
{
    partial class DocumentosGuardados
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DocumentosGuardados));
            this.knGuardados = new ComponentFactory.Krypton.Docking.KryptonDockableNavigator();
            this.VentasContado = new ComponentFactory.Krypton.Navigator.KryptonPage();
            this.tbContado = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.txtBuscarContado = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.kryptonLabel1 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.dgvVentasContado = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.VentasCredito = new ComponentFactory.Krypton.Navigator.KryptonPage();
            this.tbCredito = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.txtBuscarCredito = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.kryptonLabel2 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.dgvVentasCredito = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.pgCotizaciones = new ComponentFactory.Krypton.Navigator.KryptonPage();
            this.tbCotizaciones = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.txtBuscarCotizacion = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.kryptonLabel3 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.dgvCotizacion = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.pgVales = new ComponentFactory.Krypton.Navigator.KryptonPage();
            this.tbVales = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel7 = new System.Windows.Forms.TableLayoutPanel();
            this.txtBuscarVale = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.kryptonLabel4 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.dgvVales = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.pgProdAcumulados = new ComponentFactory.Krypton.Navigator.KryptonPage();
            this.tbProdAcumulados = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnAgregarVenta = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.txtbuscarProducto = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.kryptonLabel5 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.chbSelectAll = new System.Windows.Forms.CheckBox();
            this.dgvProdAcumulados = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.knGuardados)).BeginInit();
            this.knGuardados.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.VentasContado)).BeginInit();
            this.VentasContado.SuspendLayout();
            this.tbContado.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVentasContado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.VentasCredito)).BeginInit();
            this.VentasCredito.SuspendLayout();
            this.tbCredito.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVentasCredito)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pgCotizaciones)).BeginInit();
            this.pgCotizaciones.SuspendLayout();
            this.tbCotizaciones.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCotizacion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pgVales)).BeginInit();
            this.pgVales.SuspendLayout();
            this.tbVales.SuspendLayout();
            this.tableLayoutPanel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVales)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pgProdAcumulados)).BeginInit();
            this.pgProdAcumulados.SuspendLayout();
            this.tbProdAcumulados.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdAcumulados)).BeginInit();
            this.SuspendLayout();
            // 
            // knGuardados
            // 
            this.knGuardados.Dock = System.Windows.Forms.DockStyle.Fill;
            this.knGuardados.Location = new System.Drawing.Point(0, 0);
            this.knGuardados.Name = "knGuardados";
            this.knGuardados.Pages.AddRange(new ComponentFactory.Krypton.Navigator.KryptonPage[] {
            this.VentasContado,
            this.VentasCredito,
            this.pgCotizaciones,
            this.pgVales,
            this.pgProdAcumulados});
            this.knGuardados.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2007Blue;
            this.knGuardados.SelectedIndex = 0;
            this.knGuardados.Size = new System.Drawing.Size(800, 450);
            this.knGuardados.TabIndex = 0;
            this.knGuardados.Text = "navigator";
            // 
            // VentasContado
            // 
            this.VentasContado.AutoHiddenSlideSize = new System.Drawing.Size(200, 200);
            this.VentasContado.Controls.Add(this.tbContado);
            this.VentasContado.Flags = 65534;
            this.VentasContado.LastVisibleSet = true;
            this.VentasContado.MinimumSize = new System.Drawing.Size(50, 50);
            this.VentasContado.Name = "VentasContado";
            this.VentasContado.Size = new System.Drawing.Size(798, 423);
            this.VentasContado.Text = "Ventas Contado";
            this.VentasContado.ToolTipTitle = "Page ToolTip";
            this.VentasContado.UniqueName = "DEE1C6D514BA4EBA1FA71821FE705E45";
            // 
            // tbContado
            // 
            this.tbContado.BackColor = System.Drawing.Color.Transparent;
            this.tbContado.ColumnCount = 1;
            this.tbContado.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tbContado.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tbContado.Controls.Add(this.dgvVentasContado, 0, 1);
            this.tbContado.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbContado.Location = new System.Drawing.Point(0, 0);
            this.tbContado.Margin = new System.Windows.Forms.Padding(2);
            this.tbContado.Name = "tbContado";
            this.tbContado.RowCount = 2;
            this.tbContado.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.882353F));
            this.tbContado.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90.11765F));
            this.tbContado.Size = new System.Drawing.Size(798, 423);
            this.tbContado.TabIndex = 7;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.BackColor = System.Drawing.Color.White;
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Controls.Add(this.txtBuscarContado, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.kryptonLabel1, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(2, 2);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(794, 37);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // txtBuscarContado
            // 
            this.txtBuscarContado.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtBuscarContado.Location = new System.Drawing.Point(81, 2);
            this.txtBuscarContado.Margin = new System.Windows.Forms.Padding(2);
            this.txtBuscarContado.Name = "txtBuscarContado";
            this.txtBuscarContado.Size = new System.Drawing.Size(551, 23);
            this.txtBuscarContado.TabIndex = 2;
            this.txtBuscarContado.TextChanged += new System.EventHandler(this.txtBuscarContado_TextChanged);
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonLabel1.Location = new System.Drawing.Point(2, 2);
            this.kryptonLabel1.Margin = new System.Windows.Forms.Padding(2);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.Size = new System.Drawing.Size(75, 33);
            this.kryptonLabel1.TabIndex = 1;
            this.kryptonLabel1.Values.Text = "Buscar";
            // 
            // dgvVentasContado
            // 
            this.dgvVentasContado.AllowUserToAddRows = false;
            this.dgvVentasContado.AllowUserToDeleteRows = false;
            this.dgvVentasContado.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvVentasContado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVentasContado.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvVentasContado.Location = new System.Drawing.Point(2, 43);
            this.dgvVentasContado.Margin = new System.Windows.Forms.Padding(2);
            this.dgvVentasContado.Name = "dgvVentasContado";
            this.dgvVentasContado.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2007Blue;
            this.dgvVentasContado.ReadOnly = true;
            this.dgvVentasContado.RowHeadersWidth = 51;
            this.dgvVentasContado.RowTemplate.Height = 24;
            this.dgvVentasContado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvVentasContado.Size = new System.Drawing.Size(794, 378);
            this.dgvVentasContado.TabIndex = 1;
            this.dgvVentasContado.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvVentasContado_CellDoubleClick);
            // 
            // VentasCredito
            // 
            this.VentasCredito.AutoHiddenSlideSize = new System.Drawing.Size(200, 200);
            this.VentasCredito.Controls.Add(this.tbCredito);
            this.VentasCredito.Flags = 65534;
            this.VentasCredito.LastVisibleSet = true;
            this.VentasCredito.MinimumSize = new System.Drawing.Size(50, 50);
            this.VentasCredito.Name = "VentasCredito";
            this.VentasCredito.Size = new System.Drawing.Size(798, 423);
            this.VentasCredito.Text = "Ventas Crédito";
            this.VentasCredito.ToolTipTitle = "Page ToolTip";
            this.VentasCredito.UniqueName = "84EFA26A85264FD343A7B698B1B10448";
            // 
            // tbCredito
            // 
            this.tbCredito.BackColor = System.Drawing.Color.Transparent;
            this.tbCredito.ColumnCount = 1;
            this.tbCredito.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tbCredito.Controls.Add(this.tableLayoutPanel3, 0, 0);
            this.tbCredito.Controls.Add(this.dgvVentasCredito, 0, 1);
            this.tbCredito.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbCredito.Location = new System.Drawing.Point(0, 0);
            this.tbCredito.Margin = new System.Windows.Forms.Padding(2);
            this.tbCredito.Name = "tbCredito";
            this.tbCredito.RowCount = 2;
            this.tbCredito.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.882353F));
            this.tbCredito.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90.11765F));
            this.tbCredito.Size = new System.Drawing.Size(798, 423);
            this.tbCredito.TabIndex = 8;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.BackColor = System.Drawing.Color.White;
            this.tableLayoutPanel3.ColumnCount = 3;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.Controls.Add(this.txtBuscarCredito, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.kryptonLabel2, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(2, 2);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(794, 37);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // txtBuscarCredito
            // 
            this.txtBuscarCredito.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtBuscarCredito.Location = new System.Drawing.Point(81, 2);
            this.txtBuscarCredito.Margin = new System.Windows.Forms.Padding(2);
            this.txtBuscarCredito.Name = "txtBuscarCredito";
            this.txtBuscarCredito.Size = new System.Drawing.Size(551, 23);
            this.txtBuscarCredito.TabIndex = 2;
            this.txtBuscarCredito.TextChanged += new System.EventHandler(this.txtBuscarCredito_TextChanged);
            // 
            // kryptonLabel2
            // 
            this.kryptonLabel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonLabel2.Location = new System.Drawing.Point(2, 2);
            this.kryptonLabel2.Margin = new System.Windows.Forms.Padding(2);
            this.kryptonLabel2.Name = "kryptonLabel2";
            this.kryptonLabel2.Size = new System.Drawing.Size(75, 33);
            this.kryptonLabel2.TabIndex = 1;
            this.kryptonLabel2.Values.Text = "Buscar";
            // 
            // dgvVentasCredito
            // 
            this.dgvVentasCredito.AllowUserToAddRows = false;
            this.dgvVentasCredito.AllowUserToDeleteRows = false;
            this.dgvVentasCredito.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvVentasCredito.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVentasCredito.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvVentasCredito.Location = new System.Drawing.Point(2, 43);
            this.dgvVentasCredito.Margin = new System.Windows.Forms.Padding(2);
            this.dgvVentasCredito.Name = "dgvVentasCredito";
            this.dgvVentasCredito.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2007Blue;
            this.dgvVentasCredito.ReadOnly = true;
            this.dgvVentasCredito.RowHeadersWidth = 51;
            this.dgvVentasCredito.RowTemplate.Height = 24;
            this.dgvVentasCredito.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvVentasCredito.Size = new System.Drawing.Size(794, 378);
            this.dgvVentasCredito.TabIndex = 1;
            this.dgvVentasCredito.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvVentasCredito_CellDoubleClick);
            // 
            // pgCotizaciones
            // 
            this.pgCotizaciones.AutoHiddenSlideSize = new System.Drawing.Size(200, 200);
            this.pgCotizaciones.Controls.Add(this.tbCotizaciones);
            this.pgCotizaciones.Flags = 65534;
            this.pgCotizaciones.LastVisibleSet = true;
            this.pgCotizaciones.MinimumSize = new System.Drawing.Size(50, 50);
            this.pgCotizaciones.Name = "pgCotizaciones";
            this.pgCotizaciones.Size = new System.Drawing.Size(798, 423);
            this.pgCotizaciones.Text = "Cotizaciones";
            this.pgCotizaciones.ToolTipTitle = "Page ToolTip";
            this.pgCotizaciones.UniqueName = "89920341E32243D1C7848EC6AC644FCC";
            // 
            // tbCotizaciones
            // 
            this.tbCotizaciones.BackColor = System.Drawing.Color.Transparent;
            this.tbCotizaciones.ColumnCount = 1;
            this.tbCotizaciones.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tbCotizaciones.Controls.Add(this.tableLayoutPanel5, 0, 0);
            this.tbCotizaciones.Controls.Add(this.dgvCotizacion, 0, 1);
            this.tbCotizaciones.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbCotizaciones.Location = new System.Drawing.Point(0, 0);
            this.tbCotizaciones.Margin = new System.Windows.Forms.Padding(2);
            this.tbCotizaciones.Name = "tbCotizaciones";
            this.tbCotizaciones.RowCount = 2;
            this.tbCotizaciones.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.882353F));
            this.tbCotizaciones.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90.11765F));
            this.tbCotizaciones.Size = new System.Drawing.Size(798, 423);
            this.tbCotizaciones.TabIndex = 8;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.BackColor = System.Drawing.Color.White;
            this.tableLayoutPanel5.ColumnCount = 3;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel5.Controls.Add(this.txtBuscarCotizacion, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.kryptonLabel3, 0, 0);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(2, 2);
            this.tableLayoutPanel5.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 1;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(794, 37);
            this.tableLayoutPanel5.TabIndex = 0;
            // 
            // txtBuscarCotizacion
            // 
            this.txtBuscarCotizacion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtBuscarCotizacion.Location = new System.Drawing.Point(81, 2);
            this.txtBuscarCotizacion.Margin = new System.Windows.Forms.Padding(2);
            this.txtBuscarCotizacion.Name = "txtBuscarCotizacion";
            this.txtBuscarCotizacion.Size = new System.Drawing.Size(551, 23);
            this.txtBuscarCotizacion.TabIndex = 2;
            this.txtBuscarCotizacion.TextChanged += new System.EventHandler(this.txtBuscarCotizacion_TextChanged);
            // 
            // kryptonLabel3
            // 
            this.kryptonLabel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonLabel3.Location = new System.Drawing.Point(2, 2);
            this.kryptonLabel3.Margin = new System.Windows.Forms.Padding(2);
            this.kryptonLabel3.Name = "kryptonLabel3";
            this.kryptonLabel3.Size = new System.Drawing.Size(75, 33);
            this.kryptonLabel3.TabIndex = 1;
            this.kryptonLabel3.Values.Text = "Buscar";
            // 
            // dgvCotizacion
            // 
            this.dgvCotizacion.AllowUserToAddRows = false;
            this.dgvCotizacion.AllowUserToDeleteRows = false;
            this.dgvCotizacion.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvCotizacion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCotizacion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCotizacion.Location = new System.Drawing.Point(2, 43);
            this.dgvCotizacion.Margin = new System.Windows.Forms.Padding(2);
            this.dgvCotizacion.Name = "dgvCotizacion";
            this.dgvCotizacion.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2007Blue;
            this.dgvCotizacion.ReadOnly = true;
            this.dgvCotizacion.RowHeadersWidth = 51;
            this.dgvCotizacion.RowTemplate.Height = 24;
            this.dgvCotizacion.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCotizacion.Size = new System.Drawing.Size(794, 378);
            this.dgvCotizacion.TabIndex = 1;
            this.dgvCotizacion.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCotizacion_CellDoubleClick);
            // 
            // pgVales
            // 
            this.pgVales.AutoHiddenSlideSize = new System.Drawing.Size(200, 200);
            this.pgVales.Controls.Add(this.tbVales);
            this.pgVales.Flags = 65534;
            this.pgVales.LastVisibleSet = true;
            this.pgVales.MinimumSize = new System.Drawing.Size(50, 50);
            this.pgVales.Name = "pgVales";
            this.pgVales.Size = new System.Drawing.Size(798, 423);
            this.pgVales.Text = "Vales";
            this.pgVales.ToolTipTitle = "Page ToolTip";
            this.pgVales.UniqueName = "27F25EC95F4141A444A5AE674FF4B721";
            // 
            // tbVales
            // 
            this.tbVales.BackColor = System.Drawing.Color.Transparent;
            this.tbVales.ColumnCount = 1;
            this.tbVales.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tbVales.Controls.Add(this.tableLayoutPanel7, 0, 0);
            this.tbVales.Controls.Add(this.dgvVales, 0, 1);
            this.tbVales.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbVales.Location = new System.Drawing.Point(0, 0);
            this.tbVales.Margin = new System.Windows.Forms.Padding(2);
            this.tbVales.Name = "tbVales";
            this.tbVales.RowCount = 2;
            this.tbVales.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.882353F));
            this.tbVales.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90.11765F));
            this.tbVales.Size = new System.Drawing.Size(798, 423);
            this.tbVales.TabIndex = 8;
            // 
            // tableLayoutPanel7
            // 
            this.tableLayoutPanel7.BackColor = System.Drawing.Color.White;
            this.tableLayoutPanel7.ColumnCount = 3;
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel7.Controls.Add(this.txtBuscarVale, 0, 0);
            this.tableLayoutPanel7.Controls.Add(this.kryptonLabel4, 0, 0);
            this.tableLayoutPanel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel7.Location = new System.Drawing.Point(2, 2);
            this.tableLayoutPanel7.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel7.Name = "tableLayoutPanel7";
            this.tableLayoutPanel7.RowCount = 1;
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel7.Size = new System.Drawing.Size(794, 37);
            this.tableLayoutPanel7.TabIndex = 0;
            // 
            // txtBuscarVale
            // 
            this.txtBuscarVale.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtBuscarVale.Location = new System.Drawing.Point(81, 2);
            this.txtBuscarVale.Margin = new System.Windows.Forms.Padding(2);
            this.txtBuscarVale.Name = "txtBuscarVale";
            this.txtBuscarVale.Size = new System.Drawing.Size(551, 23);
            this.txtBuscarVale.TabIndex = 2;
            this.txtBuscarVale.TextChanged += new System.EventHandler(this.txtBuscarVale_TextChanged);
            // 
            // kryptonLabel4
            // 
            this.kryptonLabel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonLabel4.Location = new System.Drawing.Point(2, 2);
            this.kryptonLabel4.Margin = new System.Windows.Forms.Padding(2);
            this.kryptonLabel4.Name = "kryptonLabel4";
            this.kryptonLabel4.Size = new System.Drawing.Size(75, 33);
            this.kryptonLabel4.TabIndex = 1;
            this.kryptonLabel4.Values.Text = "Buscar";
            // 
            // dgvVales
            // 
            this.dgvVales.AllowUserToAddRows = false;
            this.dgvVales.AllowUserToDeleteRows = false;
            this.dgvVales.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvVales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVales.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvVales.Location = new System.Drawing.Point(2, 43);
            this.dgvVales.Margin = new System.Windows.Forms.Padding(2);
            this.dgvVales.Name = "dgvVales";
            this.dgvVales.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2007Blue;
            this.dgvVales.ReadOnly = true;
            this.dgvVales.RowHeadersWidth = 51;
            this.dgvVales.RowTemplate.Height = 24;
            this.dgvVales.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvVales.Size = new System.Drawing.Size(794, 378);
            this.dgvVales.TabIndex = 1;
            this.dgvVales.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvVales_CellDoubleClick);
            // 
            // pgProdAcumulados
            // 
            this.pgProdAcumulados.AutoHiddenSlideSize = new System.Drawing.Size(200, 200);
            this.pgProdAcumulados.Controls.Add(this.tbProdAcumulados);
            this.pgProdAcumulados.Flags = 65534;
            this.pgProdAcumulados.LastVisibleSet = true;
            this.pgProdAcumulados.MinimumSize = new System.Drawing.Size(50, 50);
            this.pgProdAcumulados.Name = "pgProdAcumulados";
            this.pgProdAcumulados.Size = new System.Drawing.Size(798, 423);
            this.pgProdAcumulados.Text = "Productos Acumulados";
            this.pgProdAcumulados.ToolTipTitle = "Page ToolTip";
            this.pgProdAcumulados.UniqueName = "9E943A9564714863C995DF32853EAD1D";
            // 
            // tbProdAcumulados
            // 
            this.tbProdAcumulados.BackColor = System.Drawing.Color.Transparent;
            this.tbProdAcumulados.ColumnCount = 1;
            this.tbProdAcumulados.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tbProdAcumulados.Controls.Add(this.tableLayoutPanel1, 0, 1);
            this.tbProdAcumulados.Controls.Add(this.dgvProdAcumulados, 1, 1);
            this.tbProdAcumulados.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbProdAcumulados.Location = new System.Drawing.Point(0, 0);
            this.tbProdAcumulados.Margin = new System.Windows.Forms.Padding(2);
            this.tbProdAcumulados.Name = "tbProdAcumulados";
            this.tbProdAcumulados.RowCount = 2;
            this.tbProdAcumulados.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.882353F));
            this.tbProdAcumulados.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90.11765F));
            this.tbProdAcumulados.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 377F));
            this.tbProdAcumulados.Size = new System.Drawing.Size(798, 423);
            this.tbProdAcumulados.TabIndex = 8;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 13.6612F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 86.3388F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 110F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 105F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 68F));
            this.tableLayoutPanel1.Controls.Add(this.btnAgregarVenta, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtbuscarProducto, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.kryptonLabel5, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.chbSelectAll, 3, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(2, 6);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 37F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(794, 37);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // btnAgregarVenta
            // 
            this.btnAgregarVenta.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAgregarVenta.Location = new System.Drawing.Point(512, 2);
            this.btnAgregarVenta.Margin = new System.Windows.Forms.Padding(2);
            this.btnAgregarVenta.Name = "btnAgregarVenta";
            this.btnAgregarVenta.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2007Blue;
            this.btnAgregarVenta.Size = new System.Drawing.Size(106, 33);
            this.btnAgregarVenta.TabIndex = 3;
            this.btnAgregarVenta.Values.Text = "Facturar";
            this.btnAgregarVenta.Click += new System.EventHandler(this.btnAgregarVenta_Click);
            // 
            // txtbuscarProducto
            // 
            this.txtbuscarProducto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtbuscarProducto.Location = new System.Drawing.Point(71, 2);
            this.txtbuscarProducto.Margin = new System.Windows.Forms.Padding(2);
            this.txtbuscarProducto.Name = "txtbuscarProducto";
            this.txtbuscarProducto.Size = new System.Drawing.Size(437, 23);
            this.txtbuscarProducto.TabIndex = 2;
            this.txtbuscarProducto.TextChanged += new System.EventHandler(this.txtbuscarProducto_TextChanged);
            // 
            // kryptonLabel5
            // 
            this.kryptonLabel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonLabel5.Location = new System.Drawing.Point(2, 2);
            this.kryptonLabel5.Margin = new System.Windows.Forms.Padding(2);
            this.kryptonLabel5.Name = "kryptonLabel5";
            this.kryptonLabel5.Size = new System.Drawing.Size(65, 33);
            this.kryptonLabel5.TabIndex = 1;
            this.kryptonLabel5.Values.Text = "Buscar";
            // 
            // chbSelectAll
            // 
            this.chbSelectAll.AutoSize = true;
            this.chbSelectAll.Location = new System.Drawing.Point(623, 3);
            this.chbSelectAll.Name = "chbSelectAll";
            this.chbSelectAll.Size = new System.Drawing.Size(92, 17);
            this.chbSelectAll.TabIndex = 4;
            this.chbSelectAll.Text = "Select. Todos";
            this.chbSelectAll.UseVisualStyleBackColor = true;
            this.chbSelectAll.CheckedChanged += new System.EventHandler(this.chbSelectAll_CheckedChanged);
            // 
            // dgvProdAcumulados
            // 
            this.dgvProdAcumulados.AllowUserToAddRows = false;
            this.dgvProdAcumulados.AllowUserToDeleteRows = false;
            this.dgvProdAcumulados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvProdAcumulados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProdAcumulados.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dgvProdAcumulados.Location = new System.Drawing.Point(2, 47);
            this.dgvProdAcumulados.Margin = new System.Windows.Forms.Padding(2);
            this.dgvProdAcumulados.Name = "dgvProdAcumulados";
            this.dgvProdAcumulados.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2007Blue;
            this.dgvProdAcumulados.ReadOnly = true;
            this.dgvProdAcumulados.RowHeadersWidth = 51;
            this.dgvProdAcumulados.RowTemplate.Height = 24;
            this.dgvProdAcumulados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProdAcumulados.Size = new System.Drawing.Size(794, 374);
            this.dgvProdAcumulados.TabIndex = 1;
            this.dgvProdAcumulados.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProdAcumulados_CellClick);
            // 
            // DocumentosGuardados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.knGuardados);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DocumentosGuardados";
            this.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2007Blue;
            this.Text = "Guardados";
            this.Load += new System.EventHandler(this.DocumentosGuardados_Load);
            ((System.ComponentModel.ISupportInitialize)(this.knGuardados)).EndInit();
            this.knGuardados.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.VentasContado)).EndInit();
            this.VentasContado.ResumeLayout(false);
            this.tbContado.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVentasContado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.VentasCredito)).EndInit();
            this.VentasCredito.ResumeLayout(false);
            this.tbCredito.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVentasCredito)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pgCotizaciones)).EndInit();
            this.pgCotizaciones.ResumeLayout(false);
            this.tbCotizaciones.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCotizacion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pgVales)).EndInit();
            this.pgVales.ResumeLayout(false);
            this.tbVales.ResumeLayout(false);
            this.tableLayoutPanel7.ResumeLayout(false);
            this.tableLayoutPanel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVales)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pgProdAcumulados)).EndInit();
            this.pgProdAcumulados.ResumeLayout(false);
            this.tbProdAcumulados.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdAcumulados)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ComponentFactory.Krypton.Docking.KryptonDockableNavigator knGuardados;
        private ComponentFactory.Krypton.Navigator.KryptonPage VentasContado;
        private ComponentFactory.Krypton.Navigator.KryptonPage VentasCredito;
        private ComponentFactory.Krypton.Navigator.KryptonPage pgCotizaciones;
        private ComponentFactory.Krypton.Navigator.KryptonPage pgVales;
        private System.Windows.Forms.TableLayoutPanel tbContado;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtBuscarContado;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView dgvVentasContado;
        private System.Windows.Forms.TableLayoutPanel tbCredito;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtBuscarCredito;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel2;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView dgvVentasCredito;
        private System.Windows.Forms.TableLayoutPanel tbCotizaciones;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtBuscarCotizacion;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel3;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView dgvCotizacion;
        private System.Windows.Forms.TableLayoutPanel tbVales;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel7;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtBuscarVale;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel4;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView dgvVales;
        private ComponentFactory.Krypton.Navigator.KryptonPage pgProdAcumulados;
        private System.Windows.Forms.TableLayoutPanel tbProdAcumulados;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView dgvProdAcumulados;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnAgregarVenta;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtbuscarProducto;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel5;
        private System.Windows.Forms.CheckBox chbSelectAll;
    }
}