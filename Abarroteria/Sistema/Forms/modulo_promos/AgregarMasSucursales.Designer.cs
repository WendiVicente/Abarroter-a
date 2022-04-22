namespace Sistema.Forms.modulo_promos
{
    partial class AgregarMasSucursales
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnaddTipos = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.cklistbox = new System.Windows.Forms.CheckedListBox();
            this.kryptonPanel2 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel2)).BeginInit();
            this.kryptonPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 58.16327F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 41.83673F));
            this.tableLayoutPanel1.Controls.Add(this.btnaddTipos, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.cklistbox, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 44F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(447, 241);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // btnaddTipos
            // 
            this.btnaddTipos.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnaddTipos.Location = new System.Drawing.Point(262, 200);
            this.btnaddTipos.Name = "btnaddTipos";
            this.btnaddTipos.Size = new System.Drawing.Size(182, 35);
            this.btnaddTipos.TabIndex = 1;
            this.btnaddTipos.Values.Text = "Agregar al Reporte";
            this.btnaddTipos.Click += new System.EventHandler(this.btnaddTipos_Click);
            // 
            // cklistbox
            // 
            this.cklistbox.CheckOnClick = true;
            this.cklistbox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cklistbox.FormattingEnabled = true;
            this.cklistbox.Location = new System.Drawing.Point(3, 3);
            this.cklistbox.Name = "cklistbox";
            this.cklistbox.Size = new System.Drawing.Size(253, 191);
            this.cklistbox.TabIndex = 0;
            // 
            // kryptonPanel2
            // 
            this.kryptonPanel2.Controls.Add(this.tableLayoutPanel1);
            this.kryptonPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanel2.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel2.Name = "kryptonPanel2";
            this.kryptonPanel2.Size = new System.Drawing.Size(447, 241);
            this.kryptonPanel2.TabIndex = 3;
            // 
            // AgregarMasSucursales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(447, 241);
            this.Controls.Add(this.kryptonPanel2);
            this.Name = "AgregarMasSucursales";
            this.Text = "AgregarMasSucursales";
            this.Load += new System.EventHandler(this.AgregarMasSucursales_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel2)).EndInit();
            this.kryptonPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnaddTipos;
        private System.Windows.Forms.CheckedListBox cklistbox;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel2;
    }
}