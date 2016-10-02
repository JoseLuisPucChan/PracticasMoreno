using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UTM.SQLite.DAO
{
    class ConexionAgenda
    {
        SQLiteConnection con;
       
   
        public SQLiteConnection establecerConexion()
        {
            //string cs = "Data Source=BDEstudiantes.db;Version=3;New=False;Compress=True;";
            //con = new SQLiteConnection(cs);
            //return con;
            string rutaCompleta = Application.StartupPath.ToString();
            string ruta = rutaCompleta.Substring(0, rutaCompleta.Length - 16) + @"UTM.SQLite\bin\Debug\Agenda.db";
            string cs = "Data Source=" + ruta + ";Version=3;New=False;Compress=True;";
            con = new SQLiteConnection(cs);
            return con;
        }


        public void abrirConexion()
        {
            con.Open();
        }
        public void cerrarConexion()
        {
            con.Close();
        }
    }
}
