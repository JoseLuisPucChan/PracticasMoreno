﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Unidad2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int[,] Numeros = new int[,]{
                {1,2,3},
                {5,6,7},
                {10,1,2}
            };
            int Logitud = 3;
            int SumaPrimeraColumna = 0;
            int SumaPrimeraFila = 0;
            int SumPDp = 0;
            for (int i = 0; i < Logitud; i++)
            {//Filas
                for (int j = 0; j < Logitud; j++)
                {
                    if (i == 0)
                    {
                        SumaPrimeraColumna = SumaPrimeraColumna + Numeros[j, i];
                    }
                    if (j == 0)
                    {
                        SumaPrimeraFila = SumaPrimeraFila + Numeros[j, i];
                    }
                    if ((i + j) == 2)
                    {
                        SumPDp = Numeros[i, j] + SumPDp;
                    }

                }


            }
            MessageBox.Show(SumaPrimeraColumna.ToString());
            MessageBox.Show(SumaPrimeraFila.ToString());
            MessageBox.Show(SumPDp.ToString());

        }

        private void btnIndicChar_Click(object sender, EventArgs e)
        {
            //Forma 1 arreglos paraleos(Multidimecional)
            string[,] Colore = new string[,]{
                {"Rojo","Azul","Verde"},
                {"Verde","Gris","Amarillo"},
                {"Rojo","Azul","Verde"}};


            string[,] IndiceColore = new string[,]{
                {"a","b","c"},
                {"d","f","g"},
                {"h","i","j"} };

            for (int i = 0; i < 3; i++)
            {
                for (int J = 0; J < 3; J++)
                {
                    MessageBox.Show("Color =" + Colore[i, J]);
                    MessageBox.Show("Índice =" + IndiceColore[i, J]);
                }

            }

            //Forma 2. 2 arreglos paralelos (unidimecional o vectores)

            string[] ColoreUnidimencional = new string[] { "Rojo", "Azul", "Verde", "Verde", "Gris", "Amarillo", "Rojo", "Azul", "Verde" };

            string[] IndiceColoreUnidimencional = new string[] { "a", "b", "c", "d", "f", "g", "h", "i", "j" };

            // Leer Vector Colores 
            for (int color = 0; color < ColoreUnidimencional.Length; color++)
            {
                MessageBox.Show("" + ColoreUnidimencional[color]);
            }
            for (int Indicecolor = 0; Indicecolor < IndiceColoreUnidimencional.Length; Indicecolor++)
            {
                MessageBox.Show("" + IndiceColoreUnidimencional[Indicecolor]);
            }
            //Forma 3 Usando una clase de objetos para mostrar un array de objetos;
            //Array unidimencioanl de color

            Color[] ArregloColres = {
                                        new Color{indice="a",valor="Rojo"},
                                        new Color{indice="s",valor="Verde"},
                                        new Color{indice="r",valor="Amarrillo"},
                                        new Color{indice="t",valor="Azul"},
                                        new Color{indice="f",valor="Gris"},
                                        new Color{indice="g",valor="Morado"},
                                        new Color{indice="h",valor="Gris"},

                                    };
            string Color = "";
            foreach (Color ColorActual in ArregloColres)
            {
                MessageBox.Show("Color =" + ColorActual.valor);
                MessageBox.Show("Índice =" + ColorActual.indice);
               
                
                if(ColorActual.valor=="Gris")
                {
                    Color = Color + ColorActual.indice;
                }
            }

        }

     
        private void IndiceOrdenar()
        {
            string NumI = "";
            Color[] ArregloColres = {
                                        new Color{indice="a",valor="Rojo"},
                                        new Color{indice="s",valor="Rojo"},
                                        new Color{indice="r",valor="Amarrillo"},
                                        new Color{indice="t",valor="Azul"},
                                        new Color{indice="f",valor="Gris"},
                                        new Color{indice="g",valor="Morado"},
                                        new Color{indice="h",valor="Gris"},
                                         new Color{indice="o",valor="Verdecito"},
                                         new Color{indice="e",valor="Verdecito"},
                                         new Color{indice="y",valor="Verdecito"},
                                         new Color{indice="u",valor="Verdecito"},
                                    };

            int y = 0;
            int NumeroIndice1 = 0;
            string[] Colors = new string[ArregloColres.Length];
            foreach (Color dato in ArregloColres)
            {
                string ColorActual = dato.valor;
                foreach (string dato3 in Colors)
                {
                    if (ColorActual == dato3)
                    {
                        y++;
                    }
                }
                if (y == 0)
                {
                    foreach (Color dato2 in ArregloColres)
                    {
                        if (ColorActual == dato2.valor)
                        {
                            NumI = NumI + dato2.indice + ", ";
                        }
                    }
                    Colors[NumeroIndice1] = ColorActual;
                    NumI = NumI.Substring(0, NumI.Length - 2);
                    MessageBox.Show("Color: "+ ColorActual + " se encuentra en los indices = " + NumI);
                    NumeroIndice1++;
                }
                y = 0;
                NumI = "";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            IndiceOrdenar();
        }

     
    }
}
