namespace SoftwareMinimarket
{
    partial class FormReporteCategorias
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormReporteCategorias));
            this.panelContainer = new System.Windows.Forms.Panel();
            this.btnAgregarCat = new SoftwareMinimarket.CustomControls();
            this.dgvReporteCategorias = new System.Windows.Forms.DataGridView();
            this.panelTitleBar = new System.Windows.Forms.Panel();
            this.btnMaximizar = new System.Windows.Forms.PictureBox();
            this.btnCerrar = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panelContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReporteCategorias)).BeginInit();
            this.panelTitleBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMaximizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).BeginInit();
            this.SuspendLayout();
            // 
            // panelContainer
            // 
            this.panelContainer.BackColor = System.Drawing.Color.Lavender;
            this.panelContainer.Controls.Add(this.btnAgregarCat);
            this.panelContainer.Controls.Add(this.dgvReporteCategorias);
            this.panelContainer.Controls.Add(this.panelTitleBar);
            this.panelContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContainer.Location = new System.Drawing.Point(0, 0);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Size = new System.Drawing.Size(673, 450);
            this.panelContainer.TabIndex = 0;
            this.panelContainer.Paint += new System.Windows.Forms.PaintEventHandler(this.panelContainer_Paint);
            // 
            // btnAgregarCat
            // 
            this.btnAgregarCat.BackColor = System.Drawing.Color.Transparent;
            this.btnAgregarCat.BackgroundColor = System.Drawing.Color.Transparent;
            this.btnAgregarCat.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.btnAgregarCat.BorderRadius = 20;
            this.btnAgregarCat.BorderSize = 3;
            this.btnAgregarCat.FlatAppearance.BorderSize = 0;
            this.btnAgregarCat.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue;
            this.btnAgregarCat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarCat.ForeColor = System.Drawing.Color.Black;
            this.btnAgregarCat.Image = ((System.Drawing.Image)(resources.GetObject("btnAgregarCat.Image")));
            this.btnAgregarCat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgregarCat.Location = new System.Drawing.Point(472, 60);
            this.btnAgregarCat.Name = "btnAgregarCat";
            this.btnAgregarCat.Size = new System.Drawing.Size(175, 45);
            this.btnAgregarCat.TabIndex = 15;
            this.btnAgregarCat.Text = "Agregar Categoria";
            this.btnAgregarCat.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAgregarCat.TextColor = System.Drawing.Color.Black;
            this.btnAgregarCat.UseVisualStyleBackColor = false;
            this.btnAgregarCat.Click += new System.EventHandler(this.btnAgregarCat_Click);
            // 
            // dgvReporteCategorias
            // 
            this.dgvReporteCategorias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReporteCategorias.Location = new System.Drawing.Point(24, 121);
            this.dgvReporteCategorias.Margin = new System.Windows.Forms.Padding(4);
            this.dgvReporteCategorias.Name = "dgvReporteCategorias";
            this.dgvReporteCategorias.ReadOnly = true;
            this.dgvReporteCategorias.RowHeadersWidth = 51;
            this.dgvReporteCategorias.Size = new System.Drawing.Size(623, 309);
            this.dgvReporteCategorias.TabIndex = 12;
            this.dgvReporteCategorias.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvReporteCategorias_CellDoubleClick);
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
            this.panelTitleBar.Size = new System.Drawing.Size(673, 50);
            this.panelTitleBar.TabIndex = 0;
            this.panelTitleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTitleBar_MouseDown);
            // 
            // btnMaximizar
            // 
            this.btnMaximizar.Image = ((System.Drawing.Image)(resources.GetObject("btnMaximizar.Image")));
            this.btnMaximizar.Location = new System.Drawing.Point(565, 8);
            this.btnMaximizar.Name = "btnMaximizar";
            this.btnMaximizar.Size = new System.Drawing.Size(35, 35);
            this.btnMaximizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMaximizar.TabIndex = 105;
            this.btnMaximizar.TabStop = false;
            // 
            // btnCerrar
            // 
            this.btnCerrar.Image = ((System.Drawing.Image)(resources.GetObject("btnCerrar.Image")));
            this.btnCerrar.Location = new System.Drawing.Point(615, 8);
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
            this.label1.Location = new System.Drawing.Point(17, 6);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(203, 39);
            this.label1.TabIndex = 13;
            this.label1.Text = "CATEGORIAS";
            // 
            // FormReporteCategorias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(673, 450);
            this.Controls.Add(this.panelContainer);
            this.Name = "FormReporteCategorias";
            this.Text = "FormReporteCategorias";
            this.Activated += new System.EventHandler(this.FormReporteCategorias_Activated);
            this.ResizeEnd += new System.EventHandler(this.FormReporteCategorias_ResizeEnd);
            this.SizeChanged += new System.EventHandler(this.FormReporteCategorias_SizeChanged);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.FormReporteCategorias_Paint);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FormReporteCategorias_MouseDown);
            this.panelContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvReporteCategorias)).EndInit();
            this.panelTitleBar.ResumeLayout(false);
            this.panelTitleBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMaximizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelContainer;
        private System.Windows.Forms.DataGridView dgvReporteCategorias;
        private System.Windows.Forms.Panel panelTitleBar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox btnMaximizar;
        private System.Windows.Forms.PictureBox btnCerrar;
        private CustomControls btnAgregarCat;
    }
}