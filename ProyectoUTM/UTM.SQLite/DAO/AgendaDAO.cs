using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UTM.SQLite.BO;
namespace UTM.SQLite.DAO
{
    class AgendaDAO
    {
        ConexionAgenda con;
        DataSet dsContactos = null;
        string sql = "";
        SQLiteCommand cmd;
        SQLiteDataAdapter da;
        public DataSet BusquedaContactos(object obj)
        {
            string cadenaWhere = "";
            bool edo = false;
            AgendaBO data = (AgendaBO)obj;
            cmd = new SQLiteCommand();
            dsContactos = new DataSet();
            da = new SQLiteDataAdapter();
            con = new ConexionAgenda();
            cmd.Connection = con.establecerConexion();
            con.abrirConexion();

            if (data.IDagenda >0)
            {
                cadenaWhere = cadenaWhere + " IDagenda=" + data.IDagenda + " and";
                edo = true;
            }

            if (data.Nombre != null)
            {
                cadenaWhere = cadenaWhere + " Nombre=" + data.Nombre + " and";
                edo = true;
            }
            if (data.Apellidos != null)
            {
                cadenaWhere = cadenaWhere + " Apellidos='" + data.Apellidos.Trim() + "' and";
                edo = true;
            }
            if (data.Edad != null)
            {

                cadenaWhere = cadenaWhere + " Edad='" + data.Edad.Trim() + "' and";
                edo = true;
            }
            if (data.Telefono != null)
            {

                cadenaWhere = cadenaWhere + " Telefono='" + data.Telefono.Trim() + "' and";
                edo = true;
            }
            if (data.CorreoElectronico != null)
            {

                cadenaWhere = cadenaWhere + " CorreoElectronico='" + data.CorreoElectronico.Trim() + "' and";
                edo = true;
            }
            
          
            if (edo == true)
            {
                cadenaWhere = " WHERE " + cadenaWhere.Remove(cadenaWhere.Length - 3, 3);
            }
            sql = " SELECT * FROM Agenda1 " + cadenaWhere;
            cmd.CommandText = sql;
            DataSet ds = new DataSet();
            da.SelectCommand = cmd;
            da.Fill(dsContactos);
            con.cerrarConexion();
            return dsContactos;
        }

        public DataSet BusquedaActividades(object obj)
        {
            string cadenaWhere = "";
            bool edo = false;
            AgendaBO data = (AgendaBO)obj;
            cmd = new SQLiteCommand();
            dsContactos = new DataSet();
            da = new SQLiteDataAdapter();
            con = new ConexionAgenda();
            cmd.Connection = con.establecerConexion();
            con.abrirConexion();

            if (data.IdContacto > 0)
            {
                cadenaWhere = cadenaWhere + " idContacto=" + data.IdContacto + " and";
                edo = true;
            }

            if (edo == true)
            {
                cadenaWhere = " WHERE " + cadenaWhere.Remove(cadenaWhere.Length - 3, 3);
            }
            sql = " SELECT * FROM RegistroActividades " + cadenaWhere;
            cmd.CommandText = sql;
            DataSet ds = new DataSet();
            da.SelectCommand = cmd;
            da.Fill(dsContactos);
            con.cerrarConexion();
            return dsContactos;
        }
        public int AltaContacto(object obj)
        {
            AgendaBO data = (AgendaBO)obj;
            cmd = new SQLiteCommand();
            dsContactos = new DataSet();
            da = new SQLiteDataAdapter();
            con = new ConexionAgenda();
            cmd.Connection = con.establecerConexion();
            con.abrirConexion();

            sql = "INSERT INTO Agenda1(Nombre,Apellidos,Edad,Telefono,FechaNacimiento,CorreoElectronico)" +
            "VALUES('" +
            data.Nombre.Trim() + "','" +
            data.Apellidos.Trim() + "','" +
            data.Edad.Trim() + "','" +
            data.Telefono.ToString() + "','" +
            data.FechaNacimiento1 + "','" +
            data.CorreoElectronico.Trim() + "')";
            cmd.CommandText = sql;
            int i = cmd.ExecuteNonQuery();

            if (i <= 0)
            {
                return 0;
            }
            return 1;
        }
        public int AltaA(object obj)
        {
            AgendaBO data = (AgendaBO)obj;
            cmd = new SQLiteCommand();
            dsContactos = new DataSet();
            da = new SQLiteDataAdapter();
            con = new ConexionAgenda();
            cmd.Connection = con.establecerConexion();
            con.abrirConexion();

            sql = "INSERT INTO RegistroActividades(idContacto,NombreActividad,FechaActividad,Descripcion,Luegar)" +
            "VALUES('" +
            data.IdContacto.ToString() + "','" +
            data.NombreActividad.Trim() + "','" +
            data.FechanActividad.Trim() + "','" +
            data.Descripcion.Trim() + "','" +
            data.Lugar.Trim() + "')";
            cmd.CommandText = sql;
            int i = cmd.ExecuteNonQuery();

            if (i <= 0)
            {
                return 0;
            }
            return 1;
        }

        public int eliminaContacto(object obj)
        {

            AgendaBO data = (AgendaBO)obj;
            cmd = new SQLiteCommand();
            dsContactos = new DataSet();
            da = new SQLiteDataAdapter();
            con = new ConexionAgenda();
            cmd.Connection = con.establecerConexion();
            con.abrirConexion();
            sql = "DELETE FROM Agenda1 WHERE IDagenda=" + data.IDagenda.ToString();
            cmd.CommandText = sql;
            int i = cmd.ExecuteNonQuery();
            if (i <= 0)
            {
                return 0;
            }
            return 1;
        }
        public int eliminaActividad(object obj)
        {

            AgendaBO data = (AgendaBO)obj;
            cmd = new SQLiteCommand();
            dsContactos = new DataSet();
            da = new SQLiteDataAdapter();
            con = new ConexionAgenda();
            cmd.Connection = con.establecerConexion();
            con.abrirConexion();
            sql = "DELETE FROM RegistroActividades WHERE idActividad=" + data.IDActivida.ToString();
            cmd.CommandText = sql;
            int i = cmd.ExecuteNonQuery();
            if (i <= 0)
            {
                return 0;
            }
            return 1;
        }


        public int modificaContacto(object obj)
        {
            AgendaBO data = (AgendaBO)obj;
            cmd = new SQLiteCommand();
            dsContactos = new DataSet();
            da = new SQLiteDataAdapter();
            con = new ConexionAgenda();
            cmd.Connection = con.establecerConexion();
            con.abrirConexion();

            sql = "UPDATE Agenda1 SET Nombre='" + data.Nombre.Trim() +
                "',Apellidos='" + data.Apellidos.Trim() +
                "',Edad='" + data.Edad.Trim() +
                "',Telefono='" + data.Telefono.Trim() +
                "',FechaNacimiento='" + data.FechaNacimiento1 +
                "',CorreoElectronico='" + data.CorreoElectronico.ToString() +
                "' WHERE IDagenda='" + data.IDagenda.ToString() + "'";
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
