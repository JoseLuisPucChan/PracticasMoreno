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
            if(!IsPostBack)
            {
                  RellenarDropDownList();
            }
             
        }
        private void RellenarDropDownList()
        {
            string fileJson = File.ReadAllText(@"C:\Users\Luis Puc\Desktop\PracticasMoreno\aspnetJSON");
            DataTable dt = (DataTable)JsonConvert.DeserializeObject(fileJson, typeof(DataTable));
            GridView1.DataSource = dt;
            GridView1.DataBind();

            ddlEstados.DataSource = Buscar("1");
            ddlEstados.DataValueField = "c_estado";
            ddlEstados.DataTextField = "d_ciudad";
            DataBind();
        }

        //Recuperar el archivo Json
        private DataTable Listar()
        {
            string fileJson = File.ReadAllText(@"C:\Users\Luis Puc\Desktop\PracticasMoreno\aspnetJSON");
            DataTable dsBibliografia = (DataTable)JsonConvert.DeserializeObject(fileJson, typeof(DataTable));
            return dsBibliografia;
        }
        
        // ----Recupera el prime Drop Estados
        private DataTable Buscar(string id)
        {
            DataTable dsBibliografia = new DataTable();
            DataTable dsTemporal = new DataTable();
            dsBibliografia = this.Listar();
            try
            {
                dsTemporal = this.Listar();
                dsTemporal.Clear();
            }
            catch
            {

            }
            if (id.Trim().Length > 0)
            {
                foreach (DataRow r in dsBibliografia.Rows)
                {
                        dsTemporal.ImportRow(r);
                }
            }
            else
            {
                dsTemporal = this.Listar();
            }

            return dsTemporal;
        }
        //------- Lista los municipios anidados ----
        private DataTable BuscarMunicipio(string id)
        {
            DataTable dsBibliografia = new DataTable();
            DataTable dsTemporal = new DataTable();
            dsBibliografia = this.Listar();
            try
            {
                dsTemporal = this.Listar();
                dsTemporal.Clear();
            }
            catch
            {

            }
            if (id.Trim().Length > 0)
            {
                foreach (DataRow r in dsBibliografia.Rows)
                {
                    if (r["c_estado"].ToString() == id)
                    {
                        dsTemporal.ImportRow(r);
                    }
                }
            }
            else
            {
                dsTemporal = this.Listar();
            }

            return dsTemporal;
        }

        // ----- Evento para poder elegir el 2 Drop
        protected void ddlEstados_SelectedIndexChanged(object sender, EventArgs e)
        {
            string ID = "";
            ID = ddlEstados.SelectedItem.Value;
           // Response.Write("<script>alert(' id "+ ID+" ');</script>");
            ddlMunicipio.DataSource = BuscarMunicipio(ID);
            ddlMunicipio.DataMember = "c_estado";
            ddlMunicipio.DataValueField = "d_estado";
            DataBind();
        }
         //--------Crear Persona------
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

        protected void Button2_Click(object sender, EventArgs e)
        {

            File.WriteAllText(@"C:\Users\Luis Puc\Desktop\PracticasMoreno\aspnetJSON", "[" + Session["ARCHIVOJSON"].ToString() + "]");
            Response.Write("<script>alert(' JSON Listo !! ');</script>");
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