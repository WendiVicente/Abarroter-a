
namespace POS.Forms
{
    partial class MonitorFacturacion
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MonitorFacturacion));
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.lbNoDocumento = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAgregarProd = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnOrdenarFecha = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvEncabezadosDoc = new System.Windows.Forms.DataGridView();
            this.pbFacturarVarios = new System.Windows.Forms.PictureBox();
            this.pbFacturarPedido = new System.Windows.Forms.PictureBox();
            this.pbActualizar = new System.Windows.Forms.PictureBox();
            this.pbMostrarDetalle = new System.Windows.Forms.PictureBox();
            this.label10 = new System.Windows.Forms.Label();
            this.lblLinea = new System.Windows.Forms.Label();
            this.txtTotalPedidos = new System.Windows.Forms.TextBox();
            this.txtLineasItems = new System.Windows.Forms.TextBox();
            this.txtBoxSecc = new System.Windows.Forms.TextBox();
            this.textBox26 = new System.Windows.Forms.TextBox();
            this.dgvDetalleDoc = new System.Windows.Forms.DataGridView();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtpFechaFinal = new ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker();
            this.dtpFechaInicio = new ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.pbBuscarDoc = new System.Windows.Forms.PictureBox();
            this.txtBuscador = new System.Windows.Forms.TextBox();
            this.panel2.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEncabezadosDoc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFacturarVarios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFacturarPedido)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbActualizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMostrarDetalle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalleDoc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBuscarDoc)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.AutoScroll = true;
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.btnOrdenarFecha);
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Controls.Add(this.pbFacturarVarios);
            this.panel2.Controls.Add(this.pbFacturarPedido);
            this.panel2.Controls.Add(this.pbActualizar);
            this.panel2.Controls.Add(this.pbMostrarDetalle);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.lblLinea);
            this.panel2.Controls.Add(this.txtTotalPedidos);
            this.panel2.Controls.Add(this.txtLineasItems);
            this.panel2.Controls.Add(this.txtBoxSecc);
            this.panel2.Controls.Add(this.textBox26);
            this.panel2.Controls.Add(this.dgvDetalleDoc);
            this.panel2.Controls.Add(this.dtpFechaFinal);
            this.panel2.Controls.Add(this.dtpFechaInicio);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.pbBuscarDoc);
            this.panel2.Controls.Add(this.txtBuscador);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(784, 561);
            this.panel2.TabIndex = 1;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panel5.Controls.Add(this.lbNoDocumento);
            this.panel5.Controls.Add(this.label3);
            this.panel5.Controls.Add(this.btnAgregarProd);
            this.panel5.Location = new System.Drawing.Point(18, 398);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(643, 33);
            this.panel5.TabIndex = 5;
            // 
            // lbNoDocumento
            // 
            this.lbNoDocumento.AutoSize = true;
            this.lbNoDocumento.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNoDocumento.ForeColor = System.Drawing.Color.White;
            this.lbNoDocumento.Location = new System.Drawing.Point(263, 6);
            this.lbNoDocumento.Name = "lbNoDocumento";
            this.lbNoDocumento.Size = new System.Drawing.Size(69, 22);
            this.lbNoDocumento.TabIndex = 48;
            this.lbNoDocumento.Text = "No. 000";
            this.lbNoDocumento.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(4, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(211, 22);
            this.label3.TabIndex = 0;
            this.label3.Text = "DETALLE  DEL DOCUMENTO";
            // 
            // btnAgregarProd
            // 
            this.btnAgregarProd.Location = new System.Drawing.Point(547, 4);
            this.btnAgregarProd.Name = "btnAgregarProd";
            this.btnAgregarProd.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2007Blue;
            this.btnAgregarProd.Size = new System.Drawing.Size(90, 25);
            this.btnAgregarProd.TabIndex = 47;
            this.btnAgregarProd.Values.Text = "AGREGAR";
            this.btnAgregarProd.Click += new System.EventHandler(this.btnAgregarProd_Click);
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panel4.Controls.Add(this.label2);
            this.panel4.Location = new System.Drawing.Point(2, 1);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(824, 33);
            this.panel4.TabIndex = 61;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(276, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(214, 22);
            this.label2.TabIndex = 0;
            this.label2.Text = "MONITOR DE FACTURACIÓN";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panel3.Controls.Add(this.label1);
            this.panel3.Location = new System.Drawing.Point(16, 130);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(645, 33);
            this.panel3.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(4, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(255, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "ENCABEZADOS  DEL DOCUMENTO";
            // 
            // btnOrdenarFecha
            // 
            this.btnOrdenarFecha.Location = new System.Drawing.Point(571, 103);
            this.btnOrdenarFecha.Name = "btnOrdenarFecha";
            this.btnOrdenarFecha.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2007Blue;
            this.btnOrdenarFecha.Size = new System.Drawing.Size(90, 25);
            this.btnOrdenarFecha.TabIndex = 60;
            this.btnOrdenarFecha.Values.Text = "Ordenar Fecha";
            this.btnOrdenarFecha.Click += new System.EventHandler(this.btnOrdenarFecha_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgvEncabezadosDoc);
            this.panel1.Location = new System.Drawing.Point(16, 160);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(645, 221);
            this.panel1.TabIndex = 59;
            // 
            // dgvEncabezadosDoc
            // 
            this.dgvEncabezadosDoc.AllowUserToAddRows = false;
            this.dgvEncabezadosDoc.AllowUserToDeleteRows = false;
            this.dgvEncabezadosDoc.AllowUserToResizeRows = false;
            this.dgvEncabezadosDoc.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvEncabezadosDoc.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dgvEncabezadosDoc.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvEncabezadosDoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEncabezadosDoc.Location = new System.Drawing.Point(0, 3);
            this.dgvEncabezadosDoc.MultiSelect = false;
            this.dgvEncabezadosDoc.Name = "dgvEncabezadosDoc";
            this.dgvEncabezadosDoc.ReadOnly = true;
            this.dgvEncabezadosDoc.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEncabezadosDoc.Size = new System.Drawing.Size(645, 218);
            this.dgvEncabezadosDoc.TabIndex = 3;
            this.dgvEncabezadosDoc.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEncabezadosDoc_CellClick);
            this.dgvEncabezadosDoc.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEncabezadosDoc_CellContentClick);
            // 
            // pbFacturarVarios
            // 
            this.pbFacturarVarios.Image = global::POS.Properties.Resources.Lista_Cls;
            this.pbFacturarVarios.Location = new System.Drawing.Point(494, 46);
            this.pbFacturarVarios.Name = "pbFacturarVarios";
            this.pbFacturarVarios.Size = new System.Drawing.Size(41, 38);
            this.pbFacturarVarios.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbFacturarVarios.TabIndex = 58;
            this.pbFacturarVarios.TabStop = false;
            this.pbFacturarVarios.Click += new System.EventHandler(this.pbFacturarVarios_Click);
            // 
            // pbFacturarPedido
            // 
            this.pbFacturarPedido.Image = global::POS.Properties.Resources.Check;
            this.pbFacturarPedido.Location = new System.Drawing.Point(447, 46);
            this.pbFacturarPedido.Name = "pbFacturarPedido";
            this.pbFacturarPedido.Size = new System.Drawing.Size(41, 38);
            this.pbFacturarPedido.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbFacturarPedido.TabIndex = 57;
            this.pbFacturarPedido.TabStop = false;
            this.pbFacturarPedido.Click += new System.EventHandler(this.pbFacturarPedido_Click);
            // 
            // pbActualizar
            // 
            this.pbActualizar.Image = global::POS.Properties.Resources.Refrescar;
            this.pbActualizar.InitialImage = global::POS.Properties.Resources.Refrescar;
            this.pbActualizar.Location = new System.Drawing.Point(400, 46);
            this.pbActualizar.Name = "pbActualizar";
            this.pbActualizar.Size = new System.Drawing.Size(41, 38);
            this.pbActualizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbActualizar.TabIndex = 56;
            this.pbActualizar.TabStop = false;
            this.pbActualizar.Click += new System.EventHandler(this.pbActualizar_Click);
            // 
            // pbMostrarDetalle
            // 
            this.pbMostrarDetalle.Image = global::POS.Properties.Resources.Salir;
            this.pbMostrarDetalle.InitialImage = global::POS.Properties.Resources.Salir;
            this.pbMostrarDetalle.Location = new System.Drawing.Point(353, 46);
            this.pbMostrarDetalle.Name = "pbMostrarDetalle";
            this.pbMostrarDetalle.Size = new System.Drawing.Size(41, 38);
            this.pbMostrarDetalle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbMostrarDetalle.TabIndex = 55;
            this.pbMostrarDetalle.TabStop = false;
            this.pbMostrarDetalle.Click += new System.EventHandler(this.pbMostrarDetalle_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(674, 158);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(58, 16);
            this.label10.TabIndex = 54;
            this.label10.Text = "TOTAL: Q";
            // 
            // lblLinea
            // 
            this.lblLinea.AutoSize = true;
            this.lblLinea.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLinea.Location = new System.Drawing.Point(676, 134);
            this.lblLinea.Name = "lblLinea";
            this.lblLinea.Size = new System.Drawing.Size(43, 16);
            this.lblLinea.TabIndex = 53;
            this.lblLinea.Text = "LINEA:";
            // 
            // txtTotalPedidos
            // 
            this.txtTotalPedidos.Enabled = false;
            this.txtTotalPedidos.Location = new System.Drawing.Point(736, 155);
            this.txtTotalPedidos.Name = "txtTotalPedidos";
            this.txtTotalPedidos.Size = new System.Drawing.Size(66, 20);
            this.txtTotalPedidos.TabIndex = 52;
            this.txtTotalPedidos.Text = "0.00";
            this.txtTotalPedidos.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtLineasItems
            // 
            this.txtLineasItems.Enabled = false;
            this.txtLineasItems.Location = new System.Drawing.Point(725, 131);
            this.txtLineasItems.Name = "txtLineasItems";
            this.txtLineasItems.Size = new System.Drawing.Size(77, 20);
            this.txtLineasItems.TabIndex = 51;
            this.txtLineasItems.Text = "0";
            this.txtLineasItems.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtBoxSecc
            // 
            this.txtBoxSecc.BackColor = System.Drawing.Color.Lavender;
            this.txtBoxSecc.Enabled = false;
            this.txtBoxSecc.Location = new System.Drawing.Point(672, 103);
            this.txtBoxSecc.Multiline = true;
            this.txtBoxSecc.Name = "txtBoxSecc";
            this.txtBoxSecc.Size = new System.Drawing.Size(133, 22);
            this.txtBoxSecc.TabIndex = 50;
            this.txtBoxSecc.Text = "SELECCIONADO";
            // 
            // textBox26
            // 
            this.textBox26.BackColor = System.Drawing.Color.LightSteelBlue;
            this.textBox26.Enabled = false;
            this.textBox26.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox26.Location = new System.Drawing.Point(661, 102);
            this.textBox26.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox26.Multiline = true;
            this.textBox26.Name = "textBox26";
            this.textBox26.Size = new System.Drawing.Size(10, 579);
            this.textBox26.TabIndex = 48;
            this.textBox26.Text = "          ";
            // 
            // dgvDetalleDoc
            // 
            this.dgvDetalleDoc.AllowUserToAddRows = false;
            this.dgvDetalleDoc.AllowUserToDeleteRows = false;
            this.dgvDetalleDoc.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvDetalleDoc.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dgvDetalleDoc.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvDetalleDoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetalleDoc.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column7,
            this.Column8,
            this.Column9,
            this.Column10,
            this.Column11,
            this.Column12});
            this.dgvDetalleDoc.Location = new System.Drawing.Point(18, 431);
            this.dgvDetalleDoc.MultiSelect = false;
            this.dgvDetalleDoc.Name = "dgvDetalleDoc";
            this.dgvDetalleDoc.ReadOnly = true;
            this.dgvDetalleDoc.Size = new System.Drawing.Size(645, 250);
            this.dgvDetalleDoc.TabIndex = 45;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "CODIGO";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            this.Column7.Width = 74;
            // 
            // Column8
            // 
            this.Column8.HeaderText = "DESCRIPCION";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            this.Column8.Width = 105;
            // 
            // Column9
            // 
            this.Column9.HeaderText = "CANTIDAD ";
            this.Column9.Name = "Column9";
            this.Column9.ReadOnly = true;
            this.Column9.Width = 90;
            // 
            // Column10
            // 
            this.Column10.HeaderText = "PRECIO";
            this.Column10.Name = "Column10";
            this.Column10.ReadOnly = true;
            this.Column10.Width = 72;
            // 
            // Column11
            // 
            this.Column11.HeaderText = "DESCUENTO";
            this.Column11.Name = "Column11";
            this.Column11.ReadOnly = true;
            this.Column11.Width = 99;
            // 
            // Column12
            // 
            this.Column12.HeaderText = "SUBTOTAL";
            this.Column12.Name = "Column12";
            this.Column12.ReadOnly = true;
            this.Column12.Width = 89;
            // 
            // dtpFechaFinal
            // 
            this.dtpFechaFinal.Location = new System.Drawing.Point(121, 63);
            this.dtpFechaFinal.Name = "dtpFechaFinal";
            this.dtpFechaFinal.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2007Blue;
            this.dtpFechaFinal.Size = new System.Drawing.Size(192, 21);
            this.dtpFechaFinal.TabIndex = 25;
            this.dtpFechaFinal.ValueChanged += new System.EventHandler(this.dtpFechaFinal_ValueChanged);
            // 
            // dtpFechaInicio
            // 
            this.dtpFechaInicio.Location = new System.Drawing.Point(121, 40);
            this.dtpFechaInicio.Name = "dtpFechaInicio";
            this.dtpFechaInicio.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2007Blue;
            this.dtpFechaInicio.Size = new System.Drawing.Size(192, 21);
            this.dtpFechaInicio.TabIndex = 24;
            this.dtpFechaInicio.ValueChanged += new System.EventHandler(this.dtpFechaInicio_ValueChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(83, 63);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(25, 16);
            this.label8.TabIndex = 23;
            this.label8.Text = "AL:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(82, 41);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(32, 16);
            this.label9.TabIndex = 22;
            this.label9.Text = "DEL:";
            // 
            // pbBuscarDoc
            // 
            this.pbBuscarDoc.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pbBuscarDoc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbBuscarDoc.Image = ((System.Drawing.Image)(resources.GetObject("pbBuscarDoc.Image")));
            this.pbBuscarDoc.InitialImage = ((System.Drawing.Image)(resources.GetObject("pbBuscarDoc.InitialImage")));
            this.pbBuscarDoc.Location = new System.Drawing.Point(16, 102);
            this.pbBuscarDoc.Name = "pbBuscarDoc";
            this.pbBuscarDoc.Size = new System.Drawing.Size(33, 26);
            this.pbBuscarDoc.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbBuscarDoc.TabIndex = 6;
            this.pbBuscarDoc.TabStop = false;
            // 
            // txtBuscador
            // 
            this.txtBuscador.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscador.Location = new System.Drawing.Point(49, 102);
            this.txtBuscador.Multiline = true;
            this.txtBuscador.Name = "txtBuscador";
            this.txtBuscador.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtBuscador.Size = new System.Drawing.Size(520, 26);
            this.txtBuscador.TabIndex = 5;
            this.txtBuscador.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtBuscador.TextChanged += new System.EventHandler(this.txtBuscador_TextChanged);
            // 
            // MonitorFacturacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.panel2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MonitorFacturacion";
            this.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2007Blue;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Red Owl Software";
            this.Load += new System.EventHandler(this.MonitorFacturacion_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEncabezadosDoc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFacturarVarios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFacturarPedido)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbActualizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMostrarDetalle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalleDoc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBuscarDoc)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblLinea;
        private System.Windows.Forms.TextBox txtTotalPedidos;
        private System.Windows.Forms.TextBox txtLineasItems;
        private System.Windows.Forms.TextBox txtBoxSecc;
        private System.Windows.Forms.TextBox textBox26;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnAgregarProd;
        private System.Windows.Forms.DataGridView dgvDetalleDoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column11;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column12;
        private ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker dtpFechaFinal;
        private ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker dtpFechaInicio;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.PictureBox pbBuscarDoc;
        private System.Windows.Forms.TextBox txtBuscador;
        private System.Windows.Forms.DataGridView dgvEncabezadosDoc;
        private System.Windows.Forms.PictureBox pbFacturarVarios;
        private System.Windows.Forms.PictureBox pbFacturarPedido;
        private System.Windows.Forms.PictureBox pbActualizar;
        private System.Windows.Forms.PictureBox pbMostrarDetalle;
        private System.Windows.Forms.Panel panel1;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnOrdenarFecha;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbNoDocumento;
    }
}

