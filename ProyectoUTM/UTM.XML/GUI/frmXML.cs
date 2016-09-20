using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;
namespace UTM.XML.GUI
{
    public partial class frmXML : Form
    {
        SqlDataAdapter dtAlunos;
        public frmXML()
        {
            dtAlunos = new SqlDataAdapter();
            InitializeComponent();
        }

        private void frmXML_Load(object sender, EventArgs e)
        {

        }
        public DataTable listarAlumno()
        {
            DataSet dsAllumno = new DataSet();
            string rutaCompleta = Application.StartupPath.ToString();
            string ruta = rutaCompleta.Substring(0, rutaCompleta.Length - 16) + @"UTM.XML\bin\XMLAlumno.xml";
            dsAllumno.ReadXml(ruta);
            return dsAllumno.Tables[0];
        }

        public void ModificarAlumno()
        {
            string id = txtClave.Text.Trim();
            DataTable dt = listarAlumno();
            int numer = dt.Rows.Count;
            for (int i = 0; i < numer;i++ )
            {
                if(dt.Rows[i]["ClaveAlumno"].ToString().Trim()== id.Trim())
                {
                    dt.Rows[i]["Nombre"] = txtNombre.Text.Trim();
                    dt.Rows[i]["ApellidoMaterno"] = txtMA.Text.Trim();
                    dt.Rows[i]["ApellidoPaterno"] = txtAP.Text.Trim();
                    dt.Rows[i]["Edad"] = txtEdad.Text.Trim();

                    string rutaCompleta = Application.StartupPath.ToString();

                    string ruta = rutaCompleta.Substring(0, rutaCompleta.Length - 16) + @"UTM.XML\bin\XMLAlumno.xml";
                    dt.WriteXml(ruta);
                    break;
                }
            }
            dtgResultados.DataSource = listarAlumno();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            dtgResultados.DataSource = listarAlumno();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dtgResultados.DataSource = buscarAlumno2(GenerarCadena());

        }
  
     public void agregaAlumno()
        {
            DataSet dsAlumnos = new DataSet();
            dsAlumnos.Tables.Add(listarAlumno().Copy());
            DataRow dr;
            try
            {
                dr = dsAlumnos.Tables[0].NewRow();
                dr["ClaveAlumno"] = txtClave.Text.Trim();
                dr["Nombre"] = txtNombre.Text.Trim();
                dr["ApellidoPaterno"] = txtAP.Text.Trim();
                dr["ApellidoMaterno"] = txtMA.Text.Trim();
                dr["Edad"] = txtEdad.Text.Trim();
                dsAlumnos.Tables[0].Rows.Add(dr);
                string rutaCompleta = Application.StartupPath.ToString();
                
                string ruta = rutaCompleta.Substring(0, rutaCompleta.Length - 16) + @"UTM.XML\bin\XMLAlumno.xml";
                dsAlumnos.WriteXml(ruta);
               dtgResultados.DataSource=  listarAlumno();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Favor de Verificar los datos");
            }
        }

  

