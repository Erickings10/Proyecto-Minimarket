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
            this.btnAgregarCategoria = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvReporteCategorias = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReporteCategorias)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAgregarCategoria
            // 
            this.btnAgregarCategoria.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAgregarCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnAgregarCategoria.Image = ((System.Drawing.Image)(resources.GetObject("btnAgregarCategoria.Image")));
            this.btnAgregarCategoria.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgregarCategoria.Location = new System.Drawing.Point(672, 22);
            this.btnAgregarCategoria.Margin = new System.Windows.Forms.Padding(4);
            this.btnAgregarCategoria.Name = "btnAgregarCategoria";
            this.btnAgregarCategoria.Size = new System.Drawing.Size(249, 45);
            this.btnAgregarCategoria.TabIndex = 11;
            this.btnAgregarCategoria.Text = "Agregar Categoria";
            this.btnAgregarCategoria.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAgregarCategoria.UseVisualStyleBackColor = true;
            this.btnAgregarCategoria.Click += new System.EventHandler(this.btnAgregarCategoria_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(56, 28);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(211, 39);
            this.label1.TabIndex = 10;
            this.label1.Text = "CATEGORIAS:";
            // 
            // dgvReporteCategorias
            // 
            this.dgvReporteCategorias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReporteCategorias.Location = new System.Drawing.Point(56, 120);
            this.dgvReporteCategorias.Margin = new System.Windows.Forms.Padding(4);
            this.dgvReporteCategorias.Name = "dgvReporteCategorias";
            this.dgvReporteCategorias.ReadOnly = true;
            this.dgvReporteCategorias.RowHeadersWidth = 51;
            this.dgvReporteCategorias.Size = new System.Drawing.Size(865, 309);
            this.dgvReporteCategorias.TabIndex = 9;
            this.dgvReporteCategorias.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvReporteCategorias_CellDoubleClick);
            // 
            // FormReporteCategorias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(977, 450);
            this.Controls.Add(this.btnAgregarCategoria);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvReporteCategorias);
            this.Name = "FormReporteCategorias";
            this.Text = "FormReporteCategorias";
            ((System.ComponentModel.ISupportInitialize)(this.dgvReporteCategorias)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAgregarCategoria;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvReporteCategorias;
    }
}