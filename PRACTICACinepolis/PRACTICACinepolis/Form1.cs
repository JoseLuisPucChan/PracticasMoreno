using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PRACTICACinepolis
{
    public partial class Form1 : Form
    {
        WebBrowser navegador = new WebBrowser();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            navegador.ScriptErrorsSuppressed = true;
            navegador.DocumentCompleted += new WebBrowserDocumentCompletedEventHandler(this.datos_cargados);
            navegador.Navigate("http://www.cinepolis.com/cartelera/merida/");
        }
        private void datos_cargados(object sender, EventArgs e)
        {
            try
            {
                foreach (HtmlElement funcion in navegador.Document.All)
                {
                    if (funcion.GetAttribute("classname").Contains("ng-binding"))
                    {
                        richTextBox1.Text += funcion.InnerText;
                    }
                }
            
                foreach (HtmlElement etiqueta in navegador.Document.GetElementsByTagName("img"))
                {
                    //    if (etiqueta.GetAttribute("alt").Contains(txtcanal.Text))
                    //    {
                    //        pbcanal.ImageLocation = etiqueta.GetAttribute("data-thumb");
                    //    }
                }
            }
            catch (Exception ex)
            {

            }
        }
    }
}
