namespace SoftwareMinimarket
{
    partial class FormReporteVenta
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormReporteVenta));
            this.getSalesOrderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetMostrarFecha = new SoftwareMinimarket.DataSetMostrarFecha();
            this.panelContainer = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpFechaFinal = new System.Windows.Forms.DateTimePicker();
            this.dtpFechaInicio = new System.Windows.Forms.DateTimePicker();
            this.panel = new System.Windows.Forms.Panel();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.panelTitleBar = new System.Windows.Forms.Panel();
            this.btnCerrar = new System.Windows.Forms.PictureBox();
            this.getSalesOrderTableAdapter = new SoftwareMinimarket.DataSetMostrarFechaTableAdapters.getSalesOrderTableAdapter();
            this.label5 = new System.Windows.Forms.Label();
            this.btnBuscarFecha = new SoftwareMinimarket.CustomControls();
            ((System.ComponentModel.ISupportInitialize)(this.getSalesOrderBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetMostrarFecha)).BeginInit();
            this.panelContainer.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel.SuspendLayout();
            this.panelTitleBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).BeginInit();
            this.SuspendLayout();
            // 
            // getSalesOrderBindingSource
            // 
            this.getSalesOrderBindingSource.DataMember = "getSalesOrder";
            this.getSalesOrderBindingSource.DataSource = this.dataSetMostrarFecha;
            // 
            // dataSetMostrarFecha
            // 
            this.dataSetMostrarFecha.DataSetName = "DataSetMostrarFecha";
            this.dataSetMostrarFecha.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panelContainer
            // 
            this.panelContainer.BackColor = System.Drawing.Color.Lavender;
            this.panelContainer.Controls.Add(this.panel4);
            this.panelContainer.Controls.Add(this.panel);
            this.panelContainer.Controls.Add(this.panelTitleBar);
            this.panelContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContainer.Location = new System.Drawing.Point(0, 0);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Size = new System.Drawing.Size(1282, 721);
            this.panelContainer.TabIndex = 0;
            this.panelContainer.Paint += new System.Windows.Forms.PaintEventHandler(this.panelContainer_Paint);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(0)))), ((int)(((byte)(114)))));
            this.panel4.Controls.Add(this.btnBuscarFecha);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.Add(this.dtpFechaFinal);
            this.panel4.Controls.Add(this.dtpFechaInicio);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.ForeColor = System.Drawing.Color.Black;
            this.panel4.Location = new System.Drawing.Point(0, 50);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(205, 671);
            this.panel4.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label2.Location = new System.Drawing.Point(13, 273);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "HASTA:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(13, 185);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "DESDE:";
            // 
            // dtpFechaFinal
            // 
            this.dtpFechaFinal.CalendarFont = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaFinal.CalendarTitleBackColor = System.Drawing.Color.MidnightBlue;
            this.dtpFechaFinal.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaFinal.Location = new System.Drawing.Point(17, 296);
            this.dtpFechaFinal.Name = "dtpFechaFinal";
            this.dtpFechaFinal.Size = new System.Drawing.Size(163, 22);
            this.dtpFechaFinal.TabIndex = 1;
            // 
            // dtpFechaInicio
            // 
            this.dtpFechaInicio.CalendarFont = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaInicio.CalendarTitleBackColor = System.Drawing.Color.MidnightBlue;
            this.dtpFechaInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaInicio.Location = new System.Drawing.Point(17, 208);
            this.dtpFechaInicio.Name = "dtpFechaInicio";
            this.dtpFechaInicio.Size = new System.Drawing.Size(163, 22);
            this.dtpFechaInicio.TabIndex = 0;
            // 
            // panel
            // 
            this.panel.Controls.Add(this.reportViewer1);
            this.panel.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel.Location = new System.Drawing.Point(205, 50);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(1077, 671);
            this.panel.TabIndex = 2;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.getSalesOrderBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "SoftwareMinimarket.ReportVentas.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1077, 671);
            this.reportViewer1.TabIndex = 1;
            // 
            // panelTitleBar
            // 
            this.panelTitleBar.BackColor = System.Drawing.Color.RoyalBlue;
            this.panelTitleBar.Controls.Add(this.label5);
            this.panelTitleBar.Controls.Add(this.btnCerrar);
            this.panelTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitleBar.Location = new System.Drawing.Point(0, 0);
            this.panelTitleBar.Name = "panelTitleBar";
            this.panelTitleBar.Size = new System.Drawing.Size(1282, 50);
            this.panelTitleBar.TabIndex = 0;
            this.panelTitleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTitleBar_MouseDown);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Image = ((System.Drawing.Image)(resources.GetObject("btnCerrar.Image")));
            this.btnCerrar.Location = new System.Drawing.Point(1235, 7);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(35, 35);
            this.btnCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnCerrar.TabIndex = 105;
            this.btnCerrar.TabStop = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // getSalesOrderTableAdapter
            // 
            this.getSalesOrderTableAdapter.ClearBeforeFill = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Tai Le", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(7, 5);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(318, 39);
            this.label5.TabIndex = 106;
            this.label5.Text = "REPORTE DE VENTAS";
            // 
            // btnBuscarFecha
            // 
            this.btnBuscarFecha.BackColor = System.Drawing.Color.BlueViolet;
            this.btnBuscarFecha.BackgroundColor = System.Drawing.Color.BlueViolet;
            this.btnBuscarFecha.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnBuscarFecha.BorderRadius = 20;
            this.btnBuscarFecha.BorderSize = 0;
            this.btnBuscarFecha.FlatAppearance.BorderSize = 0;
            this.btnBuscarFecha.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkViolet;
            this.btnBuscarFecha.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarFecha.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarFecha.ForeColor = System.Drawing.Color.White;
            this.btnBuscarFecha.Location = new System.Drawing.Point(17, 353);
            this.btnBuscarFecha.Name = "btnBuscarFecha";
            this.btnBuscarFecha.Size = new System.Drawing.Size(163, 40);
            this.btnBuscarFecha.TabIndex = 4;
            this.btnBuscarFecha.Text = "APLICAR";
            this.btnBuscarFecha.TextColor = System.Drawing.Color.White;
            this.btnBuscarFecha.UseVisualStyleBackColor = false;
            this.btnBuscarFecha.Click += new System.EventHandler(this.btnBuscarFecha_Click);
            // 
            // FormReporteVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1282, 721);
            this.Controls.Add(this.panelContainer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FormReporteVenta";
            this.Text = "FormReporteVenta";
            this.Activated += new System.EventHandler(this.FormReporteVenta_Activated);
            this.Load += new System.EventHandler(this.FormReporteVenta_Load);
            this.ResizeEnd += new System.EventHandler(this.FormReporteVenta_ResizeEnd);
            this.SizeChanged += new System.EventHandler(this.FormReporteVenta_SizeChanged);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.FormReporteVenta_Paint);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FormReporteVenta_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.getSalesOrderBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetMostrarFecha)).EndInit();
            this.panelContainer.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel.ResumeLayout(false);
            this.panelTitleBar.ResumeLayout(false);
            this.panelTitleBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelContainer;
        private System.Windows.Forms.Panel panelTitleBar;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource getSalesOrderBindingSource;
        private DataSetMostrarFecha dataSetMostrarFecha;
        private DataSetMostrarFechaTableAdapters.getSalesOrderTableAdapter getSalesOrderTableAdapter;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DateTimePicker dtpFechaFinal;
        private System.Windows.Forms.DateTimePicker dtpFechaInicio;
        private CustomControls btnBuscarFecha;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox btnCerrar;
        private System.Windows.Forms.Label label5;
    }
}