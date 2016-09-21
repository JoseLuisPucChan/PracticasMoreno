using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Practica3.BO;
namespace Practica3
{
    public partial class Form1 : Form
    {
        Numero oNumero;
        public Form1()
        {
            InitializeComponent();
            tabNavigationPage2.PageVisible = false;
            radSuma.Checked = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            tabPane1.SelectedPageIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
       
           if(lblOperacion.Text == "+")
           {
               txtR1.Visible = true;
               oNumero = new Numero();
               oNumero.SimplificarSuma2(Convert.ToInt32(txtA.Text), Convert.ToInt32(txtB.Text), Convert.ToInt32(txtC.Text), Convert.ToInt32(txtD.Text));
              // txtR2.Visible = oNumero.Texbox;
               if(oNumero.Texbox == false)
               {
                   txtR1.Text = oNumero.Enteros.ToString();
                  if(oNumero.R2 == 1)
                  {
                      txtR2.Text = oNumero.R2.ToString();
                      txtR2.Visible = false;
                  }
               }
               else
               {
                   txtR1.Text = oNumero.R1.ToString();
                   txtR2.Text = oNumero.R2.ToString();
               }
              

           }
            if(lblOperacion.Text == "x")
            {
                txtR1.Visible = true;
                oNumero = new Numero();
                oNumero.SimplificarMultiplicacion(Convert.ToInt32(txtA.Text), Convert.ToInt32(txtB.Text), Convert.ToInt32(txtC.Text), Convert.ToInt32(txtD.Text));
                if (oNumero.R2 == 1)
                {
                    txtR2.Visible = false;
                }
                else
                {
                    txtR2.Visible = true;

                }
                txtR1.Text = oNumero.R1.ToString();
                txtR2.Text = oNumero.R2.ToString();
            }
            if (lblOperacion.Text == "=")
            {
                oNumero = new Numero();
                lblEquivalentes.Text = oNumero.EsIgual(Convert.ToInt32(txtA.Text), Convert.ToInt32(txtB.Text), Convert.ToInt32(txtC.Text), Convert.ToInt32(txtD.Text));
                lblEquivalentes.Visible = true;
                txtR1.Visible = false;
                txtR2.Visible = false;
                txtR1.Text = oNumero.R1.ToString();
                txtR2.Text = oNumero.R2.ToString();
            }
            tabNavigationPage2.PageVisible = true;
            tabNavigationPage1.PageVisible = false;
            tabPane1.SelectedPageIndex = 1;
           


        }

        private void radSuma_CheckedChanged(object sender, EventArgs e)
        {
            lblOperacion.Text = "+";
        }

        private void radMultiplicacion_CheckedChanged(object sender, EventArgs e)
        {
            lblOperacion.Text = "x";
        }

        private void radIgualdad_CheckedChanged(object sender, EventArgs e)
        {
            lblOperacion.Text = "=";
        }

        private void txtRegresar_Click(object sender, EventArgs e)
        {
            Contro1();
        }
        private void Contro1()
        {
            tabNavigationPage2.PageVisible = false;
            tabNavigationPage1.PageVisible = true;
            lblEquivalentes.Visible = false;
            txtR2.Visible = true;
            tabPane1.SelectedPageIndex = 0;
        }

        private void txtLimpiar_Click(object sender, EventArgs e)
        {
            Contro1();
            txtR1.Text = string.Empty;
            txtR2.Text = string.Empty;
            txtA.Text = string.Empty;
            txtB.Text = string.Empty;
            txtC.Text = string.Empty;
            txtD.Text = string.Empty;
           

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
