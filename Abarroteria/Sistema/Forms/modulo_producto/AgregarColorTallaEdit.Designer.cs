namespace Sistema.Forms.modulo_producto
{
    partial class AgregarColorTallaEdit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AgregarColorTallaEdit));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnAgregarlista = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.kryptonPanel1 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btPaleta = new System.Windows.Forms.Button();
            this.rbcolorespaleta = new ComponentFactory.Krypton.Toolkit.KryptonRadioButton();
            this.rbcolorespersonal = new ComponentFactory.Krypton.Toolkit.KryptonRadioButton();
            this.rblistacolores = new ComponentFactory.Krypton.Toolkit.KryptonRadioButton();
            this.cbcoloresba = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.lbcolor = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.txtcolor = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.kryptonLabel2 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.rbtallapersonaliz = new ComponentFactory.Krypton.Toolkit.KryptonRadioButton();
            this.txtmedida = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.lbmedida = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.rbcomboTallas = new ComponentFactory.Krypton.Toolkit.KryptonRadioButton();
            this.txtcantidad = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.comboTallas = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.dgvcolorestallas = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.btnagregar = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.Colorpaleta = new System.Windows.Forms.ColorDialog();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).BeginInit();
            this.kryptonPanel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbcoloresba)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.comboTallas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvcolorestallas)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
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
            this.toolStrip1.Size = new System.Drawing.Size(596, 27);
            this.toolStrip1.TabIndex = 1;
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
            // kryptonPanel1
            // 
            this.kryptonPanel1.Controls.Add(this.tableLayoutPanel1);
            this.kryptonPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanel1.Location = new System.Drawing.Point(0, 27);
            this.kryptonPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.kryptonPanel1.Name = "kryptonPanel1";
            this.kryptonPanel1.Size = new System.Drawing.Size(596, 469);
            this.kryptonPanel1.TabIndex = 2;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.dgvcolorestallas, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 51.0288F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 48.9712F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 87F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(596, 461);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(2, 2);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(592, 186);
            this.panel1.TabIndex = 6;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btPaleta);
            this.groupBox2.Controls.Add(this.rbcolorespaleta);
            this.groupBox2.Controls.Add(this.rbcolorespersonal);
            this.groupBox2.Controls.Add(this.rblistacolores);
            this.groupBox2.Controls.Add(this.cbcoloresba);
            this.groupBox2.Controls.Add(this.lbcolor);
            this.groupBox2.Controls.Add(this.txtcolor);
            this.groupBox2.Location = new System.Drawing.Point(289, 2);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(288, 180);
            this.groupBox2.TabIndex = 29;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Colores";
            // 
            // btPaleta
            // 
            this.btPaleta.Enabled = false;
            this.btPaleta.Location = new System.Drawing.Point(133, 55);
            this.btPaleta.Name = "btPaleta";
            this.btPaleta.Size = new System.Drawing.Size(36, 23);
            this.btPaleta.TabIndex = 38;
            this.btPaleta.UseVisualStyleBackColor = true;
            this.btPaleta.Visible = false;
            // 
            // rbcolorespaleta
            // 
            this.rbcolorespaleta.Location = new System.Drawing.Point(12, 55);
            this.rbcolorespaleta.Margin = new System.Windows.Forms.Padding(2);
            this.rbcolorespaleta.Name = "rbcolorespaleta";
            this.rbcolorespaleta.Size = new System.Drawing.Size(93, 20);
            this.rbcolorespaleta.TabIndex = 36;
            this.rbcolorespaleta.Values.Text = "Desde Paleta";
            this.rbcolorespaleta.CheckedChanged += new System.EventHandler(this.rbcolorespaleta_CheckedChanged);
            // 
            // rbcolorespersonal
            // 
            this.rbcolorespersonal.Location = new System.Drawing.Point(12, 87);
            this.rbcolorespersonal.Margin = new System.Windows.Forms.Padding(2);
            this.rbcolorespersonal.Name = "rbcolorespersonal";
            this.rbcolorespersonal.Size = new System.Drawing.Size(98, 20);
            this.rbcolorespersonal.TabIndex = 35;
            this.rbcolorespersonal.Values.Text = "Personalizado";
            this.rbcolorespersonal.CheckedChanged += new System.EventHandler(this.rbcolorespersonal_CheckedChanged);
            // 
            // rblistacolores
            // 
            this.rblistacolores.Location = new System.Drawing.Point(12, 22);
            this.rblistacolores.Margin = new System.Windows.Forms.Padding(2);
            this.rblistacolores.Name = "rblistacolores";
            this.rblistacolores.Size = new System.Drawing.Size(117, 20);
            this.rblistacolores.TabIndex = 34;
            this.rblistacolores.Values.Text = "Elegir desde Lista";
            this.rblistacolores.CheckedChanged += new System.EventHandler(this.rblistacolores_CheckedChanged);
            // 
            // cbcoloresba
            // 
            this.cbcoloresba.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbcoloresba.DropDownWidth = 139;
            this.cbcoloresba.Location = new System.Drawing.Point(133, 22);
            this.cbcoloresba.Margin = new System.Windows.Forms.Padding(2);
            this.cbcoloresba.Name = "cbcoloresba";
            this.cbcoloresba.Size = new System.Drawing.Size(132, 21);
            this.cbcoloresba.TabIndex = 33;
            this.cbcoloresba.SelectedIndexChanged += new System.EventHandler(this.cbcoloresba_SelectedIndexChanged);
            // 
            // lbcolor
            // 
            this.lbcolor.Location = new System.Drawing.Point(129, 87);
            this.lbcolor.Name = "lbcolor";
            this.lbcolor.Size = new System.Drawing.Size(40, 20);
            this.lbcolor.TabIndex = 32;
            this.lbcolor.Values.Text = "Color";
            // 
            // txtcolor
            // 
            this.txtcolor.Location = new System.Drawing.Point(175, 87);
            this.txtcolor.Name = "txtcolor";
            this.txtcolor.Size = new System.Drawing.Size(90, 23);
            this.txtcolor.TabIndex = 31;
            this.txtcolor.TextChanged += new System.EventHandler(this.txtcolor_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.kryptonLabel2);
            this.groupBox1.Controls.Add(this.rbtallapersonaliz);
            this.groupBox1.Controls.Add(this.txtmedida);
            this.groupBox1.Controls.Add(this.lbmedida);
            this.groupBox1.Controls.Add(this.rbcomboTallas);
            this.groupBox1.Controls.Add(this.txtcantidad);
            this.groupBox1.Controls.Add(this.comboTallas);
            this.groupBox1.Location = new System.Drawing.Point(2, 2);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(282, 180);
            this.groupBox1.TabIndex = 28;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Talla";
            // 
            // kryptonLabel2
            // 
            this.kryptonLabel2.Location = new System.Drawing.Point(27, 141);
            this.kryptonLabel2.Margin = new System.Windows.Forms.Padding(2);
            this.kryptonLabel2.Name = "kryptonLabel2";
            this.kryptonLabel2.Size = new System.Drawing.Size(59, 20);
            this.kryptonLabel2.TabIndex = 3;
            this.kryptonLabel2.Values.Text = "Cantidad";
            // 
            // rbtallapersonaliz
            // 
            this.rbtallapersonaliz.Location = new System.Drawing.Point(14, 87);
            this.rbtallapersonaliz.Margin = new System.Windows.Forms.Padding(2);
            this.rbtallapersonaliz.Name = "rbtallapersonaliz";
            this.rbtallapersonaliz.Size = new System.Drawing.Size(98, 20);
            this.rbtallapersonaliz.TabIndex = 27;
            this.rbtallapersonaliz.Values.Text = "Personalizado";
            this.rbtallapersonaliz.CheckedChanged += new System.EventHandler(this.rbtallapersonaliz_CheckedChanged);
            // 
            // txtmedida
            // 
            this.txtmedida.Location = new System.Drawing.Point(169, 87);
            this.txtmedida.Name = "txtmedida";
            this.txtmedida.Size = new System.Drawing.Size(98, 23);
            this.txtmedida.TabIndex = 18;
            this.txtmedida.TextChanged += new System.EventHandler(this.txtmedida_TextChanged);
            // 
            // lbmedida
            // 
            this.lbmedida.Location = new System.Drawing.Point(111, 87);
            this.lbmedida.Name = "lbmedida";
            this.lbmedida.Size = new System.Drawing.Size(52, 20);
            this.lbmedida.TabIndex = 24;
            this.lbmedida.Values.Text = "Medida";
            // 
            // rbcomboTallas
            // 
            this.rbcomboTallas.Location = new System.Drawing.Point(14, 22);
            this.rbcomboTallas.Margin = new System.Windows.Forms.Padding(2);
            this.rbcomboTallas.Name = "rbcomboTallas";
            this.rbcomboTallas.Size = new System.Drawing.Size(117, 20);
            this.rbcomboTallas.TabIndex = 26;
            this.rbcomboTallas.Values.Text = "Elegir desde Lista";
            this.rbcomboTallas.CheckedChanged += new System.EventHandler(this.rbcomboTallas_CheckedChanged);
            // 
            // txtcantidad
            // 
            this.txtcantidad.Location = new System.Drawing.Point(107, 141);
            this.txtcantidad.Margin = new System.Windows.Forms.Padding(2);
            this.txtcantidad.Name = "txtcantidad";
            this.txtcantidad.Size = new System.Drawing.Size(160, 23);
            this.txtcantidad.TabIndex = 2;
            this.txtcantidad.Text = "0";
            // 
            // comboTallas
            // 
            this.comboTallas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboTallas.DropDownWidth = 139;
            this.comboTallas.Location = new System.Drawing.Point(139, 22);
            this.comboTallas.Margin = new System.Windows.Forms.Padding(2);
            this.comboTallas.Name = "comboTallas";
            this.comboTallas.Size = new System.Drawing.Size(128, 21);
            this.comboTallas.TabIndex = 25;
            this.comboTallas.SelectedIndexChanged += new System.EventHandler(this.comboTallas_SelectedIndexChanged);
            // 
            // dgvcolorestallas
            // 
            this.dgvcolorestallas.AllowUserToAddRows = false;
            this.dgvcolorestallas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvcolorestallas.Location = new System.Drawing.Point(2, 192);
            this.dgvcolorestallas.Margin = new System.Windows.Forms.Padding(2);
            this.dgvcolorestallas.Name = "dgvcolorestallas";
            this.dgvcolorestallas.ReadOnly = true;
            this.dgvcolorestallas.RowHeadersWidth = 51;
            this.dgvcolorestallas.RowTemplate.Height = 24;
            this.dgvcolorestallas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvcolorestallas.Size = new System.Drawing.Size(592, 179);
            this.dgvcolorestallas.TabIndex = 7;
            this.dgvcolorestallas.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.dgvcolorestallas_UserDeletingRow);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 184F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 54.03423F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45.96577F));
            this.tableLayoutPanel2.Controls.Add(this.btnagregar, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(2, 375);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(592, 86);
            this.tableLayoutPanel2.TabIndex = 8;
            // 
            // btnagregar
            // 
            this.btnagregar.Location = new System.Drawing.Point(186, 2);
            this.btnagregar.Margin = new System.Windows.Forms.Padding(2);
            this.btnagregar.Name = "btnagregar";
            this.btnagregar.Size = new System.Drawing.Size(130, 35);
            this.btnagregar.TabIndex = 6;
            this.btnagregar.Values.Text = "Agregar";
            this.btnagregar.Click += new System.EventHandler(this.btnagregar_Click);
            // 
            // AgregarColorTallaEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(596, 496);
            this.Controls.Add(this.kryptonPanel1);
            this.Controls.Add(this.toolStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AgregarColorTallaEdit";
            this.Text = "Editar Color Talla";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AgregarColorTalla_FormClosing);
            this.Load += new System.EventHandler(this.AgregarColorTallaEdit_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).EndInit();
            this.kryptonPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbcoloresba)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.comboTallas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvcolorestallas)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnAgregarlista;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private ComponentFactory.Krypton.Toolkit.KryptonRadioButton rbtallapersonaliz;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel2;
        private ComponentFactory.Krypton.Toolkit.KryptonRadioButton rbcomboTallas;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox comboTallas;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtcantidad;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lbmedida;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtmedida;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView dgvcolorestallas;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnagregar;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private ComponentFactory.Krypton.Toolkit.KryptonRadioButton rbcolorespaleta;
        private ComponentFactory.Krypton.Toolkit.KryptonRadioButton rbcolorespersonal;
        private ComponentFactory.Krypton.Toolkit.KryptonRadioButton rblistacolores;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox cbcoloresba;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lbcolor;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtcolor;
        private System.Windows.Forms.ColorDialog Colorpaleta;
        private System.Windows.Forms.Button btPaleta;
    }
}