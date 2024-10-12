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
            this.btnEliminarRequerimiento = new System.Windows.Forms.Button();
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
            this.button3 = new System.Windows.Forms.Button();
            this.btnAgregarOrden = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtPrecioRequerimiento = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtRequerimientoID = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnRequerimiento = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_regresar = new System.Windows.Forms.PictureBox();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSeleccion)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_regresar)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEliminarRequerimiento
            // 
            this.btnEliminarRequerimiento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnEliminarRequerimiento.Location = new System.Drawing.Point(177, 451);
            this.btnEliminarRequerimiento.Name = "btnEliminarRequerimiento";
            this.btnEliminarRequerimiento.Size = new System.Drawing.Size(142, 56);
            this.btnEliminarRequerimiento.TabIndex = 27;
            this.btnEliminarRequerimiento.Text = "Eliminar Requerimiento";
            this.btnEliminarRequerimiento.UseVisualStyleBackColor = false;
            this.btnEliminarRequerimiento.Click += new System.EventHandler(this.btnEliminarRequerimiento_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.groupBox2.Controls.Add(this.btnProveedor);
            this.groupBox2.Controls.Add(this.txtProveedorID);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txtCantidad);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.chkEstado);
            this.groupBox2.Controls.Add(this.txtTotal);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(9, 240);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(326, 205);
            this.groupBox2.TabIndex = 26;
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
            this.dgvSeleccion.Location = new System.Drawing.Point(352, 72);
            this.dgvSeleccion.Name = "dgvSeleccion";
            this.dgvSeleccion.RowHeadersWidth = 51;
            this.dgvSeleccion.RowTemplate.Height = 24;
            this.dgvSeleccion.Size = new System.Drawing.Size(554, 508);
            this.dgvSeleccion.TabIndex = 25;
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
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button3.Location = new System.Drawing.Point(19, 451);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(143, 56);
            this.button3.TabIndex = 24;
            this.button3.Text = "Agregar Requerimiento";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.btnAgregarRequerimiento_Click);
            // 
            // btnAgregarOrden
            // 
            this.btnAgregarOrden.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnAgregarOrden.Location = new System.Drawing.Point(127, 524);
            this.btnAgregarOrden.Name = "btnAgregarOrden";
            this.btnAgregarOrden.Size = new System.Drawing.Size(142, 56);
            this.btnAgregarOrden.TabIndex = 23;
            this.btnAgregarOrden.Text = "Confirmar Orden";
            this.btnAgregarOrden.UseVisualStyleBackColor = false;
            this.btnAgregarOrden.Click += new System.EventHandler(this.btnAgregarOrden_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.groupBox1.Controls.Add(this.txtPrecioRequerimiento);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtRequerimientoID);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.btnRequerimiento);
            this.groupBox1.Location = new System.Drawing.Point(9, 68);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(326, 155);
            this.groupBox1.TabIndex = 22;
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
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Red;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(912, 50);
            this.panel1.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(346, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(306, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "ORDEN DE COMPRA";
            // 
            // btn_regresar
            // 
            this.btn_regresar.Image = ((System.Drawing.Image)(resources.GetObject("btn_regresar.Image")));
            this.btn_regresar.Location = new System.Drawing.Point(19, 528);
            this.btn_regresar.Name = "btn_regresar";
            this.btn_regresar.Size = new System.Drawing.Size(51, 46);
            this.btn_regresar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_regresar.TabIndex = 28;
            this.btn_regresar.TabStop = false;
            this.btn_regresar.Click += new System.EventHandler(this.btn_regresar_Click);
            // 
            // FormOrdenCompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(912, 586);
            this.Controls.Add(this.btn_regresar);
            this.Controls.Add(this.btnEliminarRequerimiento);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.dgvSeleccion);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btnAgregarOrden);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FormOrdenCompra";
            this.Text = "OrdenCompra";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSeleccion)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_regresar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnEliminarRequerimiento;
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
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnAgregarOrden;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtPrecioRequerimiento;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtRequerimientoID;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnRequerimiento;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox btn_regresar;
    }
}