namespace Unidad2
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
            this.btnIndicChar = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(48, 25);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(318, 126);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnIndicChar
            // 
            this.btnIndicChar.Location = new System.Drawing.Point(45, 173);
            this.btnIndicChar.Name = "btnIndicChar";
            this.btnIndicChar.Size = new System.Drawing.Size(321, 126);
            this.btnIndicChar.TabIndex = 1;
            this.btnIndicChar.Text = "Indice Char";
            this.btnIndicChar.UseVisualStyleBackColor = true;
            this.btnIndicChar.Click += new System.EventHandler(this.btnIndicChar_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(395, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(259, 126);
            this.button2.TabIndex = 2;
            this.button2.Text = "Indice Char";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(395, 173);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(259, 126);
            this.button3.TabIndex = 3;
            this.button3.Text = "Pase al exámen";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(707, 357);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnIndicChar);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnIndicChar;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}

