namespace SoftwareMinimarket
{
    partial class ModuloEntradaProductos
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ModuloEntradaProductos));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelContainer = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvDetalles = new System.Windows.Forms.DataGridView();
            this.btn_Deshabilitar = new SoftwareMinimarket.CustomControls();
            this.btn_Modificar = new SoftwareMinimarket.CustomControls();
            this.btn_Registrar = new SoftwareMinimarket.CustomControls();
            this.gboDatos = new System.Windows.Forms.GroupBox();
            this.btnAgregarDetalle = new SoftwareMinimarket.CustomControls();
            this.label3 = new System.Windows.Forms.Label();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.btnBuscarProducto = new System.Windows.Forms.Button();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtProducto = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.dgvEntradaProductos = new System.Windows.Forms.DataGridView();
            this.panelTitleBar = new System.Windows.Forms.Panel();
            this.btnMinimizar = new System.Windows.Forms.PictureBox();
            this.btnCerrar = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panelContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalles)).BeginInit();
            this.gboDatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEntradaProductos)).BeginInit();
            this.panelTitleBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).BeginInit();
            this.SuspendLayout();
            // 
            // panelContainer
            // 
            this.panelContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(0)))), ((int)(((byte)(114)))));
            this.panelContainer.Controls.Add(this.label2);
            this.panelContainer.Controls.Add(this.dgvDetalles);
            this.panelContainer.Controls.Add(this.btn_Deshabilitar);
            this.panelContainer.Controls.Add(this.btn_Modificar);
            this.panelContainer.Controls.Add(this.btn_Registrar);
            this.panelContainer.Controls.Add(this.gboDatos);
            this.panelContainer.Controls.Add(this.dgvEntradaProductos);
            this.panelContainer.Controls.Add(this.panelTitleBar);
            this.panelContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContainer.Location = new System.Drawing.Point(0, 0);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Size = new System.Drawing.Size(945, 676);
            this.panelContainer.TabIndex = 0;
            this.panelContainer.Paint += new System.Windows.Forms.PaintEventHandler(this.panelContainer_Paint);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label2.Location = new System.Drawing.Point(586, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 20);
            this.label2.TabIndex = 58;
            this.label2.Text = "DETALLES";
            // 
            // dgvDetalles
            // 
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDetalles.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvDetalles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDetalles.DefaultCellStyle = dataGridViewCellStyle8;
            this.dgvDetalles.Location = new System.Drawing.Point(590, 108);
            this.dgvDetalles.Margin = new System.Windows.Forms.Padding(4);
            this.dgvDetalles.Name = "dgvDetalles";
            this.dgvDetalles.ReadOnly = true;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDetalles.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dgvDetalles.RowHeadersWidth = 51;
            this.dgvDetalles.Size = new System.Drawing.Size(305, 181);
            this.dgvDetalles.TabIndex = 67;
            this.dgvDetalles.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDetalles_CellDoubleClick);
            // 
            // btn_Deshabilitar
            // 
            this.btn_Deshabilitar.BackColor = System.Drawing.Color.Transparent;
            this.btn_Deshabilitar.BackgroundColor = System.Drawing.Color.Transparent;
            this.btn_Deshabilitar.BorderColor = System.Drawing.Color.OrangeRed;
            this.btn_Deshabilitar.BorderRadius = 0;
            this.btn_Deshabilitar.BorderSize = 2;
            this.btn_Deshabilitar.FlatAppearance.BorderSize = 0;
            this.btn_Deshabilitar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightCoral;
            this.btn_Deshabilitar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Deshabilitar.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btn_Deshabilitar.Image = ((System.Drawing.Image)(resources.GetObject("btn_Deshabilitar.Image")));
            this.btn_Deshabilitar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Deshabilitar.Location = new System.Drawing.Point(723, 322);
            this.btn_Deshabilitar.Name = "btn_Deshabilitar";
            this.btn_Deshabilitar.Size = new System.Drawing.Size(172, 64);
            this.btn_Deshabilitar.TabIndex = 66;
            this.btn_Deshabilitar.Text = "DESHABILITAR";
            this.btn_Deshabilitar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Deshabilitar.TextColor = System.Drawing.Color.WhiteSmoke;
            this.btn_Deshabilitar.UseVisualStyleBackColor = false;
            this.btn_Deshabilitar.Click += new System.EventHandler(this.btn_Deshabilitar_Click);
            // 
            // btn_Modificar
            // 
            this.btn_Modificar.BackColor = System.Drawing.Color.Transparent;
            this.btn_Modificar.BackgroundColor = System.Drawing.Color.Transparent;
            this.btn_Modificar.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.btn_Modificar.BorderRadius = 0;
            this.btn_Modificar.BorderSize = 2;
            this.btn_Modificar.FlatAppearance.BorderSize = 0;
            this.btn_Modificar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue;
            this.btn_Modificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Modificar.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btn_Modificar.Image = ((System.Drawing.Image)(resources.GetObject("btn_Modificar.Image")));
            this.btn_Modificar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Modificar.Location = new System.Drawing.Point(413, 322);
            this.btn_Modificar.Name = "btn_Modificar";
            this.btn_Modificar.Size = new System.Drawing.Size(172, 64);
            this.btn_Modificar.TabIndex = 65;
            this.btn_Modificar.Text = "MODIFICAR";
            this.btn_Modificar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Modificar.TextColor = System.Drawing.Color.WhiteSmoke;
            this.btn_Modificar.UseVisualStyleBackColor = false;
            this.btn_Modificar.Click += new System.EventHandler(this.btn_Modificar_Click);
            // 
            // btn_Registrar
            // 
            this.btn_Registrar.BackColor = System.Drawing.Color.Transparent;
            this.btn_Registrar.BackgroundColor = System.Drawing.Color.Transparent;
            this.btn_Registrar.BorderColor = System.Drawing.Color.Lime;
            this.btn_Registrar.BorderRadius = 0;
            this.btn_Registrar.BorderSize = 2;
            this.btn_Registrar.FlatAppearance.BorderSize = 0;
            this.btn_Registrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGreen;
            this.btn_Registrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Registrar.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btn_Registrar.Image = ((System.Drawing.Image)(resources.GetObject("btn_Registrar.Image")));
            this.btn_Registrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Registrar.Location = new System.Drawing.Point(61, 322);
            this.btn_Registrar.Name = "btn_Registrar";
            this.btn_Registrar.Size = new System.Drawing.Size(172, 64);
            this.btn_Registrar.TabIndex = 64;
            this.btn_Registrar.Text = "REGISTRAR";
            this.btn_Registrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Registrar.TextColor = System.Drawing.Color.WhiteSmoke;
            this.btn_Registrar.UseVisualStyleBackColor = false;
            this.btn_Registrar.Click += new System.EventHandler(this.btn_Registrar_Click);
            // 
            // gboDatos
            // 
            this.gboDatos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(0)))), ((int)(((byte)(148)))));
            this.gboDatos.Controls.Add(this.btnAgregarDetalle);
            this.gboDatos.Controls.Add(this.label3);
            this.gboDatos.Controls.Add(this.txtUsuario);
            this.gboDatos.Controls.Add(this.btnBuscarProducto);
            this.gboDatos.Controls.Add(this.txtDescripcion);
            this.gboDatos.Controls.Add(this.label5);
            this.gboDatos.Controls.Add(this.txtProducto);
            this.gboDatos.Controls.Add(this.label6);
            this.gboDatos.Controls.Add(this.label8);
            this.gboDatos.Controls.Add(this.txtCantidad);
            this.gboDatos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gboDatos.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.gboDatos.Location = new System.Drawing.Point(61, 68);
            this.gboDatos.Margin = new System.Windows.Forms.Padding(4);
            this.gboDatos.Name = "gboDatos";
            this.gboDatos.Padding = new System.Windows.Forms.Padding(4);
            this.gboDatos.Size = new System.Drawing.Size(496, 221);
            this.gboDatos.TabIndex = 63;
            this.gboDatos.TabStop = false;
            this.gboDatos.Text = "Datos";
            // 
            // btnAgregarDetalle
            // 
            this.btnAgregarDetalle.BackColor = System.Drawing.Color.Transparent;
            this.btnAgregarDetalle.BackgroundColor = System.Drawing.Color.Transparent;
            this.btnAgregarDetalle.BorderColor = System.Drawing.Color.Transparent;
            this.btnAgregarDetalle.BorderRadius = 0;
            this.btnAgregarDetalle.BorderSize = 2;
            this.btnAgregarDetalle.FlatAppearance.BorderSize = 0;
            this.btnAgregarDetalle.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnAgregarDetalle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarDetalle.ForeColor = System.Drawing.Color.Black;
            this.btnAgregarDetalle.Image = ((System.Drawing.Image)(resources.GetObject("btnAgregarDetalle.Image")));
            this.btnAgregarDetalle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgregarDetalle.Location = new System.Drawing.Point(451, 183);
            this.btnAgregarDetalle.Name = "btnAgregarDetalle";
            this.btnAgregarDetalle.Size = new System.Drawing.Size(45, 38);
            this.btnAgregarDetalle.TabIndex = 68;
            this.btnAgregarDetalle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAgregarDetalle.TextColor = System.Drawing.Color.Black;
            this.btnAgregarDetalle.UseVisualStyleBackColor = false;
            this.btnAgregarDetalle.Click += new System.EventHandler(this.btnAgregarDetalle_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.Location = new System.Drawing.Point(268, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 20);
            this.label3.TabIndex = 57;
            this.label3.Text = "ID Usuario:";
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(395, 125);
            this.txtUsuario.Margin = new System.Windows.Forms.Padding(4);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.ReadOnly = true;
            this.txtUsuario.Size = new System.Drawing.Size(66, 26);
            this.txtUsuario.TabIndex = 3;
            // 
            // btnBuscarProducto
            // 
            this.btnBuscarProducto.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBuscarProducto.BackgroundImage")));
            this.btnBuscarProducto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnBuscarProducto.Location = new System.Drawing.Point(194, 45);
            this.btnBuscarProducto.Name = "btnBuscarProducto";
            this.btnBuscarProducto.Size = new System.Drawing.Size(30, 30);
            this.btnBuscarProducto.TabIndex = 55;
            this.btnBuscarProducto.UseVisualStyleBackColor = true;
            this.btnBuscarProducto.Click += new System.EventHandler(this.btnBuscarProducto_Click);
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(272, 70);
            this.txtDescripcion.Margin = new System.Windows.Forms.Padding(4);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(189, 26);
            this.txtDescripcion.TabIndex = 54;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label5.Location = new System.Drawing.Point(268, 46);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 20);
            this.label5.TabIndex = 53;
            this.label5.Text = "Descripcion:";
            // 
            // txtProducto
            // 
            this.txtProducto.Location = new System.Drawing.Point(148, 47);
            this.txtProducto.Margin = new System.Windows.Forms.Padding(4);
            this.txtProducto.Name = "txtProducto";
            this.txtProducto.ReadOnly = true;
            this.txtProducto.Size = new System.Drawing.Size(39, 26);
            this.txtProducto.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label6.Location = new System.Drawing.Point(19, 50);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 20);
            this.label6.TabIndex = 13;
            this.label6.Text = "ID Producto:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label8.Location = new System.Drawing.Point(19, 102);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(80, 20);
            this.label8.TabIndex = 18;
            this.label8.Text = "Cantidad:";
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(146, 99);
            this.txtCantidad.Margin = new System.Windows.Forms.Padding(4);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(77, 26);
            this.txtCantidad.TabIndex = 19;
            // 
            // dgvEntradaProductos
            // 
            this.dgvEntradaProductos.AllowUserToAddRows = false;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvEntradaProductos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.dgvEntradaProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvEntradaProductos.DefaultCellStyle = dataGridViewCellStyle11;
            this.dgvEntradaProductos.Location = new System.Drawing.Point(30, 393);
            this.dgvEntradaProductos.Margin = new System.Windows.Forms.Padding(4);
            this.dgvEntradaProductos.Name = "dgvEntradaProductos";
            this.dgvEntradaProductos.ReadOnly = true;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvEntradaProductos.RowHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.dgvEntradaProductos.RowHeadersWidth = 51;
            this.dgvEntradaProductos.Size = new System.Drawing.Size(896, 270);
            this.dgvEntradaProductos.TabIndex = 59;
            this.dgvEntradaProductos.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEntradaProductos_CellDoubleClick);
            // 
            // panelTitleBar
            // 
            this.panelTitleBar.BackColor = System.Drawing.Color.RoyalBlue;
            this.panelTitleBar.Controls.Add(this.btnMinimizar);
            this.panelTitleBar.Controls.Add(this.btnCerrar);
            this.panelTitleBar.Controls.Add(this.label1);
            this.panelTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitleBar.Location = new System.Drawing.Point(0, 0);
            this.panelTitleBar.Name = "panelTitleBar";
            this.panelTitleBar.Size = new System.Drawing.Size(945, 50);
            this.panelTitleBar.TabIndex = 0;
            this.panelTitleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTitleBar_MouseDown);
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.Image = ((System.Drawing.Image)(resources.GetObject("btnMinimizar.Image")));
            this.btnMinimizar.Location = new System.Drawing.Point(844, 8);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(35, 35);
            this.btnMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMinimizar.TabIndex = 106;
            this.btnMinimizar.TabStop = false;
            this.btnMinimizar.Click += new System.EventHandler(this.btnMinimizar_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Image = ((System.Drawing.Image)(resources.GetObject("btnCerrar.Image")));
            this.btnCerrar.Location = new System.Drawing.Point(891, 8);
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
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(9, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(395, 39);
            this.label1.TabIndex = 58;
            this.label1.Text = "ENTRADA DE PRODUCTOS";
            // 
            // ModuloEntradaProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(945, 676);
            this.Controls.Add(this.panelContainer);
            this.Name = "ModuloEntradaProductos";
            this.Text = "ModuloEntradaProductos";
            this.Activated += new System.EventHandler(this.ModuloEntradaProductos_Activated);
            this.ResizeEnd += new System.EventHandler(this.ModuloEntradaProductos_ResizeEnd);
            this.SizeChanged += new System.EventHandler(this.ModuloEntradaProductos_SizeChanged);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.ModuloEntradaProductos_Paint);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ModuloEntradaProductos_MouseDown);
            this.panelContainer.ResumeLayout(false);
            this.panelContainer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalles)).EndInit();
            this.gboDatos.ResumeLayout(false);
            this.gboDatos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEntradaProductos)).EndInit();
            this.panelTitleBar.ResumeLayout(false);
            this.panelTitleBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelContainer;
        private System.Windows.Forms.GroupBox gboDatos;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Button btnBuscarProducto;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtProducto;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.DataGridView dgvEntradaProductos;
        private System.Windows.Forms.Panel panelTitleBar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox btnMinimizar;
        private System.Windows.Forms.PictureBox btnCerrar;
        private CustomControls btn_Registrar;
        private CustomControls btn_Modificar;
        private CustomControls btn_Deshabilitar;
        private System.Windows.Forms.DataGridView dgvDetalles;
        private System.Windows.Forms.Label label2;
        private CustomControls btnAgregarDetalle;
    }
}