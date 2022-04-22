namespace Sistema.Forms.modulo_Ccobrar
{
    partial class VentaCredito
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VentaCredito));
            this.knGuardados = new ComponentFactory.Krypton.Docking.KryptonDockableNavigator();
            this.VentasCredito = new ComponentFactory.Krypton.Navigator.KryptonPage();
            this.tbCredito = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.txtBuscarCredito = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.kryptonLabel2 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.dgvVentasCredito = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.pgDetalleVenta = new ComponentFactory.Krypton.Navigator.KryptonPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lbproductos = new System.Windows.Forms.Label();
            this.dgvDetalle = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.dgvProductos = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.knGuardados)).BeginInit();
            this.knGuardados.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.VentasCredito)).BeginInit();
            this.VentasCredito.SuspendLayout();
            this.tbCredito.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVentasCredito)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pgDetalleVenta)).BeginInit();
            this.pgDetalleVenta.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).BeginInit();
            this.SuspendLayout();
            // 
            // knGuardados
            // 
            this.knGuardados.Dock = System.Windows.Forms.DockStyle.Fill;
            this.knGuardados.Location = new System.Drawing.Point(0, 0);
            this.knGuardados.Name = "knGuardados";
            this.knGuardados.Pages.AddRange(new ComponentFactory.Krypton.Navigator.KryptonPage[] {
            this.VentasCredito,
            this.pgDetalleVenta});
            this.knGuardados.SelectedIndex = 0;
            this.knGuardados.Size = new System.Drawing.Size(832, 483);
            this.knGuardados.TabIndex = 0;
            this.knGuardados.Text = "navigator";
            // 
            // VentasCredito
            // 
            this.VentasCredito.AutoHiddenSlideSize = new System.Drawing.Size(200, 200);
            this.VentasCredito.Controls.Add(this.tbCredito);
            this.VentasCredito.Flags = 65534;
            this.VentasCredito.LastVisibleSet = true;
            this.VentasCredito.MinimumSize = new System.Drawing.Size(50, 50);
            this.VentasCredito.Name = "VentasCredito";
            this.VentasCredito.Size = new System.Drawing.Size(830, 456);
            this.VentasCredito.Text = "Ventas Crédito";
            this.VentasCredito.ToolTipTitle = "Page ToolTip";
            this.VentasCredito.UniqueName = "84EFA26A85264FD343A7B698B1B10448";
            // 
            // tbCredito
            // 
            this.tbCredito.BackColor = System.Drawing.SystemColors.Control;
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
            this.tbCredito.Size = new System.Drawing.Size(830, 456);
            this.tbCredito.TabIndex = 8;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.BackColor = System.Drawing.SystemColors.Control;
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
            this.tableLayoutPanel3.Size = new System.Drawing.Size(826, 41);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // txtBuscarCredito
            // 
            this.txtBuscarCredito.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtBuscarCredito.Location = new System.Drawing.Point(84, 2);
            this.txtBuscarCredito.Margin = new System.Windows.Forms.Padding(2);
            this.txtBuscarCredito.Name = "txtBuscarCredito";
            this.txtBuscarCredito.Size = new System.Drawing.Size(574, 23);
            this.txtBuscarCredito.TabIndex = 2;
            this.txtBuscarCredito.TextChanged += new System.EventHandler(this.txtBuscarCredito_TextChanged);
            // 
            // kryptonLabel2
            // 
            this.kryptonLabel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonLabel2.Location = new System.Drawing.Point(2, 2);
            this.kryptonLabel2.Margin = new System.Windows.Forms.Padding(2);
            this.kryptonLabel2.Name = "kryptonLabel2";
            this.kryptonLabel2.Size = new System.Drawing.Size(78, 37);
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
            this.dgvVentasCredito.Location = new System.Drawing.Point(2, 47);
            this.dgvVentasCredito.Margin = new System.Windows.Forms.Padding(2);
            this.dgvVentasCredito.MultiSelect = false;
            this.dgvVentasCredito.Name = "dgvVentasCredito";
            this.dgvVentasCredito.ReadOnly = true;
            this.dgvVentasCredito.RowHeadersWidth = 51;
            this.dgvVentasCredito.RowTemplate.Height = 24;
            this.dgvVentasCredito.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvVentasCredito.Size = new System.Drawing.Size(826, 407);
            this.dgvVentasCredito.TabIndex = 1;
            this.dgvVentasCredito.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvVentasCredito_CellClick);
            // 
            // pgDetalleVenta
            // 
            this.pgDetalleVenta.AutoHiddenSlideSize = new System.Drawing.Size(200, 200);
            this.pgDetalleVenta.Controls.Add(this.panel1);
            this.pgDetalleVenta.Flags = 65534;
            this.pgDetalleVenta.LastVisibleSet = true;
            this.pgDetalleVenta.MinimumSize = new System.Drawing.Size(50, 50);
            this.pgDetalleVenta.Name = "pgDetalleVenta";
            this.pgDetalleVenta.Size = new System.Drawing.Size(830, 456);
            this.pgDetalleVenta.Text = "Detalle Venta";
            this.pgDetalleVenta.ToolTipTitle = "Page ToolTip";
            this.pgDetalleVenta.UniqueName = "629C3D2D81784186119AB58B0028CAFE";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lbproductos);
            this.panel1.Controls.Add(this.dgvDetalle);
            this.panel1.Controls.Add(this.dgvProductos);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(830, 456);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 228);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 18);
            this.label1.TabIndex = 89;
            this.label1.Text = "Detalle";
            // 
            // lbproductos
            // 
            this.lbproductos.AutoSize = true;
            this.lbproductos.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbproductos.Location = new System.Drawing.Point(10, 4);
            this.lbproductos.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbproductos.Name = "lbproductos";
            this.lbproductos.Size = new System.Drawing.Size(77, 18);
            this.lbproductos.TabIndex = 88;
            this.lbproductos.Text = "Productos";
            // 
            // dgvDetalle
            // 
            this.dgvDetalle.AllowUserToAddRows = false;
            this.dgvDetalle.AllowUserToDeleteRows = false;
            this.dgvDetalle.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvDetalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetalle.Location = new System.Drawing.Point(11, 249);
            this.dgvDetalle.MultiSelect = false;
            this.dgvDetalle.Name = "dgvDetalle";
            this.dgvDetalle.ReadOnly = true;
            this.dgvDetalle.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDetalle.Size = new System.Drawing.Size(815, 200);
            this.dgvDetalle.TabIndex = 1;
            // 
            // dgvProductos
            // 
            this.dgvProductos.AllowUserToAddRows = false;
            this.dgvProductos.AllowUserToDeleteRows = false;
            this.dgvProductos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductos.Location = new System.Drawing.Point(11, 25);
            this.dgvProductos.MultiSelect = false;
            this.dgvProductos.Name = "dgvProductos";
            this.dgvProductos.ReadOnly = true;
            this.dgvProductos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProductos.Size = new System.Drawing.Size(815, 200);
            this.dgvProductos.TabIndex = 0;
            this.dgvProductos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProductos_CellClick);
            // 
            // VentaCredito
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(832, 483);
            this.Controls.Add(this.knGuardados);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "VentaCredito";
            this.Text = "Créditos";
            this.Load += new System.EventHandler(this.VentaCredito_Load);
            ((System.ComponentModel.ISupportInitialize)(this.knGuardados)).EndInit();
            this.knGuardados.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.VentasCredito)).EndInit();
            this.VentasCredito.ResumeLayout(false);
            this.tbCredito.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVentasCredito)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pgDetalleVenta)).EndInit();
            this.pgDetalleVenta.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ComponentFactory.Krypton.Docking.KryptonDockableNavigator knGuardados;
        private ComponentFactory.Krypton.Navigator.KryptonPage VentasCredito;
        private System.Windows.Forms.TableLayoutPanel tbCredito;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtBuscarCredito;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel2;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView dgvVentasCredito;
        private ComponentFactory.Krypton.Navigator.KryptonPage pgDetalleVenta;
        private System.Windows.Forms.Panel panel1;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView dgvDetalle;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView dgvProductos;
        private System.Windows.Forms.Label lbproductos;
        private System.Windows.Forms.Label label1;
    }
}