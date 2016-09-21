using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Practica2.BO;
namespace Practica2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormulaGeneral oFormular = new  FormulaGeneral(Convert.ToDouble(txtA.Text),Convert.ToDouble(txtB.Text),Convert.ToDouble(txtC.Text));
    
            lblResultado1.Text = oFormular.resultado1.ToString();
            lblResultado2.Text = oFormular.resultado2.ToString();
            
        }
    }
}
