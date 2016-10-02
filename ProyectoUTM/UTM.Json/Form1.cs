using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UTM.Json
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CrearArchivo();
        }
        public void CrearArchivo()
        {

            Dictionary<string, int> points = new Dictionary<string, int> { { "James", 9001 }, { "Jo", 3474 }, { "Jess", 11926 } };
            string json = JsonConvert.SerializeObject(points);
            string rutaCompleta = Application.StartupPath.ToString();
            string ruta = rutaCompleta.Substring(0, rutaCompleta.Length - 16) + @"UTM.Json\Libros.json";
            System.IO.File.WriteAllText(ruta, json);
            File.WriteAllText(ruta, json);

        }


    }
}
