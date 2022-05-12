namespace CalculadoraImpuestos
{
    partial class Form1
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
            this.buttonCalcular = new System.Windows.Forms.Button();
            this.txtCalcular = new System.Windows.Forms.TextBox();
            this.txtAfp = new System.Windows.Forms.TextBox();
            this.txtIsr = new System.Windows.Forms.TextBox();
            this.txtSeguro = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelSueldoBruto = new System.Windows.Forms.Label();
            this.LabelSueldoNeto = new System.Windows.Forms.Label();
            this.LabelReducciones = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.TxtError = new System.Windows.Forms.Label();
            this.LabelIsrRed = new System.Windows.Forms.Label();
            this.LabelAfpRed = new System.Windows.Forms.Label();
            this.LabelSeguroRed = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonCalcular
            // 
            this.buttonCalcular.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.buttonCalcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCalcular.Location = new System.Drawing.Point(39, 21);
            this.buttonCalcular.Name = "buttonCalcular";
            this.buttonCalcular.Size = new System.Drawing.Size(122, 36);
            this.buttonCalcular.TabIndex = 0;
            this.buttonCalcular.Text = "CALCULAR";
            this.buttonCalcular.UseVisualStyleBackColor = false;
            this.buttonCalcular.Click += new System.EventHandler(this.buttonCalcular_Click);
            // 
            // txtCalcular
            // 
            this.txtCalcular.BackColor = System.Drawing.SystemColors.Window;
            this.txtCalcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCalcular.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.txtCalcular.Location = new System.Drawing.Point(10, 75);
            this.txtCalcular.MaxLength = 8;
            this.txtCalcular.Name = "txtCalcular";
            this.txtCalcular.Size = new System.Drawing.Size(184, 26);
            this.txtCalcular.TabIndex = 1;
            this.txtCalcular.Text = "0000000";
            this.txtCalcular.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtCalcular.TextChanged += new System.EventHandler(this.txtCalcular_TextChanged);
            // 
            // txtAfp
            // 
            this.txtAfp.BackColor = System.Drawing.SystemColors.Window;
            this.txtAfp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAfp.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.txtAfp.Location = new System.Drawing.Point(240, 205);
            this.txtAfp.MaxLength = 5;
            this.txtAfp.Name = "txtAfp";
            this.txtAfp.Size = new System.Drawing.Size(184, 26);
            this.txtAfp.TabIndex = 3;
            this.txtAfp.Text = "\r\n0";
            this.txtAfp.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtIsr
            // 
            this.txtIsr.BackColor = System.Drawing.SystemColors.Window;
            this.txtIsr.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIsr.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.txtIsr.Location = new System.Drawing.Point(10, 205);
            this.txtIsr.MaxLength = 5;
            this.txtIsr.Name = "txtIsr";
            this.txtIsr.Size = new System.Drawing.Size(184, 26);
            this.txtIsr.TabIndex = 3;
            this.txtIsr.Text = "\r\n0";
            this.txtIsr.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtSeguro
            // 
            this.txtSeguro.BackColor = System.Drawing.SystemColors.Window;
            this.txtSeguro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSeguro.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.txtSeguro.Location = new System.Drawing.Point(466, 205);
            this.txtSeguro.MaxLength = 5;
            this.txtSeguro.Name = "txtSeguro";
            this.txtSeguro.Size = new System.Drawing.Size(184, 26);
            this.txtSeguro.TabIndex = 4;
            this.txtSeguro.Text = "\r\n0";
            this.txtSeguro.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(77, 178);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 24);
            this.label1.TabIndex = 5;
            this.label1.Text = "ISR";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(309, 178);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 24);
            this.label2.TabIndex = 6;
            this.label2.Text = "AFP";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(510, 178);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 24);
            this.label3.TabIndex = 7;
            this.label3.Text = "SEGURO";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // labelSueldoBruto
            // 
            this.labelSueldoBruto.AutoSize = true;
            this.labelSueldoBruto.BackColor = System.Drawing.Color.RosyBrown;
            this.labelSueldoBruto.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSueldoBruto.Location = new System.Drawing.Point(418, 9);
            this.labelSueldoBruto.MinimumSize = new System.Drawing.Size(248, 55);
            this.labelSueldoBruto.Name = "labelSueldoBruto";
            this.labelSueldoBruto.Size = new System.Drawing.Size(248, 55);
            this.labelSueldoBruto.TabIndex = 8;
            this.labelSueldoBruto.Text = "00000000";
            this.labelSueldoBruto.Click += new System.EventHandler(this.label4_Click);
            // 
            // LabelSueldoNeto
            // 
            this.LabelSueldoNeto.AutoSize = true;
            this.LabelSueldoNeto.BackColor = System.Drawing.Color.RosyBrown;
            this.LabelSueldoNeto.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelSueldoNeto.Location = new System.Drawing.Point(418, 120);
            this.LabelSueldoNeto.MinimumSize = new System.Drawing.Size(248, 55);
            this.LabelSueldoNeto.Name = "LabelSueldoNeto";
            this.LabelSueldoNeto.Size = new System.Drawing.Size(248, 55);
            this.LabelSueldoNeto.TabIndex = 9;
            this.LabelSueldoNeto.Text = "00000000";
            // 
            // LabelReducciones
            // 
            this.LabelReducciones.AutoSize = true;
            this.LabelReducciones.BackColor = System.Drawing.Color.RosyBrown;
            this.LabelReducciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelReducciones.Location = new System.Drawing.Point(418, 65);
            this.LabelReducciones.MinimumSize = new System.Drawing.Size(248, 55);
            this.LabelReducciones.Name = "LabelReducciones";
            this.LabelReducciones.Size = new System.Drawing.Size(248, 55);
            this.LabelReducciones.TabIndex = 10;
            this.LabelReducciones.Text = "00000000";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(286, 145);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(126, 24);
            this.label7.TabIndex = 11;
            this.label7.Text = "Sueldo Neto";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(281, 90);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(133, 24);
            this.label8.TabIndex = 12;
            this.label8.Text = "Reducciones";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(281, 34);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(131, 24);
            this.label9.TabIndex = 13;
            this.label9.Text = "Sueldo Bruto";
            // 
            // TxtError
            // 
            this.TxtError.AutoSize = true;
            this.TxtError.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtError.ForeColor = System.Drawing.Color.Red;
            this.TxtError.Location = new System.Drawing.Point(119, 234);
            this.TxtError.Name = "TxtError";
            this.TxtError.Size = new System.Drawing.Size(0, 24);
            this.TxtError.TabIndex = 14;
            // 
            // LabelIsrRed
            // 
            this.LabelIsrRed.AutoSize = true;
            this.LabelIsrRed.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelIsrRed.ForeColor = System.Drawing.Color.Red;
            this.LabelIsrRed.Location = new System.Drawing.Point(68, 234);
            this.LabelIsrRed.Name = "LabelIsrRed";
            this.LabelIsrRed.Size = new System.Drawing.Size(0, 24);
            this.LabelIsrRed.TabIndex = 15;
            // 
            // LabelAfpRed
            // 
            this.LabelAfpRed.AutoSize = true;
            this.LabelAfpRed.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelAfpRed.ForeColor = System.Drawing.Color.Red;
            this.LabelAfpRed.Location = new System.Drawing.Point(286, 234);
            this.LabelAfpRed.Name = "LabelAfpRed";
            this.LabelAfpRed.Size = new System.Drawing.Size(0, 24);
            this.LabelAfpRed.TabIndex = 16;
            // 
            // LabelSeguroRed
            // 
            this.LabelSeguroRed.AutoSize = true;
            this.LabelSeguroRed.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelSeguroRed.ForeColor = System.Drawing.Color.Red;
            this.LabelSeguroRed.Location = new System.Drawing.Point(510, 234);
            this.LabelSeguroRed.Name = "LabelSeguroRed";
            this.LabelSeguroRed.Size = new System.Drawing.Size(0, 24);
            this.LabelSeguroRed.TabIndex = 17;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(672, 267);
            this.Controls.Add(this.LabelSeguroRed);
            this.Controls.Add(this.LabelAfpRed);
            this.Controls.Add(this.LabelIsrRed);
            this.Controls.Add(this.TxtError);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.LabelReducciones);
            this.Controls.Add(this.LabelSueldoNeto);
            this.Controls.Add(this.labelSueldoBruto);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSeguro);
            this.Controls.Add(this.txtIsr);
            this.Controls.Add(this.txtAfp);
            this.Controls.Add(this.txtCalcular);
            this.Controls.Add(this.buttonCalcular);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonCalcular;
        private System.Windows.Forms.TextBox txtCalcular;
        private System.Windows.Forms.TextBox txtAfp;
        private System.Windows.Forms.TextBox txtIsr;
        private System.Windows.Forms.TextBox txtSeguro;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelSueldoBruto;
        private System.Windows.Forms.Label LabelSueldoNeto;
        private System.Windows.Forms.Label LabelReducciones;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label TxtError;
        private System.Windows.Forms.Label LabelIsrRed;
        private System.Windows.Forms.Label LabelAfpRed;
        private System.Windows.Forms.Label LabelSeguroRed;
    }
}

