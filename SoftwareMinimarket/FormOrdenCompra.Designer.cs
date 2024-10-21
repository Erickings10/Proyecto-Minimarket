namespace SoftwareMinimarket
{
    partial class FormOrdenCompra
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormOrdenCompra));
            this.panelContainer = new System.Windows.Forms.Panel();
            this.btnConfirmarOrden = new SoftwareMinimarket.CustomControls();
            this.btnEliminarReq = new SoftwareMinimarket.CustomControls();
            this.btnAgregarReq = new SoftwareMinimarket.CustomControls();
            this.panelTitleBar = new System.Windows.Forms.Panel();
            this.btnMinimizar = new System.Windows.Forms.PictureBox();
            this.btnMaximizar = new System.Windows.Forms.PictureBox();
            this.btnCerrar = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnProveedor = new System.Windows.Forms.Button();
            this.txtProveedorID = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.chkEstado = new System.Windows.Forms.CheckBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dgvSeleccion = new System.Windows.Forms.DataGridView();
            this.OrdenCompraID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RequerimientoID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecioReq = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Proveedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtPrecioRequerimiento = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtRequerimientoID = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnRequerimiento = new System.Windows.Forms.Button();
            this.panelContainer.SuspendLayout();
            this.panelTitleBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMaximizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSeleccion)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelContainer
            // 
            this.panelContainer.BackColor = System.Drawing.Color.Lavender;
            this.panelContainer.Controls.Add(this.btnConfirmarOrden);
            this.panelContainer.Controls.Add(this.btnEliminarReq);
            this.panelContainer.Controls.Add(this.btnAgregarReq);
            this.panelContainer.Controls.Add(this.panelTitleBar);
            this.panelContainer.Controls.Add(this.groupBox2);
            this.panelContainer.Controls.Add(this.dgvSeleccion);
            this.panelContainer.Controls.Add(this.groupBox1);
            this.panelContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContainer.Location = new System.Drawing.Point(0, 0);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Size = new System.Drawing.Size(912, 586);
            this.panelContainer.TabIndex = 0;
            this.panelContainer.Paint += new System.Windows.Forms.PaintEventHandler(this.panelContainer_Paint);
            // 
            // btnConfirmarOrden
            // 
            this.btnConfirmarOrden.BackColor = System.Drawing.Color.Transparent;
            this.btnConfirmarOrden.BackgroundColor = System.Drawing.Color.Transparent;
            this.btnConfirmarOrden.BorderColor = System.Drawing.Color.Lime;
            this.btnConfirmarOrden.BorderRadius = 0;
            this.btnConfirmarOrden.BorderSize = 3;
            this.btnConfirmarOrden.FlatAppearance.BorderSize = 0;
            this.btnConfirmarOrden.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnConfirmarOrden.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirmarOrden.ForeColor = System.Drawing.Color.Black;
            this.btnConfirmarOrden.Image = ((System.Drawing.Image)(resources.GetObject("btnConfirmarOrden.Image")));
            this.btnConfirmarOrden.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConfirmarOrden.Location = new System.Drawing.Point(73, 518);
            this.btnConfirmarOrden.Name = "btnConfirmarOrden";
            this.btnConfirmarOrden.Size = new System.Drawing.Size(175, 56);
            this.btnConfirmarOrden.TabIndex = 40;
            this.btnConfirmarOrden.Text = "Confirmar Orden";
            this.btnConfirmarOrden.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnConfirmarOrden.TextColor = System.Drawing.Color.Black;
            this.btnConfirmarOrden.UseVisualStyleBackColor = false;
            this.btnConfirmarOrden.Click += new System.EventHandler(this.btnConfirmarOrden_Click);
            // 
            // btnEliminarReq
            // 
            this.btnEliminarReq.BackColor = System.Drawing.Color.Transparent;
            this.btnEliminarReq.BackgroundColor = System.Drawing.Color.Transparent;
            this.btnEliminarReq.BorderColor = System.Drawing.Color.OrangeRed;
            this.btnEliminarReq.BorderRadius = 0;
            this.btnEliminarReq.BorderSize = 3;
            this.btnEliminarReq.FlatAppearance.BorderSize = 0;
            this.btnEliminarReq.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnEliminarReq.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarReq.ForeColor = System.Drawing.Color.Black;
            this.btnEliminarReq.Image = ((System.Drawing.Image)(resources.GetObject("btnEliminarReq.Image")));
            this.btnEliminarReq.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEliminarReq.Location = new System.Drawing.Point(176, 449);
            this.btnEliminarReq.Name = "btnEliminarReq";
            this.btnEliminarReq.Size = new System.Drawing.Size(153, 56);
            this.btnEliminarReq.TabIndex = 39;
            this.btnEliminarReq.Text = "Eliminar Requerimiento";
            this.btnEliminarReq.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEliminarReq.TextColor = System.Drawing.Color.Black;
            this.btnEliminarReq.UseVisualStyleBackColor = false;
            this.btnEliminarReq.Click += new System.EventHandler(this.btnEliminarReq_Click);
            // 
            // btnAgregarReq
            // 
            this.btnAgregarReq.BackColor = System.Drawing.Color.Transparent;
            this.btnAgregarReq.BackgroundColor = System.Drawing.Color.Transparent;
            this.btnAgregarReq.BorderColor = System.Drawing.Color.Yellow;
            this.btnAgregarReq.BorderRadius = 0;
            this.btnAgregarReq.BorderSize = 3;
            this.btnAgregarReq.FlatAppearance.BorderSize = 0;
            this.btnAgregarReq.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnAgregarReq.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarReq.ForeColor = System.Drawing.Color.Black;
            this.btnAgregarReq.Image = ((System.Drawing.Image)(resources.GetObject("btnAgregarReq.Image")));
            this.btnAgregarReq.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgregarReq.Location = new System.Drawing.Point(8, 449);
            this.btnAgregarReq.Name = "btnAgregarReq";
            this.btnAgregarReq.Size = new System.Drawing.Size(149, 56);
            this.btnAgregarReq.TabIndex = 38;
            this.btnAgregarReq.Text = "Agregar Requerimiento";
            this.btnAgregarReq.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAgregarReq.TextColor = System.Drawing.Color.Black;
            this.btnAgregarReq.UseVisualStyleBackColor = false;
            this.btnAgregarReq.Click += new System.EventHandler(this.btnAgregarReq_Click);
            // 
            // panelTitleBar
            // 
            this.panelTitleBar.BackColor = System.Drawing.Color.RoyalBlue;
            this.panelTitleBar.Controls.Add(this.btnMinimizar);
            this.panelTitleBar.Controls.Add(this.btnMaximizar);
            this.panelTitleBar.Controls.Add(this.btnCerrar);
            this.panelTitleBar.Controls.Add(this.label1);
            this.panelTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitleBar.Location = new System.Drawing.Point(0, 0);
            this.panelTitleBar.Name = "panelTitleBar";
            this.panelTitleBar.Size = new System.Drawing.Size(912, 50);
            this.panelTitleBar.TabIndex = 37;
            this.panelTitleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTitleBar_MouseDown);
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.Image = ((System.Drawing.Image)(resources.GetObject("btnMinimizar.Image")));
            this.btnMinimizar.Location = new System.Drawing.Point(768, 8);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(35, 35);
            this.btnMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMinimizar.TabIndex = 106;
            this.btnMinimizar.TabStop = false;
            this.btnMinimizar.Click += new System.EventHandler(this.btnMinimizar_Click);
            // 
            // btnMaximizar
            // 
            this.btnMaximizar.Image = ((System.Drawing.Image)(resources.GetObject("btnMaximizar.Image")));
            this.btnMaximizar.Location = new System.Drawing.Point(816, 8);
            this.btnMaximizar.Name = "btnMaximizar";
            this.btnMaximizar.Size = new System.Drawing.Size(35, 35);
            this.btnMaximizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMaximizar.TabIndex = 105;
            this.btnMaximizar.TabStop = false;
            // 
            // btnCerrar
            // 
            this.btnCerrar.Image = ((System.Drawing.Image)(resources.GetObject("btnCerrar.Image")));
            this.btnCerrar.Location = new System.Drawing.Point(866, 8);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(35, 35);
            this.btnCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnCerrar.TabIndex = 104;
            this.btnCerrar.TabStop = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(45, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(306, 39);
            this.label1.TabIndex = 29;
            this.label1.Text = "ORDEN DE COMPRA";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.groupBox2.Controls.Add(this.btnProveedor);
            this.groupBox2.Controls.Add(this.txtProveedorID);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txtCantidad);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.chkEstado);
            this.groupBox2.Controls.Add(this.txtTotal);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(8, 231);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(326, 205);
            this.groupBox2.TabIndex = 34;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "DATOS ORDEN COMPRA";
            // 
            // btnProveedor
            // 
            this.btnProveedor.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnProveedor.BackgroundImage")));
            this.btnProveedor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnProveedor.Location = new System.Drawing.Point(266, 35);
            this.btnProveedor.Name = "btnProveedor";
            this.btnProveedor.Size = new System.Drawing.Size(30, 30);
            this.btnProveedor.TabIndex = 33;
            this.btnProveedor.UseVisualStyleBackColor = true;
            this.btnProveedor.Click += new System.EventHandler(this.btnProveedor_Click);
            // 
            // txtProveedorID
            // 
            this.txtProveedorID.Location = new System.Drawing.Point(136, 39);
            this.txtProveedorID.Name = "txtProveedorID";
            this.txtProveedorID.Size = new System.Drawing.Size(124, 22);
            this.txtProveedorID.TabIndex = 32;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(9, 39);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(121, 20);
            this.label5.TabIndex = 31;
            this.label5.Text = "PROVEEDOR:";
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(224, 84);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(77, 22);
            this.txtCantidad.TabIndex = 30;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(11, 84);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(207, 20);
            this.label8.TabIndex = 29;
            this.label8.Text = "CANT. REQUERIMIENTO:";
            // 
            // chkEstado
            // 
            this.chkEstado.AutoSize = true;
            this.chkEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkEstado.Location = new System.Drawing.Point(15, 158);
            this.chkEstado.Name = "chkEstado";
            this.chkEstado.Size = new System.Drawing.Size(100, 24);
            this.chkEstado.TabIndex = 28;
            this.chkEstado.Text = "ESTADO";
            this.chkEstado.UseVisualStyleBackColor = true;
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(85, 120);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(100, 22);
            this.txtTotal.TabIndex = 27;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(11, 122);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 20);
            this.label4.TabIndex = 26;
            this.label4.Text = "TOTAL:";
            // 
            // dgvSeleccion
            // 
            this.dgvSeleccion.AllowUserToAddRows = false;
            this.dgvSeleccion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSeleccion.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.OrdenCompraID,
            this.RequerimientoID,
            this.PrecioReq,
            this.Proveedor});
            this.dgvSeleccion.Location = new System.Drawing.Point(351, 63);
            this.dgvSeleccion.Name = "dgvSeleccion";
            this.dgvSeleccion.RowHeadersWidth = 51;
            this.dgvSeleccion.RowTemplate.Height = 24;
            this.dgvSeleccion.Size = new System.Drawing.Size(554, 508);
            this.dgvSeleccion.TabIndex = 33;
            // 
            // OrdenCompraID
            // 
            this.OrdenCompraID.HeaderText = "ID";
            this.OrdenCompraID.MinimumWidth = 6;
            this.OrdenCompraID.Name = "OrdenCompraID";
            this.OrdenCompraID.Width = 125;
            // 
            // RequerimientoID
            // 
            this.RequerimientoID.HeaderText = "Requerimiento ID";
            this.RequerimientoID.MinimumWidth = 6;
            this.RequerimientoID.Name = "RequerimientoID";
            this.RequerimientoID.Width = 125;
            // 
            // PrecioReq
            // 
            this.PrecioReq.HeaderText = "Precio";
            this.PrecioReq.MinimumWidth = 6;
            this.PrecioReq.Name = "PrecioReq";
            this.PrecioReq.Width = 125;
            // 
            // Proveedor
            // 
            this.Proveedor.HeaderText = "Proveedor ID";
            this.Proveedor.MinimumWidth = 6;
            this.Proveedor.Name = "Proveedor";
            this.Proveedor.Width = 125;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.groupBox1.Controls.Add(this.txtPrecioRequerimiento);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtRequerimientoID);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.btnRequerimiento);
            this.groupBox1.Location = new System.Drawing.Point(8, 59);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(326, 155);
            this.groupBox1.TabIndex = 30;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "DATOS REQUERIMIENTO";
            // 
            // txtPrecioRequerimiento
            // 
            this.txtPrecioRequerimiento.Location = new System.Drawing.Point(233, 96);
            this.txtPrecioRequerimiento.Name = "txtPrecioRequerimiento";
            this.txtPrecioRequerimiento.Size = new System.Drawing.Size(77, 22);
            this.txtPrecioRequerimiento.TabIndex = 18;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(6, 96);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(221, 20);
            this.label7.TabIndex = 17;
            this.label7.Text = "PRECIO REQUERIMIENTO:";
            // 
            // txtRequerimientoID
            // 
            this.txtRequerimientoID.Location = new System.Drawing.Point(168, 49);
            this.txtRequerimientoID.Name = "txtRequerimientoID";
            this.txtRequerimientoID.Size = new System.Drawing.Size(92, 22);
            this.txtRequerimientoID.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(9, 49);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(153, 20);
            this.label6.TabIndex = 15;
            this.label6.Text = "REQUERIMIENTO:";
            // 
            // btnRequerimiento
            // 
            this.btnRequerimiento.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnRequerimiento.BackgroundImage")));
            this.btnRequerimiento.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnRequerimiento.Location = new System.Drawing.Point(266, 45);
            this.btnRequerimiento.Name = "btnRequerimiento";
            this.btnRequerimiento.Size = new System.Drawing.Size(30, 30);
            this.btnRequerimiento.TabIndex = 14;
            this.btnRequerimiento.UseVisualStyleBackColor = true;
            this.btnRequerimiento.Click += new System.EventHandler(this.btnRequerimiento_Click);
            // 
            // FormOrdenCompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(912, 586);
            this.Controls.Add(this.panelContainer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FormOrdenCompra";
            this.Text = "OrdenCompra";
            this.Activated += new System.EventHandler(this.FormOrdenCompra_Activated);
            this.ResizeEnd += new System.EventHandler(this.FormOrdenCompra_ResizeEnd);
            this.SizeChanged += new System.EventHandler(this.FormOrdenCompra_SizeChanged);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.FormOrdenCompra_Paint);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FormOrdenCompra_MouseDown);
            this.panelContainer.ResumeLayout(false);
            this.panelTitleBar.ResumeLayout(false);
            this.panelTitleBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMaximizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSeleccion)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelContainer;
        private System.Windows.Forms.Panel panelTitleBar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnProveedor;
        private System.Windows.Forms.TextBox txtProveedorID;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.CheckBox chkEstado;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgvSeleccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrdenCompraID;
        private System.Windows.Forms.DataGridViewTextBoxColumn RequerimientoID;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecioReq;
        private System.Windows.Forms.DataGridViewTextBoxColumn Proveedor;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtPrecioRequerimiento;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtRequerimientoID;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnRequerimiento;
        private System.Windows.Forms.PictureBox btnMinimizar;
        private System.Windows.Forms.PictureBox btnMaximizar;
        private System.Windows.Forms.PictureBox btnCerrar;
        private CustomControls btnAgregarReq;
        private CustomControls btnEliminarReq;
        private CustomControls btnConfirmarOrden;
    }
}