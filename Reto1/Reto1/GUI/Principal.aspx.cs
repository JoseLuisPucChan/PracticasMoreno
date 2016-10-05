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

            string fileJson = File.ReadAllText(@"C:\Users\Luis Puc\Desktop\PracticasMoreno\Reto1\Reto1\Json\aspnetJSON");
            DataTable dt = (DataTable)JsonConvert.DeserializeObject(fileJson, typeof(DataTable));
            //GridView1.DataSource = dt;
            //GridView1.DataBind();
            ddlEstados.DataSource = Buscar("1");
            ddlEstados.DataValueField = "c_estado";
            ddlEstados.DataTextField = "d_estado";
            DataBind();
        }

        //Recuperar el archivo Json
        private DataTable Listar()
        {
            string fileJson = File.ReadAllText(@"C:\Users\Luis Puc\Desktop\PracticasMoreno\Reto1\Reto1\Json\aspnetJSON");
            DataTable dsBibliografia = (DataTable)JsonConvert.DeserializeObject(fileJson, typeof(DataTable));
            return dsBibliografia;
        }
        private DataTable ListarEstados(string idEstado)
        {
            string fileJson = "";
            if (idEstado == "01" || idEstado == "1") { fileJson = Server.MapPath(@"~/Json/Aguascalientes-json.json"); }
            if (idEstado == "02" || idEstado == "2") { fileJson = Server.MapPath(@"~/Json/BajaCalifornia-json.json"); }
            if (idEstado == "03" || idEstado == "3") { fileJson = Server.MapPath(@"~/Json/BajaCaliforniaSur-json.json"); }
            if (idEstado == "04") { fileJson = Server.MapPath("~/Json/Campeche-json.json"); }
            if (idEstado == "05") { fileJson = Server.MapPath("~/Json/Chiapas-json.json"); }
            if (idEstado == "06") { fileJson = Server.MapPath("~/Json/Chihuahua-json.json"); }
            if (idEstado == "07") { fileJson = Server.MapPath("~/Json/CDMexico-Json.json"); }
            if (idEstado == "08") { fileJson = Server.MapPath("~/Json/Aguascalientes-json.json"); }
            if (idEstado == "09") { fileJson = Server.MapPath("~/Json/Aguascalientes-json.json"); }
            if (idEstado == "10") { fileJson = Server.MapPath("~/Json/Aguascalientes-json.json"); }
            if (idEstado == "11") { fileJson = Server.MapPath("~/Json/Aguascalientes-json.json"); }
            if (idEstado == "12") { fileJson = Server.MapPath("~/Json/Aguascalientes-json.json"); }
            if (idEstado == "13") { fileJson = Server.MapPath("~/Json/Aguascalientes-json.json"); }
            DataTable dsBibliografia = (DataTable)JsonConvert.DeserializeObject(rutaCompleta(fileJson), typeof(DataTable));
            return dsBibliografia;
        }
        
        //------------------------------------------------------------trabajar andré ._. ---------------------------------------------
        private string rutaCompleta(string ruta)
        {
            string nuevaCadena = "";
            for (int i = 0; i < ruta.Length; i++ )
            {
                if (i > 0)
                {
                    try
                    {
                        if (ruta.Substring(i, 2) == "\\")
                        {

                            nuevaCadena += "/";
                            i++;
                        }
                        else { nuevaCadena += ruta.Substring(i, 1); }
                    }
                    catch { nuevaCadena += ruta.Substring(i, 1); }
                }
                else
                {
                    nuevaCadena += ruta.Substring(i, 1);
                }
            }
            return nuevaCadena;
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
        private DataTable BuscarMunicipio(string id, string mun)
        {
            DataTable dsBibliografia = new DataTable();
            DataTable dsTemporal = new DataTable();
            dsBibliografia = this.ListarEstados(id);
            try
            {
                dsTemporal = this.ListarEstados(id);
                dsTemporal.Clear();
            }
            catch
            {

            }
            int cont = 0, i = 0;
            string[] filas = new string[dsBibliografia.Rows.Count];
            foreach (DataRow r in dsBibliografia.Rows)
            {
                foreach (string cadena in filas)
                {
                    if (r["D_mnpio"].ToString() == cadena)
                    {
                        cont++;
                    }
                }
                if (cont == 0)
                {
                    dsTemporal.ImportRow(r);
                    filas[i] = r["D_mnpio"].ToString();
                    i++;
                }

                cont = 0;
            }
            return dsTemporal;
        }
        protected void ddlEstados_SelectedIndexChanged(object sender, EventArgs e)
        {
            string ID = "";
            string mun = "";
            ID = ddlEstados.SelectedItem.Value;
            mun = ddlEstados.SelectedItem.Text;
            Response.Write("<script>alert(' id " + ID + " ');</script>");

            ddlMunicipio.DataSource = BuscarMunicipio(ID,mun);
            ddlMunicipio.DataMember = "c_estado";
            ddlMunicipio.DataValueField = "D_mnpio";
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