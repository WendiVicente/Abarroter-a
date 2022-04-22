namespace Sistema.Forms.modulo_usurios
{
    partial class VerUsuarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VerUsuarios));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnEliminar = new System.Windows.Forms.ToolStripButton();
            this.kryptonPanel1 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.dgvusuarios = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.userBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isDeletedDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.sucursalIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.privilegiosDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sucursalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.facturasDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.transaccionesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.notaPagosDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailConfirmedDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.passwordHashDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.securityStampDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneNumberConfirmedDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.twoFactorEnabledDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.lockoutEndDateUtcDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lockoutEnabledDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.accessFailedCountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rolesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.claimsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.loginsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).BeginInit();
            this.kryptonPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvusuarios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnEliminar});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(945, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnEliminar
            // 
            this.btnEliminar.Image = ((System.Drawing.Image)(resources.GetObject("btnEliminar.Image")));
            this.btnEliminar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(70, 22);
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // kryptonPanel1
            // 
            this.kryptonPanel1.Controls.Add(this.dgvusuarios);
            this.kryptonPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanel1.Location = new System.Drawing.Point(0, 25);
            this.kryptonPanel1.Name = "kryptonPanel1";
            this.kryptonPanel1.Size = new System.Drawing.Size(945, 426);
            this.kryptonPanel1.TabIndex = 1;
            // 
            // dgvusuarios
            // 
            this.dgvusuarios.AllowUserToAddRows = false;
            this.dgvusuarios.AllowUserToDeleteRows = false;
            this.dgvusuarios.AutoGenerateColumns = false;
            this.dgvusuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvusuarios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn,
            this.isDeletedDataGridViewCheckBoxColumn,
            this.sucursalIdDataGridViewTextBoxColumn,
            this.privilegiosDataGridViewTextBoxColumn,
            this.sucursalDataGridViewTextBoxColumn,
            this.facturasDataGridViewTextBoxColumn,
            this.transaccionesDataGridViewTextBoxColumn,
            this.valesDataGridViewTextBoxColumn,
            this.notaPagosDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.emailConfirmedDataGridViewCheckBoxColumn,
            this.passwordHashDataGridViewTextBoxColumn,
            this.securityStampDataGridViewTextBoxColumn,
            this.phoneNumberDataGridViewTextBoxColumn,
            this.phoneNumberConfirmedDataGridViewCheckBoxColumn,
            this.twoFactorEnabledDataGridViewCheckBoxColumn,
            this.lockoutEndDateUtcDataGridViewTextBoxColumn,
            this.lockoutEnabledDataGridViewCheckBoxColumn,
            this.accessFailedCountDataGridViewTextBoxColumn,
            this.rolesDataGridViewTextBoxColumn,
            this.claimsDataGridViewTextBoxColumn,
            this.loginsDataGridViewTextBoxColumn,
            this.idDataGridViewTextBoxColumn,
            this.userNameDataGridViewTextBoxColumn});
            this.dgvusuarios.DataSource = this.userBindingSource;
            this.dgvusuarios.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvusuarios.Location = new System.Drawing.Point(0, 0);
            this.dgvusuarios.Name = "dgvusuarios";
            this.dgvusuarios.Size = new System.Drawing.Size(945, 426);
            this.dgvusuarios.TabIndex = 0;
            // 
            // userBindingSource
            // 
            this.userBindingSource.DataSource = typeof(CapaDatos.Models.Usuarios.User);
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // isDeletedDataGridViewCheckBoxColumn
            // 
            this.isDeletedDataGridViewCheckBoxColumn.DataPropertyName = "IsDeleted";
            this.isDeletedDataGridViewCheckBoxColumn.HeaderText = "IsDeleted";
            this.isDeletedDataGridViewCheckBoxColumn.Name = "isDeletedDataGridViewCheckBoxColumn";
            this.isDeletedDataGridViewCheckBoxColumn.ThreeState = true;
            this.isDeletedDataGridViewCheckBoxColumn.Visible = false;
            // 
            // sucursalIdDataGridViewTextBoxColumn
            // 
            this.sucursalIdDataGridViewTextBoxColumn.DataPropertyName = "SucursalId";
            this.sucursalIdDataGridViewTextBoxColumn.HeaderText = "SucursalId";
            this.sucursalIdDataGridViewTextBoxColumn.Name = "sucursalIdDataGridViewTextBoxColumn";
            this.sucursalIdDataGridViewTextBoxColumn.Visible = false;
            // 
            // privilegiosDataGridViewTextBoxColumn
            // 
            this.privilegiosDataGridViewTextBoxColumn.DataPropertyName = "Privilegios";
            this.privilegiosDataGridViewTextBoxColumn.HeaderText = "Privilegios";
            this.privilegiosDataGridViewTextBoxColumn.Name = "privilegiosDataGridViewTextBoxColumn";
            // 
            // sucursalDataGridViewTextBoxColumn
            // 
            this.sucursalDataGridViewTextBoxColumn.DataPropertyName = "Sucursal";
            this.sucursalDataGridViewTextBoxColumn.HeaderText = "Sucursal";
            this.sucursalDataGridViewTextBoxColumn.Name = "sucursalDataGridViewTextBoxColumn";
            this.sucursalDataGridViewTextBoxColumn.Visible = false;
            // 
            // facturasDataGridViewTextBoxColumn
            // 
            this.facturasDataGridViewTextBoxColumn.DataPropertyName = "Facturas";
            this.facturasDataGridViewTextBoxColumn.HeaderText = "Facturas";
            this.facturasDataGridViewTextBoxColumn.Name = "facturasDataGridViewTextBoxColumn";
            // 
            // transaccionesDataGridViewTextBoxColumn
            // 
            this.transaccionesDataGridViewTextBoxColumn.DataPropertyName = "Transacciones";
            this.transaccionesDataGridViewTextBoxColumn.HeaderText = "Transacciones";
            this.transaccionesDataGridViewTextBoxColumn.Name = "transaccionesDataGridViewTextBoxColumn";
            // 
            // valesDataGridViewTextBoxColumn
            // 
            this.valesDataGridViewTextBoxColumn.DataPropertyName = "Vales";
            this.valesDataGridViewTextBoxColumn.HeaderText = "Vales";
            this.valesDataGridViewTextBoxColumn.Name = "valesDataGridViewTextBoxColumn";
            // 
            // notaPagosDataGridViewTextBoxColumn
            // 
            this.notaPagosDataGridViewTextBoxColumn.DataPropertyName = "NotaPagos";
            this.notaPagosDataGridViewTextBoxColumn.HeaderText = "NotaPagos";
            this.notaPagosDataGridViewTextBoxColumn.Name = "notaPagosDataGridViewTextBoxColumn";
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            // 
            // emailConfirmedDataGridViewCheckBoxColumn
            // 
            this.emailConfirmedDataGridViewCheckBoxColumn.DataPropertyName = "EmailConfirmed";
            this.emailConfirmedDataGridViewCheckBoxColumn.HeaderText = "EmailConfirmed";
            this.emailConfirmedDataGridViewCheckBoxColumn.Name = "emailConfirmedDataGridViewCheckBoxColumn";
            this.emailConfirmedDataGridViewCheckBoxColumn.Visible = false;
            // 
            // passwordHashDataGridViewTextBoxColumn
            // 
            this.passwordHashDataGridViewTextBoxColumn.DataPropertyName = "PasswordHash";
            this.passwordHashDataGridViewTextBoxColumn.HeaderText = "PasswordHash";
            this.passwordHashDataGridViewTextBoxColumn.Name = "passwordHashDataGridViewTextBoxColumn";
            this.passwordHashDataGridViewTextBoxColumn.Visible = false;
            // 
            // securityStampDataGridViewTextBoxColumn
            // 
            this.securityStampDataGridViewTextBoxColumn.DataPropertyName = "SecurityStamp";
            this.securityStampDataGridViewTextBoxColumn.HeaderText = "SecurityStamp";
            this.securityStampDataGridViewTextBoxColumn.Name = "securityStampDataGridViewTextBoxColumn";
            this.securityStampDataGridViewTextBoxColumn.Visible = false;
            // 
            // phoneNumberDataGridViewTextBoxColumn
            // 
            this.phoneNumberDataGridViewTextBoxColumn.DataPropertyName = "PhoneNumber";
            this.phoneNumberDataGridViewTextBoxColumn.HeaderText = "PhoneNumber";
            this.phoneNumberDataGridViewTextBoxColumn.Name = "phoneNumberDataGridViewTextBoxColumn";
            // 
            // phoneNumberConfirmedDataGridViewCheckBoxColumn
            // 
            this.phoneNumberConfirmedDataGridViewCheckBoxColumn.DataPropertyName = "PhoneNumberConfirmed";
            this.phoneNumberConfirmedDataGridViewCheckBoxColumn.HeaderText = "PhoneNumberConfirmed";
            this.phoneNumberConfirmedDataGridViewCheckBoxColumn.Name = "phoneNumberConfirmedDataGridViewCheckBoxColumn";
            this.phoneNumberConfirmedDataGridViewCheckBoxColumn.Visible = false;
            // 
            // twoFactorEnabledDataGridViewCheckBoxColumn
            // 
            this.twoFactorEnabledDataGridViewCheckBoxColumn.DataPropertyName = "TwoFactorEnabled";
            this.twoFactorEnabledDataGridViewCheckBoxColumn.HeaderText = "TwoFactorEnabled";
            this.twoFactorEnabledDataGridViewCheckBoxColumn.Name = "twoFactorEnabledDataGridViewCheckBoxColumn";
            this.twoFactorEnabledDataGridViewCheckBoxColumn.Visible = false;
            // 
            // lockoutEndDateUtcDataGridViewTextBoxColumn
            // 
            this.lockoutEndDateUtcDataGridViewTextBoxColumn.DataPropertyName = "LockoutEndDateUtc";
            this.lockoutEndDateUtcDataGridViewTextBoxColumn.HeaderText = "LockoutEndDateUtc";
            this.lockoutEndDateUtcDataGridViewTextBoxColumn.Name = "lockoutEndDateUtcDataGridViewTextBoxColumn";
            this.lockoutEndDateUtcDataGridViewTextBoxColumn.Visible = false;
            // 
            // lockoutEnabledDataGridViewCheckBoxColumn
            // 
            this.lockoutEnabledDataGridViewCheckBoxColumn.DataPropertyName = "LockoutEnabled";
            this.lockoutEnabledDataGridViewCheckBoxColumn.HeaderText = "LockoutEnabled";
            this.lockoutEnabledDataGridViewCheckBoxColumn.Name = "lockoutEnabledDataGridViewCheckBoxColumn";
            this.lockoutEnabledDataGridViewCheckBoxColumn.Visible = false;
            // 
            // accessFailedCountDataGridViewTextBoxColumn
            // 
            this.accessFailedCountDataGridViewTextBoxColumn.DataPropertyName = "AccessFailedCount";
            this.accessFailedCountDataGridViewTextBoxColumn.HeaderText = "AccessFailedCount";
            this.accessFailedCountDataGridViewTextBoxColumn.Name = "accessFailedCountDataGridViewTextBoxColumn";
            this.accessFailedCountDataGridViewTextBoxColumn.Visible = false;
            // 
            // rolesDataGridViewTextBoxColumn
            // 
            this.rolesDataGridViewTextBoxColumn.DataPropertyName = "Roles";
            this.rolesDataGridViewTextBoxColumn.HeaderText = "Roles";
            this.rolesDataGridViewTextBoxColumn.Name = "rolesDataGridViewTextBoxColumn";
            this.rolesDataGridViewTextBoxColumn.ReadOnly = true;
            this.rolesDataGridViewTextBoxColumn.Visible = false;
            // 
            // claimsDataGridViewTextBoxColumn
            // 
            this.claimsDataGridViewTextBoxColumn.DataPropertyName = "Claims";
            this.claimsDataGridViewTextBoxColumn.HeaderText = "Claims";
            this.claimsDataGridViewTextBoxColumn.Name = "claimsDataGridViewTextBoxColumn";
            this.claimsDataGridViewTextBoxColumn.ReadOnly = true;
            this.claimsDataGridViewTextBoxColumn.Visible = false;
            // 
            // loginsDataGridViewTextBoxColumn
            // 
            this.loginsDataGridViewTextBoxColumn.DataPropertyName = "Logins";
            this.loginsDataGridViewTextBoxColumn.HeaderText = "Logins";
            this.loginsDataGridViewTextBoxColumn.Name = "loginsDataGridViewTextBoxColumn";
            this.loginsDataGridViewTextBoxColumn.ReadOnly = true;
            this.loginsDataGridViewTextBoxColumn.Visible = false;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.Visible = false;
            // 
            // userNameDataGridViewTextBoxColumn
            // 
            this.userNameDataGridViewTextBoxColumn.DataPropertyName = "UserName";
            this.userNameDataGridViewTextBoxColumn.HeaderText = "UserName";
            this.userNameDataGridViewTextBoxColumn.Name = "userNameDataGridViewTextBoxColumn";
            // 
            // VerUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(945, 451);
            this.Controls.Add(this.kryptonPanel1);
            this.Controls.Add(this.toolStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "VerUsuarios";
            this.Text = "VerUsuarios";
            this.Load += new System.EventHandler(this.VerUsuarios_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).EndInit();
            this.kryptonPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvusuarios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel1;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView dgvusuarios;
        private System.Windows.Forms.ToolStripButton btnEliminar;
        private System.Windows.Forms.BindingSource userBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn isDeletedDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sucursalIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn privilegiosDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sucursalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn facturasDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn transaccionesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn valesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn notaPagosDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn emailConfirmedDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn passwordHashDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn securityStampDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn phoneNumberConfirmedDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn twoFactorEnabledDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lockoutEndDateUtcDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn lockoutEnabledDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn accessFailedCountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rolesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn claimsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn loginsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn userNameDataGridViewTextBoxColumn;
    }
}