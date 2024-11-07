namespace SoftwareMinimarket
{
    partial class ModuloGerente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ModuloGerente));
            this.panelContainer = new System.Windows.Forms.Panel();
            this.btnDashboard = new SoftwareMinimarket.CustomControls();
            this.btnCerrarSesion = new SoftwareMinimarket.CustomControls();
            this.panelTitleBar = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_abastecimiento = new System.Windows.Forms.PictureBox();
            this.btn_almacen = new System.Windows.Forms.PictureBox();
            this.btn_ventas = new System.Windows.Forms.PictureBox();
            this.panelContainer.SuspendLayout();
            this.panelTitleBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_abastecimiento)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_almacen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_ventas)).BeginInit();
            this.SuspendLayout();
            // 
            // panelContainer
            // 
            this.panelContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(0)))), ((int)(((byte)(114)))));
            this.panelContainer.Controls.Add(this.btnDashboard);
            this.panelContainer.Controls.Add(this.btnCerrarSesion);
            this.panelContainer.Controls.Add(this.panelTitleBar);
            this.panelContainer.Controls.Add(this.label4);
            this.panelContainer.Controls.Add(this.label3);
            this.panelContainer.Controls.Add(this.label2);
            this.panelContainer.Controls.Add(this.btn_abastecimiento);
            this.panelContainer.Controls.Add(this.btn_almacen);
            this.panelContainer.Controls.Add(this.btn_ventas);
            this.panelContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContainer.Location = new System.Drawing.Point(0, 0);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Size = new System.Drawing.Size(1032, 550);
            this.panelContainer.TabIndex = 0;
            this.panelContainer.Paint += new System.Windows.Forms.PaintEventHandler(this.panelContainer_Paint);
            // 
            // btnDashboard
            // 
            this.btnDashboard.BackColor = System.Drawing.Color.Transparent;
            this.btnDashboard.BackgroundColor = System.Drawing.Color.Transparent;
            this.btnDashboard.BorderColor = System.Drawing.Color.DarkOrange;
            this.btnDashboard.BorderRadius = 15;
            this.btnDashboard.BorderSize = 2;
            this.btnDashboard.FlatAppearance.BorderSize = 0;
            this.btnDashboard.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gold;
            this.btnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDashboard.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDashboard.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnDashboard.Image = ((System.Drawing.Image)(resources.GetObject("btnDashboard.Image")));
            this.btnDashboard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDashboard.Location = new System.Drawing.Point(25, 448);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Size = new System.Drawing.Size(225, 81);
            this.btnDashboard.TabIndex = 10;
            this.btnDashboard.Text = "DASHBOARD";
            this.btnDashboard.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDashboard.TextColor = System.Drawing.Color.WhiteSmoke;
            this.btnDashboard.UseVisualStyleBackColor = false;
            this.btnDashboard.Click += new System.EventHandler(this.btnDashboard_Click);
            // 
            // btnCerrarSesion
            // 
            this.btnCerrarSesion.BackColor = System.Drawing.Color.Transparent;
            this.btnCerrarSesion.BackgroundColor = System.Drawing.Color.Transparent;
            this.btnCerrarSesion.BorderColor = System.Drawing.Color.RoyalBlue;
            this.btnCerrarSesion.BorderRadius = 15;
            this.btnCerrarSesion.BorderSize = 2;
            this.btnCerrarSesion.FlatAppearance.BorderSize = 0;
            this.btnCerrarSesion.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.btnCerrarSesion.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue;
            this.btnCerrarSesion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrarSesion.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrarSesion.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnCerrarSesion.Image = ((System.Drawing.Image)(resources.GetObject("btnCerrarSesion.Image")));
            this.btnCerrarSesion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCerrarSesion.Location = new System.Drawing.Point(830, 479);
            this.btnCerrarSesion.Name = "btnCerrarSesion";
            this.btnCerrarSesion.Size = new System.Drawing.Size(180, 50);
            this.btnCerrarSesion.TabIndex = 9;
            this.btnCerrarSesion.Text = "CERRAR SESION";
            this.btnCerrarSesion.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCerrarSesion.TextColor = System.Drawing.Color.WhiteSmoke;
            this.btnCerrarSesion.UseVisualStyleBackColor = false;
            this.btnCerrarSesion.Click += new System.EventHandler(this.btnCerrarSesion_Click);
            // 
            // panelTitleBar
            // 
            this.panelTitleBar.BackColor = System.Drawing.Color.RoyalBlue;
            this.panelTitleBar.Controls.Add(this.label1);
            this.panelTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitleBar.Location = new System.Drawing.Point(0, 0);
            this.panelTitleBar.Name = "panelTitleBar";
            this.panelTitleBar.Size = new System.Drawing.Size(1032, 50);
            this.panelTitleBar.TabIndex = 8;
            this.panelTitleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTitleBar_MouseDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft New Tai Lue", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(358, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(332, 40);
            this.label1.TabIndex = 3;
            this.label1.Text = "SELECCIONE UN AREA";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft JhengHei UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label4.Location = new System.Drawing.Point(731, 371);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(219, 29);
            this.label4.TabIndex = 6;
            this.label4.Text = "ABASTECIMIENTO";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft JhengHei UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label3.Location = new System.Drawing.Point(473, 371);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 29);
            this.label3.TabIndex = 5;
            this.label3.Text = "VENTAS";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft JhengHei UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label2.Location = new System.Drawing.Point(142, 371);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 29);
            this.label2.TabIndex = 4;
            this.label2.Text = "ALMACEN";
            // 
            // btn_abastecimiento
            // 
            this.btn_abastecimiento.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_abastecimiento.Image = ((System.Drawing.Image)(resources.GetObject("btn_abastecimiento.Image")));
            this.btn_abastecimiento.Location = new System.Drawing.Point(730, 128);
            this.btn_abastecimiento.Name = "btn_abastecimiento";
            this.btn_abastecimiento.Size = new System.Drawing.Size(220, 240);
            this.btn_abastecimiento.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btn_abastecimiento.TabIndex = 2;
            this.btn_abastecimiento.TabStop = false;
            this.btn_abastecimiento.Click += new System.EventHandler(this.btn_abastecimiento_Click);
            // 
            // btn_almacen
            // 
            this.btn_almacen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_almacen.Image = ((System.Drawing.Image)(resources.GetObject("btn_almacen.Image")));
            this.btn_almacen.Location = new System.Drawing.Point(103, 128);
            this.btn_almacen.Name = "btn_almacen";
            this.btn_almacen.Size = new System.Drawing.Size(220, 240);
            this.btn_almacen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btn_almacen.TabIndex = 1;
            this.btn_almacen.TabStop = false;
            this.btn_almacen.Click += new System.EventHandler(this.btn_almacen_Click);
            // 
            // btn_ventas
            // 
            this.btn_ventas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_ventas.Image = ((System.Drawing.Image)(resources.GetObject("btn_ventas.Image")));
            this.btn_ventas.Location = new System.Drawing.Point(416, 128);
            this.btn_ventas.Name = "btn_ventas";
            this.btn_ventas.Size = new System.Drawing.Size(220, 240);
            this.btn_ventas.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btn_ventas.TabIndex = 0;
            this.btn_ventas.TabStop = false;
            this.btn_ventas.Click += new System.EventHandler(this.btn_ventas_Click);
            // 
            // ModuloGerente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1032, 550);
            this.Controls.Add(this.panelContainer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "ModuloGerente";
            this.Text = "ModuloGerente";
            this.Activated += new System.EventHandler(this.ModuloGerente_Activated);
            this.ResizeEnd += new System.EventHandler(this.ModuloGerente_ResizeEnd);
            this.SizeChanged += new System.EventHandler(this.ModuloGerente_SizeChanged);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.ModuloGerente_Paint);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ModuloGerente_MouseDown);
            this.panelContainer.ResumeLayout(false);
            this.panelContainer.PerformLayout();
            this.panelTitleBar.ResumeLayout(false);
            this.panelTitleBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_abastecimiento)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_almacen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_ventas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelContainer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox btn_abastecimiento;
        private System.Windows.Forms.PictureBox btn_almacen;
        private System.Windows.Forms.PictureBox btn_ventas;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panelTitleBar;
        private CustomControls btnCerrarSesion;
        private CustomControls btnDashboard;
    }
}