using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;
using System.Diagnostics;

using System.ComponentModel;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Reto1.GUI
{
    public partial class Principal : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        //private DataTable Listar()
        //{
        //    DataSet dsBibliografia = new DataSet();
        //    string Rutacompleta =  
        //    string ruta = Rutacompleta.Substring(0, Rutacompleta.Length - 5) + @"\JSONBibliografia.json";
        //    dsBibliografia = JsonConvert.DeserializeObject<DataSet>(File.ReadAllText(ruta));
        //    if (dsBibliografia == null)
        //    {
        //     //   MessageBox.Show("No Existen datos");
        //        return null;

        //    }
        //    else
        //    {
        //        return dsBibliografia.Tables[0];
        //    }

        //}


    }
}