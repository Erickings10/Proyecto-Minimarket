namespace SoftwareMinimarket
{
    partial class ModuloCategoriaProducto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ModuloCategoriaProducto));
            this.panelContainer = new System.Windows.Forms.Panel();
            this.btn_Deshabilitar = new SoftwareMinimarket.CustomControls();
            this.btn_Modificar = new SoftwareMinimarket.CustomControls();
            this.btn_Agregar = new SoftwareMinimarket.CustomControls();
            this.dgvCategoriaProducto = new System.Windows.Forms.DataGridView();
            this.gboxDatos = new System.Windows.Forms.GroupBox();
            this.chbxEstado = new System.Windows.Forms.CheckBox();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.panelTitleBar = new System.Windows.Forms.Panel();
            this.btnMaximizar = new System.Windows.Forms.PictureBox();
            this.btnCerrar = new System.Windows.Forms.PictureBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.panelContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategoriaProducto)).BeginInit();
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
            this.panelContainer.Controls.Add(this.dgvCategoriaProducto);
            this.panelContainer.Controls.Add(this.gboxDatos);
            this.panelContainer.Controls.Add(this.panelTitleBar);
            this.panelContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContainer.Location = new System.Drawing.Point(0, 0);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Size = new System.Drawing.Size(723, 447);
            this.panelContainer.TabIndex = 0;
            this.panelContainer.Paint += new System.Windows.Forms.PaintEventHandler(this.panelContainer_Paint);
            // 
            // btn_Deshabilitar
            // 
            this.btn_Deshabilitar.BackColor = System.Drawing.Color.Transparent;
            this.btn_Deshabilitar.BackgroundColor = System.Drawing.Color.Transparent;
            this.btn_Deshabilitar.BorderColor = System.Drawing.Color.OrangeRed;
            this.btn_Deshabilitar.BorderRadius = 0;
            this.btn_Deshabilitar.BorderSize = 3;
            this.btn_Deshabilitar.FlatAppearance.BorderSize = 0;
            this.btn_Deshabilitar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightCoral;
            this.btn_Deshabilitar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Deshabilitar.ForeColor = System.Drawing.Color.Black;
            this.btn_Deshabilitar.Image = ((System.Drawing.Image)(resources.GetObject("btn_Deshabilitar.Image")));
            this.btn_Deshabilitar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Deshabilitar.Location = new System.Drawing.Point(417, 142);
            this.btn_Deshabilitar.Name = "btn_Deshabilitar";
            this.btn_Deshabilitar.Size = new System.Drawing.Size(179, 47);
            this.btn_Deshabilitar.TabIndex = 107;
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
            this.btn_Modificar.BorderSize = 3;
            this.btn_Modificar.FlatAppearance.BorderSize = 0;
            this.btn_Modificar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue;
            this.btn_Modificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Modificar.ForeColor = System.Drawing.Color.Black;
            this.btn_Modificar.Image = ((System.Drawing.Image)(resources.GetObject("btn_Modificar.Image")));
            this.btn_Modificar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Modificar.Location = new System.Drawing.Point(520, 70);
            this.btn_Modificar.Name = "btn_Modificar";
            this.btn_Modificar.Size = new System.Drawing.Size(179, 47);
            this.btn_Modificar.TabIndex = 106;
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
            this.btn_Agregar.BorderSize = 3;
            this.btn_Agregar.FlatAppearance.BorderSize = 0;
            this.btn_Agregar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGreen;
            this.btn_Agregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Agregar.ForeColor = System.Drawing.Color.Black;
            this.btn_Agregar.Image = ((System.Drawing.Image)(resources.GetObject("btn_Agregar.Image")));
            this.btn_Agregar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Agregar.Location = new System.Drawing.Point(318, 70);
            this.btn_Agregar.Name = "btn_Agregar";
            this.btn_Agregar.Size = new System.Drawing.Size(179, 47);
            this.btn_Agregar.TabIndex = 106;
            this.btn_Agregar.Text = "AGREGAR";
            this.btn_Agregar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Agregar.TextColor = System.Drawing.Color.Black;
            this.btn_Agregar.UseVisualStyleBackColor = false;
            this.btn_Agregar.Click += new System.EventHandler(this.btn_Agregar_Click);
            // 
            // dgvCategoriaProducto
            // 
            this.dgvCategoriaProducto.AllowUserToOrderColumns = true;
            this.dgvCategoriaProducto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCategoriaProducto.Location = new System.Drawing.Point(25, 215);
            this.dgvCategoriaProducto.Margin = new System.Windows.Forms.Padding(4);
            this.dgvCategoriaProducto.Name = "dgvCategoriaProducto";
            this.dgvCategoriaProducto.RowHeadersWidth = 51;
            this.dgvCategoriaProducto.Size = new System.Drawing.Size(674, 208);
            this.dgvCategoriaProducto.TabIndex = 92;
            this.dgvCategoriaProducto.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCategoriaProducto_CellClick);
            // 
            // gboxDatos
            // 
            this.gboxDatos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.gboxDatos.Controls.Add(this.chbxEstado);
            this.gboxDatos.Controls.Add(this.txtDescripcion);
            this.gboxDatos.Controls.Add(this.lblCategoria);
            this.gboxDatos.Location = new System.Drawing.Point(18, 70);
            this.gboxDatos.Margin = new System.Windows.Forms.Padding(4);
            this.gboxDatos.Name = "gboxDatos";
            this.gboxDatos.Padding = new System.Windows.Forms.Padding(4);
            this.gboxDatos.Size = new System.Drawing.Size(268, 119);
            this.gboxDatos.TabIndex = 91;
            this.gboxDatos.TabStop = false;
            this.gboxDatos.Text = "DATOS";
            // 
            // chbxEstado
            // 
            this.chbxEstado.AutoSize = true;
            this.chbxEstado.Location = new System.Drawing.Point(7, 82);
            this.chbxEstado.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chbxEstado.Name = "chbxEstado";
            this.chbxEstado.Size = new System.Drawing.Size(72, 20);
            this.chbxEstado.TabIndex = 7;
            this.chbxEstado.Text = "Estado";
            this.chbxEstado.UseVisualStyleBackColor = true;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(104, 39);
            this.txtDescripcion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(143, 22);
            this.txtDescripcion.TabIndex = 5;
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Location = new System.Drawing.Point(4, 43);
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
            this.panelTitleBar.Size = new System.Drawing.Size(723, 50);
            this.panelTitleBar.TabIndex = 0;
            this.panelTitleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTitleBar_MouseDown);
            // 
            // btnMaximizar
            // 
            this.btnMaximizar.Image = ((System.Drawing.Image)(resources.GetObject("btnMaximizar.Image")));
            this.btnMaximizar.Location = new System.Drawing.Point(618, 7);
            this.btnMaximizar.Name = "btnMaximizar";
            this.btnMaximizar.Size = new System.Drawing.Size(35, 35);
            this.btnMaximizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMaximizar.TabIndex = 105;
            this.btnMaximizar.TabStop = false;
            // 
            // btnCerrar
            // 
            this.btnCerrar.Image = ((System.Drawing.Image)(resources.GetObject("btnCerrar.Image")));
            this.btnCerrar.Location = new System.Drawing.Point(668, 7);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(35, 35);
            this.btnCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnCerrar.TabIndex = 104;
            this.btnCerrar.TabStop = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Tai Le", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(13, 6);
            this.lblTitulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(186, 39);
            this.lblTitulo.TabIndex = 86;
            this.lblTitulo.Text = "CATEGORIA";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // ModuloCategoriaProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(723, 447);
            this.Controls.Add(this.panelContainer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "ModuloCategoriaProducto";
            this.Text = "ModuloCategoria";
            this.Activated += new System.EventHandler(this.ModuloCategoriaProducto_Activated);
            this.ResizeEnd += new System.EventHandler(this.ModuloCategoriaProducto_ResizeEnd);
            this.SizeChanged += new System.EventHandler(this.ModuloCategoriaProducto_SizeChanged);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.ModuloCategoriaProducto_Paint);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ModuloCategoriaProducto_MouseDown);
            this.panelContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategoriaProducto)).EndInit();
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
        private System.Windows.Forms.DataGridView dgvCategoriaProducto;
        private System.Windows.Forms.GroupBox gboxDatos;
        private System.Windows.Forms.CheckBox chbxEstado;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.Panel panelTitleBar;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.PictureBox btnMaximizar;
        private System.Windows.Forms.PictureBox btnCerrar;
        private CustomControls btn_Agregar;
        private CustomControls btn_Modificar;
        private CustomControls btn_Deshabilitar;
    }
}