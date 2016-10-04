using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.IO;
namespace Practica2.GUI
{
    public partial class Estados : Form
    {
        public Estados()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = Listar();
        }
        //private DataTable Buscar()
        //{
        //    DataTable dsBibliografia = new DataTable();
        //    DataTable dsTemporal = new DataTable();
        //    dsBibliografia = this.Listar();
        //    try
        //    {
        //        dsTemporal = this.Listar();
        //        dsTemporal.Clear();
        //    }
        //    catch
        //    {

        //    }


        //    if (Nombre.Trim().Length > 0 || isbn.Trim().Length > 0)
        //    {
        //        foreach (DataRow r in dsBibliografia.Rows)
        //        {
        //            if (r["Nombre"].ToString() == Nombre || r["ISBN"].ToString() == isbn)
        //            {
        //                dsTemporal.ImportRow(r);
        //            }
        //        }
        //    }
        //    else
        //    {
        //        dsTemporal = this.Listar();
        //    }

        //    return dsTemporal;
        //}
        private DataTable Listar()
        {
            DataSet dsBibliografia = new DataSet();
            string Rutacompleta = Application.StartupPath.ToString();
            string ruta = Rutacompleta.Substring(0, Rutacompleta.Length - 5) + @"\JSONBibliografia.json";
            dsBibliografia = JsonConvert.DeserializeObject<DataSet>(File.ReadAllText(ruta));
            if (dsBibliografia == null)
            {
                MessageBox.Show("No Existen datos");
                return null;

            }
            else
            {
                return dsBibliografia.Tables[0];
            }

        }
    }
}
