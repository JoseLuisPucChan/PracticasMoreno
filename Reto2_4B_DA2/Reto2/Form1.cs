using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.IO;
using Reto2.Reporte;

namespace Reto2
{
    public partial class Form1 : Form
    {
        private string tabla = "";
        private DataSet report = new DataSet();
        public Form1()
        {
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cobSede.SelectedIndex = 0;
            LeerPaginaCinemex(cobSede.SelectedItem.ToString());
            //LeerPaginaCinepolis();
        }
        private void LeerPaginaCinemex(string filtro)
        {
            WebRequest request = WebRequest.Create("http://cinemex.com/cartelera/zona-86/merida/");

            // Obtener la respuesta.
            WebResponse response = request.GetResponse();

            // Abrir el stream de la respuesta recibida.
            StreamReader reader = new StreamReader(response.GetResponseStream());

            //Leer el contenido.
           String res = reader.ReadToEnd();

            // Cerrar los streams abiertos.
            reader.Close();
            response.Close();

            Cinemex ds = new Cinemex();
            string[,] lista = new string[100, 4];
            string cadena = "", tamaño = "", sede = "";
            int cont = 0, posicion = 0, car = 0, anterior = 0, src = 0;
            foreach (char dato in res)
            {
                cadena += dato;
                tamaño += dato;
                if (dato == ' ')
                {
                    cadena = "";
                }
                // detección de cambio de títulos de películas
                if (cadena == "class=\"mycinema-item-rating\"" && lista[posicion, 0] != null)
                {
                    posicion++;
                }
                // Detección de imagenes ---- proceso
                //if (cadena.Length > 20)
                //{
                //    string hr = cadena.Substring(0, 3);
                //    cont = cadena.Length - 35;
                //    if (hr == "src")
                //    {
                //        car++;
                //        while (res.Substring(tamaño.Length + cont, 1) != "\"" && car > 3)
                //        {
                //            lista[posicion, 3] += res.Substring(tamaño.Length +cont, 1);
                //            cont++;
                //        }


                //        cont = 0;
                //        cadena = "";
                //    }
                //}
                if (dato == '>')
                {
                    // detección de sedes de Cinemex
                    if (cadena == "class=\"billboard-block-title\">")
                    {
                        cont = 0;
                        car = 0;
                        cont = tamaño.Length;
                        while (res.Substring(cont, 1) != "<")
                        {
                            if (car == 0)
                            {
                                sede = res.Substring(cont, 1);
                            }
                            else
                            {
                                sede += res.Substring(cont, 1);
                            }
                            cont++;
                            car++;
                        }
                        cont = 0;
                        cadena = "";
                    }
                    // detección de títulos de películas
                    if (cadena == "class=\"mycinema-item-title\">")
                    {
                        cont = 0;
                        cont = tamaño.Length;
                        if (lista[posicion, 1] == null)
                        {
                            while (res.Substring(cont, 1) != "<")
                            {
                                foreach (string titulo in lista)
                                {

                                }
                                if (cont == 0)
                                {
                                    lista[posicion, 1] = res.Substring(cont, 1);
                                }
                                else
                                {
                                    lista[posicion, 1] += res.Substring(cont, 1);
                                }
                                cont++;
                            }
                            lista[posicion, 0] = sede.Trim();
                            cont = 0;
                            cadena = "";
                        }
                    }
                    string hr = "";
                    // detección de horarios
                    if (cadena.Length > 10)
                    {
                        hr = cadena.Substring(0, 10);
                        if (hr == "data-time=")
                        {
                            for (int i = 0; i < lista.Length - 1; i++)
                            {
                                if (lista[i, 0] == null && lista[i, 1] == null)
                                {
                                    anterior = i - 1;
                                    if (anterior < 0)
                                    {
                                        anterior = 0;
                                    }
                                    break;
                                }
                            }
                            if (lista[anterior, 2] == null || lista[anterior, 2] == "")
                            {
                                lista[anterior, 2] = res.Substring(tamaño.Length, 2) + ":" + res.Substring(tamaño.Length + 3, 2);
                            }
                            else
                            {
                                lista[anterior, 2] += ", " + res.Substring(tamaño.Length, 2) + ":" + res.Substring(tamaño.Length + 3, 2);
                            }
                            cont = 0;
                            cadena = "";
                        }

                    }
                }
            }
            cont = 0;
            string[] peliculas = new string[100];
            while (lista[cont, 0] != null)
            {
                peliculas[cont] = lista[cont, 0];
                cont++;
            }
            // agrupación de películas por sedes
            string comp = "";
            cont = 0;
            if (filtro == "Todos")
            {
                tabla = filtro;
                for (int a = 0; a < lista.Length; a++)
                {
                    if (lista[cont, 0] != null)
                    {
                        sede = lista[cont, 0];
                        while (lista[cont, 0] == sede && lista[cont, 0] != null)
                        {
                            cont++;
                        }
                        if (comp == "")
                        {
                            comp += "Sede: " + sede + "\n";
                        }
                        else
                        {
                            comp += "\nSede: " + sede + "\n";
                        }
                        comp += "_____________________________________________________________________\n";
                        for (int i = src; i < cont; i++)
                        {
                            if (i < cont)
                            {
                                if (lista[i, 0] == sede)
                                {
                                    ds.Tables[sede].Rows.Add(lista[i,1],lista[i,2]);
                                    comp += "       Título: " + lista[i, 1] + "\n               Horario: " + lista[i, 2] + "\n";
                                }
                            }
                        }
                        src = cont;
                    }
                    else
                    {
                        break;
                    }
                }
            }
            else
            {
                for (int a = 0; a < lista.Length; a++)
                {
                    if (lista[cont, 0] != null)
                    {
                        sede = lista[cont, 0];
                        while (lista[cont, 0] == sede && lista[cont, 0] != null)
                        {
                            cont++;
                        }
                        if (sede == filtro)
                        {
                            tabla = sede;
                            if (comp == "")
                            {
                                comp += "Sede: " + sede + "\n";
                            }
                            else
                            {
                                comp += "\nSede: " + sede + "\n";
                            }
                            comp += "_____________________________________________________________________\n";
                            for (int i = src; i < cont; i++)
                            {
                                if (i < cont)
                                {
                                    if (lista[i, 0] == sede)
                                    {
                                        comp += "       Título: " + lista[i, 1] + "\n               Horario: " + lista[i, 2] + "\n";
                                    }
                                }
                            }
                            src = cont;
                        }
                    }
                    else
                    {
                        break;
                    }
                }
            }
            TextBox1.Text = comp;
            report = ds;
        }



        private void LeerPaginaCinepolis()
        {
            WebRequest request = WebRequest.Create("http://www.cinepolis.com/cartelera/merida/cinepolis-plaza-kukulcan");

            // Obtener la respuesta.
            WebResponse response = request.GetResponse();

            // Abrir el stream de la respuesta recibida.
            StreamReader reader = new StreamReader(response.GetResponseStream());

            // Leer el contenido.
            String res = reader.ReadToEnd();

            // Cerrar los streams abiertos.
            reader.Close();
            response.Close();

            ricCinepolis.Text = res;
        }



        private void Form1_SizeChanged(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                this.Hide();
                notifyIcon1.Icon = SystemIcons.Application;
            }
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.Show();
        }

        private void restaurarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Show();
            this.Focus();
        }

        private void minimizarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            notifyIcon1.Icon = SystemIcons.Application;
        }

        private void cerrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void cobSede_SelectedIndexChanged(object sender, EventArgs e)
        {
            LeerPaginaCinemex(cobSede.SelectedItem.ToString());
        }

        private void btnReporte_Click(object sender, EventArgs e)
        {
            ReporteCinemex frm = new ReporteCinemex(report,tabla);
            frm.ShowDialog();
        }
    }
}
