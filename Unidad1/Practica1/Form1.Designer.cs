namespace Practica1
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.Panel1C = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.lblAreaC = new System.Windows.Forms.Label();
            this.lblPerimetroC = new System.Windows.Forms.Label();
            this.txtRadio = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.GroupBox();
            this.txtAltura = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.lblAreaR = new System.Windows.Forms.Label();
            this.lblPerimetroR = new System.Windows.Forms.Label();
            this.txtBase = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnRecta = new System.Windows.Forms.Button();
            this.btnCcontrol = new System.Windows.Forms.Button();
            this.Panel1C.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Panel1C
            // 
            this.Panel1C.Controls.Add(this.button1);
            this.Panel1C.Controls.Add(this.lblAreaC);
            this.Panel1C.Controls.Add(this.lblPerimetroC);
            this.Panel1C.Controls.Add(this.txtRadio);
            this.Panel1C.Controls.Add(this.label1);
            this.Panel1C.Location = new System.Drawing.Point(23, 74);
            this.Panel1C.Name = "Panel1C";
            this.Panel1C.Size = new System.Drawing.Size(258, 164);
            this.Panel1C.TabIndex = 7;
            this.Panel1C.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(82, 135);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Circulo";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblAreaC
            // 
            this.lblAreaC.AutoSize = true;
            this.lblAreaC.Location = new System.Drawing.Point(6, 118);
            this.lblAreaC.Name = "lblAreaC";
            this.lblAreaC.Size = new System.Drawing.Size(29, 13);
            this.lblAreaC.TabIndex = 3;
            this.lblAreaC.Text = "Área";
            // 
            // lblPerimetroC
            // 
            this.lblPerimetroC.AutoSize = true;
            this.lblPerimetroC.Location = new System.Drawing.Point(6, 88);
            this.lblPerimetroC.Name = "lblPerimetroC";
            this.lblPerimetroC.Size = new System.Drawing.Size(51, 13);
            this.lblPerimetroC.TabIndex = 2;
            this.lblPerimetroC.Text = "Perimetro";
            // 
            // txtRadio
            // 
            this.txtRadio.Location = new System.Drawing.Point(6, 40);
            this.txtRadio.Name = "txtRadio";
            this.txtRadio.Size = new System.Drawing.Size(151, 20);
            this.txtRadio.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Radio";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txtAltura);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.button4);
            this.panel2.Controls.Add(this.lblAreaR);
            this.panel2.Controls.Add(this.lblPerimetroR);
            this.panel2.Controls.Add(this.txtBase);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Location = new System.Drawing.Point(287, 74);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(227, 164);
            this.panel2.TabIndex = 8;
            this.panel2.TabStop = false;
            // 
            // txtAltura
            // 
            this.txtAltura.Location = new System.Drawing.Point(115, 40);
            this.txtAltura.Name = "txtAltura";
            this.txtAltura.Size = new System.Drawing.Size(88, 20);
            this.txtAltura.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(112, 16);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 13);
            this.label7.TabIndex = 5;
            this.label7.Text = "Altura";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(82, 135);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 4;
            this.button4.Text = "Rectangulo";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // lblAreaR
            // 
            this.lblAreaR.AutoSize = true;
            this.lblAreaR.Location = new System.Drawing.Point(126, 88);
            this.lblAreaR.Name = "lblAreaR";
            this.lblAreaR.Size = new System.Drawing.Size(29, 13);
            this.lblAreaR.TabIndex = 3;
            this.lblAreaR.Text = "Área";
            // 
            // lblPerimetroR
            // 
            this.lblPerimetroR.AutoSize = true;
            this.lblPerimetroR.Location = new System.Drawing.Point(6, 88);
            this.lblPerimetroR.Name = "lblPerimetroR";
            this.lblPerimetroR.Size = new System.Drawing.Size(51, 13);
            this.lblPerimetroR.TabIndex = 2;
            this.lblPerimetroR.Text = "Perimetro";
            // 
            // txtBase
            // 
            this.txtBase.Location = new System.Drawing.Point(9, 40);
            this.txtBase.Name = "txtBase";
            this.txtBase.Size = new System.Drawing.Size(82, 20);
            this.txtBase.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Base";
            // 
            // btnRecta
            // 
            this.btnRecta.Location = new System.Drawing.Point(123, 26);
            this.btnRecta.Name = "btnRecta";
            this.btnRecta.Size = new System.Drawing.Size(75, 23);
            this.btnRecta.TabIndex = 10;
            this.btnRecta.Text = "Rectangulo";
            this.btnRecta.UseVisualStyleBackColor = true;
            this.btnRecta.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnCcontrol
            // 
            this.btnCcontrol.Location = new System.Drawing.Point(23, 26);
            this.btnCcontrol.Name = "btnCcontrol";
            this.btnCcontrol.Size = new System.Drawing.Size(75, 23);
            this.btnCcontrol.TabIndex = 9;
            this.btnCcontrol.Text = "Circulo";
            this.btnCcontrol.UseVisualStyleBackColor = true;
            this.btnCcontrol.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(537, 255);
            this.Controls.Add(this.Panel1C);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btnRecta);
            this.Controls.Add(this.btnCcontrol);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Panel1C.ResumeLayout(false);
            this.Panel1C.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox Panel1C;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblAreaC;
        private System.Windows.Forms.Label lblPerimetroC;
        private System.Windows.Forms.TextBox txtRadio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox panel2;
        private System.Windows.Forms.TextBox txtAltura;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label lblAreaR;
        private System.Windows.Forms.Label lblPerimetroR;
        private System.Windows.Forms.TextBox txtBase;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnRecta;
        private System.Windows.Forms.Button btnCcontrol;
    }
}

