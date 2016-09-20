namespace UTM.Archivo.GUI
{
    partial class frmArchivo
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
            this.txtDatos = new System.Windows.Forms.TextBox();
            this.txtParcial2 = new System.Windows.Forms.TextBox();
            this.txtParcial3 = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tabPane1 = new DevExpress.XtraBars.Navigation.TabPane();
            this.tabNavigationPage1 = new DevExpress.XtraBars.Navigation.TabNavigationPage();
            this.tabNavigationPage2 = new DevExpress.XtraBars.Navigation.TabNavigationPage();
            this.button1 = new System.Windows.Forms.Button();
            this.Materia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaExamen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Horario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Laboratorio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabPane1)).BeginInit();
            this.tabPane1.SuspendLayout();
            this.tabNavigationPage1.SuspendLayout();
            this.tabNavigationPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtDatos
            // 
            this.txtDatos.Location = new System.Drawing.Point(13, 3);
            this.txtDatos.Multiline = true;
            this.txtDatos.Name = "txtDatos";
            this.txtDatos.Size = new System.Drawing.Size(645, 148);
            this.txtDatos.TabIndex = 0;
            // 
            // txtParcial2
            // 
            this.txtParcial2.Location = new System.Drawing.Point(13, 157);
            this.txtParcial2.Multiline = true;
            this.txtParcial2.Name = "txtParcial2";
            this.txtParcial2.Size = new System.Drawing.Size(645, 148);
            this.txtParcial2.TabIndex = 2;
            // 
            // txtParcial3
            // 
            this.txtParcial3.Location = new System.Drawing.Point(13, 311);
            this.txtParcial3.Multiline = true;
            this.txtParcial3.Name = "txtParcial3";
            this.txtParcial3.Size = new System.Drawing.Size(645, 148);
            this.txtParcial3.TabIndex = 3;
            this.txtParcial3.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Materia,
            this.FechaExamen,
            this.Horario,
            this.Laboratorio});
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(682, 443);
            this.dataGridView1.TabIndex = 4;
            // 
            // tabPane1
            // 
            this.tabPane1.Controls.Add(this.tabNavigationPage1);
            this.tabPane1.Controls.Add(this.tabNavigationPage2);
            this.tabPane1.Location = new System.Drawing.Point(12, 12);
            this.tabPane1.Name = "tabPane1";
            this.tabPane1.Pages.AddRange(new DevExpress.XtraBars.Navigation.NavigationPageBase[] {
            this.tabNavigationPage1,
            this.tabNavigationPage2});
            this.tabPane1.RegularSize = new System.Drawing.Size(736, 514);
            this.tabPane1.SelectedPage = this.tabNavigationPage1;
            this.tabPane1.Size = new System.Drawing.Size(736, 514);
            this.tabPane1.TabIndex = 5;
            this.tabPane1.Text = "tabPane1";
            // 
            // tabNavigationPage1
            // 
            this.tabNavigationPage1.Caption = "Examenes 3 Parcial";
            this.tabNavigationPage1.Controls.Add(this.txtDatos);
            this.tabNavigationPage1.Controls.Add(this.txtParcial2);
            this.tabNavigationPage1.Controls.Add(this.txtParcial3);
            this.tabNavigationPage1.Name = "tabNavigationPage1";
            this.tabNavigationPage1.Size = new System.Drawing.Size(718, 469);
            // 
            // tabNavigationPage2
            // 
            this.tabNavigationPage2.Caption = "Fecha Examenes";
            this.tabNavigationPage2.Controls.Add(this.dataGridView1);
            this.tabNavigationPage2.Name = "tabNavigationPage2";
            this.tabNavigationPage2.Size = new System.Drawing.Size(718, 469);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(723, 26);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(79, 63);
            this.button1.TabIndex = 6;
            this.button1.Text = "Leer";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Materia
            // 
            this.Materia.HeaderText = "Materia";
            this.Materia.Name = "Materia";
            // 
            // FechaExamen
            // 
            this.FechaExamen.HeaderText = "Fecha Examen";
            this.FechaExamen.Name = "FechaExamen";
            // 
            // Horario
            // 
            this.Horario.HeaderText = "Horario";
            this.Horario.Name = "Horario";
            // 
            // Laboratorio
            // 
            this.Laboratorio.HeaderText = "Laboratorio";
            this.Laboratorio.Name = "Laboratorio";
            // 
            // frmArchivo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(845, 741);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tabPane1);
            this.Name = "frmArchivo";
            this.Text = "frmArchivo";
            this.Load += new System.EventHandler(this.frmArchivo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabPane1)).EndInit();
            this.tabPane1.ResumeLayout(false);
            this.tabNavigationPage1.ResumeLayout(false);
            this.tabNavigationPage1.PerformLayout();
            this.tabNavigationPage2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtDatos;
        private System.Windows.Forms.TextBox txtParcial2;
        private System.Windows.Forms.TextBox txtParcial3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private DevExpress.XtraBars.Navigation.TabPane tabPane1;
        private DevExpress.XtraBars.Navigation.TabNavigationPage tabNavigationPage1;
        private DevExpress.XtraBars.Navigation.TabNavigationPage tabNavigationPage2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Materia;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaExamen;
        private System.Windows.Forms.DataGridViewTextBoxColumn Horario;
        private System.Windows.Forms.DataGridViewTextBoxColumn Laboratorio;
    }
}