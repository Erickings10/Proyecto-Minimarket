namespace SoftwareMinimarket
{
    partial class ModuloProveedor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ModuloProveedor));
            this.panelContainer = new System.Windows.Forms.Panel();
            this.btnNewRubro = new SoftwareMinimarket.CustomControls();
            this.btn_Deshabilitar = new SoftwareMinimarket.CustomControls();
            this.btn_Modificar = new SoftwareMinimarket.CustomControls();
            this.btn_Registrar = new SoftwareMinimarket.CustomControls();
            this.dgvProveedores = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbxRubro = new System.Windows.Forms.ComboBox();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.cbxEstado = new System.Windows.Forms.CheckBox();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtUbigeo = new System.Windows.Forms.TextBox();
            this.txtRUC = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panelTitleBar = new System.Windows.Forms.Panel();
            this.btnMaximizar = new System.Windows.Forms.PictureBox();
            this.btnCerrar = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panelContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProveedores)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.panelTitleBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMaximizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).BeginInit();
            this.SuspendLayout();
            // 
            // panelContainer
            // 
            this.panelContainer.BackColor = System.Drawing.Color.Lavender;
            this.panelContainer.Controls.Add(this.btnNewRubro);
            this.panelContainer.Controls.Add(this.btn_Deshabilitar);
            this.panelContainer.Controls.Add(this.btn_Modificar);
            this.panelContainer.Controls.Add(this.btn_Registrar);
            this.panelContainer.Controls.Add(this.dgvProveedores);
            this.panelContainer.Controls.Add(this.groupBox1);
            this.panelContainer.Controls.Add(this.panelTitleBar);
            this.panelContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContainer.Location = new System.Drawing.Point(0, 0);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Size = new System.Drawing.Size(1119, 465);
            this.panelContainer.TabIndex = 0;
            this.panelContainer.Paint += new System.Windows.Forms.PaintEventHandler(this.panelContainer_Paint);
            // 
            // btnNewRubro
            // 
            this.btnNewRubro.BackColor = System.Drawing.Color.Transparent;
            this.btnNewRubro.BackgroundColor = System.Drawing.Color.Transparent;
            this.btnNewRubro.BorderColor = System.Drawing.Color.Gold;
            this.btnNewRubro.BorderRadius = 20;
            this.btnNewRubro.BorderSize = 3;
            this.btnNewRubro.FlatAppearance.BorderSize = 0;
            this.btnNewRubro.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightYellow;
            this.btnNewRubro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewRubro.ForeColor = System.Drawing.Color.Black;
            this.btnNewRubro.Image = ((System.Drawing.Image)(resources.GetObject("btnNewRubro.Image")));
            this.btnNewRubro.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNewRubro.Location = new System.Drawing.Point(195, 406);
            this.btnNewRubro.Name = "btnNewRubro";
            this.btnNewRubro.Size = new System.Drawing.Size(155, 46);
            this.btnNewRubro.TabIndex = 70;
            this.btnNewRubro.Text = "Registrar Rubro";
            this.btnNewRubro.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNewRubro.TextColor = System.Drawing.Color.Black;
            this.btnNewRubro.UseVisualStyleBackColor = false;
            this.btnNewRubro.Click += new System.EventHandler(this.btnNewRubro_Click);
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
            this.btn_Deshabilitar.Location = new System.Drawing.Point(16, 409);
            this.btn_Deshabilitar.Name = "btn_Deshabilitar";
            this.btn_Deshabilitar.Size = new System.Drawing.Size(159, 44);
            this.btn_Deshabilitar.TabIndex = 69;
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
            this.btn_Modificar.Location = new System.Drawing.Point(195, 354);
            this.btn_Modificar.Name = "btn_Modificar";
            this.btn_Modificar.Size = new System.Drawing.Size(155, 46);
            this.btn_Modificar.TabIndex = 68;
            this.btn_Modificar.Text = "MODIFICAR";
            this.btn_Modificar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Modificar.TextColor = System.Drawing.Color.Black;
            this.btn_Modificar.UseVisualStyleBackColor = false;
            this.btn_Modificar.Click += new System.EventHandler(this.btn_Modificar_Click);
            // 
            // btn_Registrar
            // 
            this.btn_Registrar.BackColor = System.Drawing.Color.Transparent;
            this.btn_Registrar.BackgroundColor = System.Drawing.Color.Transparent;
            this.btn_Registrar.BorderColor = System.Drawing.Color.Lime;
            this.btn_Registrar.BorderRadius = 0;
            this.btn_Registrar.BorderSize = 3;
            this.btn_Registrar.FlatAppearance.BorderSize = 0;
            this.btn_Registrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGreen;
            this.btn_Registrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Registrar.ForeColor = System.Drawing.Color.Black;
            this.btn_Registrar.Image = ((System.Drawing.Image)(resources.GetObject("btn_Registrar.Image")));
            this.btn_Registrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Registrar.Location = new System.Drawing.Point(16, 356);
            this.btn_Registrar.Name = "btn_Registrar";
            this.btn_Registrar.Size = new System.Drawing.Size(159, 44);
            this.btn_Registrar.TabIndex = 67;
            this.btn_Registrar.Text = "REGISTRAR";
            this.btn_Registrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Registrar.TextColor = System.Drawing.Color.Black;
            this.btn_Registrar.UseVisualStyleBackColor = false;
            this.btn_Registrar.Click += new System.EventHandler(this.btn_Registrar_Click);
            // 
            // dgvProveedores
            // 
            this.dgvProveedores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProveedores.Location = new System.Drawing.Point(360, 65);
            this.dgvProveedores.Name = "dgvProveedores";
            this.dgvProveedores.RowHeadersWidth = 51;
            this.dgvProveedores.RowTemplate.Height = 24;
            this.dgvProveedores.Size = new System.Drawing.Size(737, 376);
            this.dgvProveedores.TabIndex = 13;
            this.dgvProveedores.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProveedores_CellClick);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.groupBox1.Controls.Add(this.cbxRubro);
            this.groupBox1.Controls.Add(this.dtpFecha);
            this.groupBox1.Controls.Add(this.cbxEstado);
            this.groupBox1.Controls.Add(this.txtTelefono);
            this.groupBox1.Controls.Add(this.txtNombre);
            this.groupBox1.Controls.Add(this.txtUbigeo);
            this.groupBox1.Controls.Add(this.txtRUC);
            this.groupBox1.Controls.Add(this.txtID);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(16, 65);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(334, 276);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "REGISTRAR";
            // 
            // cbxRubro
            // 
            this.cbxRubro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxRubro.FormattingEnabled = true;
            this.cbxRubro.Location = new System.Drawing.Point(105, 76);
            this.cbxRubro.Name = "cbxRubro";
            this.cbxRubro.Size = new System.Drawing.Size(200, 24);
            this.cbxRubro.TabIndex = 16;
            // 
            // dtpFecha
            // 
            this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecha.Location = new System.Drawing.Point(74, 205);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(231, 22);
            this.dtpFecha.TabIndex = 15;
            // 
            // cbxEstado
            // 
            this.cbxEstado.AutoSize = true;
            this.cbxEstado.Location = new System.Drawing.Point(9, 242);
            this.cbxEstado.Name = "cbxEstado";
            this.cbxEstado.Size = new System.Drawing.Size(85, 20);
            this.cbxEstado.TabIndex = 14;
            this.cbxEstado.Text = "ESTADO";
            this.cbxEstado.UseVisualStyleBackColor = true;
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(105, 175);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(200, 22);
            this.txtTelefono.TabIndex = 13;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(105, 141);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(200, 22);
            this.txtNombre.TabIndex = 12;
            // 
            // txtUbigeo
            // 
            this.txtUbigeo.Location = new System.Drawing.Point(105, 106);
            this.txtUbigeo.Name = "txtUbigeo";
            this.txtUbigeo.Size = new System.Drawing.Size(200, 22);
            this.txtUbigeo.TabIndex = 11;
            // 
            // txtRUC
            // 
            this.txtRUC.Location = new System.Drawing.Point(105, 46);
            this.txtRUC.Name = "txtRUC";
            this.txtRUC.Size = new System.Drawing.Size(200, 22);
            this.txtRUC.TabIndex = 9;
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(105, 17);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(200, 22);
            this.txtID.TabIndex = 8;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(6, 208);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 18);
            this.label8.TabIndex = 6;
            this.label8.Text = "FECHA:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(6, 176);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(93, 18);
            this.label7.TabIndex = 5;
            this.label7.Text = "TELEFONO:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(6, 142);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 18);
            this.label6.TabIndex = 4;
            this.label6.Text = "NOMBRE:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 109);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 18);
            this.label5.TabIndex = 3;
            this.label5.Text = "UBIGEO:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 79);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 18);
            this.label4.TabIndex = 2;
            this.label4.Text = "RUBRO:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 18);
            this.label3.TabIndex = 1;
            this.label3.Text = "RUC:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 18);
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
            this.panelTitleBar.Size = new System.Drawing.Size(1119, 50);
            this.panelTitleBar.TabIndex = 0;
            this.panelTitleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTitleBar_MouseDown);
            // 
            // btnMaximizar
            // 
            this.btnMaximizar.Image = ((System.Drawing.Image)(resources.GetObject("btnMaximizar.Image")));
            this.btnMaximizar.Location = new System.Drawing.Point(1014, 8);
            this.btnMaximizar.Name = "btnMaximizar";
            this.btnMaximizar.Size = new System.Drawing.Size(35, 35);
            this.btnMaximizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMaximizar.TabIndex = 105;
            this.btnMaximizar.TabStop = false;
            // 
            // btnCerrar
            // 
            this.btnCerrar.Image = ((System.Drawing.Image)(resources.GetObject("btnCerrar.Image")));
            this.btnCerrar.Location = new System.Drawing.Point(1064, 8);
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
            this.label1.Location = new System.Drawing.Point(122, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(228, 39);
            this.label1.TabIndex = 8;
            this.label1.Text = "PROVEEDORES";
            // 
            // ModuloProveedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(1119, 465);
            this.Controls.Add(this.panelContainer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "ModuloProveedor";
            this.Activated += new System.EventHandler(this.ModuloProveedor_Activated);
            this.Load += new System.EventHandler(this.FormProveedor_Load);
            this.ResizeEnd += new System.EventHandler(this.ModuloProveedor_ResizeEnd);
            this.SizeChanged += new System.EventHandler(this.ModuloProveedor_SizeChanged);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.ModuloProveedor_Paint);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ModuloProveedor_MouseDown);
            this.panelContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProveedores)).EndInit();
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
        private System.Windows.Forms.DataGridView dgvProveedores;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbxRubro;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.CheckBox cbxEstado;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtUbigeo;
        private System.Windows.Forms.TextBox txtRUC;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panelTitleBar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox btnMaximizar;
        private System.Windows.Forms.PictureBox btnCerrar;
        private CustomControls btn_Deshabilitar;
        private CustomControls btn_Modificar;
        private CustomControls btn_Registrar;
        private CustomControls btnNewRubro;
    }
}