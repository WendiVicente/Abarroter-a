namespace Sistema.Forms.modulo_producto
{
    partial class AgregarTallaEdit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AgregarTallaEdit));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnAgregarlista = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.kryptonPanel5 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.rbtallapersonaliz = new ComponentFactory.Krypton.Toolkit.KryptonRadioButton();
            this.kryptonLabel2 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonPanel3 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.dgvtallaslist = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.kryptonPanel2 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rbcomboTallas = new ComponentFactory.Krypton.Toolkit.KryptonRadioButton();
            this.comboTallas = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.txtCantidadTallas = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.lbTalla = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.txtTalla = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.btnagregar = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kryptonPanel4 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.kryptonPanel1 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel5)).BeginInit();
            this.kryptonPanel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel3)).BeginInit();
            this.kryptonPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvtallaslist)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel2)).BeginInit();
            this.kryptonPanel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.comboTallas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel4)).BeginInit();
            this.kryptonPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).BeginInit();
            this.kryptonPanel1.SuspendLayout();
            this.SuspendLayout();
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
            this.toolStrip1.Size = new System.Drawing.Size(324, 27);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            this.toolStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.toolStrip1_ItemClicked);
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
            // kryptonPanel5
            // 
            this.kryptonPanel5.Controls.Add(this.toolStrip1);
            this.kryptonPanel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.kryptonPanel5.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel5.Margin = new System.Windows.Forms.Padding(2);
            this.kryptonPanel5.Name = "kryptonPanel5";
            this.kryptonPanel5.Size = new System.Drawing.Size(324, 24);
            this.kryptonPanel5.TabIndex = 4;
            // 
            // rbtallapersonaliz
            // 
            this.rbtallapersonaliz.Location = new System.Drawing.Point(11, 70);
            this.rbtallapersonaliz.Margin = new System.Windows.Forms.Padding(2);
            this.rbtallapersonaliz.Name = "rbtallapersonaliz";
            this.rbtallapersonaliz.Size = new System.Drawing.Size(98, 20);
            this.rbtallapersonaliz.TabIndex = 27;
            this.rbtallapersonaliz.Values.Text = "Personalizado";
            this.rbtallapersonaliz.CheckedChanged += new System.EventHandler(this.rbtallapersonal_CheckedChanged);
            // 
            // kryptonLabel2
            // 
            this.kryptonLabel2.Location = new System.Drawing.Point(37, 110);
            this.kryptonLabel2.Margin = new System.Windows.Forms.Padding(2);
            this.kryptonLabel2.Name = "kryptonLabel2";
            this.kryptonLabel2.Size = new System.Drawing.Size(59, 20);
            this.kryptonLabel2.TabIndex = 3;
            this.kryptonLabel2.Values.Text = "Cantidad";
            // 
            // kryptonPanel3
            // 
            this.kryptonPanel3.Controls.Add(this.dgvtallaslist);
            this.kryptonPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanel3.Location = new System.Drawing.Point(0, 199);
            this.kryptonPanel3.Margin = new System.Windows.Forms.Padding(2);
            this.kryptonPanel3.Name = "kryptonPanel3";
            this.kryptonPanel3.Size = new System.Drawing.Size(324, 241);
            this.kryptonPanel3.TabIndex = 7;
            // 
            // dgvtallaslist
            // 
            this.dgvtallaslist.AllowUserToAddRows = false;
            this.dgvtallaslist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvtallaslist.Location = new System.Drawing.Point(0, 0);
            this.dgvtallaslist.Margin = new System.Windows.Forms.Padding(2);
            this.dgvtallaslist.Name = "dgvtallaslist";
            this.dgvtallaslist.ReadOnly = true;
            this.dgvtallaslist.RowHeadersWidth = 51;
            this.dgvtallaslist.RowTemplate.Height = 24;
            this.dgvtallaslist.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvtallaslist.Size = new System.Drawing.Size(324, 198);
            this.dgvtallaslist.TabIndex = 0;
            this.dgvtallaslist.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.dgvtallaslist_UserDeletingRow);
            // 
            // kryptonPanel2
            // 
            this.kryptonPanel2.Controls.Add(this.panel1);
            this.kryptonPanel2.Controls.Add(this.kryptonPanel5);
            this.kryptonPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.kryptonPanel2.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel2.Margin = new System.Windows.Forms.Padding(2);
            this.kryptonPanel2.Name = "kryptonPanel2";
            this.kryptonPanel2.Size = new System.Drawing.Size(324, 199);
            this.kryptonPanel2.TabIndex = 6;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.rbtallapersonaliz);
            this.panel1.Controls.Add(this.kryptonLabel2);
            this.panel1.Controls.Add(this.rbcomboTallas);
            this.panel1.Controls.Add(this.comboTallas);
            this.panel1.Controls.Add(this.txtCantidadTallas);
            this.panel1.Controls.Add(this.lbTalla);
            this.panel1.Controls.Add(this.txtTalla);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 24);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(324, 175);
            this.panel1.TabIndex = 5;
            // 
            // rbcomboTallas
            // 
            this.rbcomboTallas.Location = new System.Drawing.Point(10, 29);
            this.rbcomboTallas.Margin = new System.Windows.Forms.Padding(2);
            this.rbcomboTallas.Name = "rbcomboTallas";
            this.rbcomboTallas.Size = new System.Drawing.Size(117, 20);
            this.rbcomboTallas.TabIndex = 26;
            this.rbcomboTallas.Values.Text = "Elegir desde Lista";
            this.rbcomboTallas.CheckedChanged += new System.EventHandler(this.rblistatallas_CheckedChanged);
            // 
            // comboTallas
            // 
            this.comboTallas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboTallas.DropDownWidth = 139;
            this.comboTallas.Location = new System.Drawing.Point(136, 29);
            this.comboTallas.Margin = new System.Windows.Forms.Padding(2);
            this.comboTallas.Name = "comboTallas";
            this.comboTallas.Size = new System.Drawing.Size(150, 21);
            this.comboTallas.TabIndex = 25;
            this.comboTallas.SelectedIndexChanged += new System.EventHandler(this.comboTallas_SelectedIndexChanged);
            // 
            // txtCantidadTallas
            // 
            this.txtCantidadTallas.Location = new System.Drawing.Point(125, 108);
            this.txtCantidadTallas.Margin = new System.Windows.Forms.Padding(2);
            this.txtCantidadTallas.Name = "txtCantidadTallas";
            this.txtCantidadTallas.Size = new System.Drawing.Size(160, 23);
            this.txtCantidadTallas.TabIndex = 2;
            this.txtCantidadTallas.Text = "0";
            // 
            // lbTalla
            // 
            this.lbTalla.Location = new System.Drawing.Point(113, 68);
            this.lbTalla.Name = "lbTalla";
            this.lbTalla.Size = new System.Drawing.Size(52, 20);
            this.lbTalla.TabIndex = 24;
            this.lbTalla.Values.Text = "Medida";
            // 
            // txtTalla
            // 
            this.txtTalla.Location = new System.Drawing.Point(167, 68);
            this.txtTalla.Name = "txtTalla";
            this.txtTalla.Size = new System.Drawing.Size(119, 23);
            this.txtTalla.TabIndex = 18;
            // 
            // btnagregar
            // 
            this.btnagregar.Location = new System.Drawing.Point(75, 2);
            this.btnagregar.Margin = new System.Windows.Forms.Padding(2);
            this.btnagregar.Name = "btnagregar";
            this.btnagregar.Size = new System.Drawing.Size(130, 35);
            this.btnagregar.TabIndex = 5;
            this.btnagregar.Values.Text = "Agregar";
            this.btnagregar.Click += new System.EventHandler(this.btnagregar_Click);
            // 
            // kryptonPanel4
            // 
            this.kryptonPanel4.Controls.Add(this.btnagregar);
            this.kryptonPanel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.kryptonPanel4.Location = new System.Drawing.Point(0, 401);
            this.kryptonPanel4.Margin = new System.Windows.Forms.Padding(2);
            this.kryptonPanel4.Name = "kryptonPanel4";
            this.kryptonPanel4.Size = new System.Drawing.Size(324, 39);
            this.kryptonPanel4.TabIndex = 8;
            // 
            // kryptonPanel1
            // 
            this.kryptonPanel1.Controls.Add(this.kryptonPanel4);
            this.kryptonPanel1.Controls.Add(this.kryptonPanel3);
            this.kryptonPanel1.Controls.Add(this.kryptonPanel2);
            this.kryptonPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanel1.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.kryptonPanel1.Name = "kryptonPanel1";
            this.kryptonPanel1.Size = new System.Drawing.Size(324, 440);
            this.kryptonPanel1.TabIndex = 1;
            // 
            // AgregarTallaEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(324, 440);
            this.Controls.Add(this.kryptonPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AgregarTallaEdit";
            this.Text = "Editar Tallas";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AgregarTalla_FormClosing);
            this.Load += new System.EventHandler(this.AgregarTalla_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel5)).EndInit();
            this.kryptonPanel5.ResumeLayout(false);
            this.kryptonPanel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel3)).EndInit();
            this.kryptonPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvtallaslist)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel2)).EndInit();
            this.kryptonPanel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.comboTallas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel4)).EndInit();
            this.kryptonPanel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).EndInit();
            this.kryptonPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ToolStripButton btnAgregarlista;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel5;
        private ComponentFactory.Krypton.Toolkit.KryptonRadioButton rbtallapersonaliz;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel2;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel3;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView dgvtallaslist;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel2;
        private System.Windows.Forms.Panel panel1;
        private ComponentFactory.Krypton.Toolkit.KryptonRadioButton rbcomboTallas;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox comboTallas;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtCantidadTallas;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lbTalla;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtTalla;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnagregar;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel4;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel1;
    }
}