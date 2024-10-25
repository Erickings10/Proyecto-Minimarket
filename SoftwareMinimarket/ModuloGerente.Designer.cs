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
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_abastecimiento = new System.Windows.Forms.PictureBox();
            this.btn_almacen = new System.Windows.Forms.PictureBox();
            this.btn_ventas = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_abastecimiento)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_almacen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_ventas)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MistyRose;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btn_abastecimiento);
            this.panel1.Controls.Add(this.btn_almacen);
            this.panel1.Controls.Add(this.btn_ventas);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1032, 550);
            this.panel1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(775, 479);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(193, 49);
            this.button1.TabIndex = 7;
            this.button1.Text = "CERRAR SESION";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft JhengHei UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.label2.Location = new System.Drawing.Point(142, 371);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 29);
            this.label2.TabIndex = 4;
            this.label2.Text = "ALMACEN";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft JhengHei UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(388, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(262, 29);
            this.label1.TabIndex = 3;
            this.label1.Text = "SELECCIONE UN AREA";
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
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ModuloGerente";
            this.Text = "ModuloGerente";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_abastecimiento)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_almacen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_ventas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox btn_abastecimiento;
        private System.Windows.Forms.PictureBox btn_almacen;
        private System.Windows.Forms.PictureBox btn_ventas;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
    }
}