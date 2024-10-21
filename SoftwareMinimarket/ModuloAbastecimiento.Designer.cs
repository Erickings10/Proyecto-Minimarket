namespace SoftwareMinimarket
{
    partial class ModuloAbastecimiento
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ModuloAbastecimiento));
            this.panelContainer = new System.Windows.Forms.Panel();
            this.btnAbrirOC = new SoftwareMinimarket.CustomControls();
            this.btnMostrarDetalle = new SoftwareMinimarket.CustomControls();
            this.btnRegistrarReque = new SoftwareMinimarket.CustomControls();
            this.btnAgregarProd = new SoftwareMinimarket.CustomControls();
            this.chbEstado = new System.Windows.Forms.CheckBox();
            this.dgvDetalleRequerimiento = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Prioridad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbPrior = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.btnBajoStock = new System.Windows.Forms.Button();
            this.txtProducto = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panelTitleBar = new System.Windows.Forms.Panel();
            this.btnMinimizar = new System.Windows.Forms.PictureBox();
            this.btnMaximizar = new System.Windows.Forms.PictureBox();
            this.btnCerrar = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panelContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalleRequerimiento)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.panelTitleBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMaximizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).BeginInit();
            this.SuspendLayout();
            // 
            // panelContainer
            // 
            this.panelContainer.BackColor = System.Drawing.Color.Lavender;
            this.panelContainer.Controls.Add(this.btnAbrirOC);
            this.panelContainer.Controls.Add(this.btnMostrarDetalle);
            this.panelContainer.Controls.Add(this.btnRegistrarReque);
            this.panelContainer.Controls.Add(this.btnAgregarProd);
            this.panelContainer.Controls.Add(this.chbEstado);
            this.panelContainer.Controls.Add(this.dgvDetalleRequerimiento);
            this.panelContainer.Controls.Add(this.groupBox1);
            this.panelContainer.Controls.Add(this.panelTitleBar);
            this.panelContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContainer.Location = new System.Drawing.Point(0, 0);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Size = new System.Drawing.Size(859, 518);
            this.panelContainer.TabIndex = 0;
            this.panelContainer.Paint += new System.Windows.Forms.PaintEventHandler(this.panelContainer_Paint);
            // 
            // btnAbrirOC
            // 
            this.btnAbrirOC.BackColor = System.Drawing.Color.Transparent;
            this.btnAbrirOC.BackgroundColor = System.Drawing.Color.Transparent;
            this.btnAbrirOC.BorderColor = System.Drawing.Color.Gold;
            this.btnAbrirOC.BorderRadius = 0;
            this.btnAbrirOC.BorderSize = 3;
            this.btnAbrirOC.FlatAppearance.BorderSize = 0;
            this.btnAbrirOC.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightYellow;
            this.btnAbrirOC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAbrirOC.ForeColor = System.Drawing.Color.Black;
            this.btnAbrirOC.Image = ((System.Drawing.Image)(resources.GetObject("btnAbrirOC.Image")));
            this.btnAbrirOC.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAbrirOC.Location = new System.Drawing.Point(75, 376);
            this.btnAbrirOC.Name = "btnAbrirOC";
            this.btnAbrirOC.Size = new System.Drawing.Size(218, 56);
            this.btnAbrirOC.TabIndex = 29;
            this.btnAbrirOC.Text = "ABRIR ORDEN COMPRA";
            this.btnAbrirOC.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAbrirOC.TextColor = System.Drawing.Color.Black;
            this.btnAbrirOC.UseVisualStyleBackColor = false;
            this.btnAbrirOC.Click += new System.EventHandler(this.btnAbrirOC_Click);
            // 
            // btnMostrarDetalle
            // 
            this.btnMostrarDetalle.BackColor = System.Drawing.Color.Transparent;
            this.btnMostrarDetalle.BackgroundColor = System.Drawing.Color.Transparent;
            this.btnMostrarDetalle.BorderColor = System.Drawing.Color.HotPink;
            this.btnMostrarDetalle.BorderRadius = 0;
            this.btnMostrarDetalle.BorderSize = 3;
            this.btnMostrarDetalle.FlatAppearance.BorderSize = 0;
            this.btnMostrarDetalle.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightPink;
            this.btnMostrarDetalle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMostrarDetalle.ForeColor = System.Drawing.Color.Black;
            this.btnMostrarDetalle.Image = ((System.Drawing.Image)(resources.GetObject("btnMostrarDetalle.Image")));
            this.btnMostrarDetalle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMostrarDetalle.Location = new System.Drawing.Point(75, 450);
            this.btnMostrarDetalle.Name = "btnMostrarDetalle";
            this.btnMostrarDetalle.Size = new System.Drawing.Size(218, 56);
            this.btnMostrarDetalle.TabIndex = 28;
            this.btnMostrarDetalle.Text = "MOSTRAR DETALLE";
            this.btnMostrarDetalle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnMostrarDetalle.TextColor = System.Drawing.Color.Black;
            this.btnMostrarDetalle.UseVisualStyleBackColor = false;
            this.btnMostrarDetalle.Click += new System.EventHandler(this.btnMostrarDetalle_Click);
            // 
            // btnRegistrarReque
            // 
            this.btnRegistrarReque.BackColor = System.Drawing.Color.Transparent;
            this.btnRegistrarReque.BackgroundColor = System.Drawing.Color.Transparent;
            this.btnRegistrarReque.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.btnRegistrarReque.BorderRadius = 0;
            this.btnRegistrarReque.BorderSize = 3;
            this.btnRegistrarReque.FlatAppearance.BorderSize = 0;
            this.btnRegistrarReque.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue;
            this.btnRegistrarReque.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrarReque.ForeColor = System.Drawing.Color.Black;
            this.btnRegistrarReque.Image = ((System.Drawing.Image)(resources.GetObject("btnRegistrarReque.Image")));
            this.btnRegistrarReque.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRegistrarReque.Location = new System.Drawing.Point(187, 305);
            this.btnRegistrarReque.Name = "btnRegistrarReque";
            this.btnRegistrarReque.Size = new System.Drawing.Size(208, 56);
            this.btnRegistrarReque.TabIndex = 27;
            this.btnRegistrarReque.Text = "REGISTRAR REQUERIMIENTO";
            this.btnRegistrarReque.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRegistrarReque.TextColor = System.Drawing.Color.Black;
            this.btnRegistrarReque.UseVisualStyleBackColor = false;
            this.btnRegistrarReque.Click += new System.EventHandler(this.btnRegistrarReque_Click);
            // 
            // btnAgregarProd
            // 
            this.btnAgregarProd.BackColor = System.Drawing.Color.Transparent;
            this.btnAgregarProd.BackgroundColor = System.Drawing.Color.Transparent;
            this.btnAgregarProd.BorderColor = System.Drawing.Color.Lime;
            this.btnAgregarProd.BorderRadius = 0;
            this.btnAgregarProd.BorderSize = 3;
            this.btnAgregarProd.FlatAppearance.BorderSize = 0;
            this.btnAgregarProd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGreen;
            this.btnAgregarProd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarProd.ForeColor = System.Drawing.Color.Black;
            this.btnAgregarProd.Image = ((System.Drawing.Image)(resources.GetObject("btnAgregarProd.Image")));
            this.btnAgregarProd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgregarProd.Location = new System.Drawing.Point(9, 305);
            this.btnAgregarProd.Name = "btnAgregarProd";
            this.btnAgregarProd.Size = new System.Drawing.Size(157, 56);
            this.btnAgregarProd.TabIndex = 26;
            this.btnAgregarProd.Text = "AGREGAR PRODUCTO";
            this.btnAgregarProd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAgregarProd.TextColor = System.Drawing.Color.Black;
            this.btnAgregarProd.UseVisualStyleBackColor = false;
            this.btnAgregarProd.Click += new System.EventHandler(this.btnAgregarProd_Click);
            // 
            // chbEstado
            // 
            this.chbEstado.AutoSize = true;
            this.chbEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbEstado.Location = new System.Drawing.Point(42, 275);
            this.chbEstado.Name = "chbEstado";
            this.chbEstado.Size = new System.Drawing.Size(83, 24);
            this.chbEstado.TabIndex = 23;
            this.chbEstado.Text = "Estado";
            this.chbEstado.UseVisualStyleBackColor = true;
            // 
            // dgvDetalleRequerimiento
            // 
            this.dgvDetalleRequerimiento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetalleRequerimiento.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Producto,
            this.Cantidad,
            this.Prioridad});
            this.dgvDetalleRequerimiento.Location = new System.Drawing.Point(411, 56);
            this.dgvDetalleRequerimiento.Name = "dgvDetalleRequerimiento";
            this.dgvDetalleRequerimiento.RowHeadersWidth = 51;
            this.dgvDetalleRequerimiento.RowTemplate.Height = 24;
            this.dgvDetalleRequerimiento.Size = new System.Drawing.Size(436, 450);
            this.dgvDetalleRequerimiento.TabIndex = 21;
            this.dgvDetalleRequerimiento.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDetalleRequerimiento_CellClick);
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.MinimumWidth = 6;
            this.ID.Name = "ID";
            this.ID.Width = 125;
            // 
            // Producto
            // 
            this.Producto.HeaderText = "Producto";
            this.Producto.MinimumWidth = 6;
            this.Producto.Name = "Producto";
            this.Producto.Width = 125;
            // 
            // Cantidad
            // 
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.MinimumWidth = 6;
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.Width = 125;
            // 
            // Prioridad
            // 
            this.Prioridad.HeaderText = "Prioridad";
            this.Prioridad.MinimumWidth = 6;
            this.Prioridad.Name = "Prioridad";
            this.Prioridad.Width = 125;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.groupBox1.Controls.Add(this.cmbPrior);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtCantidad);
            this.groupBox1.Controls.Add(this.btnBajoStock);
            this.groupBox1.Controls.Add(this.txtProducto);
            this.groupBox1.Controls.Add(this.txtID);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Location = new System.Drawing.Point(42, 62);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(326, 203);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "DATOS";
            // 
            // cmbPrior
            // 
            this.cmbPrior.FormattingEnabled = true;
            this.cmbPrior.Location = new System.Drawing.Point(130, 168);
            this.cmbPrior.Name = "cmbPrior";
            this.cmbPrior.Size = new System.Drawing.Size(121, 24);
            this.cmbPrior.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 168);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 20);
            this.label4.TabIndex = 13;
            this.label4.Text = "PRIORIDAD:";
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(130, 123);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(121, 22);
            this.txtCantidad.TabIndex = 12;
            // 
            // btnBajoStock
            // 
            this.btnBajoStock.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBajoStock.BackgroundImage")));
            this.btnBajoStock.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnBajoStock.Location = new System.Drawing.Point(264, 75);
            this.btnBajoStock.Name = "btnBajoStock";
            this.btnBajoStock.Size = new System.Drawing.Size(30, 30);
            this.btnBajoStock.TabIndex = 11;
            this.btnBajoStock.UseVisualStyleBackColor = true;
            this.btnBajoStock.Click += new System.EventHandler(this.btnBajoStock_Click);
            // 
            // txtProducto
            // 
            this.txtProducto.Location = new System.Drawing.Point(130, 79);
            this.txtProducto.Name = "txtProducto";
            this.txtProducto.Size = new System.Drawing.Size(121, 22);
            this.txtProducto.TabIndex = 6;
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(43, 31);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(50, 22);
            this.txtID.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "ID:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "CANTIDAD:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 79);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "PRODUCTO:";
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
            this.panelTitleBar.Size = new System.Drawing.Size(859, 50);
            this.panelTitleBar.TabIndex = 0;
            this.panelTitleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTitleBar_MouseDown);
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.Image = ((System.Drawing.Image)(resources.GetObject("btnMinimizar.Image")));
            this.btnMinimizar.Location = new System.Drawing.Point(708, 7);
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
            this.btnMaximizar.Location = new System.Drawing.Point(756, 7);
            this.btnMaximizar.Name = "btnMaximizar";
            this.btnMaximizar.Size = new System.Drawing.Size(35, 35);
            this.btnMaximizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMaximizar.TabIndex = 105;
            this.btnMaximizar.TabStop = false;
            // 
            // btnCerrar
            // 
            this.btnCerrar.Image = ((System.Drawing.Image)(resources.GetObject("btnCerrar.Image")));
            this.btnCerrar.Location = new System.Drawing.Point(806, 7);
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
            this.label1.Location = new System.Drawing.Point(12, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(264, 39);
            this.label1.TabIndex = 17;
            this.label1.Text = "REQUERIMIENTO";
            // 
            // ModuloAbastecimiento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(859, 518);
            this.Controls.Add(this.panelContainer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "ModuloAbastecimiento";
            this.Activated += new System.EventHandler(this.ModuloAbastecimiento_Activated);
            this.Load += new System.EventHandler(this.ModuloAbastecimiento_Load);
            this.ResizeEnd += new System.EventHandler(this.ModuloAbastecimiento_ResizeEnd);
            this.SizeChanged += new System.EventHandler(this.ModuloAbastecimiento_SizeChanged);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.ModuloAbastecimiento_Paint);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ModuloAbastecimiento_MouseDown);
            this.panelContainer.ResumeLayout(false);
            this.panelContainer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalleRequerimiento)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panelTitleBar.ResumeLayout(false);
            this.panelTitleBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMaximizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelContainer;
        private System.Windows.Forms.CheckBox chbEstado;
        private System.Windows.Forms.DataGridView dgvDetalleRequerimiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Prioridad;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmbPrior;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.Button btnBajoStock;
        private System.Windows.Forms.TextBox txtProducto;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panelTitleBar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox btnMinimizar;
        private System.Windows.Forms.PictureBox btnMaximizar;
        private System.Windows.Forms.PictureBox btnCerrar;
        private CustomControls btnAgregarProd;
        private CustomControls btnRegistrarReque;
        private CustomControls btnMostrarDetalle;
        private CustomControls btnAbrirOC;
    }
}