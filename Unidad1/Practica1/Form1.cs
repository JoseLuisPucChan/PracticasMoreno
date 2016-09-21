using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Practica1.BO;
namespace Practica1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Panel1C.Visible = false;
            panel2.Visible = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            LimpiarControles();

            if (btnCcontrol.Text == "Limpiar")
            {
                LimpiarControles();
                btnCcontrol.Text = "Circulo";
            }
            if (btnCcontrol.Text == "Circulo")
            {
                Panel1C.Visible = true;
                panel2.Visible = false;
                btnCcontrol.Text = "Limpiar";
            }
            btnRecta.Text = "Rectangulo";
        }
        public void LimpiarControles()
        {
            txtAltura.Text = string.Empty;
            txtBase.Text = string.Empty;
            txtRadio.Text = string.Empty;
            lblAreaC.Text = "Área";
            lblAreaR.Text = "Área";
            lblPerimetroC.Text = "Perimetro";
            lblPerimetroR.Text = "Perimetro";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            LimpiarControles();
            if (btnRecta.Text == "Limpiar")
            {
                btnRecta.Text = "Rectangulo";
                LimpiarControles();
                
            }
            
            if (btnRecta.Text == "Rectangulo")
            {
                Panel1C.Visible = false;
                panel2.Visible = true;
                btnRecta.Text = "Limpiar";
              
            }
            btnCcontrol.Text = "Circulo";
           
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Circulo oCirculo = new Circulo();
            oCirculo.Radio = Convert.ToDouble(txtRadio.Text);
            lblAreaC.Text = oCirculo.area().ToString();
            lblPerimetroC.Text = oCirculo.perimetro().ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Rectangulo oRectangulo = new Rectangulo();
            oRectangulo.Altura = Convert.ToDouble(txtAltura.Text);
            oRectangulo.Bases = Convert.ToDouble(txtBase.Text);
            lblAreaR.Text = oRectangulo.area().ToString();
            lblPerimetroR.Text = oRectangulo.perimetro().ToString();
        }
    }
}
