
namespace Sistema.Forms.modulo_producto
{
    partial class Importar_data
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Importar_data));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.btnImportar = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.lbActualizados = new System.Windows.Forms.Label();
            this.lbtotal = new System.Windows.Forms.Label();
            this.btnMigrar = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kryptonLabel1 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel2 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel3 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.lbInsertados = new System.Windows.Forms.Label();
            this.btnInsertarNuevos = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.DataDetalles = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataDetalles)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.81215F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 86.18784F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 87F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 450);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 73.17381F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 26.8262F));
            this.tableLayoutPanel2.Controls.Add(this.btnImportar, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(794, 44);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // btnImportar
            // 
            this.btnImportar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnImportar.Location = new System.Drawing.Point(583, 3);
            this.btnImportar.Name = "btnImportar";
            this.btnImportar.Size = new System.Drawing.Size(208, 38);
            this.btnImportar.TabIndex = 0;
            this.btnImportar.Values.Text = "Importar";
            this.btnImportar.Click += new System.EventHandler(this.btnImportar_Click);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 4;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 48.07198F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 51.92802F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 287F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 164F));
            this.tableLayoutPanel3.Controls.Add(this.lbActualizados, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.lbtotal, 3, 0);
            this.tableLayoutPanel3.Controls.Add(this.btnMigrar, 3, 1);
            this.tableLayoutPanel3.Controls.Add(this.kryptonLabel1, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.kryptonLabel2, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.kryptonLabel3, 2, 0);
            this.tableLayoutPanel3.Controls.Add(this.lbInsertados, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.btnInsertarNuevos, 2, 1);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 365);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 51.21951F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 48.78049F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(794, 82);
            this.tableLayoutPanel3.TabIndex = 1;
            this.tableLayoutPanel3.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel3_Paint);
            // 
            // lbActualizados
            // 
            this.lbActualizados.AutoSize = true;
            this.lbActualizados.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbActualizados.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbActualizados.Location = new System.Drawing.Point(167, 41);
            this.lbActualizados.Name = "lbActualizados";
            this.lbActualizados.Size = new System.Drawing.Size(172, 41);
            this.lbActualizados.TabIndex = 6;
            this.lbActualizados.Text = "0";
            this.lbActualizados.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbtotal
            // 
            this.lbtotal.AutoSize = true;
            this.lbtotal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbtotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbtotal.Location = new System.Drawing.Point(632, 0);
            this.lbtotal.Name = "lbtotal";
            this.lbtotal.Size = new System.Drawing.Size(159, 41);
            this.lbtotal.TabIndex = 5;
            this.lbtotal.Text = "0";
            this.lbtotal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnMigrar
            // 
            this.btnMigrar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnMigrar.Location = new System.Drawing.Point(632, 44);
            this.btnMigrar.Name = "btnMigrar";
            this.btnMigrar.Size = new System.Drawing.Size(159, 35);
            this.btnMigrar.TabIndex = 0;
            this.btnMigrar.Values.Text = "Migrar";
            this.btnMigrar.Click += new System.EventHandler(this.btnMigrar_Click);
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonLabel1.Location = new System.Drawing.Point(3, 3);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.kryptonLabel1.Size = new System.Drawing.Size(158, 35);
            this.kryptonLabel1.TabIndex = 1;
            this.kryptonLabel1.Values.Text = "Insertados";
            // 
            // kryptonLabel2
            // 
            this.kryptonLabel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonLabel2.Location = new System.Drawing.Point(3, 44);
            this.kryptonLabel2.Name = "kryptonLabel2";
            this.kryptonLabel2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.kryptonLabel2.Size = new System.Drawing.Size(158, 35);
            this.kryptonLabel2.TabIndex = 2;
            this.kryptonLabel2.Values.Text = "Actualizados";
            // 
            // kryptonLabel3
            // 
            this.kryptonLabel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonLabel3.Location = new System.Drawing.Point(345, 3);
            this.kryptonLabel3.Name = "kryptonLabel3";
            this.kryptonLabel3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.kryptonLabel3.Size = new System.Drawing.Size(281, 35);
            this.kryptonLabel3.TabIndex = 3;
            this.kryptonLabel3.Values.Text = "Total";
            // 
            // lbInsertados
            // 
            this.lbInsertados.AutoSize = true;
            this.lbInsertados.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbInsertados.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbInsertados.Location = new System.Drawing.Point(167, 0);
            this.lbInsertados.Name = "lbInsertados";
            this.lbInsertados.Size = new System.Drawing.Size(172, 41);
            this.lbInsertados.TabIndex = 4;
            this.lbInsertados.Text = "0";
            this.lbInsertados.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnInsertarNuevos
            // 
            this.btnInsertarNuevos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnInsertarNuevos.Location = new System.Drawing.Point(345, 44);
            this.btnInsertarNuevos.Name = "btnInsertarNuevos";
            this.btnInsertarNuevos.Size = new System.Drawing.Size(281, 35);
            this.btnInsertarNuevos.TabIndex = 7;
            this.btnInsertarNuevos.Values.Text = "Insertar Nuevos";
            this.btnInsertarNuevos.Click += new System.EventHandler(this.btnInsertarNuevos_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.DataDetalles);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 53);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(794, 306);
            this.panel1.TabIndex = 2;
            // 
            // DataDetalles
            // 
            this.DataDetalles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataDetalles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DataDetalles.Location = new System.Drawing.Point(0, 0);
            this.DataDetalles.Name = "DataDetalles";
            this.DataDetalles.Size = new System.Drawing.Size(794, 306);
            this.DataDetalles.TabIndex = 0;
            // 
            // Importar_data
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Importar_data";
            this.Text = "Importar_data";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DataDetalles)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnImportar;
        private System.Windows.Forms.Panel panel1;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView DataDetalles;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label lbActualizados;
        private System.Windows.Forms.Label lbtotal;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnMigrar;
        protected internal ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel2;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel3;
        private System.Windows.Forms.Label lbInsertados;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnInsertarNuevos;
    }
}