using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;
using System.Data;
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
        //------Load----------
        protected void Page_Load(object sender, EventArgs e)
        {
            string fileJson = File.ReadAllText(@"C:\Users\Luis Puc\Desktop\PracticasMoreno\aspnetJSON");
            DataTable dt = (DataTable)JsonConvert.DeserializeObject(fileJson, typeof(DataTable));
            GridView1.DataSource = dt;
            GridView1.DataBind();

            ddlLocalidad.DataSource = dt;
            ddlLocalidad.DataMember = "edad";
            ddlLocalidad.DataValueField = "Nombre";
            DataBind();
           //
           

        }

        protected void Button1_Click(object sender, EventArgs e)
        {

        }

        protected void ddlLocalidad_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        protected void ddlLocalidad_TextChanged(object sender, EventArgs e)
        {
            string ID = "";
            ID = ddlLocalidad.SelectedValue.ToString();
            Response.Write("<script>alert(' " + ID + "JSON Listo !! ');</script>");
        }

        //protected void Button1_Click(object sender, EventArgs e)
        //{

        //    persona opersona = new persona
        //    {
        //        Nombre = txtNombre.Text,
        //        edad = Convert.ToInt32(txtEdad.Text),
        //        email = txtEmail.Text
        //    };
        //    Agregar los objetos a la clase
        //    txtNombre.Text = "";
        //    txtEdad.Text = "";
        //    txtEmail.Text = "";

        //    if (Session["ARCHIVOJSON"].ToString() == string.Empty)
        //        Session["ARCHIVOJSON"] = JsonConvert.SerializeObject(opersona);
        //    else
        //        Session["ARCHIVOJSON"] = Session["ARCHIVOJSON"].ToString() + "," + JsonConvert.SerializeObject(opersona);
        //    ListBox1.Items.Add("Nombre: " + opersona.Nombre + "Edad: " + opersona.edad + "Email: " + opersona.email);

            
        //    string fileJSON = File.ReadAllText = 
        //}

        //protected void Button2_Click(object sender, EventArgs e)
        //{

        //    File.WriteAllText(@"C:\Users\Luis Puc\Desktop\PracticasMoreno\aspnetJSON", "[" + Session["ARCHIVOJSON"].ToString() + "]");
        //    Response.Write("<script>alert(' JSON Listo !! ');</script>");
        //}
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