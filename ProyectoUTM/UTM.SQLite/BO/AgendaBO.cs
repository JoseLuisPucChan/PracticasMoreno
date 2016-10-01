using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UTM.SQLite.BO
{
   public class AgendaBO
    {
        string nombre;
        string apellidos;
        string edad;
        string telefono;
        string fechaNacimiento;
        int iDagenda;




       //Actividades
        int iDActivida;
        int idContacto;
        string fechanActividad;
        string descripcion;
        string lugar;

        public string Lugar
        {
            get { return lugar; }
            set { lugar = value; }
        }

        public string Descripcion
        {
            get { return descripcion; }
            set { descripcion = value; }
        }


        public string FechanActividad
        {
            get { return fechanActividad; }
            set { fechanActividad = value; }
        }


        public int IdContacto
        {
            get { return idContacto; }
            set { idContacto = value; }
        }
        string nombreActividad;

        public string NombreActividad
        {
            get { return nombreActividad; }
            set { nombreActividad = value; }
        }

        public int IDActivida
        {
            get { return iDActivida; }
            set { iDActivida = value; }
        }
        public int IDagenda
        {
            get { return iDagenda; }
            set { iDagenda = value; }
        }
        public string FechaNacimiento1
        {
            get { return fechaNacimiento; }
            set { fechaNacimiento = value; }
        }
        string correoElectronico;
        

        public string CorreoElectronico
        {
            get { return correoElectronico; }
            set { correoElectronico = value; }
        }


     

        public string Telefono
        {
            get { return telefono; }
            set { telefono = value; }
        }


        public string Edad
        {
            get { return edad; }
            set { edad = value; }
        }

        public string Apellidos
        {
            get { return apellidos; }
            set { apellidos = value; }
        }
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

    }
}
