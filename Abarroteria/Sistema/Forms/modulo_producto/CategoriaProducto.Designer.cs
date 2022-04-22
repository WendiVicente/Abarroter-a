namespace Sistema.Forms.modulo_producto
{
    partial class CategoriaProducto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CategoriaProducto));
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.kryptonPanel6 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.dgvCategorias = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoriaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estadoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imagenDataGridViewImageColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.listarCategoriaProdBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kryptonPanel5 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.PbIcono = new System.Windows.Forms.PictureBox();
            this.lbcatelimpiar = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.LbIdCat = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel4 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.checkestadocate = new ComponentFactory.Krypton.Toolkit.KryptonCheckBox();
            this.txtcategoria = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.kryptonLabel6 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.btnGuardarCate = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.btnActualizarCate = new System.Windows.Forms.ToolStripButton();
            this.BtnIcono = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel6)).BeginInit();
            this.kryptonPanel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategorias)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listarCategoriaProdBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel5)).BeginInit();
            this.kryptonPanel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PbIcono)).BeginInit();
            this.toolStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 27);
            // 
            // kryptonPanel6
            // 
            this.kryptonPanel6.Controls.Add(this.dgvCategorias);
            this.kryptonPanel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanel6.Location = new System.Drawing.Point(0, 146);
            this.kryptonPanel6.Margin = new System.Windows.Forms.Padding(2);
            this.kryptonPanel6.Name = "kryptonPanel6";
            this.kryptonPanel6.Size = new System.Drawing.Size(600, 220);
            this.kryptonPanel6.TabIndex = 8;
            // 
            // dgvCategorias
            // 
            this.dgvCategorias.AllowUserToAddRows = false;
            this.dgvCategorias.AllowUserToDeleteRows = false;
            this.dgvCategorias.AutoGenerateColumns = false;
            this.dgvCategorias.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCategorias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCategorias.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.categoriaDataGridViewTextBoxColumn,
            this.estadoDataGridViewTextBoxColumn,
            this.imagenDataGridViewImageColumn});
            this.dgvCategorias.DataSource = this.listarCategoriaProdBindingSource;
            this.dgvCategorias.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCategorias.Location = new System.Drawing.Point(0, 0);
            this.dgvCategorias.Margin = new System.Windows.Forms.Padding(2);
            this.dgvCategorias.Name = "dgvCategorias";
            this.dgvCategorias.ReadOnly = true;
            this.dgvCategorias.RowHeadersWidth = 51;
            this.dgvCategorias.RowTemplate.Height = 50;
            this.dgvCategorias.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCategorias.Size = new System.Drawing.Size(600, 220);
            this.dgvCategorias.TabIndex = 0;
            this.dgvCategorias.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCategorias_CellClick);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // categoriaDataGridViewTextBoxColumn
            // 
            this.categoriaDataGridViewTextBoxColumn.DataPropertyName = "Categoria";
            this.categoriaDataGridViewTextBoxColumn.HeaderText = "Categoria";
            this.categoriaDataGridViewTextBoxColumn.Name = "categoriaDataGridViewTextBoxColumn";
            this.categoriaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // estadoDataGridViewTextBoxColumn
            // 
            this.estadoDataGridViewTextBoxColumn.DataPropertyName = "Estado";
            this.estadoDataGridViewTextBoxColumn.HeaderText = "Estado";
            this.estadoDataGridViewTextBoxColumn.Name = "estadoDataGridViewTextBoxColumn";
            this.estadoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // imagenDataGridViewImageColumn
            // 
            this.imagenDataGridViewImageColumn.DataPropertyName = "Imagen";
            this.imagenDataGridViewImageColumn.HeaderText = "Imagen";
            this.imagenDataGridViewImageColumn.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.imagenDataGridViewImageColumn.Name = "imagenDataGridViewImageColumn";
            this.imagenDataGridViewImageColumn.ReadOnly = true;
            // 
            // listarCategoriaProdBindingSource
            // 
            this.listarCategoriaProdBindingSource.DataSource = typeof(CapaDatos.ListasPersonalizadas.ListarCategoriaProd);
            // 
            // kryptonPanel5
            // 
            this.kryptonPanel5.Controls.Add(this.PbIcono);
            this.kryptonPanel5.Controls.Add(this.lbcatelimpiar);
            this.kryptonPanel5.Controls.Add(this.LbIdCat);
            this.kryptonPanel5.Controls.Add(this.kryptonLabel4);
            this.kryptonPanel5.Controls.Add(this.checkestadocate);
            this.kryptonPanel5.Controls.Add(this.txtcategoria);
            this.kryptonPanel5.Controls.Add(this.kryptonLabel6);
            this.kryptonPanel5.Controls.Add(this.toolStrip2);
            this.kryptonPanel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.kryptonPanel5.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel5.Margin = new System.Windows.Forms.Padding(2);
            this.kryptonPanel5.Name = "kryptonPanel5";
            this.kryptonPanel5.Size = new System.Drawing.Size(600, 146);
            this.kryptonPanel5.TabIndex = 6;
            // 
            // PbIcono
            // 
            this.PbIcono.BackColor = System.Drawing.Color.Transparent;
            this.PbIcono.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PbIcono.Image = global::Sistema.Properties.Resources.anadir_imagen32;
            this.PbIcono.Location = new System.Drawing.Point(349, 34);
            this.PbIcono.Name = "PbIcono";
            this.PbIcono.Size = new System.Drawing.Size(117, 100);
            this.PbIcono.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.PbIcono.TabIndex = 14;
            this.PbIcono.TabStop = false;
            // 
            // lbcatelimpiar
            // 
            this.lbcatelimpiar.Location = new System.Drawing.Point(206, 108);
            this.lbcatelimpiar.Margin = new System.Windows.Forms.Padding(2);
            this.lbcatelimpiar.Name = "lbcatelimpiar";
            this.lbcatelimpiar.Size = new System.Drawing.Size(101, 20);
            this.lbcatelimpiar.TabIndex = 13;
            this.lbcatelimpiar.Values.Image = global::Sistema.Properties.Resources.CleanData_16x;
            this.lbcatelimpiar.Values.Text = "Limpiar datos";
            this.lbcatelimpiar.Click += new System.EventHandler(this.lbcatelimpiar_Click);
            // 
            // LbIdCat
            // 
            this.LbIdCat.Location = new System.Drawing.Point(177, 43);
            this.LbIdCat.Margin = new System.Windows.Forms.Padding(2);
            this.LbIdCat.Name = "LbIdCat";
            this.LbIdCat.Size = new System.Drawing.Size(40, 20);
            this.LbIdCat.TabIndex = 12;
            this.LbIdCat.Values.Text = "------";
            // 
            // kryptonLabel4
            // 
            this.kryptonLabel4.Location = new System.Drawing.Point(106, 43);
            this.kryptonLabel4.Margin = new System.Windows.Forms.Padding(2);
            this.kryptonLabel4.Name = "kryptonLabel4";
            this.kryptonLabel4.Size = new System.Drawing.Size(53, 20);
            this.kryptonLabel4.TabIndex = 11;
            this.kryptonLabel4.Values.Text = "Codigo:";
            // 
            // checkestadocate
            // 
            this.checkestadocate.Location = new System.Drawing.Point(106, 108);
            this.checkestadocate.Margin = new System.Windows.Forms.Padding(2);
            this.checkestadocate.Name = "checkestadocate";
            this.checkestadocate.Size = new System.Drawing.Size(69, 20);
            this.checkestadocate.TabIndex = 9;
            this.checkestadocate.Values.Text = "Inactivar";
            this.checkestadocate.CheckedChanged += new System.EventHandler(this.checkestadocate_CheckedChanged);
            // 
            // txtcategoria
            // 
            this.txtcategoria.Location = new System.Drawing.Point(177, 67);
            this.txtcategoria.Margin = new System.Windows.Forms.Padding(2);
            this.txtcategoria.Name = "txtcategoria";
            this.txtcategoria.Size = new System.Drawing.Size(130, 23);
            this.txtcategoria.TabIndex = 8;
            // 
            // kryptonLabel6
            // 
            this.kryptonLabel6.Location = new System.Drawing.Point(69, 70);
            this.kryptonLabel6.Margin = new System.Windows.Forms.Padding(2);
            this.kryptonLabel6.Name = "kryptonLabel6";
            this.kryptonLabel6.Size = new System.Drawing.Size(104, 20);
            this.kryptonLabel6.TabIndex = 7;
            this.kryptonLabel6.Values.Text = "Nueva Categoria:";
            // 
            // toolStrip2
            // 
            this.toolStrip2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toolStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnGuardarCate,
            this.toolStripSeparator3,
            this.btnActualizarCate,
            this.toolStripSeparator4,
            this.BtnIcono,
            this.toolStripSeparator1});
            this.toolStrip2.Location = new System.Drawing.Point(0, 0);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(600, 27);
            this.toolStrip2.TabIndex = 0;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // btnGuardarCate
            // 
            this.btnGuardarCate.Image = global::Sistema.Properties.Resources.Add_8x_16x;
            this.btnGuardarCate.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnGuardarCate.Name = "btnGuardarCate";
            this.btnGuardarCate.Size = new System.Drawing.Size(111, 24);
            this.btnGuardarCate.Text = "Nuevo Guardar";
            this.btnGuardarCate.Click += new System.EventHandler(this.btnGuardarCate_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 27);
            // 
            // btnActualizarCate
            // 
            this.btnActualizarCate.Image = global::Sistema.Properties.Resources.EditDocument_16x;
            this.btnActualizarCate.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnActualizarCate.Name = "btnActualizarCate";
            this.btnActualizarCate.Size = new System.Drawing.Size(83, 24);
            this.btnActualizarCate.Text = "Actualizar";
            this.btnActualizarCate.Click += new System.EventHandler(this.btnActualizarCate_Click);
            // 
            // BtnIcono
            // 
            this.BtnIcono.Image = global::Sistema.Properties.Resources.anadir_imagen32;
            this.BtnIcono.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnIcono.Name = "BtnIcono";
            this.BtnIcono.Size = new System.Drawing.Size(106, 24);
            this.BtnIcono.Text = "Agregar Icono";
            this.BtnIcono.Click += new System.EventHandler(this.BtnIcono_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // CategoriaProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.kryptonPanel6);
            this.Controls.Add(this.kryptonPanel5);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "CategoriaProducto";
            this.Text = "Categoria Producto";
            this.Load += new System.EventHandler(this.CategoriaProducto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel6)).EndInit();
            this.kryptonPanel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategorias)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listarCategoriaProdBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel5)).EndInit();
            this.kryptonPanel5.ResumeLayout(false);
            this.kryptonPanel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PbIcono)).EndInit();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel6;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView dgvCategorias;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel5;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lbcatelimpiar;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel LbIdCat;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel4;
        private ComponentFactory.Krypton.Toolkit.KryptonCheckBox checkestadocate;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtcategoria;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel6;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripButton btnGuardarCate;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton btnActualizarCate;
        private System.Windows.Forms.ToolStripButton BtnIcono;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.PictureBox PbIcono;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoriaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn estadoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn imagenDataGridViewImageColumn;
        private System.Windows.Forms.BindingSource listarCategoriaProdBindingSource;
    }
}