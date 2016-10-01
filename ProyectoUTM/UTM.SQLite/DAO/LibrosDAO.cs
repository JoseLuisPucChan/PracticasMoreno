using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using UTM.SQLite.BO;
using System.Data;
namespace UTM.SQLite.DAO
{
    class LibrosDAO
    {
        Conexion con;
        DataSet dsLibros = null;
        string sql="";
        SQLiteCommand cmd;
        SQLiteDataAdapter da;

        public LibrosDAO()
        {

        }
        
        public DataSet BusquedaLibro(object obj)
        {
            string cadenaWhere = "";
            bool edo = false;
            LibroBO data = (LibroBO)obj;
            cmd = new SQLiteCommand();
            dsLibros = new DataSet();
            da = new SQLiteDataAdapter();
            con = new Conexion();
            cmd.Connection = con.establecerConexion();
            con.abrirConexion();


            if (data.ISBN > 0)
            {
                cadenaWhere = cadenaWhere + " ISBN=" + data.ISBN + " and";
                edo = true;
            }
            if (data.Titulo != null)
            {
                cadenaWhere = cadenaWhere + " Titulo='" + data.Titulo.Trim() + "' and";
                edo = true;
            }
            if (data.Autor != null)
            {

                cadenaWhere = cadenaWhere + " Autor='" + data.Autor.Trim() + "' and";
                edo = true;
            }
            if (data.Editorial != null)
            {

                cadenaWhere = cadenaWhere + " Editorial='" + data.Editorial.Trim() + "' and";
                edo = true;
            }
            if (data.Precio > 0)
            {
                cadenaWhere = cadenaWhere + " Precio=" + data.Precio + " and";
                edo = true;
            }
            if (data.Imagen != null)
            {

                cadenaWhere = cadenaWhere + " Imagen='" + data.Imagen.Trim() + "' and";
                edo = true;
            }
            if (edo == true)
            {
                cadenaWhere = " WHERE " + cadenaWhere.Remove(cadenaWhere.Length - 3, 3);
            }
            sql = " SELECT * FROM Libro " + cadenaWhere;
            cmd.CommandText = sql;
            DataSet ds = new DataSet();
            da.SelectCommand = cmd;
            da.Fill(dsLibros);
            con.cerrarConexion();
            return dsLibros;
        }
        public int AltaLibro(object obj)
        {
            LibroBO data = (LibroBO)obj;
            cmd = new SQLiteCommand();
            dsLibros= new DataSet();
            da = new SQLiteDataAdapter();
            con = new Conexion();
            cmd.Connection = con.establecerConexion();
            con.abrirConexion();

            sql = "INSERT INTO Libro(Titulo,Autor,Editorial,Precio,Imagen)" +
            "VALUES('" +
            data.Titulo.Trim() + "','" +
            data.Autor.Trim() + "','" +
            data.Editorial.Trim() + "','" +
            data.Precio.ToString() + "','" +
            data.Imagen.Trim() + "')";
            cmd.CommandText = sql;
            int i = cmd.ExecuteNonQuery();

            if (i <= 0)
            {
                return 0;
            }
            return 1;
        }

        public int eliminaLibro(object obj)
        {

            LibroBO data = (LibroBO)obj;
            cmd = new SQLiteCommand();
            dsLibros = new DataSet();
            da = new SQLiteDataAdapter();
            con = new Conexion();
            cmd.Connection = con.establecerConexion();
            con.abrirConexion();
            sql = "DELETE FROM Libro WHERE ISBN=" + data.ISBN.ToString();
            cmd.CommandText = sql;
            int i = cmd.ExecuteNonQuery();
            if (i <= 0)
            {
                return 0;
            }
            return 1;
        }


        public int modificaLibro(object obj)
        {
            LibroBO data = (LibroBO)obj;
            cmd = new SQLiteCommand();
            dsLibros = new DataSet();
            da = new SQLiteDataAdapter();
            con = new Conexion();
            cmd.Connection = con.establecerConexion();
            con.abrirConexion();


            sql = "UPDATE Libro SET Titulo='" + data.Titulo.Trim() +
                "',Autor='" + data.Autor.Trim() +
                "',Editorial='" + data.Editorial.Trim() +
                "',Precio='" + data.Precio.ToString() +
                "' WHERE ISBN='" + data.ISBN.ToString() + "'";
            cmd.CommandText = sql;
            int i = cmd.ExecuteNonQuery();
            if (i <= 0)
            {
                return 0;
            }
            return 1;
        }

       

    }
}
