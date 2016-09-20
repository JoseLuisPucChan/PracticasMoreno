using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UTM.Archivo.bin
{
    public partial class frmTraductor : Form
    {
        int Busqueda1;
        int Busqueda2;
        public frmTraductor()
        {
           
            InitializeComponent();
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox2.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.SelectedItem = "Ingles";
            comboBox2.SelectedItem = "Español";
        }

        private void frmTraductor_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtTexto2.Text != string.Empty)
            {
                txtPalabra1.Text = txtTexto2.Text;
                Traductor1();
            }
            string a = "";
            string b = "";
            a = comboBox1.SelectedItem.ToString();
            b = comboBox2.SelectedItem.ToString();
            comboBox1.SelectedItem = b;
            comboBox2.SelectedItem = a;
            
        }
        private void Traductor1()
        {
            txtTexto2.Clear();
         
            if(comboBox1.SelectedItem.ToString() == "Español" && comboBox2.SelectedItem.ToString() == "Ingles")
            {
                Busqueda2 = 1;
                Busqueda1 = 2;
            }
            if (comboBox1.SelectedItem.ToString() == "Ingles" && comboBox2.SelectedItem.ToString() == "Español")
            {
                Busqueda2 = 2;
                Busqueda1 = 1;
            }
            if (comboBox1.SelectedItem.ToString() == "Maya" && comboBox2.SelectedItem.ToString() == "Ingles")
            {
                Busqueda2 = 0;
                Busqueda1 = 2;
            }
            if (comboBox1.SelectedItem.ToString() == "Ingles" && comboBox2.SelectedItem.ToString() == "Maya")
            {
                Busqueda2 = 2;
                Busqueda1 = 0;
            }

            string ruta="";
            string rutaCompleta = Application.StartupPath.ToString();
            ruta = rutaCompleta.Substring(0, rutaCompleta.Length - 16) + @"UTM.Archivo\bin\EspañolM.txt";
            StreamReader objReader = new StreamReader(ruta, System.Text.Encoding.Default);
            string texto = "";
            int count = 3;
            string[] split = null;
            while (((texto != null)))
            {
                texto = objReader.ReadLine();
                if ((texto != null))
                {
                    split = texto.Split(new char[] {',',':',';'}, count);

                    if (split[Busqueda2] == txtPalabra1.Text.Trim())
                    {
                        txtTexto2.Text += split[Busqueda1].ToString();
                    }
                }
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem.ToString() == "Español")
            {
                Busqueda1 = 0;
            }
            if (comboBox1.SelectedItem.ToString() == "Maya")
            {
                Busqueda1 = 1;
            }
            Traductor();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox2.SelectedItem.ToString() == "Maya")
            {
                Busqueda2 = 1;

            }
            if (comboBox2.SelectedItem.ToString() == "Español")
            {
                Busqueda2 = 0;

            }
            Traductor();
        }

        private void txtPalabra1_TextChanged(object sender, EventArgs e)
        {
            Traductor();
        }
        private void Traductor()
        {
            if (txtPalabra1.Text != String.Empty)
            {
                Traductor1();
            }
        }
        
    }
}
