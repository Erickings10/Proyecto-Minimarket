namespace SoftwareMinimarket
{
    partial class ModuloRubro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ModuloRubro));
            this.panelContainer = new System.Windows.Forms.Panel();
            this.btn_Deshabilitar = new SoftwareMinimarket.CustomControls();
            this.btn_Modificar = new SoftwareMinimarket.CustomControls();
            this.btn_Agregar = new SoftwareMinimarket.CustomControls();
            this.dgvRubros = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtRubro = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.chbEstado = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panelTitleBar = new System.Windows.Forms.Panel();
            this.btnMaximizar = new System.Windows.Forms.PictureBox();
            this.btnCerrar = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panelContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRubros)).BeginInit();
            this.groupBox1.SuspendLayout();
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
            this.panelContainer.Controls.Add(this.dgvRubros);
            this.panelContainer.Controls.Add(this.groupBox1);
            this.panelContainer.Controls.Add(this.panelTitleBar);
            this.panelContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContainer.Location = new System.Drawing.Point(0, 0);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Size = new System.Drawing.Size(800, 410);
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
            this.btn_Deshabilitar.Location = new System.Drawing.Point(69, 344);
            this.btn_Deshabilitar.Name = "btn_Deshabilitar";
            this.btn_Deshabilitar.Size = new System.Drawing.Size(170, 47);
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
            this.btn_Modificar.BorderSize = 3;
            this.btn_Modificar.FlatAppearance.BorderSize = 0;
            this.btn_Modificar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue;
            this.btn_Modificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Modificar.ForeColor = System.Drawing.Color.Black;
            this.btn_Modificar.Image = ((System.Drawing.Image)(resources.GetObject("btn_Modificar.Image")));
            this.btn_Modificar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Modificar.Location = new System.Drawing.Point(159, 271);
            this.btn_Modificar.Name = "btn_Modificar";
            this.btn_Modificar.Size = new System.Drawing.Size(136, 47);
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
            this.btn_Agregar.BorderSize = 3;
            this.btn_Agregar.FlatAppearance.BorderSize = 0;
            this.btn_Agregar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGreen;
            this.btn_Agregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Agregar.ForeColor = System.Drawing.Color.Black;
            this.btn_Agregar.Image = ((System.Drawing.Image)(resources.GetObject("btn_Agregar.Image")));
            this.btn_Agregar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Agregar.Location = new System.Drawing.Point(17, 271);
            this.btn_Agregar.Name = "btn_Agregar";
            this.btn_Agregar.Size = new System.Drawing.Size(136, 47);
            this.btn_Agregar.TabIndex = 109;
            this.btn_Agregar.Text = "AGREGAR";
            this.btn_Agregar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Agregar.TextColor = System.Drawing.Color.Black;
            this.btn_Agregar.UseVisualStyleBackColor = false;
            this.btn_Agregar.Click += new System.EventHandler(this.btn_Agregar_Click);
            // 
            // dgvRubros
            // 
            this.dgvRubros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRubros.Location = new System.Drawing.Point(300, 64);
            this.dgvRubros.Name = "dgvRubros";
            this.dgvRubros.RowHeadersWidth = 51;
            this.dgvRubros.RowTemplate.Height = 24;
            this.dgvRubros.Size = new System.Drawing.Size(481, 327);
            this.dgvRubros.TabIndex = 14;
            this.dgvRubros.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRubros_CellClick);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.groupBox1.Controls.Add(this.txtRubro);
            this.groupBox1.Controls.Add(this.txtID);
            this.groupBox1.Controls.Add(this.chbEstado);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(17, 66);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(270, 186);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "REGISTRAR";
            // 
            // txtRubro
            // 
            this.txtRubro.Location = new System.Drawing.Point(71, 86);
            this.txtRubro.Name = "txtRubro";
            this.txtRubro.Size = new System.Drawing.Size(149, 22);
            this.txtRubro.TabIndex = 4;
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(71, 28);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(149, 22);
            this.txtID.TabIndex = 3;
            // 
            // chbEstado
            // 
            this.chbEstado.AutoSize = true;
            this.chbEstado.Location = new System.Drawing.Point(9, 133);
            this.chbEstado.Name = "chbEstado";
            this.chbEstado.Size = new System.Drawing.Size(85, 20);
            this.chbEstado.TabIndex = 2;
            this.chbEstado.Text = "ESTADO";
            this.chbEstado.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "RUBRO:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "ID:";
            // 
            // panelTitleBar
            // 
            this.panelTitleBar.BackColor = System.Drawing.Color.RoyalBlue;
            this.panelTitleBar.Controls.Add(this.btnMaximizar);
            this.panelTitleBar.Controls.Add(this.btnCerrar);
            this.panelTitleBar.Controls.Add(this.label1);
            this.panelTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitleBar.Location = new System.Drawing.Point(0, 0);
            this.panelTitleBar.Name = "panelTitleBar";
            this.panelTitleBar.Size = new System.Drawing.Size(800, 50);
            this.panelTitleBar.TabIndex = 0;
            this.panelTitleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTitleBar_MouseDown);
            // 
            // btnMaximizar
            // 
            this.btnMaximizar.Image = ((System.Drawing.Image)(resources.GetObject("btnMaximizar.Image")));
            this.btnMaximizar.Location = new System.Drawing.Point(696, 8);
            this.btnMaximizar.Name = "btnMaximizar";
            this.btnMaximizar.Size = new System.Drawing.Size(35, 35);
            this.btnMaximizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMaximizar.TabIndex = 105;
            this.btnMaximizar.TabStop = false;
            // 
            // btnCerrar
            // 
            this.btnCerrar.Image = ((System.Drawing.Image)(resources.GetObject("btnCerrar.Image")));
            this.btnCerrar.Location = new System.Drawing.Point(746, 8);
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
            this.label1.Location = new System.Drawing.Point(21, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 39);
            this.label1.TabIndex = 8;
            this.label1.Text = "RUBRO";
            // 
            // ModuloRubro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(800, 410);
            this.Controls.Add(this.panelContainer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "ModuloRubro";
            this.Activated += new System.EventHandler(this.ModuloRubro_Activated);
            this.ResizeEnd += new System.EventHandler(this.ModuloRubro_ResizeEnd);
            this.SizeChanged += new System.EventHandler(this.ModuloRubro_SizeChanged);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.ModuloRubro_Paint);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ModuloRubro_MouseDown);
            this.panelContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRubros)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panelTitleBar.ResumeLayout(false);
            this.panelTitleBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMaximizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelContainer;
        private System.Windows.Forms.DataGridView dgvRubros;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtRubro;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.CheckBox chbEstado;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panelTitleBar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox btnMaximizar;
        private System.Windows.Forms.PictureBox btnCerrar;
        private CustomControls btn_Deshabilitar;
        private CustomControls btn_Modificar;
        private CustomControls btn_Agregar;
    }
}