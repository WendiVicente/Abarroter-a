
namespace Sistema.Forms.modulo_recargas
{
    partial class ListadoRecargas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListadoRecargas));
            this.kryptonPanel1 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.listRecargas = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.buscarprod = new System.Windows.Forms.ToolStripButton();
            this.txtBuscador = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnBorrar = new System.Windows.Forms.ToolStripButton();
            this.btnDetalleP = new System.Windows.Forms.ToolStripButton();
            this.btnActualizar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.listarRecargasBindingSource = new System.Windows.Forms.BindingSource(this.components);
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
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).BeginInit();
            this.kryptonPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listRecargas)).BeginInit();
            this.toolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listarRecargasBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // kryptonPanel1
            // 
            this.kryptonPanel1.Controls.Add(this.listRecargas);
            this.kryptonPanel1.Controls.Add(this.toolStrip);
            this.kryptonPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanel1.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel1.Name = "kryptonPanel1";
            this.kryptonPanel1.Size = new System.Drawing.Size(720, 392);
            this.kryptonPanel1.TabIndex = 1;
            // 
            // listRecargas
            // 
            this.listRecargas.AllowUserToAddRows = false;
            this.listRecargas.AllowUserToDeleteRows = false;
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
            this.listRecargas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listRecargas.Location = new System.Drawing.Point(0, 27);
            this.listRecargas.Name = "listRecargas";
            this.listRecargas.ReadOnly = true;
            this.listRecargas.RowHeadersWidth = 51;
            this.listRecargas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.listRecargas.Size = new System.Drawing.Size(720, 365);
            this.listRecargas.TabIndex = 4;
            // 
            // toolStrip
            // 
            this.toolStrip.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toolStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.buscarprod,
            this.txtBuscador,
            this.toolStripSeparator2,
            this.btnBorrar,
            this.btnDetalleP,
            this.btnActualizar,
            this.toolStripSeparator1});
            this.toolStrip.Location = new System.Drawing.Point(0, 0);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Size = new System.Drawing.Size(720, 27);
            this.toolStrip.TabIndex = 3;
            this.toolStrip.Text = "ToolStrip";
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
            this.txtBuscador.Name = "txtBuscador";
            this.txtBuscador.Size = new System.Drawing.Size(150, 27);
            this.txtBuscador.TextChanged += new System.EventHandler(this.txtBuscador_TextChanged);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // btnBorrar
            // 
            this.btnBorrar.Image = global::Sistema.Properties.Resources._0405_20_delete;
            this.btnBorrar.ImageTransparentColor = System.Drawing.Color.Black;
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(74, 24);
            this.btnBorrar.Text = "Eliminar";
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // btnDetalleP
            // 
            this.btnDetalleP.Image = ((System.Drawing.Image)(resources.GetObject("btnDetalleP.Image")));
            this.btnDetalleP.ImageTransparentColor = System.Drawing.Color.Black;
            this.btnDetalleP.Name = "btnDetalleP";
            this.btnDetalleP.Size = new System.Drawing.Size(67, 24);
            this.btnDetalleP.Text = "Detalle";
            this.btnDetalleP.Click += new System.EventHandler(this.btnDetalleP_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.Image = global::Sistema.Properties.Resources.Refresh_16x;
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
            // listarRecargasBindingSource
            // 
            this.listarRecargasBindingSource.DataSource = typeof(CapaDatos.ListasPersonalizadas.ListarRecargas);
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
            this.deletedDataGridViewCheckBoxColumn.Width = 57;
            // 
            // ListadoRecargas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(720, 392);
            this.Controls.Add(this.kryptonPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ListadoRecargas";
            this.Text = "Listado de Recargas";
            this.Load += new System.EventHandler(this.ListadoRecargas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).EndInit();
            this.kryptonPanel1.ResumeLayout(false);
            this.kryptonPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listRecargas)).EndInit();
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listarRecargasBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel1;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView listRecargas;
        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.ToolStripButton buscarprod;
        private System.Windows.Forms.ToolStripButton btnBorrar;
        private System.Windows.Forms.ToolStripButton btnDetalleP;
        private System.Windows.Forms.ToolStripButton btnActualizar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripTextBox txtBuscador;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
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
    }
}