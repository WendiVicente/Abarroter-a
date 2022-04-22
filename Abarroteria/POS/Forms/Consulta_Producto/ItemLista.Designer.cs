
namespace POS.Forms
{
    partial class ItemLista
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
            this.tblItem = new System.Windows.Forms.TableLayoutPanel();
            this.tblProducto = new System.Windows.Forms.TableLayoutPanel();
            this.pbProducto = new System.Windows.Forms.PictureBox();
            this.pnlDetalleProdcuto = new System.Windows.Forms.Panel();
            this.kryptonButton1 = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnVender = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.tblDetalle = new System.Windows.Forms.TableLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbExistencias = new System.Windows.Forms.Label();
            this.lbPrecioVenta = new System.Windows.Forms.Label();
            this.lbCodigo = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbNombreProducto = new System.Windows.Forms.Label();
            this.tblItem.SuspendLayout();
            this.tblProducto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbProducto)).BeginInit();
            this.pnlDetalleProdcuto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.tblDetalle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tblItem
            // 
            this.tblItem.BackColor = System.Drawing.Color.White;
            this.tblItem.ColumnCount = 1;
            this.tblItem.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblItem.Controls.Add(this.tblProducto, 0, 0);
            this.tblItem.Location = new System.Drawing.Point(12, 12);
            this.tblItem.Name = "tblItem";
            this.tblItem.RowCount = 1;
            this.tblItem.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblItem.Size = new System.Drawing.Size(900, 147);
            this.tblItem.TabIndex = 0;
            // 
            // tblProducto
            // 
            this.tblProducto.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.tblProducto.ColumnCount = 2;
            this.tblProducto.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.02237F));
            this.tblProducto.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 79.97763F));
            this.tblProducto.Controls.Add(this.pbProducto, 0, 0);
            this.tblProducto.Controls.Add(this.pnlDetalleProdcuto, 1, 0);
            this.tblProducto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblProducto.Location = new System.Drawing.Point(3, 3);
            this.tblProducto.Name = "tblProducto";
            this.tblProducto.RowCount = 1;
            this.tblProducto.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblProducto.Size = new System.Drawing.Size(894, 141);
            this.tblProducto.TabIndex = 0;
            // 
            // pbProducto
            // 
            this.pbProducto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbProducto.Location = new System.Drawing.Point(3, 3);
            this.pbProducto.Name = "pbProducto";
            this.pbProducto.Size = new System.Drawing.Size(172, 135);
            this.pbProducto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbProducto.TabIndex = 0;
            this.pbProducto.TabStop = false;
            // 
            // pnlDetalleProdcuto
            // 
            this.pnlDetalleProdcuto.Controls.Add(this.kryptonButton1);
            this.pnlDetalleProdcuto.Controls.Add(this.btnVender);
            this.pnlDetalleProdcuto.Controls.Add(this.pictureBox3);
            this.pnlDetalleProdcuto.Controls.Add(this.pictureBox2);
            this.pnlDetalleProdcuto.Controls.Add(this.tblDetalle);
            this.pnlDetalleProdcuto.Controls.Add(this.pictureBox1);
            this.pnlDetalleProdcuto.Controls.Add(this.lbNombreProducto);
            this.pnlDetalleProdcuto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlDetalleProdcuto.Location = new System.Drawing.Point(181, 3);
            this.pnlDetalleProdcuto.Name = "pnlDetalleProdcuto";
            this.pnlDetalleProdcuto.Size = new System.Drawing.Size(710, 135);
            this.pnlDetalleProdcuto.TabIndex = 1;
            // 
            // kryptonButton1
            // 
            this.kryptonButton1.Location = new System.Drawing.Point(651, 9);
            this.kryptonButton1.Name = "kryptonButton1";
            this.kryptonButton1.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2007Blue;
            this.kryptonButton1.Size = new System.Drawing.Size(56, 34);
            this.kryptonButton1.TabIndex = 6;
            this.kryptonButton1.Values.Text = "P";
            // 
            // btnVender
            // 
            this.btnVender.Location = new System.Drawing.Point(651, 49);
            this.btnVender.Name = "btnVender";
            this.btnVender.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2007Blue;
            this.btnVender.Size = new System.Drawing.Size(56, 50);
            this.btnVender.TabIndex = 5;
            this.btnVender.Values.Text = "Vender";
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.pictureBox3.Location = new System.Drawing.Point(677, 99);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(5, 30);
            this.pictureBox3.TabIndex = 4;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.pictureBox2.Location = new System.Drawing.Point(0, 127);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(682, 5);
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // tblDetalle
            // 
            this.tblDetalle.ColumnCount = 3;
            this.tblDetalle.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 44.94773F));
            this.tblDetalle.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 55.05227F));
            this.tblDetalle.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 210F));
            this.tblDetalle.Controls.Add(this.label2, 0, 0);
            this.tblDetalle.Controls.Add(this.label3, 1, 0);
            this.tblDetalle.Controls.Add(this.label4, 2, 0);
            this.tblDetalle.Controls.Add(this.lbExistencias, 0, 1);
            this.tblDetalle.Controls.Add(this.lbPrecioVenta, 1, 1);
            this.tblDetalle.Controls.Add(this.lbCodigo, 2, 1);
            this.tblDetalle.Location = new System.Drawing.Point(16, 57);
            this.tblDetalle.Name = "tblDetalle";
            this.tblDetalle.RowCount = 2;
            this.tblDetalle.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 41.30435F));
            this.tblDetalle.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 58.69565F));
            this.tblDetalle.Size = new System.Drawing.Size(629, 46);
            this.tblDetalle.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(182, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "Existencias";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(191, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(224, 19);
            this.label3.TabIndex = 1;
            this.label3.Text = "P/Venta";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.label4.Location = new System.Drawing.Point(421, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(205, 19);
            this.label4.TabIndex = 2;
            this.label4.Text = "Código";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbExistencias
            // 
            this.lbExistencias.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbExistencias.AutoSize = true;
            this.lbExistencias.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.lbExistencias.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbExistencias.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbExistencias.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.lbExistencias.Location = new System.Drawing.Point(3, 19);
            this.lbExistencias.Name = "lbExistencias";
            this.lbExistencias.Size = new System.Drawing.Size(182, 27);
            this.lbExistencias.TabIndex = 4;
            this.lbExistencias.Text = "0";
            this.lbExistencias.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbPrecioVenta
            // 
            this.lbPrecioVenta.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbPrecioVenta.AutoSize = true;
            this.lbPrecioVenta.BackColor = System.Drawing.SystemColors.Control;
            this.lbPrecioVenta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbPrecioVenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPrecioVenta.ForeColor = System.Drawing.Color.Red;
            this.lbPrecioVenta.Location = new System.Drawing.Point(191, 19);
            this.lbPrecioVenta.Name = "lbPrecioVenta";
            this.lbPrecioVenta.Size = new System.Drawing.Size(224, 27);
            this.lbPrecioVenta.TabIndex = 5;
            this.lbPrecioVenta.Text = "Q 0.00";
            this.lbPrecioVenta.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbCodigo
            // 
            this.lbCodigo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbCodigo.AutoSize = true;
            this.lbCodigo.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.lbCodigo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCodigo.Location = new System.Drawing.Point(421, 19);
            this.lbCodigo.Name = "lbCodigo";
            this.lbCodigo.Size = new System.Drawing.Size(205, 27);
            this.lbCodigo.TabIndex = 6;
            this.lbCodigo.Text = "0000000000000";
            this.lbCodigo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.pictureBox1.Location = new System.Drawing.Point(16, 41);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(629, 10);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // lbNombreProducto
            // 
            this.lbNombreProducto.AutoSize = true;
            this.lbNombreProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNombreProducto.Location = new System.Drawing.Point(16, 18);
            this.lbNombreProducto.Name = "lbNombreProducto";
            this.lbNombreProducto.Size = new System.Drawing.Size(181, 18);
            this.lbNombreProducto.TabIndex = 0;
            this.lbNombreProducto.Text = "NOMBRE PRODUCTO";
            // 
            // ItemLista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(920, 248);
            this.Controls.Add(this.tblItem);
            this.Name = "ItemLista";
            this.Text = "ItemLista";
            this.tblItem.ResumeLayout(false);
            this.tblProducto.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbProducto)).EndInit();
            this.pnlDetalleProdcuto.ResumeLayout(false);
            this.pnlDetalleProdcuto.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.tblDetalle.ResumeLayout(false);
            this.tblDetalle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel tblProducto;
        private System.Windows.Forms.PictureBox pbProducto;
        public System.Windows.Forms.TableLayoutPanel tblItem;
        private System.Windows.Forms.Panel pnlDetalleProdcuto;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnVender;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TableLayoutPanel tblDetalle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbExistencias;
        private System.Windows.Forms.Label lbPrecioVenta;
        private System.Windows.Forms.Label lbCodigo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbNombreProducto;
        private ComponentFactory.Krypton.Toolkit.KryptonButton kryptonButton1;
    }
}