namespace Practica3
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
            this.button1 = new System.Windows.Forms.Button();
            this.txtR1 = new System.Windows.Forms.TextBox();
            this.tabPane1 = new DevExpress.XtraBars.Navigation.TabPane();
            this.tabNavigationPage1 = new DevExpress.XtraBars.Navigation.TabNavigationPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radMultiplicacion = new System.Windows.Forms.RadioButton();
            this.radSuma = new System.Windows.Forms.RadioButton();
            this.radIgualdad = new System.Windows.Forms.RadioButton();
            this.txtB = new System.Windows.Forms.TextBox();
            this.txtD = new System.Windows.Forms.TextBox();
            this.txtC = new System.Windows.Forms.TextBox();
            this.txtA = new System.Windows.Forms.TextBox();
            this.lblOperacion = new System.Windows.Forms.Label();
            this.tabNavigationPage2 = new DevExpress.XtraBars.Navigation.TabNavigationPage();
            this.txtLimpiar = new System.Windows.Forms.Button();
            this.txtRegresar = new System.Windows.Forms.Button();
            this.txtR2 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.lblEquivalentes = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tabPane1)).BeginInit();
            this.tabPane1.SuspendLayout();
            this.tabNavigationPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabNavigationPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(201, 231);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(135, 35);
            this.button1.TabIndex = 4;
            this.button1.Text = "Resultado";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtR1
            // 
            this.txtR1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtR1.Location = new System.Drawing.Point(180, 46);
            this.txtR1.Name = "txtR1";
            this.txtR1.ReadOnly = true;
            this.txtR1.Size = new System.Drawing.Size(77, 62);
            this.txtR1.TabIndex = 11;
            this.txtR1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tabPane1
            // 
            this.tabPane1.Controls.Add(this.tabNavigationPage1);
            this.tabPane1.Controls.Add(this.tabNavigationPage2);
            this.tabPane1.Location = new System.Drawing.Point(37, 3);
            this.tabPane1.Name = "tabPane1";
            this.tabPane1.Pages.AddRange(new DevExpress.XtraBars.Navigation.NavigationPageBase[] {
            this.tabNavigationPage1,
            this.tabNavigationPage2});
            this.tabPane1.RegularSize = new System.Drawing.Size(543, 314);
            this.tabPane1.SelectedPage = this.tabNavigationPage2;
            this.tabPane1.Size = new System.Drawing.Size(543, 314);
            this.tabPane1.TabIndex = 12;
            this.tabPane1.Text = "tabPane1";
            // 
            // tabNavigationPage1
            // 
            this.tabNavigationPage1.Caption = "Operaciones";
            this.tabNavigationPage1.Controls.Add(this.groupBox1);
            this.tabNavigationPage1.Controls.Add(this.txtB);
            this.tabNavigationPage1.Controls.Add(this.txtD);
            this.tabNavigationPage1.Controls.Add(this.txtC);
            this.tabNavigationPage1.Controls.Add(this.txtA);
            this.tabNavigationPage1.Controls.Add(this.lblOperacion);
            this.tabNavigationPage1.Controls.Add(this.button1);
            this.tabNavigationPage1.Name = "tabNavigationPage1";
            this.tabNavigationPage1.Size = new System.Drawing.Size(525, 269);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radMultiplicacion);
            this.groupBox1.Controls.Add(this.radSuma);
            this.groupBox1.Controls.Add(this.radIgualdad);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(36, 19);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 189);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Operaciones";
            // 
            // radMultiplicacion
            // 
            this.radMultiplicacion.AutoSize = true;
            this.radMultiplicacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radMultiplicacion.Location = new System.Drawing.Point(6, 88);
            this.radMultiplicacion.Name = "radMultiplicacion";
            this.radMultiplicacion.Size = new System.Drawing.Size(195, 35);
            this.radMultiplicacion.TabIndex = 18;
            this.radMultiplicacion.TabStop = true;
            this.radMultiplicacion.Text = "Multiplicación";
            this.radMultiplicacion.UseVisualStyleBackColor = true;
            this.radMultiplicacion.CheckedChanged += new System.EventHandler(this.radMultiplicacion_CheckedChanged);
            // 
            // radSuma
            // 
            this.radSuma.AutoSize = true;
            this.radSuma.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radSuma.Location = new System.Drawing.Point(6, 30);
            this.radSuma.Name = "radSuma";
            this.radSuma.Size = new System.Drawing.Size(102, 35);
            this.radSuma.TabIndex = 16;
            this.radSuma.TabStop = true;
            this.radSuma.Text = "Suma";
            this.radSuma.UseVisualStyleBackColor = true;
            this.radSuma.CheckedChanged += new System.EventHandler(this.radSuma_CheckedChanged);
            // 
            // radIgualdad
            // 
            this.radIgualdad.AutoSize = true;
            this.radIgualdad.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radIgualdad.Location = new System.Drawing.Point(6, 147);
            this.radIgualdad.Name = "radIgualdad";
            this.radIgualdad.Size = new System.Drawing.Size(136, 35);
            this.radIgualdad.TabIndex = 19;
            this.radIgualdad.TabStop = true;
            this.radIgualdad.Text = "Igualdad";
            this.radIgualdad.UseVisualStyleBackColor = true;
            this.radIgualdad.CheckedChanged += new System.EventHandler(this.radIgualdad_CheckedChanged);
            // 
            // txtB
            // 
            this.txtB.Font = new System.Drawing.Font("Agency FB", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtB.Location = new System.Drawing.Point(293, 138);
            this.txtB.Name = "txtB";
            this.txtB.Size = new System.Drawing.Size(62, 64);
            this.txtB.TabIndex = 1;
            this.txtB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtD
            // 
            this.txtD.Font = new System.Drawing.Font("Agency FB", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtD.Location = new System.Drawing.Point(426, 138);
            this.txtD.Name = "txtD";
            this.txtD.Size = new System.Drawing.Size(62, 64);
            this.txtD.TabIndex = 3;
            this.txtD.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtC
            // 
            this.txtC.Font = new System.Drawing.Font("Agency FB", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtC.Location = new System.Drawing.Point(426, 27);
            this.txtC.Name = "txtC";
            this.txtC.Size = new System.Drawing.Size(62, 64);
            this.txtC.TabIndex = 2;
            this.txtC.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtA
            // 
            this.txtA.Font = new System.Drawing.Font("Agency FB", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtA.Location = new System.Drawing.Point(293, 27);
            this.txtA.Name = "txtA";
            this.txtA.Size = new System.Drawing.Size(62, 64);
            this.txtA.TabIndex = 0;
            this.txtA.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblOperacion
            // 
            this.lblOperacion.AutoSize = true;
            this.lblOperacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOperacion.Location = new System.Drawing.Point(346, 61);
            this.lblOperacion.Name = "lblOperacion";
            this.lblOperacion.Size = new System.Drawing.Size(101, 108);
            this.lblOperacion.TabIndex = 11;
            this.lblOperacion.Text = "+";
            // 
            // tabNavigationPage2
            // 
            this.tabNavigationPage2.Caption = "Resultado";
            this.tabNavigationPage2.Controls.Add(this.lblEquivalentes);
            this.tabNavigationPage2.Controls.Add(this.txtLimpiar);
            this.tabNavigationPage2.Controls.Add(this.txtRegresar);
            this.tabNavigationPage2.Controls.Add(this.txtR2);
            this.tabNavigationPage2.Controls.Add(this.txtR1);
            this.tabNavigationPage2.Name = "tabNavigationPage2";
            this.tabNavigationPage2.Size = new System.Drawing.Size(525, 269);
            // 
            // txtLimpiar
            // 
            this.txtLimpiar.Location = new System.Drawing.Point(364, 144);
            this.txtLimpiar.Name = "txtLimpiar";
            this.txtLimpiar.Size = new System.Drawing.Size(75, 47);
            this.txtLimpiar.TabIndex = 15;
            this.txtLimpiar.Text = "Limpiar";
            this.txtLimpiar.UseVisualStyleBackColor = true;
            this.txtLimpiar.Click += new System.EventHandler(this.txtLimpiar_Click);
            // 
            // txtRegresar
            // 
            this.txtRegresar.Location = new System.Drawing.Point(364, 46);
            this.txtRegresar.Name = "txtRegresar";
            this.txtRegresar.Size = new System.Drawing.Size(75, 47);
            this.txtRegresar.TabIndex = 14;
            this.txtRegresar.Text = "Regresar";
            this.txtRegresar.UseVisualStyleBackColor = true;
            this.txtRegresar.Click += new System.EventHandler(this.txtRegresar_Click);
            // 
            // txtR2
            // 
            this.txtR2.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtR2.Location = new System.Drawing.Point(180, 129);
            this.txtR2.Name = "txtR2";
            this.txtR2.ReadOnly = true;
            this.txtR2.Size = new System.Drawing.Size(77, 62);
            this.txtR2.TabIndex = 13;
            this.txtR2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(530, -1);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(94, 35);
            this.button2.TabIndex = 18;
            this.button2.Text = "Salir";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // lblEquivalentes
            // 
            this.lblEquivalentes.AutoSize = true;
            this.lblEquivalentes.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEquivalentes.Location = new System.Drawing.Point(94, 85);
            this.lblEquivalentes.Name = "lblEquivalentes";
            this.lblEquivalentes.Size = new System.Drawing.Size(152, 55);
            this.lblEquivalentes.TabIndex = 2;
            this.lblEquivalentes.Text = "label1";
            this.lblEquivalentes.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 347);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.tabPane1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tabPane1)).EndInit();
            this.tabPane1.ResumeLayout(false);
            this.tabNavigationPage1.ResumeLayout(false);
            this.tabNavigationPage1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabNavigationPage2.ResumeLayout(false);
            this.tabNavigationPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtR1;
        private DevExpress.XtraBars.Navigation.TabPane tabPane1;
        private DevExpress.XtraBars.Navigation.TabNavigationPage tabNavigationPage1;
        private System.Windows.Forms.TextBox txtB;
        private System.Windows.Forms.TextBox txtD;
        private System.Windows.Forms.TextBox txtC;
        private System.Windows.Forms.TextBox txtA;
        private System.Windows.Forms.Label lblOperacion;
        private DevExpress.XtraBars.Navigation.TabNavigationPage tabNavigationPage2;
        private System.Windows.Forms.TextBox txtR2;
        private System.Windows.Forms.Button txtLimpiar;
        private System.Windows.Forms.Button txtRegresar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radMultiplicacion;
        private System.Windows.Forms.RadioButton radSuma;
        private System.Windows.Forms.RadioButton radIgualdad;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label lblEquivalentes;
    }
}

