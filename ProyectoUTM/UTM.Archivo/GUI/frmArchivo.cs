using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Collections;
namespace UTM.Archivo.GUI
{
    public partial class frmArchivo : Form
    {
        public frmArchivo()
        {
            InitializeComponent();
            tabNavigationPage2.PageVisible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            leerArchivo();
            AgregarDtg();
            tabNavigationPage2.PageVisible = true;
        }
       
    
        
        public void leerArchivo()
        {
            string rutaCompleta = Application.StartupPath.ToString();
            string ruta = rutaCompleta.Substring(0, rutaCompleta.Length - 16) + @"UTM.Archivo\bin\FExamen.txt";
            StreamReader objReader = new StreamReader(ruta, System.Text.Encoding.Default);
            string leelinea = "";
            int i = 0;
            ArrayList contenido = new ArrayList();
            while (objReader.Peek() > -1)
            {
                leelinea = objReader.ReadLine();
                if(leelinea=="Parcial 2")
                {
                    foreach (string datos in contenido)
                        txtDatos.Text += datos.ToString() + Environment.NewLine;
                    contenido.Clear();
                }
                if (leelinea == "Parcial 3")
                {
                    foreach (string datos in contenido)
                     txtParcial2.Text += datos.ToString() + Environment.NewLine;
                    contenido.Clear();
                }
                contenido.Add(leelinea);

            }

            foreach (string datos in contenido)
                txtParcial3.Text += datos.ToString() + Environment.NewLine;

            objReader.Close();

          
         //   foreach (string datos in contenido)

             //   txtDatos.Text += datos.ToString() + Environment.NewLine;

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }



         private void AgregarDtg()
        {
            string rutaCompleta = Application.StartupPath.ToString();
            string ruta = rutaCompleta.Substring(0, rutaCompleta.Length - 16) + @"UTM.Archivo\bin\FExamen.txt";
            StreamReader objReader = new StreamReader(ruta, System.Text.Encoding.Default);   
	                string texto = "";
	                int count = 4;
	                string[] split = null;
	                while (((texto != null))) {
		                texto = objReader.ReadLine();
                        if (texto != "Parcial 1" && texto != "Parcial 2" && texto != "Parcial 3")
                        {
                            if (((texto != null)))
                            {
                                split = texto.Split(new char[] { '-' }, count);
                                dataGridView1.Rows.Add(split[0], split[1], split[2], split[3]);
                            }
                        }  
	                }
           }

         private void frmArchivo_Load(object sender, EventArgs e)
         {
             dataGridView1.Columns[0].Width = 210;
             dataGridView1.Columns[1].Width = 202;
             dataGridView1.Columns[2].Width = 127;
         }



    }
}
