
namespace POS.Forms
{
    partial class ProductoGrano
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductoGrano));
            this.pnlDetalle = new System.Windows.Forms.Panel();
            this.StockActual = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.lbUMedida = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlGrano = new System.Windows.Forms.Panel();
            this.kryptonLabel3 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel2 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel1 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.lbPrecioOnz = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.lbPrecioLb = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.lbPrecioQ = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.CheckQuintal = new ComponentFactory.Krypton.Toolkit.KryptonRadioButton();
            this.CheckOnza = new ComponentFactory.Krypton.Toolkit.KryptonRadioButton();
            this.CheckLibra = new ComponentFactory.Krypton.Toolkit.KryptonRadioButton();
            this.BtnAceptar = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.lbProd = new System.Windows.Forms.Label();
            this.lbTotal = new System.Windows.Forms.Label();
            this.lb = new System.Windows.Forms.Label();
            this.label = new System.Windows.Forms.Label();
            this.TxtCantidad = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.pnlDetalle.SuspendLayout();
            this.pnlGrano.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlDetalle
            // 
            this.pnlDetalle.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnlDetalle.Controls.Add(this.StockActual);
            this.pnlDetalle.Controls.Add(this.lbUMedida);
            this.pnlDetalle.Controls.Add(this.label1);
            this.pnlDetalle.Controls.Add(this.pnlGrano);
            this.pnlDetalle.Controls.Add(this.BtnAceptar);
            this.pnlDetalle.Controls.Add(this.lbProd);
            this.pnlDetalle.Controls.Add(this.lbTotal);
            this.pnlDetalle.Controls.Add(this.lb);
            this.pnlDetalle.Controls.Add(this.label);
            this.pnlDetalle.Controls.Add(this.TxtCantidad);
            this.pnlDetalle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlDetalle.Location = new System.Drawing.Point(0, 0);
            this.pnlDetalle.Name = "pnlDetalle";
            this.pnlDetalle.Size = new System.Drawing.Size(549, 178);
            this.pnlDetalle.TabIndex = 40;
            // 
            // StockActual
            // 
            this.StockActual.Location = new System.Drawing.Point(206, 131);
            this.StockActual.Name = "StockActual";
            this.StockActual.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2007Blue;
            this.StockActual.ReadOnly = true;
            this.StockActual.Size = new System.Drawing.Size(169, 23);
            this.StockActual.TabIndex = 100;
            this.StockActual.Text = "0";
            this.StockActual.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lbUMedida
            // 
            this.lbUMedida.AutoSize = true;
            this.lbUMedida.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUMedida.Location = new System.Drawing.Point(8, 29);
            this.lbUMedida.Name = "lbUMedida";
            this.lbUMedida.Size = new System.Drawing.Size(54, 16);
            this.lbUMedida.TabIndex = 99;
            this.lbUMedida.Text = "Medida";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 16);
            this.label1.TabIndex = 98;
            this.label1.Text = "Unidad de Medida";
            // 
            // pnlGrano
            // 
            this.pnlGrano.Controls.Add(this.kryptonLabel3);
            this.pnlGrano.Controls.Add(this.kryptonLabel2);
            this.pnlGrano.Controls.Add(this.kryptonLabel1);
            this.pnlGrano.Controls.Add(this.lbPrecioOnz);
            this.pnlGrano.Controls.Add(this.lbPrecioLb);
            this.pnlGrano.Controls.Add(this.lbPrecioQ);
            this.pnlGrano.Controls.Add(this.CheckQuintal);
            this.pnlGrano.Controls.Add(this.CheckOnza);
            this.pnlGrano.Controls.Add(this.CheckLibra);
            this.pnlGrano.Location = new System.Drawing.Point(35, 85);
            this.pnlGrano.Name = "pnlGrano";
            this.pnlGrano.Size = new System.Drawing.Size(165, 69);
            this.pnlGrano.TabIndex = 97;
            // 
            // kryptonLabel3
            // 
            this.kryptonLabel3.Location = new System.Drawing.Point(60, 45);
            this.kryptonLabel3.Name = "kryptonLabel3";
            this.kryptonLabel3.Size = new System.Drawing.Size(20, 20);
            this.kryptonLabel3.TabIndex = 57;
            this.kryptonLabel3.Values.Text = "Q";
            // 
            // kryptonLabel2
            // 
            this.kryptonLabel2.Location = new System.Drawing.Point(60, 24);
            this.kryptonLabel2.Name = "kryptonLabel2";
            this.kryptonLabel2.Size = new System.Drawing.Size(20, 20);
            this.kryptonLabel2.TabIndex = 56;
            this.kryptonLabel2.Values.Text = "Q";
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.Location = new System.Drawing.Point(60, 3);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.Size = new System.Drawing.Size(20, 20);
            this.kryptonLabel1.TabIndex = 55;
            this.kryptonLabel1.Values.Text = "Q";
            // 
            // lbPrecioOnz
            // 
            this.lbPrecioOnz.Location = new System.Drawing.Point(78, 46);
            this.lbPrecioOnz.Name = "lbPrecioOnz";
            this.lbPrecioOnz.Size = new System.Drawing.Size(33, 20);
            this.lbPrecioOnz.TabIndex = 54;
            this.lbPrecioOnz.Values.Text = "0.00";
            // 
            // lbPrecioLb
            // 
            this.lbPrecioLb.Location = new System.Drawing.Point(78, 24);
            this.lbPrecioLb.Name = "lbPrecioLb";
            this.lbPrecioLb.Size = new System.Drawing.Size(33, 20);
            this.lbPrecioLb.TabIndex = 53;
            this.lbPrecioLb.Values.Text = "0.00";
            // 
            // lbPrecioQ
            // 
            this.lbPrecioQ.Location = new System.Drawing.Point(78, 3);
            this.lbPrecioQ.Name = "lbPrecioQ";
            this.lbPrecioQ.Size = new System.Drawing.Size(33, 20);
            this.lbPrecioQ.TabIndex = 52;
            this.lbPrecioQ.Values.Text = "0.00";
            // 
            // CheckQuintal
            // 
            this.CheckQuintal.Location = new System.Drawing.Point(3, 2);
            this.CheckQuintal.Margin = new System.Windows.Forms.Padding(2);
            this.CheckQuintal.Name = "CheckQuintal";
            this.CheckQuintal.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2007Blue;
            this.CheckQuintal.Size = new System.Drawing.Size(60, 20);
            this.CheckQuintal.TabIndex = 51;
            this.CheckQuintal.Values.Text = "quintal";
            this.CheckQuintal.CheckedChanged += new System.EventHandler(this.CheckQuintal_CheckedChanged);
            // 
            // CheckOnza
            // 
            this.CheckOnza.Location = new System.Drawing.Point(3, 45);
            this.CheckOnza.Margin = new System.Windows.Forms.Padding(2);
            this.CheckOnza.Name = "CheckOnza";
            this.CheckOnza.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2007Blue;
            this.CheckOnza.Size = new System.Drawing.Size(54, 20);
            this.CheckOnza.TabIndex = 32;
            this.CheckOnza.Values.Text = "onzas";
            this.CheckOnza.CheckedChanged += new System.EventHandler(this.CheckOnza_CheckedChanged);
            // 
            // CheckLibra
            // 
            this.CheckLibra.Location = new System.Drawing.Point(3, 24);
            this.CheckLibra.Margin = new System.Windows.Forms.Padding(2);
            this.CheckLibra.Name = "CheckLibra";
            this.CheckLibra.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2007Blue;
            this.CheckLibra.Size = new System.Drawing.Size(52, 20);
            this.CheckLibra.TabIndex = 33;
            this.CheckLibra.Values.Text = "libras";
            this.CheckLibra.CheckedChanged += new System.EventHandler(this.CheckLibra_CheckedChanged);
            // 
            // BtnAceptar
            // 
            this.BtnAceptar.Location = new System.Drawing.Point(388, 53);
            this.BtnAceptar.Name = "BtnAceptar";
            this.BtnAceptar.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2007Blue;
            this.BtnAceptar.Size = new System.Drawing.Size(133, 32);
            this.BtnAceptar.TabIndex = 96;
            this.BtnAceptar.Values.Text = "Aceptar";
            this.BtnAceptar.Click += new System.EventHandler(this.BtnAceptar_Click);
            // 
            // lbProd
            // 
            this.lbProd.AutoSize = true;
            this.lbProd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbProd.Location = new System.Drawing.Point(172, 30);
            this.lbProd.Name = "lbProd";
            this.lbProd.Size = new System.Drawing.Size(62, 16);
            this.lbProd.TabIndex = 95;
            this.lbProd.Text = "Producto";
            // 
            // lbTotal
            // 
            this.lbTotal.AutoSize = true;
            this.lbTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTotal.Location = new System.Drawing.Point(203, 109);
            this.lbTotal.Name = "lbTotal";
            this.lbTotal.Size = new System.Drawing.Size(102, 15);
            this.lbTotal.TabIndex = 94;
            this.lbTotal.Text = "Total Existencias ";
            // 
            // lb
            // 
            this.lb.AutoSize = true;
            this.lb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb.Location = new System.Drawing.Point(172, 9);
            this.lb.Name = "lb";
            this.lb.Size = new System.Drawing.Size(155, 16);
            this.lb.TabIndex = 30;
            this.lb.Text = "Nombre del Producto";
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.Location = new System.Drawing.Point(32, 59);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(56, 15);
            this.label.TabIndex = 28;
            this.label.Text = "Cantidad";
            // 
            // TxtCantidad
            // 
            this.TxtCantidad.Location = new System.Drawing.Point(100, 57);
            this.TxtCantidad.Name = "TxtCantidad";
            this.TxtCantidad.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2007Blue;
            this.TxtCantidad.Size = new System.Drawing.Size(275, 23);
            this.TxtCantidad.TabIndex = 29;
            this.TxtCantidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.TxtCantidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtCantidad_KeyPress);
            // 
            // ProductoGrano
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(549, 178);
            this.Controls.Add(this.pnlDetalle);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ProductoGrano";
            this.Text = "Granos";
            this.Load += new System.EventHandler(this.ProductoGrano_Load);
            this.pnlDetalle.ResumeLayout(false);
            this.pnlDetalle.PerformLayout();
            this.pnlGrano.ResumeLayout(false);
            this.pnlGrano.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlDetalle;
        private ComponentFactory.Krypton.Toolkit.KryptonButton BtnAceptar;
        private System.Windows.Forms.Label lbProd;
        private System.Windows.Forms.Label lb;
        private System.Windows.Forms.Label label;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox TxtCantidad;
        private System.Windows.Forms.Label lbTotal;
        private System.Windows.Forms.Label lbUMedida;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlGrano;
        public ComponentFactory.Krypton.Toolkit.KryptonRadioButton CheckQuintal;
        public ComponentFactory.Krypton.Toolkit.KryptonRadioButton CheckOnza;
        public ComponentFactory.Krypton.Toolkit.KryptonRadioButton CheckLibra;
        public ComponentFactory.Krypton.Toolkit.KryptonTextBox StockActual;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lbPrecioOnz;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lbPrecioLb;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lbPrecioQ;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel3;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel2;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel1;
    }
}