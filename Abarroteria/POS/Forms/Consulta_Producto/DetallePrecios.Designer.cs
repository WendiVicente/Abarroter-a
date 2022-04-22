
namespace POS.Forms
{
    partial class DetallePrecios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DetallePrecios));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.gbPreciosVarios = new System.Windows.Forms.GroupBox();
            this.lbNombreProducto = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel4 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.txtPrecioMinimo = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.txtPrecioEspecial = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.txtPrecioGeneral = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.kryptonLabel2 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel1 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel22 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.dgvEscalas = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbCantidadEscalas = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.gbPreciosVarios.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEscalas)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.White;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.dgvEscalas, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 164F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(546, 378);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.gbPreciosVarios);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(540, 163);
            this.panel1.TabIndex = 0;
            // 
            // gbPreciosVarios
            // 
            this.gbPreciosVarios.Controls.Add(this.lbNombreProducto);
            this.gbPreciosVarios.Controls.Add(this.kryptonLabel4);
            this.gbPreciosVarios.Controls.Add(this.txtPrecioMinimo);
            this.gbPreciosVarios.Controls.Add(this.txtPrecioEspecial);
            this.gbPreciosVarios.Controls.Add(this.txtPrecioGeneral);
            this.gbPreciosVarios.Controls.Add(this.kryptonLabel2);
            this.gbPreciosVarios.Controls.Add(this.kryptonLabel1);
            this.gbPreciosVarios.Controls.Add(this.kryptonLabel22);
            this.gbPreciosVarios.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbPreciosVarios.ForeColor = System.Drawing.Color.MidnightBlue;
            this.gbPreciosVarios.Location = new System.Drawing.Point(10, 6);
            this.gbPreciosVarios.Name = "gbPreciosVarios";
            this.gbPreciosVarios.Size = new System.Drawing.Size(521, 143);
            this.gbPreciosVarios.TabIndex = 0;
            this.gbPreciosVarios.TabStop = false;
            this.gbPreciosVarios.Text = "Precios Varios";
            // 
            // lbNombreProducto
            // 
            this.lbNombreProducto.Location = new System.Drawing.Point(154, 32);
            this.lbNombreProducto.Name = "lbNombreProducto";
            this.lbNombreProducto.Size = new System.Drawing.Size(6, 2);
            this.lbNombreProducto.TabIndex = 66;
            this.lbNombreProducto.Values.Text = "";
            // 
            // kryptonLabel4
            // 
            this.kryptonLabel4.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.BoldControl;
            this.kryptonLabel4.Location = new System.Drawing.Point(17, 32);
            this.kryptonLabel4.Name = "kryptonLabel4";
            this.kryptonLabel4.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2007Blue;
            this.kryptonLabel4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.kryptonLabel4.Size = new System.Drawing.Size(140, 20);
            this.kryptonLabel4.TabIndex = 65;
            this.kryptonLabel4.Values.Text = "Nombre del Producto:";
            // 
            // txtPrecioMinimo
            // 
            this.txtPrecioMinimo.Location = new System.Drawing.Point(110, 108);
            this.txtPrecioMinimo.Name = "txtPrecioMinimo";
            this.txtPrecioMinimo.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2007Blue;
            this.txtPrecioMinimo.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtPrecioMinimo.Size = new System.Drawing.Size(125, 23);
            this.txtPrecioMinimo.TabIndex = 64;
            this.txtPrecioMinimo.Text = "0.00";
            // 
            // txtPrecioEspecial
            // 
            this.txtPrecioEspecial.Location = new System.Drawing.Point(347, 69);
            this.txtPrecioEspecial.Name = "txtPrecioEspecial";
            this.txtPrecioEspecial.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2007Blue;
            this.txtPrecioEspecial.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtPrecioEspecial.Size = new System.Drawing.Size(148, 23);
            this.txtPrecioEspecial.TabIndex = 63;
            this.txtPrecioEspecial.Text = "0.00";
            // 
            // txtPrecioGeneral
            // 
            this.txtPrecioGeneral.Location = new System.Drawing.Point(110, 68);
            this.txtPrecioGeneral.Name = "txtPrecioGeneral";
            this.txtPrecioGeneral.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2007Blue;
            this.txtPrecioGeneral.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtPrecioGeneral.Size = new System.Drawing.Size(125, 23);
            this.txtPrecioGeneral.TabIndex = 61;
            this.txtPrecioGeneral.Text = "0.00";
            // 
            // kryptonLabel2
            // 
            this.kryptonLabel2.Location = new System.Drawing.Point(252, 70);
            this.kryptonLabel2.Name = "kryptonLabel2";
            this.kryptonLabel2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.kryptonLabel2.Size = new System.Drawing.Size(91, 20);
            this.kryptonLabel2.TabIndex = 59;
            this.kryptonLabel2.Values.Text = "Precio Especial";
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.Location = new System.Drawing.Point(15, 108);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.kryptonLabel1.Size = new System.Drawing.Size(89, 20);
            this.kryptonLabel1.TabIndex = 58;
            this.kryptonLabel1.Values.Text = "Precio Mínimo";
            // 
            // kryptonLabel22
            // 
            this.kryptonLabel22.Location = new System.Drawing.Point(15, 68);
            this.kryptonLabel22.Name = "kryptonLabel22";
            this.kryptonLabel22.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.kryptonLabel22.Size = new System.Drawing.Size(89, 20);
            this.kryptonLabel22.TabIndex = 57;
            this.kryptonLabel22.Values.Text = "Precio General";
            // 
            // dgvEscalas
            // 
            this.dgvEscalas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEscalas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvEscalas.Location = new System.Drawing.Point(3, 172);
            this.dgvEscalas.Name = "dgvEscalas";
            this.dgvEscalas.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2007Blue;
            this.dgvEscalas.Size = new System.Drawing.Size(540, 158);
            this.dgvEscalas.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lbCantidadEscalas);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 336);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(540, 39);
            this.panel2.TabIndex = 2;
            // 
            // lbCantidadEscalas
            // 
            this.lbCantidadEscalas.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.BoldControl;
            this.lbCantidadEscalas.Location = new System.Drawing.Point(278, 10);
            this.lbCantidadEscalas.Name = "lbCantidadEscalas";
            this.lbCantidadEscalas.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbCantidadEscalas.Size = new System.Drawing.Size(138, 20);
            this.lbCantidadEscalas.TabIndex = 67;
            this.lbCantidadEscalas.Values.Text = "Cantidad de Escalas: 0";
            // 
            // DetallePrecios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(546, 378);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DetallePrecios";
            this.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2007Blue;
            this.Text = "Detalle de precios";
            this.Load += new System.EventHandler(this.DetallePrecios_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.gbPreciosVarios.ResumeLayout(false);
            this.gbPreciosVarios.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEscalas)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView dgvEscalas;
        private System.Windows.Forms.GroupBox gbPreciosVarios;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtPrecioMinimo;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtPrecioEspecial;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtPrecioGeneral;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel2;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel22;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lbNombreProducto;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel4;
        private System.Windows.Forms.Panel panel2;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lbCantidadEscalas;
    }
}