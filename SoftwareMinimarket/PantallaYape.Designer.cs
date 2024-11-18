namespace SoftwareMinimarket
{
    partial class PantallaYape
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PantallaYape));
            this.btnConfirmarVenta = new SoftwareMinimarket.CustomControls();
            this.txtCliente = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.txtOTP = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNumYape = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.btnConfirmarPago = new SoftwareMinimarket.CustomControls();
            this.SuspendLayout();
            // 
            // btnConfirmarVenta
            // 
            this.btnConfirmarVenta.BackColor = System.Drawing.Color.Transparent;
            this.btnConfirmarVenta.BackgroundColor = System.Drawing.Color.Transparent;
            this.btnConfirmarVenta.BorderColor = System.Drawing.Color.Lime;
            this.btnConfirmarVenta.BorderRadius = 10;
            this.btnConfirmarVenta.BorderSize = 2;
            this.btnConfirmarVenta.FlatAppearance.BorderSize = 0;
            this.btnConfirmarVenta.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGreen;
            this.btnConfirmarVenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirmarVenta.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirmarVenta.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnConfirmarVenta.Image = ((System.Drawing.Image)(resources.GetObject("btnConfirmarVenta.Image")));
            this.btnConfirmarVenta.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConfirmarVenta.Location = new System.Drawing.Point(614, 364);
            this.btnConfirmarVenta.Name = "btnConfirmarVenta";
            this.btnConfirmarVenta.Size = new System.Drawing.Size(183, 50);
            this.btnConfirmarVenta.TabIndex = 116;
            this.btnConfirmarVenta.Text = "Confirmar Venta";
            this.btnConfirmarVenta.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnConfirmarVenta.TextColor = System.Drawing.Color.WhiteSmoke;
            this.btnConfirmarVenta.UseVisualStyleBackColor = false;
            this.btnConfirmarVenta.Click += new System.EventHandler(this.btnConfirmarVenta_Click);
            // 
            // txtCliente
            // 
            this.txtCliente.Location = new System.Drawing.Point(152, 35);
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.Size = new System.Drawing.Size(100, 22);
            this.txtCliente.TabIndex = 117;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label2.Location = new System.Drawing.Point(12, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 20);
            this.label2.TabIndex = 119;
            this.label2.Text = "Nombre Cliente";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(12, 136);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 20);
            this.label1.TabIndex = 120;
            this.label1.Text = "OTP";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label3.Location = new System.Drawing.Point(12, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 20);
            this.label3.TabIndex = 121;
            this.label3.Text = "Monto Total";
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(130, 87);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(100, 22);
            this.txtTotal.TabIndex = 122;
            // 
            // txtOTP
            // 
            this.txtOTP.Location = new System.Drawing.Point(87, 134);
            this.txtOTP.Name = "txtOTP";
            this.txtOTP.Size = new System.Drawing.Size(100, 22);
            this.txtOTP.TabIndex = 123;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label4.Location = new System.Drawing.Point(12, 188);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 20);
            this.label4.TabIndex = 124;
            this.label4.Text = "Numero Yape";
            // 
            // txtNumYape
            // 
            this.txtNumYape.Location = new System.Drawing.Point(141, 188);
            this.txtNumYape.Name = "txtNumYape";
            this.txtNumYape.Size = new System.Drawing.Size(100, 22);
            this.txtNumYape.TabIndex = 125;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label5.Location = new System.Drawing.Point(12, 239);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 20);
            this.label5.TabIndex = 126;
            this.label5.Text = "Correo";
            // 
            // txtCorreo
            // 
            this.txtCorreo.Location = new System.Drawing.Point(130, 237);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(100, 22);
            this.txtCorreo.TabIndex = 127;
            // 
            // btnConfirmarPago
            // 
            this.btnConfirmarPago.BackColor = System.Drawing.Color.Transparent;
            this.btnConfirmarPago.BackgroundColor = System.Drawing.Color.Transparent;
            this.btnConfirmarPago.BorderColor = System.Drawing.Color.Lime;
            this.btnConfirmarPago.BorderRadius = 10;
            this.btnConfirmarPago.BorderSize = 2;
            this.btnConfirmarPago.FlatAppearance.BorderSize = 0;
            this.btnConfirmarPago.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGreen;
            this.btnConfirmarPago.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirmarPago.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirmarPago.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnConfirmarPago.Image = ((System.Drawing.Image)(resources.GetObject("btnConfirmarPago.Image")));
            this.btnConfirmarPago.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConfirmarPago.Location = new System.Drawing.Point(16, 364);
            this.btnConfirmarPago.Name = "btnConfirmarPago";
            this.btnConfirmarPago.Size = new System.Drawing.Size(183, 50);
            this.btnConfirmarPago.TabIndex = 128;
            this.btnConfirmarPago.Text = "Confirmar Pago";
            this.btnConfirmarPago.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnConfirmarPago.TextColor = System.Drawing.Color.WhiteSmoke;
            this.btnConfirmarPago.UseVisualStyleBackColor = false;
            this.btnConfirmarPago.Click += new System.EventHandler(this.btnConfirmarPago_Click);
            // 
            // PantallaYape
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(0)))), ((int)(((byte)(114)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnConfirmarPago);
            this.Controls.Add(this.txtCorreo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtNumYape);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtOTP);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCliente);
            this.Controls.Add(this.btnConfirmarVenta);
            this.Name = "PantallaYape";
            this.Text = "PantallaYape";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private CustomControls btnConfirmarVenta;
        private System.Windows.Forms.TextBox txtCliente;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.TextBox txtOTP;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNumYape;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCorreo;
        private CustomControls btnConfirmarPago;
    }
}