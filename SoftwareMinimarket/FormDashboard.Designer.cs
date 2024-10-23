namespace SoftwareMinimarket
{
    partial class FormDashboard
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea13 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend13 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series13 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title13 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea14 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend14 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series14 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title14 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDashboard));
            this.panelContainer = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.dgvUnderstock = new System.Windows.Forms.DataGridView();
            this.label10 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lblNumProducts = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblNumCustomers = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.chartTopProducts = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartGrossRevenue = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblTotalProfit = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblTotalRevenue = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblNumOrders = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpEndDate = new System.Windows.Forms.DateTimePicker();
            this.dtpStartDate = new System.Windows.Forms.DateTimePicker();
            this.panelTitleBar = new System.Windows.Forms.Panel();
            this.btnMinimizar = new System.Windows.Forms.PictureBox();
            this.btnMaximizar = new System.Windows.Forms.PictureBox();
            this.btnCerrar = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnOkCustomDate = new SoftwareMinimarket.CustomControls();
            this.btnCustomDate = new SoftwareMinimarket.CustomControls();
            this.btnToday = new SoftwareMinimarket.CustomControls();
            this.btnLast7days = new SoftwareMinimarket.CustomControls();
            this.btnLast30days = new SoftwareMinimarket.CustomControls();
            this.btnThisMonth = new SoftwareMinimarket.CustomControls();
            this.panelContainer.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUnderstock)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartTopProducts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartGrossRevenue)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panelTitleBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMaximizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).BeginInit();
            this.SuspendLayout();
            // 
            // panelContainer
            // 
            this.panelContainer.BackColor = System.Drawing.Color.Lavender;
            this.panelContainer.Controls.Add(this.panel5);
            this.panelContainer.Controls.Add(this.panel4);
            this.panelContainer.Controls.Add(this.chartTopProducts);
            this.panelContainer.Controls.Add(this.chartGrossRevenue);
            this.panelContainer.Controls.Add(this.panel3);
            this.panelContainer.Controls.Add(this.panel2);
            this.panelContainer.Controls.Add(this.panel1);
            this.panelContainer.Controls.Add(this.btnOkCustomDate);
            this.panelContainer.Controls.Add(this.btnCustomDate);
            this.panelContainer.Controls.Add(this.btnToday);
            this.panelContainer.Controls.Add(this.btnLast7days);
            this.panelContainer.Controls.Add(this.btnLast30days);
            this.panelContainer.Controls.Add(this.btnThisMonth);
            this.panelContainer.Controls.Add(this.label2);
            this.panelContainer.Controls.Add(this.dtpEndDate);
            this.panelContainer.Controls.Add(this.dtpStartDate);
            this.panelContainer.Controls.Add(this.panelTitleBar);
            this.panelContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContainer.Location = new System.Drawing.Point(0, 0);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Size = new System.Drawing.Size(1182, 683);
            this.panelContainer.TabIndex = 0;
            this.panelContainer.Paint += new System.Windows.Forms.PaintEventHandler(this.panelContainer_Paint);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.LightSkyBlue;
            this.panel5.Controls.Add(this.dgvUnderstock);
            this.panel5.Controls.Add(this.label10);
            this.panel5.Location = new System.Drawing.Point(215, 480);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(572, 186);
            this.panel5.TabIndex = 16;
            // 
            // dgvUnderstock
            // 
            this.dgvUnderstock.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvUnderstock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUnderstock.Location = new System.Drawing.Point(11, 26);
            this.dgvUnderstock.Name = "dgvUnderstock";
            this.dgvUnderstock.RowHeadersWidth = 51;
            this.dgvUnderstock.RowTemplate.Height = 24;
            this.dgvUnderstock.Size = new System.Drawing.Size(548, 146);
            this.dgvUnderstock.TabIndex = 17;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Tai Le", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(7, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(204, 23);
            this.label10.TabIndex = 16;
            this.label10.Text = "Productos de Bajo Stock";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.LightSkyBlue;
            this.panel4.Controls.Add(this.lblNumProducts);
            this.panel4.Controls.Add(this.label8);
            this.panel4.Controls.Add(this.label9);
            this.panel4.Controls.Add(this.lblNumCustomers);
            this.panel4.Controls.Add(this.label7);
            this.panel4.Location = new System.Drawing.Point(17, 480);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(192, 186);
            this.panel4.TabIndex = 15;
            // 
            // lblNumProducts
            // 
            this.lblNumProducts.AutoSize = true;
            this.lblNumProducts.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumProducts.Location = new System.Drawing.Point(6, 131);
            this.lblNumProducts.Name = "lblNumProducts";
            this.lblNumProducts.Size = new System.Drawing.Size(97, 29);
            this.lblNumProducts.TabIndex = 16;
            this.lblNumProducts.Text = "100000";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Tai Le", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(7, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(129, 23);
            this.label8.TabIndex = 16;
            this.label8.Text = "Contador Total";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(7, 107);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(155, 19);
            this.label9.TabIndex = 17;
            this.label9.Text = "Número de productos";
            // 
            // lblNumCustomers
            // 
            this.lblNumCustomers.AutoSize = true;
            this.lblNumCustomers.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumCustomers.Location = new System.Drawing.Point(6, 62);
            this.lblNumCustomers.Name = "lblNumCustomers";
            this.lblNumCustomers.Size = new System.Drawing.Size(97, 29);
            this.lblNumCustomers.TabIndex = 11;
            this.lblNumCustomers.Text = "100000";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(7, 38);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(138, 19);
            this.label7.TabIndex = 11;
            this.label7.Text = "Número de clientes";
            // 
            // chartTopProducts
            // 
            chartArea13.Name = "ChartArea1";
            this.chartTopProducts.ChartAreas.Add(chartArea13);
            legend13.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
            legend13.Name = "Legend1";
            this.chartTopProducts.Legends.Add(legend13);
            this.chartTopProducts.Location = new System.Drawing.Point(793, 165);
            this.chartTopProducts.Name = "chartTopProducts";
            series13.ChartArea = "ChartArea1";
            series13.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            series13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            series13.IsValueShownAsLabel = true;
            series13.LabelForeColor = System.Drawing.Color.White;
            series13.Legend = "Legend1";
            series13.Name = "Series1";
            this.chartTopProducts.Series.Add(series13);
            this.chartTopProducts.Size = new System.Drawing.Size(372, 506);
            this.chartTopProducts.TabIndex = 14;
            this.chartTopProducts.Text = "chart2";
            title13.Alignment = System.Drawing.ContentAlignment.TopLeft;
            title13.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            title13.Name = "Title1";
            title13.Text = "Top 5 Productos";
            this.chartTopProducts.Titles.Add(title13);
            // 
            // chartGrossRevenue
            // 
            chartArea14.Name = "ChartArea1";
            this.chartGrossRevenue.ChartAreas.Add(chartArea14);
            legend14.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Top;
            legend14.Name = "Legend1";
            this.chartGrossRevenue.Legends.Add(legend14);
            this.chartGrossRevenue.Location = new System.Drawing.Point(17, 165);
            this.chartGrossRevenue.Name = "chartGrossRevenue";
            series14.ChartArea = "ChartArea1";
            series14.Legend = "Legend1";
            series14.Name = "Series1";
            this.chartGrossRevenue.Series.Add(series14);
            this.chartGrossRevenue.Size = new System.Drawing.Size(770, 300);
            this.chartGrossRevenue.TabIndex = 13;
            this.chartGrossRevenue.Text = "chart1";
            title14.Alignment = System.Drawing.ContentAlignment.TopLeft;
            title14.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            title14.Name = "Title1";
            title14.Text = "Ingreso Bruto";
            this.chartGrossRevenue.Titles.Add(title14);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.LightSkyBlue;
            this.panel3.Controls.Add(this.lblTotalProfit);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Location = new System.Drawing.Point(659, 89);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(506, 70);
            this.panel3.TabIndex = 12;
            // 
            // lblTotalProfit
            // 
            this.lblTotalProfit.AutoSize = true;
            this.lblTotalProfit.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalProfit.Location = new System.Drawing.Point(5, 30);
            this.lblTotalProfit.Name = "lblTotalProfit";
            this.lblTotalProfit.Size = new System.Drawing.Size(97, 29);
            this.lblTotalProfit.TabIndex = 11;
            this.lblTotalProfit.Text = "100000";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(6, 6);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(109, 19);
            this.label6.TabIndex = 11;
            this.label6.Text = "Beneficio Total";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightSkyBlue;
            this.panel2.Controls.Add(this.lblTotalRevenue);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Location = new System.Drawing.Point(303, 89);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(350, 70);
            this.panel2.TabIndex = 11;
            // 
            // lblTotalRevenue
            // 
            this.lblTotalRevenue.AutoSize = true;
            this.lblTotalRevenue.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalRevenue.Location = new System.Drawing.Point(5, 30);
            this.lblTotalRevenue.Name = "lblTotalRevenue";
            this.lblTotalRevenue.Size = new System.Drawing.Size(97, 29);
            this.lblTotalRevenue.TabIndex = 11;
            this.lblTotalRevenue.Text = "100000";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 6);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(116, 19);
            this.label5.TabIndex = 11;
            this.label5.Text = "Ingresos Totales";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.panel1.Controls.Add(this.lblNumOrders);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(17, 89);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(280, 70);
            this.panel1.TabIndex = 10;
            // 
            // lblNumOrders
            // 
            this.lblNumOrders.AutoSize = true;
            this.lblNumOrders.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumOrders.Location = new System.Drawing.Point(5, 30);
            this.lblNumOrders.Name = "lblNumOrders";
            this.lblNumOrders.Size = new System.Drawing.Size(97, 29);
            this.lblNumOrders.TabIndex = 11;
            this.lblNumOrders.Text = "100000";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 19);
            this.label3.TabIndex = 11;
            this.label3.Text = "Número de ventas";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "ESTADISTICAS";
            // 
            // dtpEndDate
            // 
            this.dtpEndDate.CustomFormat = "MMM dd, yyyy";
            this.dtpEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpEndDate.Location = new System.Drawing.Point(305, 61);
            this.dtpEndDate.Name = "dtpEndDate";
            this.dtpEndDate.Size = new System.Drawing.Size(144, 22);
            this.dtpEndDate.TabIndex = 2;
            // 
            // dtpStartDate
            // 
            this.dtpStartDate.CustomFormat = "MMM dd, yyyy";
            this.dtpStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpStartDate.Location = new System.Drawing.Point(155, 61);
            this.dtpStartDate.Name = "dtpStartDate";
            this.dtpStartDate.Size = new System.Drawing.Size(144, 22);
            this.dtpStartDate.TabIndex = 1;
            // 
            // panelTitleBar
            // 
            this.panelTitleBar.BackColor = System.Drawing.Color.RoyalBlue;
            this.panelTitleBar.Controls.Add(this.btnMinimizar);
            this.panelTitleBar.Controls.Add(this.btnMaximizar);
            this.panelTitleBar.Controls.Add(this.btnCerrar);
            this.panelTitleBar.Controls.Add(this.label1);
            this.panelTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitleBar.Location = new System.Drawing.Point(0, 0);
            this.panelTitleBar.Name = "panelTitleBar";
            this.panelTitleBar.Size = new System.Drawing.Size(1182, 50);
            this.panelTitleBar.TabIndex = 0;
            this.panelTitleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTitleBar_MouseDown);
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.Image = ((System.Drawing.Image)(resources.GetObject("btnMinimizar.Image")));
            this.btnMinimizar.Location = new System.Drawing.Point(1039, 8);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(35, 35);
            this.btnMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMinimizar.TabIndex = 106;
            this.btnMinimizar.TabStop = false;
            this.btnMinimizar.Click += new System.EventHandler(this.btnMinimizar_Click);
            // 
            // btnMaximizar
            // 
            this.btnMaximizar.Image = ((System.Drawing.Image)(resources.GetObject("btnMaximizar.Image")));
            this.btnMaximizar.Location = new System.Drawing.Point(1087, 8);
            this.btnMaximizar.Name = "btnMaximizar";
            this.btnMaximizar.Size = new System.Drawing.Size(35, 35);
            this.btnMaximizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMaximizar.TabIndex = 105;
            this.btnMaximizar.TabStop = false;
            // 
            // btnCerrar
            // 
            this.btnCerrar.Image = ((System.Drawing.Image)(resources.GetObject("btnCerrar.Image")));
            this.btnCerrar.Location = new System.Drawing.Point(1137, 8);
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
            this.label1.Location = new System.Drawing.Point(4, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(205, 39);
            this.label1.TabIndex = 1;
            this.label1.Text = "DASHBOARD";
            // 
            // btnOkCustomDate
            // 
            this.btnOkCustomDate.BackColor = System.Drawing.Color.Transparent;
            this.btnOkCustomDate.BackgroundColor = System.Drawing.Color.Transparent;
            this.btnOkCustomDate.BorderColor = System.Drawing.Color.MediumBlue;
            this.btnOkCustomDate.BorderRadius = 3;
            this.btnOkCustomDate.BorderSize = 1;
            this.btnOkCustomDate.FlatAppearance.BorderSize = 0;
            this.btnOkCustomDate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnOkCustomDate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOkCustomDate.ForeColor = System.Drawing.Color.Black;
            this.btnOkCustomDate.Location = new System.Drawing.Point(473, 56);
            this.btnOkCustomDate.Name = "btnOkCustomDate";
            this.btnOkCustomDate.Size = new System.Drawing.Size(70, 30);
            this.btnOkCustomDate.TabIndex = 9;
            this.btnOkCustomDate.Text = "OK";
            this.btnOkCustomDate.TextColor = System.Drawing.Color.Black;
            this.btnOkCustomDate.UseVisualStyleBackColor = false;
            this.btnOkCustomDate.Click += new System.EventHandler(this.btnOkCustomDate_Click);
            // 
            // btnCustomDate
            // 
            this.btnCustomDate.BackColor = System.Drawing.Color.Transparent;
            this.btnCustomDate.BackgroundColor = System.Drawing.Color.Transparent;
            this.btnCustomDate.BorderColor = System.Drawing.Color.MediumBlue;
            this.btnCustomDate.BorderRadius = 3;
            this.btnCustomDate.BorderSize = 1;
            this.btnCustomDate.FlatAppearance.BorderSize = 0;
            this.btnCustomDate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnCustomDate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCustomDate.ForeColor = System.Drawing.Color.Black;
            this.btnCustomDate.Location = new System.Drawing.Point(541, 56);
            this.btnCustomDate.Name = "btnCustomDate";
            this.btnCustomDate.Size = new System.Drawing.Size(120, 30);
            this.btnCustomDate.TabIndex = 8;
            this.btnCustomDate.Text = "Personalizado";
            this.btnCustomDate.TextColor = System.Drawing.Color.Black;
            this.btnCustomDate.UseVisualStyleBackColor = false;
            this.btnCustomDate.Click += new System.EventHandler(this.btnCustomDate_Click);
            // 
            // btnToday
            // 
            this.btnToday.BackColor = System.Drawing.Color.Transparent;
            this.btnToday.BackgroundColor = System.Drawing.Color.Transparent;
            this.btnToday.BorderColor = System.Drawing.Color.MediumBlue;
            this.btnToday.BorderRadius = 3;
            this.btnToday.BorderSize = 1;
            this.btnToday.FlatAppearance.BorderSize = 0;
            this.btnToday.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnToday.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnToday.ForeColor = System.Drawing.Color.Black;
            this.btnToday.Location = new System.Drawing.Point(667, 56);
            this.btnToday.Name = "btnToday";
            this.btnToday.Size = new System.Drawing.Size(120, 30);
            this.btnToday.TabIndex = 7;
            this.btnToday.Text = "Hoy";
            this.btnToday.TextColor = System.Drawing.Color.Black;
            this.btnToday.UseVisualStyleBackColor = false;
            this.btnToday.Click += new System.EventHandler(this.btnToday_Click);
            // 
            // btnLast7days
            // 
            this.btnLast7days.BackColor = System.Drawing.Color.Transparent;
            this.btnLast7days.BackgroundColor = System.Drawing.Color.Transparent;
            this.btnLast7days.BorderColor = System.Drawing.Color.MediumBlue;
            this.btnLast7days.BorderRadius = 3;
            this.btnLast7days.BorderSize = 1;
            this.btnLast7days.FlatAppearance.BorderSize = 0;
            this.btnLast7days.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnLast7days.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLast7days.ForeColor = System.Drawing.Color.Black;
            this.btnLast7days.Location = new System.Drawing.Point(793, 56);
            this.btnLast7days.Name = "btnLast7days";
            this.btnLast7days.Size = new System.Drawing.Size(120, 30);
            this.btnLast7days.TabIndex = 6;
            this.btnLast7days.Text = "Ultimos 7 dias";
            this.btnLast7days.TextColor = System.Drawing.Color.Black;
            this.btnLast7days.UseVisualStyleBackColor = false;
            this.btnLast7days.Click += new System.EventHandler(this.btnLast7days_Click);
            // 
            // btnLast30days
            // 
            this.btnLast30days.BackColor = System.Drawing.Color.Transparent;
            this.btnLast30days.BackgroundColor = System.Drawing.Color.Transparent;
            this.btnLast30days.BorderColor = System.Drawing.Color.MediumBlue;
            this.btnLast30days.BorderRadius = 3;
            this.btnLast30days.BorderSize = 1;
            this.btnLast30days.FlatAppearance.BorderSize = 0;
            this.btnLast30days.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnLast30days.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLast30days.ForeColor = System.Drawing.Color.Black;
            this.btnLast30days.Location = new System.Drawing.Point(919, 56);
            this.btnLast30days.Name = "btnLast30days";
            this.btnLast30days.Size = new System.Drawing.Size(120, 30);
            this.btnLast30days.TabIndex = 5;
            this.btnLast30days.Text = "Ultimos 30 dias";
            this.btnLast30days.TextColor = System.Drawing.Color.Black;
            this.btnLast30days.UseVisualStyleBackColor = false;
            this.btnLast30days.Click += new System.EventHandler(this.btnLast30days_Click);
            // 
            // btnThisMonth
            // 
            this.btnThisMonth.BackColor = System.Drawing.Color.Transparent;
            this.btnThisMonth.BackgroundColor = System.Drawing.Color.Transparent;
            this.btnThisMonth.BorderColor = System.Drawing.Color.MediumBlue;
            this.btnThisMonth.BorderRadius = 3;
            this.btnThisMonth.BorderSize = 1;
            this.btnThisMonth.FlatAppearance.BorderSize = 0;
            this.btnThisMonth.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnThisMonth.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThisMonth.ForeColor = System.Drawing.Color.Black;
            this.btnThisMonth.Location = new System.Drawing.Point(1045, 56);
            this.btnThisMonth.Name = "btnThisMonth";
            this.btnThisMonth.Size = new System.Drawing.Size(120, 30);
            this.btnThisMonth.TabIndex = 4;
            this.btnThisMonth.Text = "Este Mes";
            this.btnThisMonth.TextColor = System.Drawing.Color.Black;
            this.btnThisMonth.UseVisualStyleBackColor = false;
            this.btnThisMonth.Click += new System.EventHandler(this.btnThisMonth_Click);
            // 
            // FormDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 683);
            this.Controls.Add(this.panelContainer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FormDashboard";
            this.Text = "Dashboard";
            this.Activated += new System.EventHandler(this.Dashboard_Activated);
            this.ResizeEnd += new System.EventHandler(this.Dashboard_ResizeEnd);
            this.SizeChanged += new System.EventHandler(this.Dashboard_SizeChanged);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Dashboard_Paint);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Dashboard_MouseDown);
            this.panelContainer.ResumeLayout(false);
            this.panelContainer.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUnderstock)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartTopProducts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartGrossRevenue)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelTitleBar.ResumeLayout(false);
            this.panelTitleBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMaximizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelContainer;
        private System.Windows.Forms.Panel panelTitleBar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox btnMinimizar;
        private System.Windows.Forms.PictureBox btnMaximizar;
        private System.Windows.Forms.PictureBox btnCerrar;
        private System.Windows.Forms.DateTimePicker dtpEndDate;
        private System.Windows.Forms.DateTimePicker dtpStartDate;
        private System.Windows.Forms.Label label2;
        private CustomControls btnCustomDate;
        private CustomControls btnToday;
        private CustomControls btnLast7days;
        private CustomControls btnLast30days;
        private CustomControls btnThisMonth;
        private CustomControls btnOkCustomDate;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblTotalProfit;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblTotalRevenue;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblNumOrders;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartGrossRevenue;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lblNumCustomers;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartTopProducts;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblNumProducts;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView dgvUnderstock;
    }
}