        public DataTable buscarAlumno2(string[,] cadena)
        {

            DataTable dtTemporal = new DataTable();
            DataTable dtAlumno = new DataTable();
            dtAlumno = listarAlumno();
            dtTemporal = listarAlumno();
            dtTemporal.Clear();
           
            if (cadena.Length > 0)
            {
                foreach (DataRow i in dtAlumno.Rows)
                {
                   

                   if (i["ClaveAlumno"].ToString() == cadena[0, 0])
                     {
                                dtTemporal.ImportRow(i);
                                return dtTemporal;
                     }
                     else
                     {
                       if (i["Nombre"].ToString() == cadena[0, 1] && i["Edad"].ToString() == cadena[0, 2] && i["ApellidoPaterno"].ToString() == cadena[0, 3] && i["ApellidoMaterno"].ToString() == cadena[0, 4])
                       {
                           if (i[0].ToString() != cadena[0, 1])
                           {
                               dtTemporal.ImportRow(i);
                           }
                           
                       }
                       else
                       {
                           if (i["Nombre"].ToString() == cadena[0, 1] && i["Edad"].ToString() == cadena[0, 2] && i["ApellidoPaterno"].ToString() == cadena[0, 3] )
                           {
                               if (i[0].ToString() != cadena[0, 1])
                               {
                                   dtTemporal.ImportRow(i);
                               }
                              
                           }
                           else
                           {
                               if (i["Nombre"].ToString() == cadena[0, 1] && i["Edad"].ToString() == cadena[0, 2])
                               {
                                   if (i[0].ToString() != cadena[0, 1])
                                   {
                                       dtTemporal.ImportRow(i);
                                   }
                                  
                               }
                               else
                               {
                                   if (i["Nombre"].ToString() == cadena[0, 1])
                                   {
                                       if (i[1].ToString() != cadena[0, 2])
                                       {
                                           dtTemporal.ImportRow(i);
                                       }
                                      
                                   } 
                               }
                           }

                       }

                     }



                   if (i["Edad"].ToString() == cadena[0, 2] && i["ApellidoPaterno"].ToString() == cadena[0, 3] && i["ApellidoMaterno"].ToString() == cadena[0, 4])
                   {
                       if (i[0].ToString() != cadena[0, 1])
                       {
                           dtTemporal.ImportRow(i);
                       }
                      
                   }
                   else
                   {
                       if (i["Edad"].ToString() == cadena[0, 2] && i["ApellidoPaterno"].ToString() == cadena[0, 3])
                       {
                           if (i[0].ToString() != cadena[0, 1])
                           {
                               dtTemporal.ImportRow(i);
                           }
                           
                       }
                       else
                       {
                           if (i["Edad"].ToString() == cadena[0, 2])
                           {
                               if (i[0].ToString() != cadena[0, 1])
                               {
                                   dtTemporal.ImportRow(i);
                               }
                              
                           }
                       }

                   }

                   if (i["ApellidoPaterno"].ToString() == cadena[0, 3] && i["ApellidoMaterno"].ToString() == cadena[0, 4])
                   {
                       if (i[0].ToString() != cadena[0, 1])
                       {
                           dtTemporal.ImportRow(i);
                       }
                     
                   }
                   else
                   {
                       if (i["ApellidoPaterno"].ToString() == cadena[0, 3])
                       {
                           if (i[0].ToString() != cadena[0, 1])
                           {
                               dtTemporal.ImportRow(i);
                           }
                           
                       }
                       else
                       {
                           if (i["ApellidoMaterno"].ToString() == cadena[0, 4])
                           {
                               if (i[0].ToString() != cadena[0, 1])
                               {
                                   dtTemporal.ImportRow(i);
                               }
                           }

                       }

                   }

        

                
                    //Final Forech
                 }

            }
            return dtTemporal;
        }

        public string[,] GenerarCadena()
        {
            string[,] cadena = new string[2, 5];

            if (txtClave.Text != "")
            {
                cadena[0, 0] = txtClave.Text.Trim();
                return cadena;
            }
            if (txtNombre.Text != "")
            {
                cadena[0, 1] = txtNombre.Text.Trim();
            }
            if (txtEdad.Text != "")
            {
                cadena[0, 2] += txtEdad.Text.Trim();
            }
            if (txtAP.Text != "")
            {
                cadena[0, 3] += txtAP.Text.Trim();
            }
            if (txtMA.Text != "")
            {
                cadena[0, 4] += txtMA.Text.Trim();
            }

            return cadena;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            agregaAlumno();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ModificarAlumno();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Eliminar();

        }
        public void Eliminar()
        {
            string id = txtClave.Text.Trim();
            DataTable dt = listarAlumno();
            int numer = dt.Rows.Count;
            for (int i = 0; i < numer; i++)
            {
                if (dt.Rows[i]["ClaveAlumno"].ToString().Trim() == id.Trim())
                {
                    dt.Rows[i].Delete();
                    string rutaCompleta = Application.StartupPath.ToString();
                    string ruta = rutaCompleta.Substring(0, rutaCompleta.Length - 16) + @"UTM.XML\bin\XMLAlumno.xml";
                    dt.WriteXml(ruta);
                    break;
                }
            }
            dtgResultados.DataSource = listarAlumno();

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }



     
    }
}
