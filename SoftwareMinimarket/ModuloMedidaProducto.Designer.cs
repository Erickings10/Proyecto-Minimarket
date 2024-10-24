namespace SoftwareMinimarket
{
    partial class ModuloMedidaProducto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ModuloMedidaProducto));
            this.panelContainer = new System.Windows.Forms.Panel();
            this.btn_Deshabilitar = new SoftwareMinimarket.CustomControls();
            this.btn_Modificar = new SoftwareMinimarket.CustomControls();
            this.btn_Agregar = new SoftwareMinimarket.CustomControls();
            this.dgvMedidaProducto = new System.Windows.Forms.DataGridView();
            this.gboxDatos = new System.Windows.Forms.GroupBox();
            this.chbxEstado = new System.Windows.Forms.CheckBox();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.panelTitleBar = new System.Windows.Forms.Panel();
            this.btnMaximizar = new System.Windows.Forms.PictureBox();
            this.btnCerrar = new System.Windows.Forms.PictureBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.panelContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMedidaProducto)).BeginInit();
            this.gboxDatos.SuspendLayout();
            this.panelTitleBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMaximizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).BeginInit();
            this.SuspendLayout();
            // 
            // panelContainer
            // 
            this.panelContainer.BackColor = System.Drawing.Color.Lavender;
            this.panelContainer.Controls.Add(this.btn_Deshabilitar);
            this.panelContainer.Controls.Add(this.btn_Modificar);
            this.panelContainer.Controls.Add(this.btn_Agregar);
            this.panelContainer.Controls.Add(this.dgvMedidaProducto);
            this.panelContainer.Controls.Add(this.gboxDatos);
            this.panelContainer.Controls.Add(this.panelTitleBar);
            this.panelContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContainer.Location = new System.Drawing.Point(0, 0);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Size = new System.Drawing.Size(734, 545);
            this.panelContainer.TabIndex = 0;
            this.panelContainer.Paint += new System.Windows.Forms.PaintEventHandler(this.panelContainer_Paint);
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
            this.btn_Deshabilitar.ForeColor = System.Drawing.Color.Black;
            this.btn_Deshabilitar.Image = ((System.Drawing.Image)(resources.GetObject("btn_Deshabilitar.Image")));
            this.btn_Deshabilitar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Deshabilitar.Location = new System.Drawing.Point(429, 125);
            this.btn_Deshabilitar.Name = "btn_Deshabilitar";
            this.btn_Deshabilitar.Size = new System.Drawing.Size(179, 47);
            this.btn_Deshabilitar.TabIndex = 110;
            this.btn_Deshabilitar.Text = "DESHABILITAR";
            this.btn_Deshabilitar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Deshabilitar.TextColor = System.Drawing.Color.Black;
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
            this.btn_Modificar.ForeColor = System.Drawing.Color.Black;
            this.btn_Modificar.Image = ((System.Drawing.Image)(resources.GetObject("btn_Modificar.Image")));
            this.btn_Modificar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Modificar.Location = new System.Drawing.Point(538, 67);
            this.btn_Modificar.Name = "btn_Modificar";
            this.btn_Modificar.Size = new System.Drawing.Size(179, 47);
            this.btn_Modificar.TabIndex = 108;
            this.btn_Modificar.Text = "MODIFICAR";
            this.btn_Modificar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Modificar.TextColor = System.Drawing.Color.Black;
            this.btn_Modificar.UseVisualStyleBackColor = false;
            this.btn_Modificar.Click += new System.EventHandler(this.btn_Modificar_Click);
            // 
            // btn_Agregar
            // 
            this.btn_Agregar.BackColor = System.Drawing.Color.Transparent;
            this.btn_Agregar.BackgroundColor = System.Drawing.Color.Transparent;
            this.btn_Agregar.BorderColor = System.Drawing.Color.Lime;
            this.btn_Agregar.BorderRadius = 0;
            this.btn_Agregar.BorderSize = 2;
            this.btn_Agregar.FlatAppearance.BorderSize = 0;
            this.btn_Agregar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGreen;
            this.btn_Agregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Agregar.ForeColor = System.Drawing.Color.Black;
            this.btn_Agregar.Image = ((System.Drawing.Image)(resources.GetObject("btn_Agregar.Image")));
            this.btn_Agregar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Agregar.Location = new System.Drawing.Point(324, 67);
            this.btn_Agregar.Name = "btn_Agregar";
            this.btn_Agregar.Size = new System.Drawing.Size(179, 47);
            this.btn_Agregar.TabIndex = 109;
            this.btn_Agregar.Text = "AGREGAR";
            this.btn_Agregar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Agregar.TextColor = System.Drawing.Color.Black;
            this.btn_Agregar.UseVisualStyleBackColor = false;
            this.btn_Agregar.Click += new System.EventHandler(this.btn_Agregar_Click);
            // 
            // dgvMedidaProducto
            // 
            this.dgvMedidaProducto.AllowUserToAddRows = false;
            this.dgvMedidaProducto.AllowUserToDeleteRows = false;
            this.dgvMedidaProducto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMedidaProducto.Location = new System.Drawing.Point(13, 195);
            this.dgvMedidaProducto.Margin = new System.Windows.Forms.Padding(4);
            this.dgvMedidaProducto.Name = "dgvMedidaProducto";
            this.dgvMedidaProducto.ReadOnly = true;
            this.dgvMedidaProducto.RowHeadersWidth = 51;
            this.dgvMedidaProducto.Size = new System.Drawing.Size(703, 332);
            this.dgvMedidaProducto.TabIndex = 98;
            this.dgvMedidaProducto.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMedidaProducto_CellClick);
            // 
            // gboxDatos
            // 
            this.gboxDatos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.gboxDatos.Controls.Add(this.chbxEstado);
            this.gboxDatos.Controls.Add(this.txtDescripcion);
            this.gboxDatos.Controls.Add(this.lblCategoria);
            this.gboxDatos.Location = new System.Drawing.Point(13, 67);
            this.gboxDatos.Margin = new System.Windows.Forms.Padding(4);
            this.gboxDatos.Name = "gboxDatos";
            this.gboxDatos.Padding = new System.Windows.Forms.Padding(4);
            this.gboxDatos.Size = new System.Drawing.Size(271, 105);
            this.gboxDatos.TabIndex = 97;
            this.gboxDatos.TabStop = false;
            this.gboxDatos.Text = "Datos";
            // 
            // chbxEstado
            // 
            this.chbxEstado.AutoSize = true;
            this.chbxEstado.Location = new System.Drawing.Point(11, 73);
            this.chbxEstado.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chbxEstado.Name = "chbxEstado";
            this.chbxEstado.Size = new System.Drawing.Size(72, 20);
            this.chbxEstado.TabIndex = 7;
            this.chbxEstado.Text = "Estado";
            this.chbxEstado.UseVisualStyleBackColor = true;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(108, 34);
            this.txtDescripcion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(143, 22);
            this.txtDescripcion.TabIndex = 5;
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Location = new System.Drawing.Point(8, 38);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(85, 16);
            this.lblCategoria.TabIndex = 1;
            this.lblCategoria.Text = "Descripcion: ";
            // 
            // panelTitleBar
            // 
            this.panelTitleBar.BackColor = System.Drawing.Color.RoyalBlue;
            this.panelTitleBar.Controls.Add(this.btnMaximizar);
            this.panelTitleBar.Controls.Add(this.btnCerrar);
            this.panelTitleBar.Controls.Add(this.lblTitulo);
            this.panelTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitleBar.Location = new System.Drawing.Point(0, 0);
            this.panelTitleBar.Name = "panelTitleBar";
            this.panelTitleBar.Size = new System.Drawing.Size(734, 50);
            this.panelTitleBar.TabIndex = 0;
            this.panelTitleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTitleBar_MouseDown);
            // 
            // btnMaximizar
            // 
            this.btnMaximizar.Image = ((System.Drawing.Image)(resources.GetObject("btnMaximizar.Image")));
            this.btnMaximizar.Location = new System.Drawing.Point(632, 7);
            this.btnMaximizar.Name = "btnMaximizar";
            this.btnMaximizar.Size = new System.Drawing.Size(35, 35);
            this.btnMaximizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMaximizar.TabIndex = 107;
            this.btnMaximizar.TabStop = false;
            // 
            // btnCerrar
            // 
            this.btnCerrar.Image = ((System.Drawing.Image)(resources.GetObject("btnCerrar.Image")));
            this.btnCerrar.Location = new System.Drawing.Point(682, 7);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(35, 35);
            this.btnCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnCerrar.TabIndex = 106;
            this.btnCerrar.TabStop = false;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Tai Le", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(17, 5);
            this.lblTitulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(312, 39);
            this.lblTitulo.TabIndex = 92;
            this.lblTitulo.Text = "UNIDAD DE MEDIDA";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // ModuloMedidaProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 545);
            this.Controls.Add(this.panelContainer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "ModuloMedidaProducto";
            this.Text = "ModuloMedidaProducto";
            this.Activated += new System.EventHandler(this.ModuloMedidaProducto_Activated);
            this.ResizeEnd += new System.EventHandler(this.ModuloMedidaProducto_ResizeEnd);
            this.SizeChanged += new System.EventHandler(this.ModuloMedidaProducto_SizeChanged);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.ModuloMedidaProducto_Paint);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ModuloMedidaProducto_MouseDown);
            this.panelContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMedidaProducto)).EndInit();
            this.gboxDatos.ResumeLayout(false);
            this.gboxDatos.PerformLayout();
            this.panelTitleBar.ResumeLayout(false);
            this.panelTitleBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMaximizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelContainer;
        private System.Windows.Forms.DataGridView dgvMedidaProducto;
        private System.Windows.Forms.GroupBox gboxDatos;
        private System.Windows.Forms.CheckBox chbxEstado;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.Panel panelTitleBar;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.PictureBox btnMaximizar;
        private System.Windows.Forms.PictureBox btnCerrar;
        private CustomControls btn_Deshabilitar;
        private CustomControls btn_Modificar;
        private CustomControls btn_Agregar;
    }
}