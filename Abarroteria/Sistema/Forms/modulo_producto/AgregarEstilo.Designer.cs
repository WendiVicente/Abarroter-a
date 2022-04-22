
namespace Sistema.Forms.modulo_producto
{
    partial class AgregarEstilo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AgregarEstilo));
            this.detalleEstiloBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kryptonPanel1 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.kryptonPanel2 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.RbPersonalizado = new ComponentFactory.Krypton.Toolkit.KryptonRadioButton();
            this.kryptonLabel2 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.RbListado = new ComponentFactory.Krypton.Toolkit.KryptonRadioButton();
            this.CbEstilos = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.TxtCantidad = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.lbEstilo = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.TxtEstilo = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.kryptonPanel5 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnAgregarlista = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.kryptonPanel3 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.DgvEstilos = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnagregar = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productoIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stockDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estiloDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.detalleEstiloBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).BeginInit();
            this.kryptonPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel2)).BeginInit();
            this.kryptonPanel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CbEstilos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel5)).BeginInit();
            this.kryptonPanel5.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel3)).BeginInit();
            this.kryptonPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvEstilos)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // detalleEstiloBindingSource
            // 
            this.detalleEstiloBindingSource.DataSource = typeof(CapaDatos.Models.Productos.DetalleEstilo);
            // 
            // kryptonPanel1
            // 
            this.kryptonPanel1.Controls.Add(this.kryptonPanel3);
            this.kryptonPanel1.Controls.Add(this.kryptonPanel2);
            this.kryptonPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanel1.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.kryptonPanel1.Name = "kryptonPanel1";
            this.kryptonPanel1.Size = new System.Drawing.Size(294, 441);
            this.kryptonPanel1.TabIndex = 1;
            // 
            // kryptonPanel2
            // 
            this.kryptonPanel2.Controls.Add(this.panel1);
            this.kryptonPanel2.Controls.Add(this.kryptonPanel5);
            this.kryptonPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.kryptonPanel2.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel2.Margin = new System.Windows.Forms.Padding(2);
            this.kryptonPanel2.Name = "kryptonPanel2";
            this.kryptonPanel2.Size = new System.Drawing.Size(294, 199);
            this.kryptonPanel2.TabIndex = 6;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.RbPersonalizado);
            this.panel1.Controls.Add(this.kryptonLabel2);
            this.panel1.Controls.Add(this.RbListado);
            this.panel1.Controls.Add(this.CbEstilos);
            this.panel1.Controls.Add(this.TxtCantidad);
            this.panel1.Controls.Add(this.lbEstilo);
            this.panel1.Controls.Add(this.TxtEstilo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 28);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(294, 171);
            this.panel1.TabIndex = 5;
            // 
            // RbPersonalizado
            // 
            this.RbPersonalizado.Location = new System.Drawing.Point(10, 76);
            this.RbPersonalizado.Margin = new System.Windows.Forms.Padding(2);
            this.RbPersonalizado.Name = "RbPersonalizado";
            this.RbPersonalizado.Size = new System.Drawing.Size(98, 20);
            this.RbPersonalizado.TabIndex = 27;
            this.RbPersonalizado.Values.Text = "Personalizado";
            this.RbPersonalizado.CheckedChanged += new System.EventHandler(this.RbPersonalizado_CheckedChanged);
            // 
            // kryptonLabel2
            // 
            this.kryptonLabel2.Location = new System.Drawing.Point(16, 127);
            this.kryptonLabel2.Margin = new System.Windows.Forms.Padding(2);
            this.kryptonLabel2.Name = "kryptonLabel2";
            this.kryptonLabel2.Size = new System.Drawing.Size(59, 20);
            this.kryptonLabel2.TabIndex = 3;
            this.kryptonLabel2.Values.Text = "Cantidad";
            // 
            // RbListado
            // 
            this.RbListado.Location = new System.Drawing.Point(10, 26);
            this.RbListado.Margin = new System.Windows.Forms.Padding(2);
            this.RbListado.Name = "RbListado";
            this.RbListado.Size = new System.Drawing.Size(117, 20);
            this.RbListado.TabIndex = 26;
            this.RbListado.Values.Text = "Elegir desde Lista";
            this.RbListado.CheckedChanged += new System.EventHandler(this.RbListado_CheckedChanged);
            // 
            // CbEstilos
            // 
            this.CbEstilos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbEstilos.DropDownWidth = 139;
            this.CbEstilos.Location = new System.Drawing.Point(136, 26);
            this.CbEstilos.Margin = new System.Windows.Forms.Padding(2);
            this.CbEstilos.Name = "CbEstilos";
            this.CbEstilos.Size = new System.Drawing.Size(128, 21);
            this.CbEstilos.TabIndex = 25;
            this.CbEstilos.SelectedIndexChanged += new System.EventHandler(this.CbEstilos_SelectedIndexChanged);
            // 
            // TxtCantidad
            // 
            this.TxtCantidad.Location = new System.Drawing.Point(104, 125);
            this.TxtCantidad.Margin = new System.Windows.Forms.Padding(2);
            this.TxtCantidad.Name = "TxtCantidad";
            this.TxtCantidad.Size = new System.Drawing.Size(160, 23);
            this.TxtCantidad.TabIndex = 2;
            this.TxtCantidad.Text = "0";
            // 
            // lbEstilo
            // 
            this.lbEstilo.Location = new System.Drawing.Point(115, 77);
            this.lbEstilo.Name = "lbEstilo";
            this.lbEstilo.Size = new System.Drawing.Size(48, 20);
            this.lbEstilo.TabIndex = 24;
            this.lbEstilo.Values.Text = "Diseño";
            // 
            // TxtEstilo
            // 
            this.TxtEstilo.Location = new System.Drawing.Point(166, 76);
            this.TxtEstilo.Name = "TxtEstilo";
            this.TxtEstilo.Size = new System.Drawing.Size(98, 23);
            this.TxtEstilo.TabIndex = 18;
            // 
            // kryptonPanel5
            // 
            this.kryptonPanel5.Controls.Add(this.toolStrip1);
            this.kryptonPanel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.kryptonPanel5.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel5.Margin = new System.Windows.Forms.Padding(2);
            this.kryptonPanel5.Name = "kryptonPanel5";
            this.kryptonPanel5.Size = new System.Drawing.Size(294, 28);
            this.kryptonPanel5.TabIndex = 4;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnAgregarlista,
            this.toolStripSeparator1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(294, 27);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnAgregarlista
            // 
            this.btnAgregarlista.Image = global::Sistema.Properties.Resources.Checkmark_green_12x_16x;
            this.btnAgregarlista.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAgregarlista.Name = "btnAgregarlista";
            this.btnAgregarlista.Size = new System.Drawing.Size(73, 24);
            this.btnAgregarlista.Text = "Guardar";
            this.btnAgregarlista.Click += new System.EventHandler(this.btnAgregarlista_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.DgvEstilos, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 82.64463F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 17.35537F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(294, 242);
            this.tableLayoutPanel1.TabIndex = 10;
            // 
            // kryptonPanel3
            // 
            this.kryptonPanel3.Controls.Add(this.tableLayoutPanel1);
            this.kryptonPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanel3.Location = new System.Drawing.Point(0, 199);
            this.kryptonPanel3.Margin = new System.Windows.Forms.Padding(2);
            this.kryptonPanel3.Name = "kryptonPanel3";
            this.kryptonPanel3.Size = new System.Drawing.Size(294, 242);
            this.kryptonPanel3.TabIndex = 9;
            // 
            // DgvEstilos
            // 
            this.DgvEstilos.AllowUserToAddRows = false;
            this.DgvEstilos.AutoGenerateColumns = false;
            this.DgvEstilos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.DgvEstilos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvEstilos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.productoIdDataGridViewTextBoxColumn,
            this.stockDataGridViewTextBoxColumn,
            this.estiloDataGridViewTextBoxColumn});
            this.DgvEstilos.DataSource = this.detalleEstiloBindingSource;
            this.DgvEstilos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DgvEstilos.Location = new System.Drawing.Point(2, 2);
            this.DgvEstilos.Margin = new System.Windows.Forms.Padding(2);
            this.DgvEstilos.Name = "DgvEstilos";
            this.DgvEstilos.ReadOnly = true;
            this.DgvEstilos.RowHeadersWidth = 51;
            this.DgvEstilos.RowTemplate.Height = 24;
            this.DgvEstilos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvEstilos.Size = new System.Drawing.Size(290, 196);
            this.DgvEstilos.TabIndex = 1;
            this.DgvEstilos.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.DgvEstilos_UserDeletingRow);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.btnagregar);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 203);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(288, 36);
            this.panel2.TabIndex = 3;
            // 
            // btnagregar
            // 
            this.btnagregar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnagregar.Location = new System.Drawing.Point(77, 2);
            this.btnagregar.Margin = new System.Windows.Forms.Padding(2);
            this.btnagregar.Name = "btnagregar";
            this.btnagregar.Size = new System.Drawing.Size(130, 32);
            this.btnagregar.TabIndex = 5;
            this.btnagregar.Values.Text = "Agregar";
            this.btnagregar.Click += new System.EventHandler(this.btnagregar_Click);
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
            // productoIdDataGridViewTextBoxColumn
            // 
            this.productoIdDataGridViewTextBoxColumn.DataPropertyName = "ProductoId";
            this.productoIdDataGridViewTextBoxColumn.HeaderText = "ProductoId";
            this.productoIdDataGridViewTextBoxColumn.Name = "productoIdDataGridViewTextBoxColumn";
            this.productoIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.productoIdDataGridViewTextBoxColumn.Visible = false;
            this.productoIdDataGridViewTextBoxColumn.Width = 95;
            // 
            // stockDataGridViewTextBoxColumn
            // 
            this.stockDataGridViewTextBoxColumn.DataPropertyName = "Stock";
            this.stockDataGridViewTextBoxColumn.HeaderText = "Stock";
            this.stockDataGridViewTextBoxColumn.Name = "stockDataGridViewTextBoxColumn";
            this.stockDataGridViewTextBoxColumn.ReadOnly = true;
            this.stockDataGridViewTextBoxColumn.Width = 65;
            // 
            // estiloDataGridViewTextBoxColumn
            // 
            this.estiloDataGridViewTextBoxColumn.DataPropertyName = "Estilo";
            this.estiloDataGridViewTextBoxColumn.HeaderText = "Estilo";
            this.estiloDataGridViewTextBoxColumn.Name = "estiloDataGridViewTextBoxColumn";
            this.estiloDataGridViewTextBoxColumn.ReadOnly = true;
            this.estiloDataGridViewTextBoxColumn.Width = 64;
            // 
            // AgregarEstilo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(294, 441);
            this.Controls.Add(this.kryptonPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AgregarEstilo";
            this.Text = "Agregar Estilo";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AgregarEstilo_FormClosing);
            this.Load += new System.EventHandler(this.AgregarEstilo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.detalleEstiloBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).EndInit();
            this.kryptonPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel2)).EndInit();
            this.kryptonPanel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CbEstilos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel5)).EndInit();
            this.kryptonPanel5.ResumeLayout(false);
            this.kryptonPanel5.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel3)).EndInit();
            this.kryptonPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DgvEstilos)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource detalleEstiloBindingSource;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel1;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel2;
        private System.Windows.Forms.Panel panel1;
        private ComponentFactory.Krypton.Toolkit.KryptonRadioButton RbPersonalizado;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel2;
        private ComponentFactory.Krypton.Toolkit.KryptonRadioButton RbListado;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox CbEstilos;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox TxtCantidad;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lbEstilo;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox TxtEstilo;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel5;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnAgregarlista;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView DgvEstilos;
        private System.Windows.Forms.Panel panel2;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnagregar;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productoIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stockDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn estiloDataGridViewTextBoxColumn;
    }
}